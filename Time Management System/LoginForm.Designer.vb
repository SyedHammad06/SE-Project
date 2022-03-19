<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameField = New System.Windows.Forms.TextBox()
        Me.PasswordField = New System.Windows.Forms.TextBox()
        Me.LoginSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Username2Field = New System.Windows.Forms.TextBox()
        Me.EmailField = New System.Windows.Forms.TextBox()
        Me.Password2Field = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordField = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SignupSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(116, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(488, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sign up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'UsernameField
        '
        Me.UsernameField.BackColor = System.Drawing.Color.LavenderBlush
        Me.UsernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameField.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameField.Location = New System.Drawing.Point(108, 189)
        Me.UsernameField.Name = "UsernameField"
        Me.UsernameField.Size = New System.Drawing.Size(188, 27)
        Me.UsernameField.TabIndex = 4
        '
        'PasswordField
        '
        Me.PasswordField.BackColor = System.Drawing.Color.LavenderBlush
        Me.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordField.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordField.Location = New System.Drawing.Point(108, 242)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordField.Size = New System.Drawing.Size(188, 27)
        Me.PasswordField.TabIndex = 5
        '
        'LoginSubmit
        '
        Me.LoginSubmit.BackColor = System.Drawing.Color.LightPink
        Me.LoginSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoginSubmit.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginSubmit.Location = New System.Drawing.Point(108, 350)
        Me.LoginSubmit.Name = "LoginSubmit"
        Me.LoginSubmit.Size = New System.Drawing.Size(134, 34)
        Me.LoginSubmit.TabIndex = 6
        Me.LoginSubmit.Text = "Submit"
        Me.LoginSubmit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email"
        '
        'Username2Field
        '
        Me.Username2Field.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Username2Field.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username2Field.Location = New System.Drawing.Point(510, 154)
        Me.Username2Field.Name = "Username2Field"
        Me.Username2Field.Size = New System.Drawing.Size(197, 27)
        Me.Username2Field.TabIndex = 9
        '
        'EmailField
        '
        Me.EmailField.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EmailField.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailField.Location = New System.Drawing.Point(510, 194)
        Me.EmailField.Name = "EmailField"
        Me.EmailField.Size = New System.Drawing.Size(197, 27)
        Me.EmailField.TabIndex = 10
        '
        'Password2Field
        '
        Me.Password2Field.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Password2Field.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2Field.Location = New System.Drawing.Point(510, 239)
        Me.Password2Field.Name = "Password2Field"
        Me.Password2Field.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password2Field.Size = New System.Drawing.Size(197, 27)
        Me.Password2Field.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(424, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Password"
        '
        'ConfirmPasswordField
        '
        Me.ConfirmPasswordField.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ConfirmPasswordField.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordField.Location = New System.Drawing.Point(510, 284)
        Me.ConfirmPasswordField.Name = "ConfirmPasswordField"
        Me.ConfirmPasswordField.Size = New System.Drawing.Size(197, 27)
        Me.ConfirmPasswordField.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(424, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 38)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Confirm Password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SignupSubmit
        '
        Me.SignupSubmit.BackColor = System.Drawing.Color.PowderBlue
        Me.SignupSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignupSubmit.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupSubmit.Location = New System.Drawing.Point(495, 350)
        Me.SignupSubmit.Name = "SignupSubmit"
        Me.SignupSubmit.Size = New System.Drawing.Size(121, 34)
        Me.SignupSubmit.TabIndex = 16
        Me.SignupSubmit.Text = "Submit"
        Me.SignupSubmit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(729, 487)
        Me.Controls.Add(Me.SignupSubmit)
        Me.Controls.Add(Me.ConfirmPasswordField)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Password2Field)
        Me.Controls.Add(Me.EmailField)
        Me.Controls.Add(Me.Username2Field)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LoginSubmit)
        Me.Controls.Add(Me.PasswordField)
        Me.Controls.Add(Me.UsernameField)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Name = "Form1"
        Me.Text = "Time Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UsernameField As System.Windows.Forms.TextBox
    Friend WithEvents PasswordField As System.Windows.Forms.TextBox
    Friend WithEvents LoginSubmit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Username2Field As System.Windows.Forms.TextBox
    Friend WithEvents EmailField As System.Windows.Forms.TextBox
    Friend WithEvents Password2Field As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPasswordField As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SignupSubmit As System.Windows.Forms.Button

End Class
