Imports System.IO
Imports System.Net.Sockets

Public Class User
    Public Shared Property ESP As EspClass = New EspClass()

    Public Shared Property listaDePines As New List(Of Pin)
    Public IP As String = Nothing
    Public stateConnect As Boolean = False
    Public stateLed As Boolean = False

    Dim rutaDocumentos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Dim rutaEleconar As String = rutaDocumentos & "\Eleconar"
    Dim rutaArchivo As String = rutaEleconar & "\config.txt"
    Dim valores() As String = {"0", "1", "2", "3", "4", "5", "12", "13", "14", "15", "16", "A0"}


    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerArchivo()
        boxTipoPin.Items.Add("Analogico")
        boxTipoPin.Items.Add("Digital")
        boxModoPin.Items.Add("Entrada")
        boxModoPin.Items.Add("Salida")
    End Sub

    Private Sub Conectarse(sender As Object, e As EventArgs) Handles btnIp.Click
        'Validaciones
        If IP = Nothing Then
            ShowError("Tiene que acceder al panel de administrador y configurar una ip." + IP)
            Return
        End If

        'Conectar al esp
        Try
            ESP.Conectar(IP:=IP)
            CambiarPanel(PanelStateEsp, stateConnect, stateEspText)
            stateConnect = True
        Catch ex As Exception
            ShowError(ex.Message())
            stateConnect = ESP.EstaConectado()
        End Try

    End Sub

    Private Sub AgregarPin(sender As Object, e As EventArgs) Handles btnLed.Click
        'Validaciones
        If txtNombrePin.Text = "" Or txtNumeroPin.Text = "" Or boxModoPin.Text = "" Or boxTipoPin.Text = "" Then
            ShowError("Complete el formulario.")
            Return
        End If
        Dim nombreDePin As String = txtNombrePin.Text
        Dim numeroDePin As String = txtNumeroPin.Text
        Dim tipoDePin As String = boxTipoPin.Text
        Dim modoDePin As String = boxModoPin.Text
        Dim nuevoPin As Pin

        If Not valores.Contains(numeroDePin) Then
            MsgBox("Ingresa un pin valido.")
            Return
        End If


        If (listaDePines.Any(Function(p) p.NumeroDePin = numeroDePin)) Then
            MsgBox("Este pin ya esta en uso.")
            Return
        End If
        Try
            nuevoPin = New Pin(nombreDePin, numeroDePin, tipoDePin, modoDePin)
            listaDePines.Add(nuevoPin)
            FlowLayoutPanelPines.Controls.Add(nuevoPin.PanelPin)
        Catch ex As Exception
            nuevoPin = Nothing
        End Try
    End Sub


    Private Sub TextBoxLed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroPin.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "A" AndAlso Not e.KeyChar = "a" AndAlso Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True ' Cancela el evento KeyPress si el carácter presionado no es numérico ni es la letra A.
        End If
    End Sub


    Public Sub ShowError(ex As String)
        If ex = "" Then
            Return
        End If
        MsgBox(ex, 0)
    End Sub

    Private Sub LoginForm(sender As Object, e As EventArgs) Handles PictureAdminBox.Click
        Dim form As New Login()
        form.Show()
    End Sub

    Private Sub LeerArchivo()
        If Not My.Computer.FileSystem.DirectoryExists(rutaEleconar) Then
            My.Computer.FileSystem.CreateDirectory(rutaEleconar)
        End If

        If File.Exists(rutaArchivo) Then
            ' Lee el contenido del archivo
            Dim contenidoArchivo As String = File.ReadAllText(rutaArchivo)

            ' Busca la cadena "IP=" y extrae la dirección IP
            Dim indiceInicio As Integer = contenidoArchivo.IndexOf("IP=") + 3
            Dim indiceFin As Integer = contenidoArchivo.IndexOf(Environment.NewLine)

            If indiceInicio >= 0 AndAlso indiceFin > indiceInicio Then
                IP = contenidoArchivo.Substring(indiceInicio, indiceFin - indiceInicio)
            End If
            btnIp.Cursor = Cursors.Hand
            btnIp.Enabled = True
        Else
            ShowError("Tiene que acceder al panel de administrador y configurar una ip.")
        End If
    End Sub
    Private Sub CambiarPanel(panel As Panel, state As Boolean, label As Label)
        If ESP.EstaConectado() Then
            PanelStateEsp.BackColor = Color.FromArgb(34, 51, 40)
            label.Text = "Connected"
        Else
            PanelStateEsp.BackColor = Color.FromArgb(92, 22, 26)
            label.Text = "Disconnected"
        End If
    End Sub


    Private Sub changeToPanelPin(panel As Panel, state As Boolean, label As Label)
        If state Then
            panel.BackColor = Color.FromArgb(34, 51, 40)
            label.Text = "Connected"
        Else
            panel.BackColor = Color.FromArgb(92, 22, 26)
            label.Text = "Disconnected"
        End If
    End Sub

End Class
