<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.PictureAdminBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelMain = New System.Windows.Forms.Label()
        Me.btnIp = New System.Windows.Forms.Button()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PictureAdminBox.TabIndex = 17
        Me.PictureAdminBox.TabStop = False
        Me.PictureAdminBox.Tag = "Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'LabelMain
        '
        Me.LabelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMain.ForeColor = System.Drawing.Color.White
        Me.LabelMain.Location = New System.Drawing.Point(241, 12)
        Me.LabelMain.Name = "LabelMain"
        Me.LabelMain.Size = New System.Drawing.Size(118, 21)
        Me.LabelMain.TabIndex = 15
        Me.LabelMain.Text = "Admin"
        Me.LabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIp
        '
        Me.btnIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIp.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnIp.FlatAppearance.BorderSize = 0
        Me.btnIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIp.Location = New System.Drawing.Point(260, 160)
        Me.btnIp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIp.Name = "btnIp"
        Me.btnIp.Size = New System.Drawing.Size(80, 20)
        Me.btnIp.TabIndex = 20
        Me.btnIp.Text = "Guardar"
        Me.btnIp.UseVisualStyleBackColor = True
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIP.ForeColor = System.Drawing.Color.White
        Me.TextBoxIP.Location = New System.Drawing.Point(200, 98)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxIP.Size = New System.Drawing.Size(200, 19)
        Me.TextBoxIP.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(200, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ingrese IP"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(200, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Para que se efectuen los cambios debe reiniciar la aplicacion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIp)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureAdminBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelMain)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureAdminBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelMain As Label
    Friend WithEvents btnIp As Button
    Friend WithEvents TextBoxIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
