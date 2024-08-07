Imports System
Imports System.Text
Imports System.Windows.Forms

Namespace NecroObfuscator.Algorithms.ScriptObfuscation
    Friend Class ScriptMethod
#Region "BatObfuscator"
        Public Shared Function BatObfuscator(batchCode As String) As String
            Try
                Dim obfuscatedCode As StringBuilder = New StringBuilder()
                Dim lines = batchCode.Split({Environment.NewLine}, StringSplitOptions.None)

                obfuscatedCode.AppendLine("::obfuscated by NecroFuscator")

                For Each line In lines
                    Dim obfuscatedLine As StringBuilder = New StringBuilder()
                    Dim inPercent = False
                    For Each ch In line
                        If Not inPercent Then
                            If ch = "%"c Then
                                obfuscatedLine.Append(ch)
                                inPercent = True
                            Else
                                Dim randomLength As Integer = New Random().Next(1, 11)
                                Dim randomString = ScriptMethod.RandomString(randomLength)
                                obfuscatedLine.Append($"{ch}%{randomString}%")
                            End If
                        Else
                            If ch = "%"c Then
                                obfuscatedLine.Append(ch)
                                inPercent = False
                            Else
                                obfuscatedLine.Append(ch)
                            End If
                        End If
                    Next
                    obfuscatedCode.AppendLine(obfuscatedLine.ToString())
                Next

                Return obfuscatedCode.ToString()
            Catch ex As Exception
                MessageBox.Show("~ Internal Error ~", $"Internal Building Error: {ex}")
                Return Nothing
            End Try
        End Function

#End Region
#Region "VBSObfuscator"
        Public Shared Function VBSObfuscator(vbsCode As String) As String
            Dim obfuscatedCode As StringBuilder = New StringBuilder()
            Dim random As Random = New Random()

            For Each ch In vbsCode
                obfuscatedCode.Append($"Chr({Microsoft.VisualBasic.AscW(ch)})&")
            Next

            ' Убираем последний амперсанд '&'
            If obfuscatedCode.Length > 0 Then
                obfuscatedCode.Length -= 1
            End If

            Return $"Execute({obfuscatedCode.ToString()})"
        End Function
#End Region
#Region "HelperFunctions"
        Private Shared Function RandomString(length As Integer) As String
            Const chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789卐☀☁☂☃☼☽★☆☾℃℉☀ -‘๑’-☁ϟ☂︸☃⁂☼☽✩✪✫✬✭✮✯✰牡マキグナルファ系路克瑞大阪市立学鎰命科ャマ能力ϒ人は妻スティ要望通り玉宏¥サ丹谷Ѫ灯影伝鶐ԱաԲբԳգԴդԵեԶզԷէԸըԹթԺժԻиԼլԽխԾծԿկՀհՁձՂղՃճՄмՅյՆնՇշՈոՉчПпՋջՌрՍսՎвՏтՐрՑцՒуՓпՔкՕоՖфლ(´ڡ`ლ)ლ(ಠ益ಠლ)ლ(╹◡╹ლ)ლ(◉◞౪◟◉‵ლヾ(⌐■_■)ノ♪(◕‿◕)| (• ◡•)|(❍ᴥ❍ʋ)⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛"
            Dim charArray As Char() = chars.ToCharArray()
            Dim rng As Random = New Random()
            Dim n = charArray.Length
            While n > 1
                n -= 1
                Dim k = rng.Next(n + 1)
                Dim value = charArray(k)
                charArray(k) = charArray(n)
                charArray(n) = value
            End While
            Dim lRandomString As StringBuilder = New StringBuilder()
            For i = 0 To length - 1
                lRandomString.Append(charArray(rng.Next(charArray.Length)))
            Next
            Return lRandomString.ToString()
        End Function
#End Region
    End Class
End Namespace
