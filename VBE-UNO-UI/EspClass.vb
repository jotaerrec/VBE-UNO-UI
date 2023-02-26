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

    Public Sub RegistrarNuevoPin(pin As String, tipo As String, modo As String)
        Try
            If salida IsNot Nothing Then
                salida.WriteLine("AgregarPin:PinNumber:" & pin & ",Modo:" & modo & ",Tipo:" & tipo)
                salida.Flush()
            Else
                Throw New Exception("No estas conectado")
            End If
        Catch ex As Exception
            Throw New Exception("Error al enviar datos: " & ex.Message)
        End Try
    End Sub
    Public Sub Enviar(pinout As String, valor As String, tipo As String)
        Try
            If salida IsNot Nothing Then
                salida.WriteLine("Escribir:Pin:" & pinout & ",Valor:" & valor & ",Tipo:" & tipo)
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
                    If Not String.IsNullOrEmpty(rawdata) Then
                        ProcesarMensaje(rawdata)
                    End If
                    ' User.listaDePines.Contains
                    'Procesar datos recibidos
                End While
            End If
        Catch ex As Exception
            MsgBox("Error al recibir datos: " & ex.Message)
        Finally
            If entrada IsNot Nothing Then entrada.Dispose()
            If salida IsNot Nothing Then salida.Dispose()
            If client IsNot Nothing Then client.Close()
        End Try
    End Sub

    Private Sub ProcesarMensaje(ByVal mensaje As String)
        Dim partes As String() = mensaje.Split(":")
        If partes(0) = "valoresDeEntrada" Then
            leerValor(partes(2), partes(4))
        End If
    End Sub

    Private Sub leerValor(ByVal pinOut As String, ByVal valor As String)

        If User.listaDePines.Find(Function(p) p.NumeroDePin = pinOut) IsNot Nothing Then
            Dim pinModificado As Pin = User.listaDePines.Find(Function(p) p.NumeroDePin = pinOut)
            pinModificado.CambiarValor(valor)
        End If
    End Sub

End Class
