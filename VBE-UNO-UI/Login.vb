Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private exist As Boolean
    Private rutaArchivo As String = "C:\Users\javir\Documents\Eleconar\credentials.txt"

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        existTxt()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (adminBox.Text = "" And passBox.Text = "") Then
            MsgBox("Complete el formulario.")
            Return
        End If
        If exist Then
            BuscarUsuario()
        Else
            agregarUsuario(adminBox.Text, passBox.Text)
        End If
    End Sub

    Private Sub existTxt()
        If Not File.Exists(rutaArchivo) Then
            registerLbl.Text = "Todavia no te registraste, registrate!"
            registerLbl.Visible = True
            exist = False
        Else
            exist = True
        End If

    End Sub

    Private Sub agregarUsuario(admin As String, pass As String)
        File.Create(rutaArchivo).Close()
        Dim contenido As String = "admin=" & admin & ";pass=" & pass & ";" & vbCrLf
        File.AppendAllText(rutaArchivo, contenido)
        Dim form As New Admin()
        form.Show()
        Me.Close()
    End Sub

    Private Sub BuscarUsuario()
        Dim fileReader As System.IO.StreamReader
        Dim usuarioBuscado As String = adminBox.Text
        Dim passBuscado As String = passBox.Text
        Dim encontrado As Boolean = False
        fileReader = My.Computer.FileSystem.OpenTextFileReader(rutaArchivo)



        ' Lee el archivo línea por línea
        Do While fileReader.Peek() <> -1
            Dim linea As String = fileReader.ReadLine()
            Dim partes() As String = linea.Split(";")
            Dim admin As String = partes(0).Substring(partes(0).IndexOf("=") + 1)
            Dim pass As String = partes(1).Substring(partes(1).IndexOf("=") + 1)


            If admin = usuarioBuscado And pass = passBuscado Then
                encontrado = True
                Exit Do
            End If
        Loop

        fileReader.Close()

        ' Muestra el resultado
        If encontrado Then
            registerLbl.Text = "El usuario y contraseña coinciden con un valor en el archivo."
            registerLbl.Visible = True
            Dim form As New Admin()
            form.Show()
            Me.Close()
        Else
            registerLbl.Text = "El usuario y contraseña no coinciden con ningún valor en el archivo."
            registerLbl.Visible = True
        End If
    End Sub

    Private Sub PictureAdminBox_Click(sender As Object, e As EventArgs) Handles PictureAdminBox.Click
        Me.Close()
    End Sub
End Class