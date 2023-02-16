<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.LabelMain = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelStateEsp = New System.Windows.Forms.Panel()
        Me.stateEspText = New System.Windows.Forms.Label()
        Me.TextBoxLed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stateLedText = New System.Windows.Forms.Label()
        Me.PanelStateLed = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIp = New System.Windows.Forms.Button()
        Me.btnLed = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureAdminBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelStateEsp.SuspendLayout()
        Me.PanelStateLed.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMain
        '
        Me.LabelMain.AutoSize = True
        Me.LabelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMain.ForeColor = System.Drawing.Color.White
        Me.LabelMain.Location = New System.Drawing.Point(241, 12)
        Me.LabelMain.Name = "LabelMain"
        Me.LabelMain.Size = New System.Drawing.Size(117, 21)
        Me.LabelMain.TabIndex = 0
        Me.LabelMain.Text = "VBE-UNO-ESP"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(50, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado de conexion:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelStateEsp
        '
        Me.PanelStateEsp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStateEsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelStateEsp.Controls.Add(Me.stateEspText)
        Me.PanelStateEsp.Location = New System.Drawing.Point(50, 111)
        Me.PanelStateEsp.Name = "PanelStateEsp"
        Me.PanelStateEsp.Size = New System.Drawing.Size(133, 20)
        Me.PanelStateEsp.TabIndex = 4
        '
        'stateEspText
        '
        Me.stateEspText.BackColor = System.Drawing.Color.Transparent
        Me.stateEspText.Cursor = System.Windows.Forms.Cursors.No
        Me.stateEspText.ForeColor = System.Drawing.Color.White
        Me.stateEspText.Location = New System.Drawing.Point(25, 1)
        Me.stateEspText.Name = "stateEspText"
        Me.stateEspText.Size = New System.Drawing.Size(78, 17)
        Me.stateEspText.TabIndex = 0
        Me.stateEspText.Text = "Disconnect"
        Me.stateEspText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxLed
        '
        Me.TextBoxLed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxLed.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxLed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLed.ForeColor = System.Drawing.Color.White
        Me.TextBoxLed.Location = New System.Drawing.Point(397, 111)
        Me.TextBoxLed.Name = "TextBoxLed"
        Me.TextBoxLed.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxLed.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(397, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agregar Pin"
        '
        'stateLedText
        '
        Me.stateLedText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stateLedText.BackColor = System.Drawing.Color.Transparent
        Me.stateLedText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stateLedText.ForeColor = System.Drawing.Color.White
        Me.stateLedText.Location = New System.Drawing.Point(22, 2)
        Me.stateLedText.Name = "stateLedText"
        Me.stateLedText.Size = New System.Drawing.Size(78, 15)
        Me.stateLedText.TabIndex = 0
        Me.stateLedText.Text = "Disconnect"
        Me.stateLedText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelStateLed
        '
        Me.PanelStateLed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStateLed.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelStateLed.Controls.Add(Me.stateLedText)
        Me.PanelStateLed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelStateLed.Location = New System.Drawing.Point(397, 170)
        Me.PanelStateLed.Name = "PanelStateLed"
        Me.PanelStateLed.Size = New System.Drawing.Size(133, 20)
        Me.PanelStateLed.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(397, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Estado de Led:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnIp
        '
        Me.btnIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIp.Cursor = System.Windows.Forms.Cursors.No
        Me.btnIp.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnIp.Enabled = False
        Me.btnIp.FlatAppearance.BorderSize = 0
        Me.btnIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIp.Location = New System.Drawing.Point(78, 170)
        Me.btnIp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIp.Name = "btnIp"
        Me.btnIp.Size = New System.Drawing.Size(80, 20)
        Me.btnIp.TabIndex = 9
        Me.btnIp.Text = "Conectar"
        Me.btnIp.UseVisualStyleBackColor = True
        '
        'btnLed
        '
        Me.btnLed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLed.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnLed.FlatAppearance.BorderSize = 0
        Me.btnLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLed.Location = New System.Drawing.Point(500, 110)
        Me.btnLed.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLed.Name = "btnLed"
        Me.btnLed.Size = New System.Drawing.Size(33, 20)
        Me.btnLed.TabIndex = 10
        Me.btnLed.Text = "OK"
        Me.btnLed.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
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
        Me.PictureAdminBox.TabIndex = 12
        Me.PictureAdminBox.TabStop = False
        Me.PictureAdminBox.Tag = "Admin"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(78, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ESP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.PictureAdminBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLed)
        Me.Controls.Add(Me.btnIp)
        Me.Controls.Add(Me.PanelStateLed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxLed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelStateEsp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelMain)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.PanelStateEsp.ResumeLayout(False)
        Me.PanelStateLed.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMain As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelStateEsp As Panel
    Friend WithEvents stateEspText As Label
    Friend WithEvents TextBoxLed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents stateLedText As Label
    Friend WithEvents PanelStateLed As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnIp As Button
    Friend WithEvents btnLed As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureAdminBox As PictureBox
    Friend WithEvents Label1 As Label
End Class
