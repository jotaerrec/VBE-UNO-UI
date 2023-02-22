Imports System.IO
Imports System.Net.Sockets

Public Class User
    Public Shared Property ESP As EspClass = New EspClass()

    Public IP As String = Nothing
    Public stateConnect As Boolean = False
    Public stateLed As Boolean = False
    Public listaDePines As New List(Of Pin)

    Dim rutaDocumentos As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Dim rutaEleconar As String = rutaDocumentos & "\Eleconar"
    Dim rutaArchivo As String = rutaEleconar & "\config.txt"



    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerArchivo()
        boxTipoPin.Items.Add("Analogico")
        boxTipoPin.Items.Add("Digital")
        boxModoPin.Items.Add("Input")
        boxModoPin.Items.Add("Output")
    End Sub

    Private Sub btnIp_Click(sender As Object, e As EventArgs) Handles btnIp.Click
        'Validaciones
        If IP = Nothing Then
            ShowError("Tiene que acceder al panel de administrador y configurar una ip." + IP)
            Return
        End If

        'Conectar al esp
        Try
            ESP.Conectar(IP:=IP)
            changeToPanel(PanelStateEsp, stateConnect, stateEspText)
            stateConnect = True
        Catch ex As Exception
            ShowError(ex.Message())
            stateConnect = ESP.EstaConectado()
        End Try

    End Sub

    Private Sub btnLed_Click(sender As Object, e As EventArgs) Handles btnLed.Click
        'Validaciones
        If txtNombrePin.Text = "" Or txtNumeroPin.Text = "" Or boxModoPin.Text = "" Or boxTipoPin.Text = "" Then
            ShowError("Complete el formulario.")
            Return
        End If
        Dim nombreDePin As String = txtNombrePin.Text
        Dim numeroDePin As String = txtNumeroPin.Text
        Dim tipoDePin As String = boxTipoPin.Text
        Dim modoDePin As String = boxModoPin.Text

        ' Crear un nuevo objeto Pin con los datos ingresados
        Dim nuevoPin As New Pin(nombreDePin, numeroDePin, tipoDePin, modoDePin)

        listaDePines.Add(nuevoPin)
        ' Agregar el nuevo objeto Pin al control contenedor
        FlowLayoutPanelPines.Controls.Add(nuevoPin.PanelPin)
    End Sub


    Private Sub TextBoxLed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroPin.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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

    Public Sub ShowError(ex As String)
        If ex = "" Then
            Return
        End If
        MsgBox(ex, 0)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureAdminBox.Click
        Dim form As New Login()
        form.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
            Debug.WriteLine(indiceFin)
            btnIp.Cursor = Cursors.Hand
            btnIp.Enabled = True
        Else
            ShowError("Tiene que acceder al panel de administrador y configurar una ip.")
        End If
    End Sub
    Private Sub changeToPanel(panel As Panel, state As Boolean, label As Label)
        If state Then
            panel.BackColor = Color.FromArgb(34, 51, 40)
            label.Text = "Connected"
        Else
            panel.BackColor = Color.FromArgb(92, 22, 26)
            label.Text = "Disconnected"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
