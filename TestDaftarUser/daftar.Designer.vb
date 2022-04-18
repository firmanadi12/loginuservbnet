<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar
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
        Me.namaTBX = New System.Windows.Forms.TextBox()
        Me.emailTBX = New System.Windows.Forms.TextBox()
        Me.PasswordTBX = New System.Windows.Forms.TextBox()
        Me.usernameTBX = New System.Windows.Forms.TextBox()
        Me.tlpTBX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'namaTBX
        '
        Me.namaTBX.Location = New System.Drawing.Point(102, 85)
        Me.namaTBX.Name = "namaTBX"
        Me.namaTBX.Size = New System.Drawing.Size(150, 20)
        Me.namaTBX.TabIndex = 0
        '
        'emailTBX
        '
        Me.emailTBX.Location = New System.Drawing.Point(102, 145)
        Me.emailTBX.Name = "emailTBX"
        Me.emailTBX.Size = New System.Drawing.Size(151, 20)
        Me.emailTBX.TabIndex = 1
        '
        'PasswordTBX
        '
        Me.PasswordTBX.Location = New System.Drawing.Point(359, 145)
        Me.PasswordTBX.Name = "PasswordTBX"
        Me.PasswordTBX.Size = New System.Drawing.Size(158, 20)
        Me.PasswordTBX.TabIndex = 2
        '
        'usernameTBX
        '
        Me.usernameTBX.Location = New System.Drawing.Point(359, 85)
        Me.usernameTBX.Name = "usernameTBX"
        Me.usernameTBX.Size = New System.Drawing.Size(158, 20)
        Me.usernameTBX.TabIndex = 3
        '
        'tlpTBX
        '
        Me.tlpTBX.Location = New System.Drawing.Point(101, 210)
        Me.tlpTBX.Name = "tlpTBX"
        Me.tlpTBX.Size = New System.Drawing.Size(151, 20)
        Me.tlpTBX.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "No Tlp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Daftar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 533)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tlpTBX)
        Me.Controls.Add(Me.usernameTBX)
        Me.Controls.Add(Me.PasswordTBX)
        Me.Controls.Add(Me.emailTBX)
        Me.Controls.Add(Me.namaTBX)
        Me.Name = "daftar"
        Me.Text = "Daftar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaTBX As TextBox
    Friend WithEvents emailTBX As TextBox
    Friend WithEvents PasswordTBX As TextBox
    Friend WithEvents usernameTBX As TextBox
    Friend WithEvents tlpTBX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
