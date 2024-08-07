Imports dnlib.DotNet
Imports System
Imports NecroObfuscator.Algorithms.Obufscation.Modules

Namespace NecroObfuscator.Algorithms.Obufscation
    Friend Class Runtimer
        Public Shared Sub RuntimeExecute(inputFilePath As String, outputFilePath As String, useRenameFuncs As Boolean, useJunkMethods As Boolean, useProxyStrings As Boolean, useControlFlow As Boolean, useWatermark As Boolean, useAntiDe4dot As Boolean, useHideOEP As Boolean)
            Try
                Dim [module] = ModuleDefMD.Load(inputFilePath)

                If useRenameFuncs Then
                    RenameProtector.Execute([module], outputFilePath)
                    Console.WriteLine("RenameProtector applied successfully.")
                End If

                If useJunkMethods Then
                    JunkMethods.Execute([module], outputFilePath)
                    Console.WriteLine("JunkMethods applied successfully.")
                End If

                If useProxyStrings Then
                    ProxyString.Execute([module], outputFilePath)
                    Console.WriteLine("ProxyString applied successfully.")
                End If

                If useControlFlow Then
                    ControlFlow.Execute([module], outputFilePath)
                    Console.WriteLine("ControlFlow applied successfully.")
                End If

                If useWatermark Then
                    WaterMark.Execute([module])
                    Console.WriteLine("Watermark applied successfully.")
                End If

                If useAntiDe4dot Then
                    AntiDe4dot.Execute([module])
                    Console.WriteLine("AntiDe4dot applied successfully.")
                End If

                If useHideOEP Then
                    HideOEP.Execute([module], outputFilePath)
                End If

                [module].Write(outputFilePath)
                Console.WriteLine($"Obfuscation completed successfully. Output saved to {outputFilePath}")
            Catch ex As Exception
                Console.WriteLine($"An error occurred during obfuscation: {ex.Message}")
            End Try
        End Sub
    End Class
End Namespace
