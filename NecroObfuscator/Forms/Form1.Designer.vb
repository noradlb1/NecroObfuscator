Imports System

Namespace NecroObfuscator
    Partial Class Form1
        ''' <summary>
        ''' Обязательная переменная конструктора.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Освободить все используемые ресурсы.
        ''' </summary>
        ''' <paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Код, автоматически созданный конструктором форм Windows"

        ''' <summary>
        ''' Требуемый метод для поддержки конструктора — не изменяйте 
        ''' содержимое этого метода с помощью редактора кода.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            metroLabel1 = New MetroFramework.Controls.MetroLabel()
            metroTabControl1 = New MetroFramework.Controls.MetroTabControl()
            metroTabPage1 = New MetroFramework.Controls.MetroTabPage()
            Antide4dot_Chk = New MetroFramework.Controls.MetroCheckBox()
            Watermark_Chk = New MetroFramework.Controls.MetroCheckBox()
            ControlFlow_Chk = New MetroFramework.Controls.MetroCheckBox()
            SelectorBtn = New Windows.Forms.Button()
            BuildBtn = New Windows.Forms.Button()
            ProxyString_Chk = New MetroFramework.Controls.MetroCheckBox()
            JunkMethods_Chk = New MetroFramework.Controls.MetroCheckBox()
            RenameFuncs_Chk = New MetroFramework.Controls.MetroCheckBox()
            SelectedFile_Box = New MetroFramework.Controls.MetroTextBox()
            metroTabPage2 = New MetroFramework.Controls.MetroTabPage()
            label2 = New Windows.Forms.Label()
            DetectorLabel = New Windows.Forms.Label()
            label1 = New Windows.Forms.Label()
            ScriptObfuscateBtn = New Windows.Forms.Button()
            ScriptSelectorBtn = New Windows.Forms.Button()
            ScripLocateBox = New MetroFramework.Controls.MetroTextBox()
            metroTabPage3 = New MetroFramework.Controls.MetroTabPage()
            AuthorLabel = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            pictureBox2 = New Windows.Forms.PictureBox()
            pictureBox1 = New Windows.Forms.PictureBox()
            HideOEP_Chk = New MetroFramework.Controls.MetroCheckBox()
            metroTabControl1.SuspendLayout()
            metroTabPage1.SuspendLayout()
            metroTabPage2.SuspendLayout()
            metroTabPage3.SuspendLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' metroLabel1
            ' 
            metroLabel1.AutoSize = True
            metroLabel1.CustomBackground = True
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
            metroLabel1.Location = New Drawing.Point(70, 11)
            metroLabel1.Name = "metroLabel1"
            metroLabel1.Size = New Drawing.Size(203, 50)
            metroLabel1.Style = MetroFramework.MetroColorStyle.Blue
            metroLabel1.TabIndex = 1
            metroLabel1.Text = "NecroObfuscator v 1.2" & Microsoft.VisualBasic.Constants.vbCrLf
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
            metroLabel1.UseStyleColors = True
            ' 
            ' metroTabControl1
            ' 
            metroTabControl1.Controls.Add(metroTabPage1)
            metroTabControl1.Controls.Add(metroTabPage2)
            metroTabControl1.Controls.Add(metroTabPage3)
            metroTabControl1.CustomBackground = True
            metroTabControl1.Location = New Drawing.Point(13, 89)
            metroTabControl1.Name = "metroTabControl1"
            metroTabControl1.SelectedIndex = 0
            metroTabControl1.Size = New Drawing.Size(384, 261)
            metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue
            metroTabControl1.TabIndex = 2
            metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
            ' 
            ' metroTabPage1
            ' 
            metroTabPage1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            metroTabPage1.Controls.Add(HideOEP_Chk)
            metroTabPage1.Controls.Add(Antide4dot_Chk)
            metroTabPage1.Controls.Add(Watermark_Chk)
            metroTabPage1.Controls.Add(ControlFlow_Chk)
            metroTabPage1.Controls.Add(SelectorBtn)
            metroTabPage1.Controls.Add(BuildBtn)
            metroTabPage1.Controls.Add(ProxyString_Chk)
            metroTabPage1.Controls.Add(JunkMethods_Chk)
            metroTabPage1.Controls.Add(RenameFuncs_Chk)
            metroTabPage1.Controls.Add(SelectedFile_Box)
            metroTabPage1.HorizontalScrollbarBarColor = True
            metroTabPage1.Location = New Drawing.Point(4, 35)
            metroTabPage1.Name = "metroTabPage1"
            metroTabPage1.Size = New Drawing.Size(376, 222)
            metroTabPage1.TabIndex = 0
            metroTabPage1.Text = ".NET/DLL-Obfuscator"
            metroTabPage1.VerticalScrollbarBarColor = True
            ' 
            ' Antide4dot_Chk
            ' 
            Antide4dot_Chk.AutoSize = True
            Antide4dot_Chk.BackColor = Drawing.Color.White
            Antide4dot_Chk.CustomBackground = True
            Antide4dot_Chk.CustomForeColor = True
            Antide4dot_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            Antide4dot_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            Antide4dot_Chk.ForeColor = Drawing.Color.Black
            Antide4dot_Chk.Location = New Drawing.Point(221, 116)
            Antide4dot_Chk.Name = "Antide4dot_Chk"
            Antide4dot_Chk.Size = New Drawing.Size(96, 19)
            Antide4dot_Chk.Style = MetroFramework.MetroColorStyle.Blue
            Antide4dot_Chk.TabIndex = 16
            Antide4dot_Chk.Text = "AntiDe4dot"
            Antide4dot_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            Antide4dot_Chk.UseStyleColors = True
            Antide4dot_Chk.UseVisualStyleBackColor = False
            ' 
            ' Watermark_Chk
            ' 
            Watermark_Chk.AutoSize = True
            Watermark_Chk.BackColor = Drawing.Color.White
            Watermark_Chk.CustomBackground = True
            Watermark_Chk.CustomForeColor = True
            Watermark_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            Watermark_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            Watermark_Chk.ForeColor = Drawing.Color.Black
            Watermark_Chk.Location = New Drawing.Point(221, 66)
            Watermark_Chk.Name = "Watermark_Chk"
            Watermark_Chk.Size = New Drawing.Size(92, 19)
            Watermark_Chk.Style = MetroFramework.MetroColorStyle.Blue
            Watermark_Chk.TabIndex = 15
            Watermark_Chk.Text = "Watermark"
            Watermark_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            Watermark_Chk.UseStyleColors = True
            Watermark_Chk.UseVisualStyleBackColor = False
            ' 
            ' ControlFlow_Chk
            ' 
            ControlFlow_Chk.AutoSize = True
            ControlFlow_Chk.BackColor = Drawing.Color.White
            ControlFlow_Chk.CustomBackground = True
            ControlFlow_Chk.CustomForeColor = True
            ControlFlow_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            ControlFlow_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            ControlFlow_Chk.ForeColor = Drawing.Color.Black
            ControlFlow_Chk.Location = New Drawing.Point(221, 91)
            ControlFlow_Chk.Name = "ControlFlow_Chk"
            ControlFlow_Chk.Size = New Drawing.Size(99, 19)
            ControlFlow_Chk.Style = MetroFramework.MetroColorStyle.Blue
            ControlFlow_Chk.TabIndex = 14
            ControlFlow_Chk.Text = "ControlFlow"
            ControlFlow_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            ControlFlow_Chk.UseStyleColors = True
            ControlFlow_Chk.UseVisualStyleBackColor = False
            ' 
            ' SelectorBtn
            ' 
            SelectorBtn.BackColor = Drawing.Color.Aqua
            SelectorBtn.BackgroundImageLayout = Windows.Forms.ImageLayout.None
            SelectorBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
            SelectorBtn.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            SelectorBtn.ForeColor = Drawing.Color.White
            SelectorBtn.Location = New Drawing.Point(319, 31)
            SelectorBtn.Name = "SelectorBtn"
            SelectorBtn.Size = New Drawing.Size(42, 29)
            SelectorBtn.TabIndex = 13
            SelectorBtn.Text = "..."
            SelectorBtn.UseVisualStyleBackColor = False
            AddHandler SelectorBtn.Click, New EventHandler(AddressOf SelectorBtn_Click)
            ' 
            ' BuildBtn
            ' 
            BuildBtn.BackColor = Drawing.Color.Aqua
            BuildBtn.BackgroundImageLayout = Windows.Forms.ImageLayout.None
            BuildBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
            BuildBtn.Font = New Drawing.Font("Consolas", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            BuildBtn.ForeColor = Drawing.Color.White
            BuildBtn.Location = New Drawing.Point(79, 152)
            BuildBtn.Name = "BuildBtn"
            BuildBtn.Size = New Drawing.Size(215, 49)
            BuildBtn.TabIndex = 12
            BuildBtn.Text = "OBFUSCATE"
            BuildBtn.UseVisualStyleBackColor = False
            AddHandler BuildBtn.Click, New EventHandler(AddressOf BuildBtn_Click)
            ' 
            ' ProxyString_Chk
            ' 
            ProxyString_Chk.AutoSize = True
            ProxyString_Chk.BackColor = Drawing.Color.White
            ProxyString_Chk.CustomBackground = True
            ProxyString_Chk.CustomForeColor = True
            ProxyString_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            ProxyString_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            ProxyString_Chk.ForeColor = Drawing.Color.Black
            ProxyString_Chk.Location = New Drawing.Point(21, 116)
            ProxyString_Chk.Name = "ProxyString_Chk"
            ProxyString_Chk.Size = New Drawing.Size(95, 19)
            ProxyString_Chk.Style = MetroFramework.MetroColorStyle.Blue
            ProxyString_Chk.TabIndex = 5
            ProxyString_Chk.Text = "ProxyString"
            ProxyString_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            ProxyString_Chk.UseStyleColors = True
            ProxyString_Chk.UseVisualStyleBackColor = False
            ' 
            ' JunkMethods_Chk
            ' 
            JunkMethods_Chk.AutoSize = True
            JunkMethods_Chk.BackColor = Drawing.Color.White
            JunkMethods_Chk.CustomBackground = True
            JunkMethods_Chk.CustomForeColor = True
            JunkMethods_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            JunkMethods_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            JunkMethods_Chk.ForeColor = Drawing.Color.Black
            JunkMethods_Chk.Location = New Drawing.Point(21, 91)
            JunkMethods_Chk.Name = "JunkMethods_Chk"
            JunkMethods_Chk.Size = New Drawing.Size(114, 19)
            JunkMethods_Chk.Style = MetroFramework.MetroColorStyle.Blue
            JunkMethods_Chk.TabIndex = 4
            JunkMethods_Chk.Text = "Junk-Methods"
            JunkMethods_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            JunkMethods_Chk.UseStyleColors = True
            JunkMethods_Chk.UseVisualStyleBackColor = False
            ' 
            ' RenameFuncs_Chk
            ' 
            RenameFuncs_Chk.AutoSize = True
            RenameFuncs_Chk.BackColor = Drawing.Color.White
            RenameFuncs_Chk.CustomBackground = True
            RenameFuncs_Chk.CustomForeColor = True
            RenameFuncs_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            RenameFuncs_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            RenameFuncs_Chk.ForeColor = Drawing.Color.Black
            RenameFuncs_Chk.Location = New Drawing.Point(21, 66)
            RenameFuncs_Chk.Name = "RenameFuncs_Chk"
            RenameFuncs_Chk.Size = New Drawing.Size(139, 19)
            RenameFuncs_Chk.Style = MetroFramework.MetroColorStyle.Blue
            RenameFuncs_Chk.TabIndex = 3
            RenameFuncs_Chk.Text = "Rename-Functions"
            RenameFuncs_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            RenameFuncs_Chk.UseStyleColors = True
            RenameFuncs_Chk.UseVisualStyleBackColor = False
            ' 
            ' SelectedFile_Box
            ' 
            SelectedFile_Box.BackColor = Drawing.Color.White
            SelectedFile_Box.CustomBackground = True
            SelectedFile_Box.CustomForeColor = True
            SelectedFile_Box.FontSize = MetroFramework.MetroTextBoxSize.Medium
            SelectedFile_Box.ForeColor = Drawing.Color.Black
            SelectedFile_Box.Location = New Drawing.Point(3, 31)
            SelectedFile_Box.Multiline = True
            SelectedFile_Box.Name = "SelectedFile_Box"
            SelectedFile_Box.PromptText = "EXE PATH"
            SelectedFile_Box.Size = New Drawing.Size(310, 29)
            SelectedFile_Box.Style = MetroFramework.MetroColorStyle.Blue
            SelectedFile_Box.TabIndex = 2
            SelectedFile_Box.TextAlign = Windows.Forms.HorizontalAlignment.Center
            SelectedFile_Box.Theme = MetroFramework.MetroThemeStyle.Light
            SelectedFile_Box.UseStyleColors = True
            ' 
            ' metroTabPage2
            ' 
            metroTabPage2.BackColor = Drawing.Color.White
            metroTabPage2.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            metroTabPage2.Controls.Add(label2)
            metroTabPage2.Controls.Add(DetectorLabel)
            metroTabPage2.Controls.Add(label1)
            metroTabPage2.Controls.Add(ScriptObfuscateBtn)
            metroTabPage2.Controls.Add(ScriptSelectorBtn)
            metroTabPage2.Controls.Add(ScripLocateBox)
            metroTabPage2.HorizontalScrollbarBarColor = True
            metroTabPage2.Location = New Drawing.Point(4, 35)
            metroTabPage2.Name = "metroTabPage2"
            metroTabPage2.Size = New Drawing.Size(376, 222)
            metroTabPage2.TabIndex = 1
            metroTabPage2.Text = "Script-Obfuscate"
            metroTabPage2.VerticalScrollbarBarColor = True
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.Color.Transparent
            label2.Font = New Drawing.Font("Consolas", 14.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 204)
            label2.ForeColor = Drawing.Color.DeepSkyBlue
            label2.Location = New Drawing.Point(2, 95)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(100, 22)
            label2.TabIndex = 19
            label2.Text = "Detected:"
            ' 
            ' DetectorLabel
            ' 
            DetectorLabel.AutoSize = True
            DetectorLabel.BackColor = Drawing.Color.Transparent
            DetectorLabel.Font = New Drawing.Font("Liberation Mono", 11.75F)
            DetectorLabel.ForeColor = Drawing.Color.DeepSkyBlue
            DetectorLabel.Location = New Drawing.Point(98, 98)
            DetectorLabel.Name = "DetectorLabel"
            DetectorLabel.Size = New Drawing.Size(48, 18)
            DetectorLabel.TabIndex = 18
            DetectorLabel.Text = "Idle"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.Color.Transparent
            label1.Font = New Drawing.Font("Liberation Mono", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            label1.ForeColor = Drawing.Color.DeepSkyBlue
            label1.Location = New Drawing.Point(15, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(351, 44)
            label1.TabIndex = 17
            label1.Text = "Available files for obfuscation" & Microsoft.VisualBasic.Constants.vbCrLf & "      [ .BAT    .VBS ]"
            ' 
            ' ScriptObfuscateBtn
            ' 
            ScriptObfuscateBtn.BackColor = Drawing.Color.Aqua
            ScriptObfuscateBtn.BackgroundImageLayout = Windows.Forms.ImageLayout.None
            ScriptObfuscateBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
            ScriptObfuscateBtn.Font = New Drawing.Font("Consolas", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            ScriptObfuscateBtn.ForeColor = Drawing.Color.White
            ScriptObfuscateBtn.Location = New Drawing.Point(66, 154)
            ScriptObfuscateBtn.Name = "ScriptObfuscateBtn"
            ScriptObfuscateBtn.Size = New Drawing.Size(247, 52)
            ScriptObfuscateBtn.TabIndex = 15
            ScriptObfuscateBtn.Text = "OBFUSCATE"
            ScriptObfuscateBtn.UseVisualStyleBackColor = False
            AddHandler ScriptObfuscateBtn.Click, New EventHandler(AddressOf ScriptObfuscateBtn_Click)
            ' 
            ' ScriptSelectorBtn
            ' 
            ScriptSelectorBtn.BackColor = Drawing.Color.Aqua
            ScriptSelectorBtn.BackgroundImageLayout = Windows.Forms.ImageLayout.None
            ScriptSelectorBtn.FlatStyle = Windows.Forms.FlatStyle.Flat
            ScriptSelectorBtn.Font = New Drawing.Font("Consolas", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 204)
            ScriptSelectorBtn.ForeColor = Drawing.Color.White
            ScriptSelectorBtn.Location = New Drawing.Point(317, 61)
            ScriptSelectorBtn.Name = "ScriptSelectorBtn"
            ScriptSelectorBtn.Size = New Drawing.Size(49, 29)
            ScriptSelectorBtn.TabIndex = 15
            ScriptSelectorBtn.Text = "..."
            ScriptSelectorBtn.UseVisualStyleBackColor = False
            AddHandler ScriptSelectorBtn.Click, New EventHandler(AddressOf ScriptSelectorBtn_Click)
            ' 
            ' ScripLocateBox
            ' 
            ScripLocateBox.BackColor = Drawing.Color.White
            ScripLocateBox.CustomBackground = True
            ScripLocateBox.CustomForeColor = True
            ScripLocateBox.FontSize = MetroFramework.MetroTextBoxSize.Medium
            ScripLocateBox.ForeColor = Drawing.Color.Black
            ScripLocateBox.Location = New Drawing.Point(1, 61)
            ScripLocateBox.Multiline = True
            ScripLocateBox.Name = "ScripLocateBox"
            ScripLocateBox.PromptText = "EXE PATH"
            ScripLocateBox.Size = New Drawing.Size(310, 29)
            ScripLocateBox.Style = MetroFramework.MetroColorStyle.Blue
            ScripLocateBox.TabIndex = 14
            ScripLocateBox.TextAlign = Windows.Forms.HorizontalAlignment.Center
            ScripLocateBox.Theme = MetroFramework.MetroThemeStyle.Light
            ScripLocateBox.UseStyleColors = True
            ' 
            ' metroTabPage3
            ' 
            metroTabPage3.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            metroTabPage3.Controls.Add(AuthorLabel)
            metroTabPage3.Controls.Add(label3)
            metroTabPage3.Controls.Add(pictureBox2)
            metroTabPage3.HorizontalScrollbarBarColor = True
            metroTabPage3.Location = New Drawing.Point(4, 35)
            metroTabPage3.Name = "metroTabPage3"
            metroTabPage3.Size = New Drawing.Size(376, 222)
            metroTabPage3.TabIndex = 2
            metroTabPage3.Text = "About Program"
            metroTabPage3.VerticalScrollbarBarColor = True
            ' 
            ' AuthorLabel
            ' 
            AuthorLabel.AutoSize = True
            AuthorLabel.BackColor = Drawing.Color.White
            AuthorLabel.Font = New Drawing.Font("Microsoft Sans Serif", 10.0F, Drawing.FontStyle.Bold)
            AuthorLabel.ForeColor = Drawing.Color.DeepSkyBlue
            AuthorLabel.Location = New Drawing.Point(17, 164)
            AuthorLabel.Name = "AuthorLabel"
            AuthorLabel.Size = New Drawing.Size(278, 51)
            AuthorLabel.TabIndex = 4
            AuthorLabel.Text = "Author: K3rnel-Dev" & Microsoft.VisualBasic.Constants.vbCrLf & "Github: https://github.com/k3rnel-dev" & Microsoft.VisualBasic.Constants.vbCrLf & "Telegram: @K666Plus"
            AddHandler AuthorLabel.Click, New EventHandler(AddressOf AuthorLabel_Click)
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(159, 63)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(209, 65)
            label3.TabIndex = 3
            label3.Text = "A simple example of an obfuscator using " & Microsoft.VisualBasic.Constants.vbCrLf & "the dnlib library, the finished version" & ", allows" & Microsoft.VisualBasic.Constants.vbCrLf & "you to obfuscate the main code of an " & Microsoft.VisualBasic.Constants.vbCrLf & "application to further complica" & "te its " & Microsoft.VisualBasic.Constants.vbCrLf & "readability and parsing"
            ' 
            ' pictureBox2
            ' 
            'pictureBox2.Image = Global.NecroObfuscator.Properties.Resources.auth
            pictureBox2.Location = New Drawing.Point(20, 32)
            pictureBox2.Name = "pictureBox2"
            pictureBox2.Size = New Drawing.Size(133, 129)
            pictureBox2.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox2.TabIndex = 2
            pictureBox2.TabStop = False
            ' 
            ' pictureBox1
            ' 
            'pictureBox1.Image = Global.NecroObfuscator.Properties.Resources.LOGO
            pictureBox1.Location = New Drawing.Point(10, 11)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(54, 52)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' HideOEP_Chk
            ' 
            HideOEP_Chk.AutoSize = True
            HideOEP_Chk.BackColor = Drawing.Color.White
            HideOEP_Chk.CustomBackground = True
            HideOEP_Chk.CustomForeColor = True
            HideOEP_Chk.FlatStyle = Windows.Forms.FlatStyle.Flat
            HideOEP_Chk.FontSize = MetroFramework.MetroLinkSize.Medium
            HideOEP_Chk.ForeColor = Drawing.Color.Black
            HideOEP_Chk.Location = New Drawing.Point(126, 117)
            HideOEP_Chk.Name = "HideOEP_Chk"
            HideOEP_Chk.Size = New Drawing.Size(83, 19)
            HideOEP_Chk.Style = MetroFramework.MetroColorStyle.Blue
            HideOEP_Chk.TabIndex = 17
            HideOEP_Chk.Text = "Hide OEP"
            HideOEP_Chk.Theme = MetroFramework.MetroThemeStyle.Light
            HideOEP_Chk.UseStyleColors = True
            HideOEP_Chk.UseVisualStyleBackColor = False
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(412, 368)
            Controls.Add(metroTabControl1)
            Controls.Add(metroLabel1)
            Controls.Add(pictureBox1)
            Cursor = Windows.Forms.Cursors.Arrow
            DisplayHeader = False
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            MaximizeBox = False
            Name = "Form1"
            Padding = New Windows.Forms.Padding(20, 30, 20, 20)
            Resizable = False
            Style = MetroFramework.MetroColorStyle.Blue
            Text = "NecroObfuscator [ Main ]"
            Theme = MetroFramework.MetroThemeStyle.Light
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            metroTabControl1.ResumeLayout(False)
            metroTabPage1.ResumeLayout(False)
            metroTabPage1.PerformLayout()
            metroTabPage2.ResumeLayout(False)
            metroTabPage2.PerformLayout()
            metroTabPage3.ResumeLayout(False)
            metroTabPage3.PerformLayout()
            CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private pictureBox1 As Windows.Forms.PictureBox
        Private metroLabel1 As MetroFramework.Controls.MetroLabel
        Private metroTabControl1 As MetroFramework.Controls.MetroTabControl
        Private metroTabPage1 As MetroFramework.Controls.MetroTabPage
        Private metroTabPage2 As MetroFramework.Controls.MetroTabPage
        Private metroTabPage3 As MetroFramework.Controls.MetroTabPage
        Private SelectedFile_Box As MetroFramework.Controls.MetroTextBox
        Private ProxyString_Chk As MetroFramework.Controls.MetroCheckBox
        Private JunkMethods_Chk As MetroFramework.Controls.MetroCheckBox
        Private RenameFuncs_Chk As MetroFramework.Controls.MetroCheckBox
        Private BuildBtn As Windows.Forms.Button
        Private SelectorBtn As Windows.Forms.Button
        Private ControlFlow_Chk As MetroFramework.Controls.MetroCheckBox
        Private ScriptObfuscateBtn As Windows.Forms.Button
        Private ScriptSelectorBtn As Windows.Forms.Button
        Private ScripLocateBox As MetroFramework.Controls.MetroTextBox
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private DetectorLabel As Windows.Forms.Label
        Private pictureBox2 As Windows.Forms.PictureBox
        Private AuthorLabel As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private Antide4dot_Chk As MetroFramework.Controls.MetroCheckBox
        Private Watermark_Chk As MetroFramework.Controls.MetroCheckBox
        Private HideOEP_Chk As MetroFramework.Controls.MetroCheckBox
    End Class
End Namespace
