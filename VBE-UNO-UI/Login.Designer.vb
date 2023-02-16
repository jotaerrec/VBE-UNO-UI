<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelMain = New System.Windows.Forms.Label()
        Me.PictureAdminBox = New System.Windows.Forms.PictureBox()
        Me.adminBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.registerLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'LabelMain
        '
        Me.LabelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMain.ForeColor = System.Drawing.Color.White
        Me.LabelMain.Location = New System.Drawing.Point(241, 12)
        Me.LabelMain.Name = "LabelMain"
        Me.LabelMain.Size = New System.Drawing.Size(117, 21)
        Me.LabelMain.TabIndex = 12
        Me.LabelMain.Text = "INGRESO"
        Me.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureAdminBox
        '
        Me.PictureAdminBox.AccessibleName = "Admin"
        Me.PictureAdminBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.PictureAdminBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureAdminBox.Image = CType(resources.GetObject("PictureAdminBox.Image"), System.Drawing.Image)
        Me.PictureAdminBox.Location = New System.Drawing.Point(487, 12)
        Me.PictureAdminBox.Name = "PictureAdminBox"
        Me.PictureAdminBox.Size = New System.Drawing.Size(46, 34)
        Me.PictureAdminBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureAdminBox.TabIndex = 14
        Me.PictureAdminBox.TabStop = False
        Me.PictureAdminBox.Tag = "Admin"
        '
        'adminBox
        '
        Me.adminBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.adminBox.Location = New System.Drawing.Point(206, 105)
        Me.adminBox.MaxLength = 20
        Me.adminBox.Name = "adminBox"
        Me.adminBox.Size = New System.Drawing.Size(200, 20)
        Me.adminBox.TabIndex = 15
        Me.adminBox.Text = "Admin..."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(242, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(242, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passBox
        '
        Me.passBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.passBox.Location = New System.Drawing.Point(206, 170)
        Me.passBox.MaxLength = 20
        Me.passBox.Name = "passBox"
        Me.passBox.Size = New System.Drawing.Size(200, 20)
        Me.passBox.TabIndex = 17
        Me.passBox.Text = "Password..."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 26)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'registerLbl
        '
        Me.registerLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.registerLbl.Location = New System.Drawing.Point(203, 274)
        Me.registerLbl.Name = "registerLbl"
        Me.registerLbl.Size = New System.Drawing.Size(200, 20)
        Me.registerLbl.TabIndex = 21
        Me.registerLbl.Text = "Todavia no te registraste, registrate!"
        Me.registerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.registerLbl.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.registerLbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminBox)
        Me.Controls.Add(Me.PictureAdminBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelMain)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelMain As Label
    Friend WithEvents PictureAdminBox As PictureBox
    Friend WithEvents adminBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents passBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents registerLbl As Label
End Class
