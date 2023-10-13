<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDecimal = New TextBox()
        lblDecimal = New Label()
        btnTruncateRoundNumber = New Button()
        txtTruncated = New TextBox()
        cbProblems = New ComboBox()
        lblTruncated = New Label()
        lblRounded = New Label()
        txtRounded = New TextBox()
        Label1 = New Label()
        btnClear = New Button()
        txtStringToNum = New TextBox()
        txtCountedChars = New TextBox()
        btnCountChars = New Button()
        lblStringToNum = New Label()
        lblNumOfChars = New Label()
        txtCharInput = New TextBox()
        txtASCIIOut = New TextBox()
        btnCharToASCII = New Button()
        lblCharInput = New Label()
        lblASCIIOut = New Label()
        txtASCIIInput = New TextBox()
        txtCharOut = New TextBox()
        lblASCIIInput = New Label()
        lblCharOut = New Label()
        btnASCIItoChar = New Button()
        txtSurname = New TextBox()
        btnUpperCaser = New Button()
        txtSurnameUpper = New TextBox()
        lblSurname = New Label()
        lblSurnameUpper = New Label()
        SuspendLayout()
        ' 
        ' txtDecimal
        ' 
        txtDecimal.Location = New Point(151, 219)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(100, 23)
        txtDecimal.TabIndex = 0
        txtDecimal.Visible = False
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.Location = New Point(118, 201)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(169, 15)
        lblDecimal.TabIndex = 1
        lblDecimal.Text = "Enter a Number with decimals:"
        lblDecimal.Visible = False
        ' 
        ' btnTruncateRoundNumber
        ' 
        btnTruncateRoundNumber.Enabled = False
        btnTruncateRoundNumber.Location = New Point(360, 219)
        btnTruncateRoundNumber.Name = "btnTruncateRoundNumber"
        btnTruncateRoundNumber.Size = New Size(75, 23)
        btnTruncateRoundNumber.TabIndex = 2
        btnTruncateRoundNumber.Text = "Calculate"
        btnTruncateRoundNumber.UseVisualStyleBackColor = True
        btnTruncateRoundNumber.Visible = False
        ' 
        ' txtTruncated
        ' 
        txtTruncated.Location = New Point(552, 193)
        txtTruncated.Name = "txtTruncated"
        txtTruncated.ReadOnly = True
        txtTruncated.Size = New Size(100, 23)
        txtTruncated.TabIndex = 3
        txtTruncated.Visible = False
        ' 
        ' cbProblems
        ' 
        cbProblems.FormattingEnabled = True
        cbProblems.Items.AddRange(New Object() {"Numeric Truncation/Rounding", "String Character Counter", "Char to ASCII", "ASCII to Char", "Uppercase Conversion"})
        cbProblems.Location = New Point(342, 78)
        cbProblems.Name = "cbProblems"
        cbProblems.Size = New Size(121, 23)
        cbProblems.TabIndex = 4
        ' 
        ' lblTruncated
        ' 
        lblTruncated.AutoSize = True
        lblTruncated.Location = New Point(555, 175)
        lblTruncated.Name = "lblTruncated"
        lblTruncated.Size = New Size(93, 15)
        lblTruncated.TabIndex = 5
        lblTruncated.Text = "Truncated Input:"
        lblTruncated.Visible = False
        ' 
        ' lblRounded
        ' 
        lblRounded.AutoSize = True
        lblRounded.Location = New Point(558, 240)
        lblRounded.Name = "lblRounded"
        lblRounded.Size = New Size(89, 15)
        lblRounded.TabIndex = 7
        lblRounded.Text = "Rounded Input:"
        lblRounded.Visible = False
        ' 
        ' txtRounded
        ' 
        txtRounded.Location = New Point(552, 258)
        txtRounded.Name = "txtRounded"
        txtRounded.ReadOnly = True
        txtRounded.Size = New Size(100, 23)
        txtRounded.TabIndex = 6
        txtRounded.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(358, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 8
        Label1.Text = "Pick a Problem:"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Location = New Point(347, 366)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 43)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtStringToNum
        ' 
        txtStringToNum.Location = New Point(151, 221)
        txtStringToNum.Name = "txtStringToNum"
        txtStringToNum.Size = New Size(100, 23)
        txtStringToNum.TabIndex = 10
        txtStringToNum.Visible = False
        ' 
        ' txtCountedChars
        ' 
        txtCountedChars.Location = New Point(552, 222)
        txtCountedChars.Name = "txtCountedChars"
        txtCountedChars.ReadOnly = True
        txtCountedChars.Size = New Size(100, 23)
        txtCountedChars.TabIndex = 12
        txtCountedChars.Visible = False
        ' 
        ' btnCountChars
        ' 
        btnCountChars.Enabled = False
        btnCountChars.Location = New Point(360, 220)
        btnCountChars.Name = "btnCountChars"
        btnCountChars.Size = New Size(75, 23)
        btnCountChars.TabIndex = 13
        btnCountChars.Text = "Count"
        btnCountChars.UseVisualStyleBackColor = True
        btnCountChars.Visible = False
        ' 
        ' lblStringToNum
        ' 
        lblStringToNum.AutoSize = True
        lblStringToNum.Location = New Point(171, 203)
        lblStringToNum.Name = "lblStringToNum"
        lblStringToNum.Size = New Size(61, 15)
        lblStringToNum.TabIndex = 14
        lblStringToNum.Text = "Enter Text:"
        lblStringToNum.Visible = False
        ' 
        ' lblNumOfChars
        ' 
        lblNumOfChars.AutoSize = True
        lblNumOfChars.Location = New Point(539, 204)
        lblNumOfChars.Name = "lblNumOfChars"
        lblNumOfChars.Size = New Size(127, 15)
        lblNumOfChars.TabIndex = 15
        lblNumOfChars.Text = "Number of Characters:"
        lblNumOfChars.Visible = False
        ' 
        ' txtCharInput
        ' 
        txtCharInput.Location = New Point(151, 219)
        txtCharInput.Name = "txtCharInput"
        txtCharInput.Size = New Size(100, 23)
        txtCharInput.TabIndex = 16
        txtCharInput.Visible = False
        ' 
        ' txtASCIIOut
        ' 
        txtASCIIOut.Location = New Point(552, 221)
        txtASCIIOut.Name = "txtASCIIOut"
        txtASCIIOut.ReadOnly = True
        txtASCIIOut.Size = New Size(100, 23)
        txtASCIIOut.TabIndex = 17
        txtASCIIOut.Visible = False
        ' 
        ' btnCharToASCII
        ' 
        btnCharToASCII.Enabled = False
        btnCharToASCII.Location = New Point(360, 218)
        btnCharToASCII.Name = "btnCharToASCII"
        btnCharToASCII.Size = New Size(75, 23)
        btnCharToASCII.TabIndex = 18
        btnCharToASCII.Text = "Convert"
        btnCharToASCII.UseVisualStyleBackColor = True
        btnCharToASCII.Visible = False
        ' 
        ' lblCharInput
        ' 
        lblCharInput.AutoSize = True
        lblCharInput.Location = New Point(155, 204)
        lblCharInput.Name = "lblCharInput"
        lblCharInput.Size = New Size(91, 15)
        lblCharInput.TabIndex = 19
        lblCharInput.Text = "Enter Character:"
        lblCharInput.Visible = False
        ' 
        ' lblASCIIOut
        ' 
        lblASCIIOut.AutoSize = True
        lblASCIIOut.Location = New Point(567, 204)
        lblASCIIOut.Name = "lblASCIIOut"
        lblASCIIOut.Size = New Size(69, 15)
        lblASCIIOut.TabIndex = 20
        lblASCIIOut.Text = "ASCII Code:"
        lblASCIIOut.Visible = False
        ' 
        ' txtASCIIInput
        ' 
        txtASCIIInput.Location = New Point(151, 220)
        txtASCIIInput.Name = "txtASCIIInput"
        txtASCIIInput.Size = New Size(100, 23)
        txtASCIIInput.TabIndex = 21
        txtASCIIInput.Visible = False
        ' 
        ' txtCharOut
        ' 
        txtCharOut.Location = New Point(552, 222)
        txtCharOut.Name = "txtCharOut"
        txtCharOut.ReadOnly = True
        txtCharOut.Size = New Size(100, 23)
        txtCharOut.TabIndex = 22
        txtCharOut.Visible = False
        ' 
        ' lblASCIIInput
        ' 
        lblASCIIInput.AutoSize = True
        lblASCIIInput.Location = New Point(152, 204)
        lblASCIIInput.Name = "lblASCIIInput"
        lblASCIIInput.Size = New Size(99, 15)
        lblASCIIInput.TabIndex = 23
        lblASCIIInput.Text = "Enter ASCII Code:"
        lblASCIIInput.Visible = False
        ' 
        ' lblCharOut
        ' 
        lblCharOut.AutoSize = True
        lblCharOut.Location = New Point(575, 204)
        lblCharOut.Name = "lblCharOut"
        lblCharOut.Size = New Size(61, 15)
        lblCharOut.TabIndex = 24
        lblCharOut.Text = "Character:"
        lblCharOut.Visible = False
        ' 
        ' btnASCIItoChar
        ' 
        btnASCIItoChar.Enabled = False
        btnASCIItoChar.Location = New Point(360, 218)
        btnASCIItoChar.Name = "btnASCIItoChar"
        btnASCIItoChar.Size = New Size(75, 23)
        btnASCIItoChar.TabIndex = 25
        btnASCIItoChar.Text = "Convert"
        btnASCIItoChar.UseVisualStyleBackColor = True
        btnASCIItoChar.Visible = False
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(151, 222)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(100, 23)
        txtSurname.TabIndex = 26
        txtSurname.Visible = False
        ' 
        ' btnUpperCaser
        ' 
        btnUpperCaser.Enabled = False
        btnUpperCaser.Location = New Point(360, 221)
        btnUpperCaser.Name = "btnUpperCaser"
        btnUpperCaser.Size = New Size(75, 23)
        btnUpperCaser.TabIndex = 27
        btnUpperCaser.Text = "Convert"
        btnUpperCaser.UseVisualStyleBackColor = True
        btnUpperCaser.Visible = False
        ' 
        ' txtSurnameUpper
        ' 
        txtSurnameUpper.Location = New Point(552, 222)
        txtSurnameUpper.Name = "txtSurnameUpper"
        txtSurnameUpper.ReadOnly = True
        txtSurnameUpper.Size = New Size(100, 23)
        txtSurnameUpper.TabIndex = 28
        txtSurnameUpper.Visible = False
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(157, 204)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(87, 15)
        lblSurname.TabIndex = 29
        lblSurname.Text = "Enter Surname:"
        lblSurname.Visible = False
        ' 
        ' lblSurnameUpper
        ' 
        lblSurnameUpper.AutoSize = True
        lblSurnameUpper.Location = New Point(545, 204)
        lblSurnameUpper.Name = "lblSurnameUpper"
        lblSurnameUpper.Size = New Size(115, 15)
        lblSurnameUpper.TabIndex = 30
        lblSurnameUpper.Text = "Converted Surname:"
        lblSurnameUpper.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSurnameUpper)
        Controls.Add(lblSurname)
        Controls.Add(txtSurnameUpper)
        Controls.Add(btnUpperCaser)
        Controls.Add(txtSurname)
        Controls.Add(btnASCIItoChar)
        Controls.Add(lblCharOut)
        Controls.Add(lblASCIIInput)
        Controls.Add(txtCharOut)
        Controls.Add(txtASCIIInput)
        Controls.Add(lblASCIIOut)
        Controls.Add(lblCharInput)
        Controls.Add(btnCharToASCII)
        Controls.Add(txtASCIIOut)
        Controls.Add(txtCharInput)
        Controls.Add(lblNumOfChars)
        Controls.Add(lblStringToNum)
        Controls.Add(btnCountChars)
        Controls.Add(txtCountedChars)
        Controls.Add(txtStringToNum)
        Controls.Add(btnClear)
        Controls.Add(Label1)
        Controls.Add(lblRounded)
        Controls.Add(txtRounded)
        Controls.Add(lblTruncated)
        Controls.Add(cbProblems)
        Controls.Add(txtTruncated)
        Controls.Add(btnTruncateRoundNumber)
        Controls.Add(lblDecimal)
        Controls.Add(txtDecimal)
        Name = "Form1"
        Text = "5-1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents lblDecimal As Label
    Friend WithEvents btnTruncateRoundNumber As Button
    Friend WithEvents txtTruncated As TextBox
    Friend WithEvents cbProblems As ComboBox
    Friend WithEvents lblTruncated As Label
    Friend WithEvents lblRounded As Label
    Friend WithEvents txtRounded As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtStringToNum As TextBox
    Friend WithEvents txtCountedChars As TextBox
    Friend WithEvents btnCountChars As Button
    Friend WithEvents lblStringToNum As Label
    Friend WithEvents lblNumOfChars As Label
    Friend WithEvents txtCharInput As TextBox
    Friend WithEvents txtASCIIOut As TextBox
    Friend WithEvents btnCharToASCII As Button
    Friend WithEvents lblCharInput As Label
    Friend WithEvents lblASCIIOut As Label
    Friend WithEvents txtASCIIInput As TextBox
    Friend WithEvents txtCharOut As TextBox
    Friend WithEvents lblASCIIInput As Label
    Friend WithEvents lblCharOut As Label
    Friend WithEvents btnASCIItoChar As Button
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents btnUpperCaser As Button
    Friend WithEvents txtSurnameUpper As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblSurnameUpper As Label
End Class
