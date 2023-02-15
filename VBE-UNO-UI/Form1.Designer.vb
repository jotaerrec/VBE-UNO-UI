<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
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
        Me.PanelError = New System.Windows.Forms.Panel()
        Me.TextError = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelStateEsp.SuspendLayout()
        Me.PanelStateLed.SuspendLayout()
        Me.PanelError.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMain
        '
        Me.LabelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelMain.AutoSize = True
        Me.LabelMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMain.ForeColor = System.Drawing.Color.White
        Me.LabelMain.Location = New System.Drawing.Point(228, 9)
        Me.LabelMain.Name = "LabelMain"
        Me.LabelMain.Size = New System.Drawing.Size(110, 21)
        Me.LabelMain.TabIndex = 0
        Me.LabelMain.Text = "VBE-UNO-ESP"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese IP"
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIP.ForeColor = System.Drawing.Color.White
        Me.TextBoxIP.Location = New System.Drawing.Point(53, 71)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxIP.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(377, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado de conexion:"
        '
        'PanelStateEsp
        '
        Me.PanelStateEsp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelStateEsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelStateEsp.Controls.Add(Me.stateEspText)
        Me.PanelStateEsp.Location = New System.Drawing.Point(380, 70)
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
        Me.TextBoxLed.Location = New System.Drawing.Point(53, 132)
        Me.TextBoxLed.Name = "TextBoxLed"
        Me.TextBoxLed.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxLed.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(50, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pin de led a utilizar"
        '
        'stateLedText
        '
        Me.stateLedText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stateLedText.BackColor = System.Drawing.Color.Transparent
        Me.stateLedText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stateLedText.ForeColor = System.Drawing.Color.White
        Me.stateLedText.Location = New System.Drawing.Point(25, 1)
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
        Me.PanelStateLed.Location = New System.Drawing.Point(380, 131)
        Me.PanelStateLed.Name = "PanelStateLed"
        Me.PanelStateLed.Size = New System.Drawing.Size(133, 20)
        Me.PanelStateLed.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(377, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Estado de Led:"
        '
        'btnIp
        '
        Me.btnIp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIp.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnIp.FlatAppearance.BorderSize = 0
        Me.btnIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIp.Location = New System.Drawing.Point(156, 70)
        Me.btnIp.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIp.Name = "btnIp"
        Me.btnIp.Size = New System.Drawing.Size(33, 20)
        Me.btnIp.TabIndex = 9
        Me.btnIp.Text = "OK"
        Me.btnIp.UseVisualStyleBackColor = True
        '
        'btnLed
        '
        Me.btnLed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLed.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnLed.FlatAppearance.BorderSize = 0
        Me.btnLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLed.Location = New System.Drawing.Point(156, 131)
        Me.btnLed.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLed.Name = "btnLed"
        Me.btnLed.Size = New System.Drawing.Size(33, 20)
        Me.btnLed.TabIndex = 10
        Me.btnLed.Text = "OK"
        Me.btnLed.UseVisualStyleBackColor = True
        '
        'PanelError
        '
        Me.PanelError.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelError.Controls.Add(Me.TextError)
        Me.PanelError.Controls.Add(Me.Button1)
        Me.PanelError.Location = New System.Drawing.Point(166, 223)
        Me.PanelError.Name = "PanelError"
        Me.PanelError.Size = New System.Drawing.Size(265, 177)
        Me.PanelError.TabIndex = 11
        Me.PanelError.Visible = False
        '
        'TextError
        '
        Me.TextError.Location = New System.Drawing.Point(15, 8)
        Me.TextError.Name = "TextError"
        Me.TextError.Size = New System.Drawing.Size(228, 145)
        Me.TextError.TabIndex = 0
        Me.TextError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.PanelError)
        Me.Controls.Add(Me.btnLed)
        Me.Controls.Add(Me.btnIp)
        Me.Controls.Add(Me.PanelStateLed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxLed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelStateEsp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelMain)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelStateEsp.ResumeLayout(False)
        Me.PanelStateLed.ResumeLayout(False)
        Me.PanelError.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMain As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxIP As TextBox
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
    Friend WithEvents PanelError As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextError As Label
End Class
