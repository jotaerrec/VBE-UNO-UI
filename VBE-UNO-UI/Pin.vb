Imports System.Windows.Forms.AxHost

Public Class Pin
    ' Atributos de la clase
    Public Property NombreDePin As String
    Public Property NumeroDePin As String
    Public Property TipoDePin As String
    Public Property ModoDePin As String
    Public Property estadoDelPin As Boolean = Nothing

    ' Elementos gráficos de la clase
    Public ReadOnly Property PanelPin As Panel
    Public ReadOnly Property PanelEstadoLed As Panel
    Public ReadOnly Property LabelNombreDePin As Label
    Public ReadOnly Property LabelNumeroDePin As Label
    Public ReadOnly Property LabelEstadoLed As Label
    Public ReadOnly Property PictureLed As PictureBox
    Public ReadOnly Property textBoxAnalogico As TextBox

    ' Constructor de la clase
    Public Sub New(nombreDePin As String, numeroDePin As String, tipoDePin As String, modoDePin As String, Optional estadoDelPin As Boolean = Nothing)

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))

        ' Asignamos los valores de los atributos de la clase
        Me.NombreDePin = nombreDePin
        Me.NumeroDePin = numeroDePin
        Me.TipoDePin = tipoDePin
        Me.ModoDePin = modoDePin

        If (Not estadoDelPin = Nothing) Then
            Me.estadoDelPin = Not estadoDelPin
        End If

        ' Creamos los elementos gráficos de la clase
        Me.PanelPin = New Panel()
        Me.PanelEstadoLed = New Panel()
        Me.LabelNombreDePin = New Label()
        Me.LabelNumeroDePin = New Label()
        Me.LabelEstadoLed = New Label()
        Me.PictureLed = New PictureBox()
        Me.textBoxAnalogico = New TextBox()

        ' Configuramos el panel del pin
        Me.PanelPin.BackColor = Color.FromArgb(71, 68, 102)
        Me.PanelPin.Size = New Size(130, 36)
        Me.PanelPin.Location = New Point(216, 116)
        Me.PanelPin.TabIndex = 22

        'Me.PanelPin.Controls.Add(Me.PanelEstadoLed)
        Me.PanelPin.Controls.Add(Me.LabelNombreDePin)
        Me.PanelPin.Controls.Add(Me.LabelNumeroDePin)
        Me.PanelPin.Controls.Add(Me.PictureLed)
        Me.PanelPin.Controls.Add(Me.textBoxAnalogico)

        'PictureLed

        Me.PictureLed.BackgroundImageLayout = ImageLayout.Stretch
        Me.PictureLed.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_off
        Me.PictureLed.Location = New Point(81, 2)
        Me.PictureLed.Name = "PictureLed"
        Me.PictureLed.Size = New Size(32, 31)
        Me.PictureLed.SizeMode = PictureBoxSizeMode.Zoom
        Me.PictureLed.TabIndex = 24
        Me.PictureLed.TabStop = False


        ' Configuramos el label del número del pin
        Me.LabelNumeroDePin.Font = New Font("Microsoft Sans Serif", 7.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroDePin.ForeColor = Color.FromArgb(192, 192, 255)
        Me.LabelNumeroDePin.Location = New Point(3, 0)
        Me.LabelNumeroDePin.Size = New Size(45, 15)
        Me.LabelNumeroDePin.TabIndex = 1
        Me.LabelNumeroDePin.Text = "Pin:" + numeroDePin

        ' Configuramos el label del nombre del pin
        Me.LabelNombreDePin.ForeColor = Color.FromArgb(20, 19, 32)
        Me.LabelNombreDePin.Location = New Point(3, 15)
        Me.LabelNombreDePin.Size = New Size(63, 21)
        Me.LabelNombreDePin.TabIndex = 0
        Me.LabelNombreDePin.Text = nombreDePin
        Me.LabelNombreDePin.TextAlign = ContentAlignment.MiddleCenter

        If tipoDePin = "Digital" Then

            'PictureLed
            Me.PictureLed.BackgroundImageLayout = ImageLayout.Stretch
            Me.PictureLed.Location = New Point(81, 2)
            Me.PictureLed.Name = "PictureLed"
            Me.PictureLed.Size = New Size(32, 31)
            Me.PictureLed.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureLed.TabIndex = 24
            Me.PictureLed.TabStop = False


            AddHandler Me.PictureLed.Click, AddressOf CambiarEstado
        Else
            '
            'textBoxAnalogico
            '
            Me.textBoxAnalogico.BackColor = Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
            Me.textBoxAnalogico.BorderStyle = BorderStyle.None
            Me.textBoxAnalogico.Font = New Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxAnalogico.ForeColor = SystemColors.Window
            Me.textBoxAnalogico.ImeMode = ImeMode.NoControl
            Me.textBoxAnalogico.Location = New Point(63, 7)
            Me.textBoxAnalogico.MaxLength = 3000
            Me.textBoxAnalogico.MinimumSize = New Size(60, 22)
            Me.textBoxAnalogico.Name = "textBoxAnalogico"
            Me.textBoxAnalogico.Size = New Size(60, 22)
            Me.textBoxAnalogico.TabIndex = 2
            Me.textBoxAnalogico.Text = "340"
            Me.textBoxAnalogico.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    ' Función que se ejecuta al hacer clic en el panel o label del estado del LED
    Private Sub CambiarEstado(sender As Object, e As EventArgs)
        Try
            Me.estadoDelPin = Not Me.estadoDelPin
            User.ESP.Enviar(NumeroDePin, Me.estadoDelPin)
            If Me.estadoDelPin Then
                Me.PictureLed.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_prendida
            Else
                Me.PictureLed.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_off
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
            User.stateConnect = User.ESP.EstaConectado()
        End Try
    End Sub


End Class