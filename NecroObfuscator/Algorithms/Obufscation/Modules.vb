Imports dnlib.DotNet
Imports dnlib.DotNet.Emit
Imports System
Imports System.Collections.Generic
Imports System.Linq


Namespace NecroObfuscator.Algorithms.Obufscation
    Friend Class Modules
#Region "Helper"
        Public NotInheritable Class RandomUtils
            Private Shared random As Random = New Random()

            Public Shared Function RandomString(length As Integer) As String
                Const chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
                Return New String(Enumerable.Repeat(chars, length).[Select](Function(s) s(random.Next(s.Length))).ToArray())
            End Function
        End Class ' Random Utils Module
#End Region
#Region "Rename Functions"
        Public Class RenameProtector
            Public Shared count_xxx As Integer = 0

            Public Shared Sub Execute([module] As ModuleDef, outPath As String)
                Try
                    [module].Name = RandomUtils.RandomString(7)

                    For Each type In [module].Types
                        If type.IsGlobalModuleType OrElse type.IsRuntimeSpecialName OrElse type.IsSpecialName OrElse type.IsWindowsRuntime OrElse type.IsInterface Then Continue For

                        count_xxx += 1
                        type.Name = RandomUtils.RandomString(40)
                        type.Namespace = ""

                        For Each [property] In type.Properties
                            count_xxx += 1
                            [property].Name = RandomUtils.RandomString(40)
                        Next

                        For Each field In type.Fields
                            count_xxx += 1
                            field.Name = RandomUtils.RandomString(40)
                        Next

                        For Each eventDef In type.Events
                            count_xxx += 1
                            eventDef.Name = RandomUtils.RandomString(40)
                        Next

                        For Each method In type.Methods
                            If method.IsConstructor Then Continue For
                            count_xxx += 1
                            method.Name = RandomUtils.RandomString(40)
                        Next
                    Next

                    ' Write the modified module to the specified output path
                    [module].Write(outPath)
                Catch ex As Exception
                    Console.WriteLine($"An error occurred during renaming: {ex.Message}")
                End Try
            End Sub
        End Class ' RenameFuncs Module
#End Region
#Region "Proxy String"
        Public Class ProxyString
            Public Shared Sub Execute([module] As ModuleDef, outPath As String)
                Try
                    For Each type In [module].GetTypes()
                        If type.IsGlobalModuleType Then Continue For

                        For Each meth In type.Methods
                            If Not meth.HasBody Then Continue For

                            Dim instr = meth.Body.Instructions
                            Dim newInstructions = New List(Of Instruction)()

                            For Each t In instr
                                If t.OpCode Is OpCodes.Ldstr Then
                                    Dim methImplFlags = MethodImplAttributes.IL Or MethodImplAttributes.Managed
                                    Dim methFlags = MethodAttributes.Public Or MethodAttributes.Static Or MethodAttributes.HideBySig Or MethodAttributes.ReuseSlot
                                    Dim meth1 = New MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.String), methImplFlags, methFlags)

                                    [module].GlobalType.Methods.Add(meth1)

                                    meth1.Body = New CilBody()
                                    meth1.Body.Variables.Add(New Local([module].CorLibTypes.String))
                                    meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, t.Operand.ToString()))
                                    meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ret))

                                    t.OpCode = OpCodes.Call
                                    t.Operand = meth1
                                End If
                                newInstructions.Add(t)
                            Next

                            meth.Body.Instructions.Clear()
                            For Each instruction In newInstructions
                                meth.Body.Instructions.Add(instruction)
                            Next

                            meth.Body.UpdateInstructionOffsets()
                            meth.Body.SimplifyBranches()
                        Next
                    Next
                    [module].Write(outPath)
                Catch ex As Exception
                    Console.WriteLine($"An error occurred during string proxying: {ex.Message}")
                End Try
            End Sub
        End Class ' ProxyString Module
#End Region
#Region "Control Flow"
        Public Class ControlFlow
            Public Shared Sub Execute([module] As ModuleDef, outPath As String)
                Try
                    For Each type In [module].Types
                        For Each method In type.Methods
                            If Not method.HasBody OrElse method.Body.Instructions.Count = 0 Then Continue For

                            Dim instructions = method.Body.Instructions
                            Dim local = New Local(method.Module.CorLibTypes.Int32)
                            method.Body.Variables.Add(local)

                            Dim firstInstruction = instructions(0)

                            instructions.Insert(0, Instruction.Create(OpCodes.Ldc_I4, 0))
                            instructions.Insert(1, Instruction.Create(OpCodes.Stloc, local))

                            Dim newInstructions = New List(Of Instruction) From {
    Instruction.Create(OpCodes.Ldloc, local),
    Instruction.Create(OpCodes.Ldc_I4, 1),
    Instruction.Create(OpCodes.Bne_Un, firstInstruction)
}
                            For i = 0 To newInstructions.Count - 1
                                instructions.Insert(2 + i, newInstructions(i))
                            Next
                        Next
                    Next

                    [module].Write(outPath)
                Catch ex As Exception
                    Console.WriteLine($"An error occurred during control flow obfuscation: {ex.Message}")
                End Try
            End Sub
        End Class ' Control-Flow Module
#End Region
#Region "Junk Methods"
        Public Class JunkMethods
            Public Shared Sub Execute([module] As ModuleDef, OutPath As String)
                Try
                    For Each type In [module].Types
                        For i = 0 To 249 ' Create 100 junk methods for each type
                            Dim junkMethod = New MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.Void), MethodAttributes.Public Or MethodAttributes.Static) With {
    .Body = New CilBody()
}
                            junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction())

                            type.Methods.Add(junkMethod)
                        Next
                    Next

                    For i = 0 To 49 ' Create 50 junk classes
                        Dim junkType = New TypeDefUser(RandomUtils.RandomString(10), [module].CorLibTypes.Object.TypeDefOrRef)
                        [module].Types.Add(junkType)

                        For j = 0 To 9 ' For each junk class, create 10 junk methods
                            Dim junkMethod = New MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.Void), MethodAttributes.Public Or MethodAttributes.Static) With {
    .Body = New CilBody()
}
                            junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction())

                            junkType.Methods.Add(junkMethod)
                        Next
                    Next
                    [module].Write(OutPath)
                Catch ex As Exception
                    Console.WriteLine($"An error occurred during junk method insertion: {ex.Message}")
                End Try
            End Sub
        End Class ' JunkMethods Module
#End Region
#Region "WaterMark"
        Public Class WaterMark
            Public Shared Sub Execute(md As ModuleDefMD)
                For Each moduleDef In md.Assembly.Modules
                    Dim [module] = CType(moduleDef, ModuleDefMD)
                    Dim attrRef = [module].CorLibTypes.GetTypeRef("System", "Attribute")
                    Dim attrType = New TypeDefUser("", "N.E.C.R.O.-.O.B.F.U.S.C.A.T.E", attrRef)
                    [module].Types.Add(attrType)

                    Dim ctor = New MethodDefUser(".ctor", MethodSig.CreateInstance([module].CorLibTypes.Void, [module].CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig Or MethodAttributes.Public Or MethodAttributes.SpecialName Or MethodAttributes.RTSpecialName) With {
.Body = New CilBody()
}
                    ctor.Body.MaxStack = 1
                    ctor.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction())
                    ctor.Body.Instructions.Add(OpCodes.Call.ToInstruction(New MemberRefUser([module], ".ctor", MethodSig.CreateInstance([module].CorLibTypes.Void), attrRef)))
                    ctor.Body.Instructions.Add(OpCodes.Ret.ToInstruction())
                    attrType.Methods.Add(ctor)
                Next
            End Sub
        End Class ' WaterMark Module
#End Region
#Region "AntiDe4Dot"
        Public Class AntiDe4dot
            Public Shared Sub Execute(md As ModuleDefMD)
                For Each moduleDef In md.Assembly.Modules
                    Dim interfaceM = New InterfaceImplUser(md.GlobalType)
                    For i = 0 To 0
                        Dim typeDef1 = New TypeDefUser(String.Empty, $"Form{i}", md.CorLibTypes.GetTypeRef("System", "Attribute"))
                        Dim interface1 = New InterfaceImplUser(typeDef1)
                        md.Types.Add(typeDef1)
                        typeDef1.Interfaces.Add(interface1)
                        typeDef1.Interfaces.Add(interfaceM)
                    Next
                Next
            End Sub
        End Class ' AntiDe4Dot Module
#End Region
#Region "HideOEP"
        Public Class HideOEP
            Public Shared Sub Execute([module] As ModuleDef, outPath As String)
                Try
                    Dim originalEntryPoint = [module].EntryPoint

                    If originalEntryPoint Is Nothing Then
                        Console.WriteLine("No entry point found.")
                        Return
                    End If

                    Dim originalMethod = [module].Types.SelectMany(Function(t) t.Methods).FirstOrDefault(Function(m) m.MDToken = originalEntryPoint.MDToken)

                    If originalMethod Is Nothing Then
                        Console.WriteLine("Original entry point method not found.")
                        Return
                    End If

                    If originalMethod.IsPrivate Then
                        originalMethod.Attributes = originalMethod.Attributes And Not MethodAttributes.Private ' Удаление модификатора Private
                        originalMethod.Attributes = originalMethod.Attributes Or MethodAttributes.Public    ' Добавление модификатора Public
                    End If

                    Dim falseEntryPoints = New List(Of MethodDef)()
                    For i = 0 To 3 ' Создаем 4 ложные точки входа
                        Dim falseEntryPoint = CreateFalseEntryPoint([module], originalMethod)
                        falseEntryPoints.Add(falseEntryPoint)
                        [module].GlobalType.Methods.Add(falseEntryPoint)
                    Next

                    ' Цепочка вызовов ложных OEP, последний вызывает настоящий OEP
                    For i = 0 To falseEntryPoints.Count - 1 - 1
                        InsertCallToNextOEP(falseEntryPoints(i), falseEntryPoints(i + 1))
                    Next

                    ' В последней ложной точке входа вызываем реальную точку входа
                    InsertCallToNextOEP(falseEntryPoints(falseEntryPoints.Count - 1), originalMethod)

                    ' Установка первой ложной точки входа как OEP программы
                    [module].EntryPoint = falseEntryPoints(0)

                    [module].Write(outPath)
                    Console.WriteLine("Multiple OEP with chaining successfully created and hidden.")
                Catch ex As Exception
                    Console.WriteLine($"An error occurred during OEP hiding: {ex.Message}")
                End Try
            End Sub

            Private Shared Function CreateFalseEntryPoint([module] As ModuleDef, realEntryPoint As MethodDef) As MethodDef
                Dim falseEntryPoint = New MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.Void), MethodImplAttributes.IL Or MethodImplAttributes.Managed, MethodAttributes.Public Or MethodAttributes.Static Or MethodAttributes.HideBySig Or MethodAttributes.ReuseSlot)

                falseEntryPoint.Body = New CilBody()
                falseEntryPoint.Body.Instructions.Add(Instruction.Create(OpCodes.Nop)) ' Простая инструкция для ложного OEP
                ' Следующий вызов OEP (реальной или ложной) будет добавлен позже
                falseEntryPoint.Body.Instructions.Add(Instruction.Create(OpCodes.Ret))

                Return falseEntryPoint
            End Function

            Private Shared Sub InsertCallToNextOEP(currentOEP As MethodDef, nextOEP As MethodDef)
                Dim instrList = currentOEP.Body.Instructions
                ' Удаление инструкции "ret" и вставка вызова следующего OEP
                instrList.RemoveAt(instrList.Count - 1)
                instrList.Add(Instruction.Create(OpCodes.Call, nextOEP))
                instrList.Add(Instruction.Create(OpCodes.Ret))
            End Sub
        End Class ' Hide OEP-Module
#End Region
    End Class
End Namespace
