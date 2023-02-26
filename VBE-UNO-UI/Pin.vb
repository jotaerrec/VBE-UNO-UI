Imports System.ComponentModel
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
    Public Sub New(nombreDePin As String, numeroDePin As String, tipoDePin As String, modoDePin As String, Optional valorPin As Boolean = Nothing)
        ' Asignamos los valores de los atributos de la clase
        Me.NombreDePin = nombreDePin
        Me.NumeroDePin = numeroDePin
        Me.TipoDePin = tipoDePin
        Me.ModoDePin = modoDePin
        Try
            User.ESP.RegistrarNuevoPin(Me.NumeroDePin, Me.TipoDePin, Me.ModoDePin)
        Catch ex As Exception
            MsgBox("Error al guardar nuevo pin, revisa si estas conectado.")
            Throw New Exception(ex.Message)
            Return
        End Try

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))


        If (Not valorPin = Nothing) Then
            estadoDelPin = False
        End If


        ' Creamos los elementos gráficos de la clase
        Me.PanelPin = New Panel()
        Me.PanelEstadoLed = New Panel()
        Me.LabelNombreDePin = New Label()
        Me.LabelNumeroDePin = New Label()
        Me.LabelEstadoLed = New Label()
        Me.PictureLed = New PictureBox()
        Me.textBoxAnalogico = New TextBox()

        CrearUI()

        If tipoDePin = "Digital" Then
            ConfigurarPictureBoxLed()
        Else
            ConfigurarTextBoxAnalogico()
        End If
    End Sub


    Private Sub CrearUI()

        ' Configuramos el panel del pin
        Me.PanelPin.BackColor = Color.FromArgb(71, 68, 102)
        Me.PanelPin.Size = New Size(130, 36)
        Me.PanelPin.Location = New Point(216, 116)
        Me.PanelPin.TabIndex = 22

        'Me.PanelPin.Controls.Add(Me.PanelEstadoLed)
        Me.PanelPin.Controls.Add(Me.LabelNombreDePin)
        Me.PanelPin.Controls.Add(Me.LabelNumeroDePin)


        ' Configuramos el label del número del pin
        With Me.LabelNumeroDePin
            .Font = New Font("Microsoft Sans Serif", 7.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.FromArgb(192, 192, 255)
            .Location = New Point(3, 0)
            .Size = New Size(45, 15)
            .TabIndex = 1
            .Text = "Pin:" + NumeroDePin
        End With

        ' Configuramos el label del nombre del pin
        With Me.LabelNombreDePin
            .ForeColor = Color.FromArgb(20, 19, 32)
            .Location = New Point(3, 15)
            .Size = New Size(63, 21)
            .TabIndex = 0
            .Text = NombreDePin
            .TextAlign = ContentAlignment.MiddleCenter
        End With

    End Sub

    Private Sub ConfigurarPictureBoxLed()

        Me.PanelPin.Controls.Add(Me.PictureLed)
        ' Configuramos el PictureBox del LED
        With PictureLed
            .BackgroundImageLayout = ImageLayout.Stretch
            .Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_off
            .Location = New Point(81, 2)
            .Name = "PictureLed"
            .Size = New Size(32, 31)
            .SizeMode = PictureBoxSizeMode.Zoom
            .TabIndex = 24
            .TabStop = False
        End With

        If Me.ModoDePin = "Entrada" Then
            Me.PictureLed.Cursor = Cursors.No
        Else
            Me.PictureLed.Cursor = Cursors.Hand
            AddHandler Me.PictureLed.Click, AddressOf CambiarEstado
        End If

    End Sub

    Private Sub ConfigurarTextBoxAnalogico()
        ' Agregar el control textBoxAnalogico al panel PanelPin
        Me.PanelPin.Controls.Add(Me.textBoxAnalogico)
        ' Crear el control textBoxAnalogico
        With Me.textBoxAnalogico
            .BackColor = Color.FromArgb(20, 19, 32)
            .BorderStyle = BorderStyle.None
            .Font = New Font("Microsoft Sans Serif", 13, FontStyle.Regular)
            .ForeColor = SystemColors.Window
            .ImeMode = ImeMode.NoControl
            .Location = New Point(66, 7)
            .MaxLength = 5
            .MinimumSize = New Size(60, 22)
            .Name = "textBoxAnalogico"
            .Size = New Size(60, 22)
            .TabIndex = 2
            .Text = "340"
            .TextAlign = HorizontalAlignment.Center
        End With


        ' Configurar el control textBoxAnalogico según el modo de pin
        If ModoDePin = "Salida" Then
            AddHandler Me.textBoxAnalogico.KeyPress, AddressOf SoloNum
        Else
            Me.textBoxAnalogico.Enabled = False
        End If
    End Sub

    Private Sub CambiarImagen()
        If Me.estadoDelPin Then
            Me.PictureLed.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_prendida
        Else
            Me.PictureLed.Image = Global.VBE_UNO_UI.My.Resources.Resources.lampara_off
        End If
    End Sub

    Private Sub SoloNum(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim data As String = textBoxAnalogico.Text
            User.ESP.Enviar(Me.NumeroDePin, data, "analogico")
        End If
    End Sub

    Private Sub CambiarEstado(sender As Object, e As EventArgs)
        ' Función que se ejecuta al hacer clic en el panel o label del estado del LED
        Try
            estadoDelPin = Not estadoDelPin
            User.ESP.Enviar(NumeroDePin, Me.estadoDelPin, "digital")
            CambiarImagen()
        Catch ex As Exception
            MsgBox(ex.Message())
            User.stateConnect = User.ESP.EstaConectado()
        End Try
    End Sub
    Public Sub CambiarValor(data As String)
        If Me.TipoDePin = "Digital" Then
            Dim boolConvert As Integer = Convert.ToInt16(data)
            Me.estadoDelPin = Convert.ToBoolean(boolConvert)

            Debug.Print("modificando!" & estadoDelPin & ":" & boolConvert)
            CambiarImagen()
        Else
            Me.textBoxAnalogico.Text = data
        End If
    End Sub


End Class