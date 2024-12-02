<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Signup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSignUp
        '
        Me.lblSignUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.ForeColor = System.Drawing.Color.Red
        Me.lblSignUp.Location = New System.Drawing.Point(43, 19)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(62, 15)
        Me.lblSignUp.TabIndex = 0
        Me.lblSignUp.Text = "SIGN UP"
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblFullName.Location = New System.Drawing.Point(131, 87)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(71, 15)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Fullname:"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblEmail.Location = New System.Drawing.Point(131, 156)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 15)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblUsername.Location = New System.Drawing.Point(131, 219)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 15)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblPassword.Location = New System.Drawing.Point(131, 280)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(123, 15)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Create Password:"
        '
        'lblConfirm
        '
        Me.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblConfirm.Location = New System.Drawing.Point(131, 348)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(130, 15)
        Me.lblConfirm.TabIndex = 5
        Me.lblConfirm.Text = "Confirm Password:"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(465, 378)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(86, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Password Status"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPassword.ForeColor = System.Drawing.Color.SpringGreen
        Me.chkShowPassword.Location = New System.Drawing.Point(275, 378)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 7
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'btnSignup
        '
        Me.btnSignup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSignup.BackColor = System.Drawing.Color.Teal
        Me.btnSignup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Location = New System.Drawing.Point(286, 445)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(111, 42)
        Me.btnSignup.TabIndex = 8
        Me.btnSignup.Text = "Sign up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUsername.Location = New System.Drawing.Point(275, 215)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(276, 20)
        Me.txtUsername.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPassword.Location = New System.Drawing.Point(275, 276)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(276, 20)
        Me.txtPassword.TabIndex = 10
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtConfirmPassword.Location = New System.Drawing.Point(275, 344)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(276, 20)
        Me.txtConfirmPassword.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEmail.Location = New System.Drawing.Point(275, 152)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(276, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtFullname
        '
        Me.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFullname.Location = New System.Drawing.Point(275, 83)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(276, 20)
        Me.txtFullname.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(615, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 37)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'UC_Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = Global.Account.My.Resources.Resources.triangle_light_dark_shape_88545_1920x1080
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblSignUp)
        Me.Name = "UC_Signup"
        Me.Size = New System.Drawing.Size(654, 514)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents btnClose As Button
End Class
