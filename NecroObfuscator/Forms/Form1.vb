Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.IO
Imports NecroObfuscator.Algorithms.Obufscation
Imports NecroObfuscator.Algorithms.ScriptObfuscation
Imports System.Diagnostics

Namespace NecroObfuscator
    Public Partial Class Form1
        Inherits MetroFramework.Forms.MetroForm
        Public Sub New()
            InitializeComponent()
        End Sub
#Region "DOTNET OBFUSCATE UTILS"
        Private Sub BuildBtn_Click(sender As Object, e As EventArgs)
            Dim controlFlow = ControlFlow_Chk.Checked, renameFuncs = RenameFuncs_Chk.Checked, junkMethods = JunkMethods_Chk.Checked, proxyString = ProxyString_Chk.Checked, antiDe4dot = Antide4dot_Chk.Checked, watermark = Watermark_Chk.Checked, hideOEP = HideOEP_Chk.Checked

            Dim FilePath = SelectedFile_Box.Text

            If String.IsNullOrEmpty(FilePath) Then
                MessageBox.Show("Forms cannot be empty!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Using save As SaveFileDialog = New SaveFileDialog()
                save.Title = "Save out file"
                save.Filter = "Exe Files (*.exe)|*.exe"

                If save.ShowDialog() = DialogResult.OK Then
                    Runtimer.RuntimeExecute(FilePath, save.FileName, renameFuncs, junkMethods, proxyString, controlFlow, watermark, antiDe4dot, hideOEP)
                    MessageBox.Show("Obfuscation Successfull!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub

        Private Sub SelectorBtn_Click(sender As Object, e As EventArgs)
            Using ofd As OpenFileDialog = New OpenFileDialog()
                ofd.Title = "Open file to Obfuscate"
                ofd.Filter = "Exe Files (*.exe)|*.exe"

                If ofd.ShowDialog() = DialogResult.OK Then
                    SelectedFile_Box.Text = ofd.FileName
                End If
            End Using
        End Sub
#End Region
#Region "SCRIPT OBFUSCATE"
        Private Sub ScriptObfuscateBtn_Click(sender As Object, e As EventArgs)
            Dim ScriptLocate = ScripLocateBox.Text
            Dim ExtensionFile = DetectorLabel.Text

            ' Проверка на наличие выбранного файла
            If String.IsNullOrEmpty(ScriptLocate) OrElse Equals(ExtensionFile, "Idle") Then
                MessageBox.Show("Please select file!", "~ Build Information ~", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Чтение исходного кода из выбранного файла
            Dim scriptCode As String
            Try
                scriptCode = File.ReadAllText(ScriptLocate)
            Catch ex As Exception
                MessageBox.Show($"Error reading file: {ex.Message}", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            ' Объявление переменной для хранения обфусцированного кода
            Dim obfuscatedCode As String = Nothing

            ' Выполнение обфускации в зависимости от типа файла
            If ExtensionFile.Contains("BAT") Then
                obfuscatedCode = ScriptMethod.BatObfuscator(scriptCode)
            ElseIf ExtensionFile.Contains("VBS") Then
                obfuscatedCode = ScriptMethod.VBSObfuscator(scriptCode)
            Else
                MessageBox.Show("Unsupported file type!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Проверка, успешно ли обфусцирован код
            If Equals(obfuscatedCode, Nothing) Then
                MessageBox.Show("Obfuscation failed!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using save As SaveFileDialog = New SaveFileDialog()
                save.Title = "Save obfuscated file!"

                If ExtensionFile.Contains("BAT") Then
                    save.Filter = "Batch Script (*.bat)|*.bat"
                    save.DefaultExt = "bat"
                ElseIf ExtensionFile.Contains("VBS") Then
                    save.Filter = "VBS Script (*.vbs)|*.vbs"
                    save.DefaultExt = "vbs"
                Else
                    MessageBox.Show("Unsupported file type!", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Если пользователь выбрал место для сохранения файла
                If save.ShowDialog() = DialogResult.OK Then
                    Dim savePath = save.FileName

                    Try
                        ' Сохранение обфусцированного кода в файл
                        File.WriteAllText(savePath, obfuscatedCode)
                        MessageBox.Show($"File saved successfully: {savePath}", "~ Save Successful ~", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show($"Error saving file: {ex.Message}", "~ Error ~", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub



        Private Sub ScriptSelectorBtn_Click(sender As Object, e As EventArgs)
            Using ofd As OpenFileDialog = New OpenFileDialog()
                ofd.Title = "Open file to Obfuscate"
                ofd.Filter = "Script Files (*.vbs;*.bat)|*.vbs;*.bat"

                If ofd.ShowDialog() = DialogResult.OK Then
                    ScripLocateBox.Text = ofd.FileName

                    ' Определяем расширение файла
                    Dim fileExtension As String = Path.GetExtension(ofd.FileName).ToLower()

                    ' В зависимости от расширения добавляем текст к DetectorLabel
                    Select Case fileExtension
                        Case ".vbs"
                            DetectorLabel.Text = "VBS"
                        Case ".bat"
                            DetectorLabel.Text = "BAT"
                        Case Else
                            DetectorLabel.Text = "Unsupported File Selected"
                    End Select
                End If
            End Using
        End Sub


#End Region
#Region "Form Setters"
        Private Function CreateRoundedRectanglePath(width As Integer, height As Integer, radius As Integer) As GraphicsPath
            Dim path As GraphicsPath = New GraphicsPath()

            ' Add rounded corners to the path
            path.AddArc(0, 0, radius, radius, 180, 90)
            path.AddArc(width - radius, 0, radius, radius, 270, 90)
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90)
            path.AddArc(0, height - radius, radius, radius, 90, 90)

            path.CloseFigure()

            Return path
        End Function

        Private Sub Form1_Load(sender As Object, e As EventArgs)

            Dim CornerRadius = 30
            Dim path = CreateRoundedRectanglePath(Width, Height, CornerRadius)
            Region = New Region(path)
        End Sub
        Private Sub AuthorLabel_Click(sender As Object, e As EventArgs)
            Process.Start("https://github.com/k3rnel-dev")
        End Sub
#End Region
    End Class
End Namespace
