Imports System.IO
Imports System.Net.Sockets
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports VBE_UNO_UI.Form1

Module commands
    Private client As TcpClient
    Private Rx As StreamReader
    Private Tx As StreamWriter
    Private rawdata As String
    Public stateConnect As Boolean = False
    Public stateLed As Boolean = False
    Public pin As String
    Public err As String

    Function connect(IP As String) As String
        'Validaciones
        Try
            client = New TcpClient(IP, 80)
            If client.GetStream.CanRead = True Or client.GetStream.CanWrite Then
                Rx = New StreamReader(client.GetStream)
                Tx = New StreamWriter(client.GetStream)
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
            End If
            stateConnect = True
        Catch ex As Exception
            stateConnect = False
            Return ex.Message()
        End Try
        Return ""
    End Function

    Function SendToServer(pinout As Integer, state As Boolean) As String
        Try
            ' Example: "9,true" 
            Tx.WriteLine(pinout.ToString() + "," + state.ToString())
            Tx.Flush()
            stateLed = state
        Catch ex As Exception
            Return ex.Message()
        End Try
        Return ""
    End Function

    Function Connected()
        If Rx.BaseStream.CanRead = True Then
            Try
                While Rx.BaseStream.CanRead = True
                    rawdata = Rx.ReadLine

                    'Threading.ThreadPool.QueueUserWorkItem(AddressOf MSG1, "Hello World.")


                End While
            Catch ex As Exception
                Debug.WriteLine(ex.Message())
            End Try
            Rx.DiscardBufferedData()
        End If
    End Function

End Module
