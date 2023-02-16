Imports System.IO
Imports System.Text

Public Class Admin
    Dim rutaArchivo As String = "C:\Users\javir\Documents\Eleconar\config.txt"
    Dim ip As String = Nothing
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verifyExist()
    End Sub

    Private Sub verifyExist()

        If File.Exists(rutaArchivo) Then
            ' Lee el contenido del archivo
            Dim contenidoArchivo As String = File.ReadAllText(rutaArchivo)

            ' Busca la cadena "IP=" y extrae la dirección IP
            Dim indiceInicio As Integer = contenidoArchivo.IndexOf("IP=") + 3
            Dim indiceFin As Integer = contenidoArchivo.IndexOf(Environment.NewLine, indiceInicio)

            If indiceInicio >= 0 AndAlso indiceFin > indiceInicio Then
                ip = contenidoArchivo.Substring(indiceInicio, indiceFin - indiceInicio)
            End If
        End If
        TextBoxIP.Text = ip

    End Sub

    Private Sub btnIp_Click(sender As Object, e As EventArgs) Handles btnIp.Click
        Dim nuevaIP As String = TextBoxIP.Text
        If Not String.IsNullOrEmpty(nuevaIP) AndAlso Not nuevaIP.Equals(ip) Then
            If Not File.Exists(rutaArchivo) Then
                Dim archivo As FileStream = File.Create(rutaArchivo)
                archivo.Close()
            End If
            ' Lee todo el contenido del archivo excepto la línea que contiene la dirección IP
            Dim lineas As String() = File.ReadAllLines(rutaArchivo)
                Dim contenidoSinIP As String = ""

                For i As Integer = 0 To lineas.Length - 1
                    If Not lineas(i).StartsWith("IP=") Then
                        contenidoSinIP &= lineas(i) & Environment.NewLine
                    End If
                Next

                ' Escribe la nueva dirección IP en el archivo
                Dim nuevoContenido As String = "IP=" & nuevaIP & Environment.NewLine & contenidoSinIP
                File.WriteAllText(rutaArchivo, nuevoContenido)
                ip = nuevaIP
                MsgBox("Se ha guardado correctamente la ip:" + ip)
            End If
    End Sub

    Private Sub PictureAdminBox_Click(sender As Object, e As EventArgs) Handles PictureAdminBox.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class