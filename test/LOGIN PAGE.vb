﻿Imports System.Net.Mail
Imports System.Web
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient




Public Class LOGIN_PAGE
    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection
    Public Shared email As String
    Public Shared StudentID As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = New MySqlConnection(connectionString)

            connection.Open()
            MessageBox.Show("Connection successful!")

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ExecuteQuery(query As String)
        Try
            connection.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(query, connection)

            cmd.ExecuteNonQuery()

            connection.Close()

            MessageBox.Show("Query executed successfully!")
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub RegisterData(SID As String, FName As String, LName As String, Email As String, Password As String)
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO user_data (`Student ID`, `First Name`, `Last Name`, Email, Password) VALUES (@SID, @FName, @LName, @Email, @Password)"

            Dim cmd As MySqlCommand = New MySqlCommand(insertQuery, connection)

            cmd.Parameters.AddWithValue("@SID", SID)
            cmd.Parameters.AddWithValue("@FName", FName)
            cmd.Parameters.AddWithValue("@LName", LName)
            cmd.Parameters.AddWithValue("@Email", Email)
            cmd.Parameters.AddWithValue("@Password", Password)

            cmd.ExecuteNonQuery()


            MessageBox.Show("Register Successful!")


            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateLogin(SID As String, Password As String) As Boolean
        Try

            connection.Open()


            Dim selectQuery As String = "SELECT COUNT(*) FROM user_data WHERE `Student ID` = @SID AND Password = @Password"


            Dim cmd As MySqlCommand = New MySqlCommand(selectQuery, connection)


            cmd.Parameters.AddWithValue("@SID", SID)
            cmd.Parameters.AddWithValue("@Password", Password)


            Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())


            connection.Close()


            Return userCount > 0
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        RegisterData(regSID.Text, regFirstName.Text, regLastName.Text, regEmail.Text, regPass.Text)
        email = regEmail.Text
        regEmail.Text = "Email"
        regSID.Text = "SID (EX. 24-12345)"
        regFirstName.Text = "First Name"
        regLastName.Text = "Last Name"
        regPass.Text = "Password"
        regConfirmPass.Text = "Confirm Password"
        EMAIL_VERIFICATION.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If ValidateLogin(logUser.Text, logPass.Text) Then
            MsgBox("Login Successful!")
            LOGIN_PAGE.StudentID = logUser.Text
            logUser.Text = ""
            logPass.Text = ""
            Me.Hide()
            NGD_Dashboard.Show()
        Else
            MsgBox("Invalid Username/Password.")
        End If
    End Sub

    Private Sub showRegBtn_Click(sender As Object, e As EventArgs) Handles showRegBtn.Click
        regPanel.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles showLoginBtn.Click
        loginPanel.BringToFront()
    End Sub

    Private Sub regFirstName_Click(sender As Object, e As EventArgs) Handles regFirstName.Click
        If regFirstName.Text = "First Name" Then
            regFirstName.Text = ""
        End If
    End Sub

    Private Sub regFirstName_LostFocus(sender As Object, e As EventArgs) Handles regFirstName.LostFocus
        If regFirstName.Text = "" Then
            regFirstName.Text = "First Name"
        End If
    End Sub

    Private Sub regLastName_Click(sender As Object, e As EventArgs) Handles regLastName.Click
        If regLastName.Text = "Last Name" Then
            regLastName.Text = ""
        End If
    End Sub

    Private Sub regLastName_LostFocus(sender As Object, e As EventArgs) Handles regLastName.LostFocus
        If regLastName.Text = "" Then
            regLastName.Text = "Last Name"
        End If
    End Sub

    Private Sub regSID_Click(sender As Object, e As EventArgs) Handles regSID.Click
        If regSID.Text = "SID (EX. 24-12345)" Then
            regSID.Text = ""
        End If
    End Sub

    Private Sub regSID_LostFocus(sender As Object, e As EventArgs) Handles regSID.LostFocus
        If regSID.Text = "" Then
            regSID.Text = "SID (EX. 24-12345)"
        End If
    End Sub
    Private Sub regEmail_Click(sender As Object, e As EventArgs) Handles regEmail.Click
        If regEmail.Text = "Email" Then
            regEmail.Text = ""
        End If
    End Sub
    Private Sub regEmail_LostFocus(sender As Object, e As EventArgs) Handles regEmail.LostFocus
        If regEmail.Text = "" Then
            regEmail.Text = "Email"
        End If
    End Sub

    Private Sub regPass_Click(sender As Object, e As EventArgs) Handles regPass.Click
        If regPass.Text = "Password" Then
            regPass.Text = ""
        End If
    End Sub

    Private Sub regPass_LostFocus(sender As Object, e As EventArgs) Handles regPass.LostFocus
        If regPass.Text = "" Then
            regPass.Text = "Password"
        End If
    End Sub

    Private Sub regPass_TextChanged(sender As Object, e As EventArgs) Handles regPass.TextChanged
        If regPass.Text <> "Password" Then
            regPass.PasswordChar = "•"
        Else
            regPass.PasswordChar = ""
        End If
    End Sub

    Private Sub regShowPass_Click(sender As Object, e As EventArgs) Handles regShowPass.Click
        regPass.PasswordChar = ""
        If regPass.Text <> "Password" Then
            regHidePass.Show()
            regShowPass.Hide()
        End If
    End Sub

    Private Sub regHidePass_Click(sender As Object, e As EventArgs) Handles regHidePass.Click
        If regPass.Text <> "Password" Then
            regPass.PasswordChar = "•"
        End If
        regShowPass.Show()
        regHidePass.Hide()
    End Sub

    Private Sub regConfirmPass_Click(sender As Object, e As EventArgs) Handles regConfirmPass.Click
        If regConfirmPass.Text = "Confirm Password" Then
            regConfirmPass.Text = ""
        End If
    End Sub

    Private Sub regConfirmPass_LostFocus(sender As Object, e As EventArgs) Handles regConfirmPass.LostFocus
        If regConfirmPass.Text = "" Then
            regConfirmPass.Text = "Confirm Password"
        End If
    End Sub

    Private Sub regConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles regConfirmPass.TextChanged
        If regConfirmPass.Text <> "Confirm Password" Then
            regConfirmPass.PasswordChar = "•"
        Else
            regConfirmPass.PasswordChar = ""
        End If
    End Sub

    Private Sub regShowConPass_Click(sender As Object, e As EventArgs) Handles regShowConPass.Click
        regConfirmPass.PasswordChar = ""
        If regConfirmPass.Text <> "Confirm Password" Then
            regHideConPass.Show()
            regShowConPass.Hide()
        End If
    End Sub

    Private Sub regHideConPass_Click(sender As Object, e As EventArgs) Handles regHideConPass.Click
        If regConfirmPass.Text <> "Confirm Password" Then
            regConfirmPass.PasswordChar = "•"
        End If
        regShowConPass.Show()
        regHideConPass.Hide()
    End Sub

    Private Sub passMatch(sender As Object, e As EventArgs) Handles regPass.TextChanged, regConfirmPass.TextChanged
        If regPass.Text = regConfirmPass.Text Then
            passMatchIdentifier.ForeColor = Color.Green
            passMatchIdentifier.Text = "PASSWORD MATCHED"
            regBtn.Enabled = True
        Else
            passMatchIdentifier.Text = "PASSWORD UNMATCHED"
            passMatchIdentifier.ForeColor = Color.Red
            regBtn.Enabled = False
        End If
    End Sub

    Private Sub canRegister(sender As Object, e As EventArgs) Handles regPass.TextChanged, regConfirmPass.TextChanged, regFirstName.TextChanged, regLastName.TextChanged, regEmail.TextChanged, regSID.TextChanged
        If regPass.Text = "Password" Or regPass.Text = "" Or regConfirmPass.Text = "Confirm Password" Or regConfirmPass.Text = "" Or regFirstName.Text = "First Name" Or regFirstName.Text = "" Or regLastName.Text = "Last Name" Or regLastName.Text = "" Or regEmail.Text = "Email" Or regEmail.Text = "" Or regSID.Text = "SID (EX. 24-12345)" Or regSID.Text = "" Or passMatchIdentifier.Text = "PASSWORD UNMATCHED" Then
            regBtn.Enabled = False
        Else
            regBtn.Enabled = True
        End If
    End Sub

    Private Sub forgotBtn_Click(sender As Object, e As EventArgs) Handles forgotBtn.Click
        ForgotPassword.Show()
    End Sub
End Class


