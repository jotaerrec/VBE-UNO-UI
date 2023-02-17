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
        Me.txtNumeroPin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureAdminBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombrePin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLed = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.boxTipoPin = New System.Windows.Forms.ComboBox()
        Me.boxModoPin = New System.Windows.Forms.ComboBox()
        Me.panelPin = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelPines = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelStateEsp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(306, 220)
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
        Me.PanelStateEsp.Location = New System.Drawing.Point(306, 240)
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
        'txtNumeroPin
        '
        Me.txtNumeroPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNumeroPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPin.ForeColor = System.Drawing.Color.White
        Me.txtNumeroPin.Location = New System.Drawing.Point(172, 145)
        Me.txtNumeroPin.Name = "txtNumeroPin"
        Me.txtNumeroPin.Size = New System.Drawing.Size(100, 19)
        Me.txtNumeroPin.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(241, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agregar Pin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnIp
        '
        Me.btnIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIp.Cursor = System.Windows.Forms.Cursors.No
        Me.btnIp.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnIp.Enabled = False
        Me.btnIp.FlatAppearance.BorderSize = 0
        Me.btnIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIp.Location = New System.Drawing.Point(195, 241)
        Me.btnIp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIp.Name = "btnIp"
        Me.btnIp.Size = New System.Drawing.Size(80, 20)
        Me.btnIp.TabIndex = 9
        Me.btnIp.Text = "Conectar"
        Me.btnIp.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(192, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ESP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Location = New System.Drawing.Point(172, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Numero de pin"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(35, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nombre de pin"
        '
        'txtNombrePin
        '
        Me.txtNombrePin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNombrePin.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtNombrePin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePin.ForeColor = System.Drawing.Color.White
        Me.txtNombrePin.Location = New System.Drawing.Point(35, 145)
        Me.txtNombrePin.MaxLength = 30
        Me.txtNombrePin.Name = "txtNombrePin"
        Me.txtNombrePin.Size = New System.Drawing.Size(100, 19)
        Me.txtNombrePin.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label7.Location = New System.Drawing.Point(309, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tipo de pin"
        '
        'btnLed
        '
        Me.btnLed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLed.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnLed.FlatAppearance.BorderSize = 0
        Me.btnLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLed.Location = New System.Drawing.Point(245, 185)
        Me.btnLed.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLed.Name = "btnLed"
        Me.btnLed.Size = New System.Drawing.Size(100, 20)
        Me.btnLed.TabIndex = 10
        Me.btnLed.Text = "Guardar"
        Me.btnLed.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label8.Location = New System.Drawing.Point(446, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Modo de pin"
        '
        'boxTipoPin
        '
        Me.boxTipoPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.boxTipoPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.boxTipoPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxTipoPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxTipoPin.ForeColor = System.Drawing.Color.White
        Me.boxTipoPin.FormattingEnabled = True
        Me.boxTipoPin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.boxTipoPin.Location = New System.Drawing.Point(309, 140)
        Me.boxTipoPin.Name = "boxTipoPin"
        Me.boxTipoPin.Size = New System.Drawing.Size(100, 24)
        Me.boxTipoPin.TabIndex = 20
        '
        'boxModoPin
        '
        Me.boxModoPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.boxModoPin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxModoPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxModoPin.ForeColor = System.Drawing.Color.White
        Me.boxModoPin.FormattingEnabled = True
        Me.boxModoPin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.boxModoPin.Location = New System.Drawing.Point(446, 140)
        Me.boxModoPin.Name = "boxModoPin"
        Me.boxModoPin.Size = New System.Drawing.Size(100, 24)
        Me.boxModoPin.TabIndex = 21
        '
        'panelPin
        '
        Me.panelPin.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.panelPin.Controls.Add(Me.PictureBox2)
        Me.panelPin.Controls.Add(Me.Label10)
        Me.panelPin.Controls.Add(Me.Label9)
        Me.panelPin.Location = New System.Drawing.Point(397, 181)
        Me.panelPin.Name = "panelPin"
        Me.panelPin.Size = New System.Drawing.Size(126, 36)
        Me.panelPin.TabIndex = 22
        Me.panelPin.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_off
        Me.PictureBox2.Location = New System.Drawing.Point(81, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Pin:11"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Luz 1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanelPines
        '
        Me.FlowLayoutPanelPines.AutoScroll = True
        Me.FlowLayoutPanelPines.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelPines.Location = New System.Drawing.Point(37, 283)
        Me.FlowLayoutPanelPines.Name = "FlowLayoutPanelPines"
        Me.FlowLayoutPanelPines.Size = New System.Drawing.Size(511, 166)
        Me.FlowLayoutPanelPines.TabIndex = 23
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.FlowLayoutPanelPines)
        Me.Controls.Add(Me.panelPin)
        Me.Controls.Add(Me.boxModoPin)
        Me.Controls.Add(Me.boxTipoPin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombrePin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureAdminBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLed)
        Me.Controls.Add(Me.btnIp)
        Me.Controls.Add(Me.txtNumeroPin)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAdminBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPin.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMain As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelStateEsp As Panel
    Friend WithEvents stateEspText As Label
    Friend WithEvents txtNumeroPin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureAdminBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombrePin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLed As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents boxTipoPin As ComboBox
    Friend WithEvents boxModoPin As ComboBox
    Friend WithEvents panelPin As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowLayoutPanelPines As FlowLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
End Class
