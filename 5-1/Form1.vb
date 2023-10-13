Public Class Form1
    Private Function Truncate(value As Decimal, numberofDigits As Integer) As Decimal
        ' create function that truncates input value, by the amount of digits to truncate by
        Dim multiplier As Decimal = CDec(Math.Pow(10, numberofDigits))
        ' multiplier 10 to the power of 10
        Dim truncatedValue As Decimal = Decimal.Truncate(value * multiplier) / multiplier
        ' truncate the value and return
        Return truncatedValue
    End Function
    Private Function ContainsNumber(input As String) As Boolean
        ' check if a string contains a number
        Return input.Any(Function(c) Char.IsDigit(c))
    End Function
    Private Function RoundToTwoDecimalPlaces(value As Decimal) As Decimal
        ' round a decimal number to two decimal places
        Return Math.Round(value, 2)
    End Function
    Private Sub cbProblems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProblems.SelectedIndexChanged
        ' handle combo box selection change
        If cbProblems.SelectedItem = "Numeric Truncation/Rounding" Then
            ' show/hide controls based on combo box selection
            lblDecimal.Visible = True
            lblRounded.Visible = True
            lblTruncated.Visible = True
            txtDecimal.Visible = True
            txtRounded.Visible = True
            txtTruncated.Visible = True
            btnTruncateRoundNumber.Visible = True
        Else
            ' hide numeric truncation/rounding controls
            lblDecimal.Visible = False
            lblRounded.Visible = False
            lblTruncated.Visible = False
            txtDecimal.Visible = False
            txtRounded.Visible = False
            txtTruncated.Visible = False
            btnTruncateRoundNumber.Visible = False
        End If
        If cbProblems.SelectedItem = "String Character Counter" Then
            ' show string character counter controls
            lblNumOfChars.Visible = True
            lblStringToNum.Visible = True
            txtCountedChars.Visible = True
            txtStringToNum.Visible = True
            btnCountChars.Visible = True
        Else
            ' hide string character counter controls
            lblNumOfChars.Visible = False
            lblStringToNum.Visible = False
            txtCountedChars.Visible = False
            txtStringToNum.Visible = False
            btnCountChars.Visible = False
        End If
        If cbProblems.SelectedItem = "Char to ASCII" Then
            ' show char to ascii controls
            lblASCIIOut.Visible = True
            lblCharInput.Visible = True
            txtASCIIOut.Visible = True
            txtCharInput.Visible = True
            btnCharToASCII.Visible = True
        Else
            ' hide char to ascii controls
            lblASCIIOut.Visible = False
            lblCharInput.Visible = False
            txtASCIIOut.Visible = False
            txtCharInput.Visible = False
            btnCharToASCII.Visible = False
        End If
        If cbProblems.SelectedItem = "ASCII to Char" Then
            ' show ascii to char controls
            lblASCIIInput.Visible = True
            lblCharOut.Visible = True
            btnASCIItoChar.Visible = True
            txtASCIIInput.Visible = True
            txtCharOut.Visible = True
        Else
            ' hide ascii to char controls
            lblASCIIInput.Visible = False
            lblCharOut.Visible = False
            btnASCIItoChar.Visible = False
            txtASCIIInput.Visible = False
            txtCharOut.Visible = False
        End If
        If cbProblems.SelectedItem = "Uppercase Conversion" Then
            ' show uppercase conversion controls
            lblSurname.Visible = True
            lblSurnameUpper.Visible = True
            txtSurname.Visible = True
            txtSurnameUpper.Visible = True
            btnUpperCaser.Visible = True
        Else
            ' hide uppercase conversion controls
            lblSurname.Visible = False
            lblSurnameUpper.Visible = False
            txtSurname.Visible = False
            txtSurnameUpper.Visible = False
            btnUpperCaser.Visible = False
        End If
    End Sub
    Private Sub txtDecimal_TextChanged(sender As Object, e As EventArgs) Handles txtDecimal.TextChanged
        ' handle text change in the decimal text box
        If IsNumeric(txtDecimal.Text) Then
            ' enable the truncate/round button
            btnTruncateRoundNumber.Enabled = True
        ElseIf txtDecimal.Text = "" Then
            ' disable the truncate/round button
            btnTruncateRoundNumber.Enabled = False
        Else
            btnTruncateRoundNumber.Enabled = False
            MessageBox.Show($"You must enter a decimal number.")
            ' show an error message
        End If
    End Sub
    Private Sub btnTruncateRoundNumber_Click(sender As Object, e As EventArgs) Handles btnTruncateRoundNumber.Click
        ' handle click on the truncate/round button
        If IsNumeric(txtDecimal.Text) Then
            Dim DecimalNum As Decimal = Convert.ToDecimal(txtDecimal.Text)
            ' convert the text to a decimal number
            Dim numberOfDigits As Integer = 2
            ' set the number of digits to truncate
            Dim truncatedValue As Decimal = Truncate(DecimalNum, numberOfDigits)
            ' truncate the value and display in the text box
            txtTruncated.Text = truncatedValue.ToString()
            Dim roundedValue As Decimal = RoundToTwoDecimalPlaces(DecimalNum)
            ' round the value to two decimal places and display in the text box
            txtRounded.Text = roundedValue.ToString()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' handle click on the clear button
        ' clear all text boxes and disable buttons
        txtDecimal.Text = Nothing
        txtRounded.Text = Nothing
        txtTruncated.Text = Nothing
        txtCountedChars.Text = Nothing
        txtStringToNum.Text = Nothing
        txtCharInput.Text = Nothing
        txtASCIIOut.Text = Nothing
        txtASCIIInput.Text = Nothing
        txtCharOut.Text = Nothing
        txtSurnameUpper.Text = Nothing
        txtSurname.Text = Nothing
        btnCharToASCII.Enabled = False
        btnTruncateRoundNumber.Enabled = False
        btnCountChars.Enabled = False
        btnASCIItoChar.Enabled = False
        btnUpperCaser.Enabled = False
    End Sub
    Private Sub txtStringToNum_TextChanged(sender As Object, e As EventArgs) Handles txtStringToNum.TextChanged
        ' handle text change in the string to number text box
        btnCountChars.Enabled = True
        ' enable the character count button if the text is not empty
        If txtStringToNum.Text = "" Then
            btnCountChars.Enabled = False
            ' disable the character count button
        End If
    End Sub
    Private Sub btnCountChars_Click(sender As Object, e As EventArgs) Handles btnCountChars.Click
        ' handle click on the character count button
        Dim inputText As String = txtStringToNum.Text
        ' count characters in the input text and display in the text box
        Dim characterCount As Integer = inputText.Length
        txtCountedChars.Text = Convert.ToString(characterCount)
    End Sub
    Private Sub txtCharInput_TextChanged(sender As Object, e As EventArgs) Handles txtCharInput.TextChanged
        ' handle text change in the character input text box
        If txtCharInput.TextLength = 1 Then
            btnCharToASCII.Enabled = True
            ' enable the char to ascii button
        ElseIf txtCharInput.Text = "" Then
            btnCharToASCII.Enabled = False
            ' disable the char to ascii button
        Else
            btnCharToASCII.Enabled = False
        End If
    End Sub
    Private Sub btnCharToASCII_Click(sender As Object, e As EventArgs) Handles btnCharToASCII.Click
        ' handle click on the char to ascii button
        Dim myChar As Char = Convert.ToChar(txtCharInput.Text)
        Dim asciiCode As Integer = Asc(myChar)
        ' convert the character to its ascii code and display
        txtASCIIOut.Text = asciiCode
    End Sub
    Private Sub btnASCIItoChar_Click(sender As Object, e As EventArgs) Handles btnASCIItoChar.Click
        ' handle click on the ascii to char button
        If Integer.TryParse(txtASCIIInput.Text, Nothing) Then
            Dim asciiValue As Integer = Integer.Parse(txtASCIIInput.Text)
            Dim convertedChar As Char = Convert.ToChar(asciiValue)
            ' convert the ascii value to a character and display
            txtCharOut.Text = Convert.ToString(convertedChar)
        End If
    End Sub
    Private Sub txtASCIIInput_TextChanged(sender As Object, e As EventArgs) Handles txtASCIIInput.TextChanged
        ' handle text change in the ascii input text box
        If Integer.TryParse(txtASCIIInput.Text, Nothing) Then
            ' enable the ascii to char button
            btnASCIItoChar.Enabled = True
        ElseIf txtASCIIInput.Text = "" Then
            ' disable the ascii to char button
            btnASCIItoChar.Enabled = False
        Else
            btnASCIItoChar.Enabled = False
            MessageBox.Show("Please enter a valid ASCII value (an integer).")
            ' show an error message
        End If
    End Sub
    Private Sub btnUpperCaser_Click(sender As Object, e As EventArgs) Handles btnUpperCaser.Click
        ' handle click on the uppercase conversion button
        Dim inputText As String = txtSurname.Text
        Dim uppercasedText As String = inputText.ToUpper()
        ' convert the text to uppercase and display
        txtSurnameUpper.Text = uppercasedText
    End Sub
    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        ' handle text change in the surname text box
        Dim hasNumber As Boolean = ContainsNumber(txtSurname.Text)
        ' check if the text contains a number
        If txtSurname.Text = "" Then
            btnUpperCaser.Enabled = False
            ' disable the uppercase conversion button
        ElseIf hasNumber Then
            btnUpperCaser.Enabled = False
        Else
            btnUpperCaser.Enabled = True
            ' enable the uppercase conversion button
        End If
    End Sub
End Class

