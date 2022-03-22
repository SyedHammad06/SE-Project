Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module Utils
    Public Function ConnectDB() As Array
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Suleman\GitHub\SE-Project\Time Management System\Database.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        Return {con, cmd}
    End Function

    ' Login
    Public Function Login(username As String, password As String) As Array
        If (IsEmpty(username) And IsEmpty(password)) Then
            Return {False, "Please provide an input"}
        End If

        If (IsPasswordValid(password) = False) Then
            Return {False, "Password too short and it doesn't contain a number and an alphabet"}
        End If

        Dim con = ConnectDB()(0)
        Dim cmd = ConnectDB()(1)

        cmd.CommandText = "select * from users where username=@username and password=@password"

        Dim paramUsername As New SqlParameter("@username", SqlDbType.VarChar, 25)
        paramUsername.Value = username

        Dim paramPassword As New SqlParameter("@password", SqlDbType.VarChar, 50)
        paramPassword.Value = password

        cmd.Parameters.Add(paramUsername)
        cmd.Parameters.Add(paramPassword)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        If (table.Rows.Count() <= 0) Then
            Return {False, "Invalid Credentials!"}
        Else
            Return {True, "Login Successfull!"}
        End If
    End Function

    'Signup
    Public Function Signup(username As String, email As String, password As String, confirmPassword As String) As Array
        If (IsEmpty(username) And IsEmpty(password) And IsEmpty(email) And IsEmpty(confirmPassword)) Then
            Return {False, "Please provide an input"}
        End If

        If (IsEmailValid(email) = False) Then
            Return {False, "Invalid Email!"}
        End If

        If (IsPasswordValid(password) = False) Then
            Return {False, "Password too short and it doesn't contain a number and an alphabet"}
        End If

        If (password = confirmPassword) Then
            Dim con = ConnectDB()(0)
            Dim cmd = ConnectDB()(1)

            Dim da As New SqlDataAdapter

            cmd.CommandText = "select * from users where username=@username"

            Dim paramUsername As New SqlParameter("@username", SqlDbType.VarChar, 25)
            paramUsername.Value = username

            cmd.Parameters.Add(paramUsername)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            If (table.Rows.Count() > 0) Then
                Return {False, "User already present!"}
            Else
                cmd.CommandText = "insert into users(username, email, password) values(@user, @email, @password)"

                Dim param2Username As New SqlParameter("@user", SqlDbType.VarChar, 25)
                param2Username.Value = username

                Dim param2Password As New SqlParameter("@password", SqlDbType.VarChar, 50)
                param2Password.Value = password

                Dim param2Email As New SqlParameter("@email", SqlDbType.VarChar, 50)
                param2Email.Value = email

                cmd.Parameters.Add(param2Username)
                cmd.Parameters.Add(param2Password)
                cmd.Parameters.Add(param2Email)

                da.InsertCommand = cmd
                Dim result = da.InsertCommand.ExecuteNonQuery()

                Return {True, "Sign up successfull!"}
                ' Redirect to a new page
            End If
        Else
            Return {False, "Passwords don't match"}
        End If
    End Function

    'Function to check if the value is not empty'
    Public Function IsEmpty(ByVal field As String) As Boolean
        If (field = "") Then
            Return True
        End If
        Return False
    End Function

    'Function to check if phone number is valid'
    Public Function IsPasswordValid(ByVal password As String) As Boolean
        Dim PasswordValid As Boolean
        Dim PasswordNumber As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
        Dim ChekPassword As New Regex(PasswordNumber)
        If Not String.IsNullOrEmpty(password) Then
            PasswordValid = ChekPassword.IsMatch(password)
        Else
            PasswordValid = False
        End If
        Return PasswordValid
    End Function

    'Function to check if email is valid'
    Public Function IsEmailValid(ByVal email As String) As Boolean
        Dim emailExpression As New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Return emailExpression.IsMatch(email)
    End Function
End Module
