Imports System.IO
Imports System.Net.Sockets

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxIP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIP.TextChanged

    End Sub

    Private Sub btnIp_Click(sender As Object, e As EventArgs) Handles btnIp.Click
        If TextBoxIP.Text = "" Then
            ShowError("Complete el formulario.")
            Return
        End If
        ShowError(connect(IP:=TextBoxIP.Text))
        changeToPanel(PanelStateEsp, stateConnect, stateEspText)

    End Sub

    Private Sub btnLed_Click(sender As Object, e As EventArgs) Handles btnLed.Click
        'Validaciones
        If TextBoxLed.Text = "" Then
            ShowError("Complete el formulario.")
            Return
        End If
        pin = TextBoxLed.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelError.Visible = False
    End Sub

    Public Sub ShowError(ex As String)
        If ex = "" Then
            Return
        End If
        PanelError.Visible = True
        TextError.Text = ex

    End Sub

    Private Sub TextBoxLed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLed.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub PanelStateLed_Click(sender As Object, e As EventArgs) Handles PanelStateLed.Click
        ShowError(SendToServer(pin, Not stateLed))
        changeToPanel(PanelStateLed, stateLed, stateLedText)
    End Sub

    Private Sub stateLedText_Click(sender As Object, e As EventArgs) Handles stateLedText.Click
        ShowError(SendToServer(pin, Not stateLed))
        changeToPanel(PanelStateLed, stateLed, stateLedText)
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

End Class
