Imports System.IO
Imports System.Net.Sockets

Public Class EspClass
    Private client As TcpClient
    Private entrada As StreamReader
    Private salida As StreamWriter
    Private rawdata As String

    Public Sub Conectar(IP As String)
        Try
            client = New TcpClient(IP, 80)
            If client.GetStream.CanRead Or client.GetStream.CanWrite Then
                entrada = New StreamReader(client.GetStream)
                salida = New StreamWriter(client.GetStream)
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Conectado)
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Public Sub Enviar(pinout As Integer, estado As Boolean)
        Try
            If salida IsNot Nothing Then
                salida.WriteLine(pinout.ToString() & "," & estado.ToString())
                salida.Flush()
            Else
                Throw New Exception("No estas conectado")
            End If
        Catch ex As Exception
            Throw New Exception("Error al enviar datos: " & ex.Message)
        End Try
    End Sub
    Public Function EstaConectado() As Boolean
        If client IsNot Nothing AndAlso client.Connected Then
            Return True
        End If
        Return False
    End Function

    Private Sub Conectado()
        Try
            If entrada IsNot Nothing Then
                While entrada.BaseStream.CanRead
                    rawdata = entrada.ReadLine()
                    ' User.listaDePines.Contains
                    'Procesar datos recibidos
                End While
            End If
        Catch ex As Exception
            Throw New Exception("Error al recibir datos: " & ex.Message)
        Finally
            If entrada IsNot Nothing Then entrada.Dispose()
            If salida IsNot Nothing Then salida.Dispose()
            If client IsNot Nothing Then client.Close()
        End Try
    End Sub

End Class
