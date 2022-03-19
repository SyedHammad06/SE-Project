Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameField.Text = ""
        PasswordField.Text = ""
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim con = ConnectDB()(0)
    '    Dim cmd = ConnectDB()(1)
    '    Dim dataReader As SqlDataReader
    '    Dim results
    '
    '   cmd.CommandText = "select * from users"
    '  dataReader = cmd.ExecuteReader()
    '
    '   Do While dataReader.Read()
    '      results = results & dataReader.GetString(0) & vbTab & _
    '     dataReader.GetString(1) & vbLf
    '   Loop
    '
    '   If TextBox1.Text = "Admin" And TextBox2.Text = "Admin" Then
    '      MessageBox.Show("Login succesfull")
    '     MsgBox(results)
    '   End If
    '
    '   con.Close()
    'End Sub

    Private Sub LoginSubmit_Click(sender As Object, e As EventArgs) Handles LoginSubmit.Click
        Dim username = UsernameField.Text
        Dim password = PasswordField.Text

        Dim status = Login(username, password)(0)
        Dim output = Login(username, password)(1)

        If (status = False) Then
            MessageBox.Show(output, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show(output, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Redirect to a new page
        End If
    End Sub

    Private Sub SignupSubmit_Click_1(sender As Object, e As EventArgs) Handles SignupSubmit.Click
        Dim username = Username2Field.Text
        Dim email = EmailField.Text
        Dim password = Password2Field.Text
        Dim confirmPassword = ConfirmPasswordField.Text

        Dim status = Signup(username, email, password, confirmPassword)(0)
        Dim output = Signup(username, email, password, confirmPassword)(1)

        If (status = True) Then
            MessageBox.Show(output, "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(output, "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
