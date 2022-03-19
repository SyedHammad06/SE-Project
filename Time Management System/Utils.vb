Imports System.Data.SqlClient

Module Utils
    Public Function ConnectDB() As Array
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Hammad\Documents\Visual Studio 2012\Projects\Time Management System\Time Management System\Database.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        Return {con, cmd}
    End Function

    ' Login
    Public Function Login(username As String, password As String) As Array
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

    Public Function Signup(username As String, email As String, password As String, confirmPassword As String) As Array
        If password = confirmPassword Then
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

                Return {True, True, "Sign up successfull!"}
                ' Redirect to a new page
            End If
        Else
            Return {False, "Passwords don't match"}
        End If
    End Function
End Module
