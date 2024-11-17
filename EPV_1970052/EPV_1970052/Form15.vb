Imports System.Threading

Public Class Form15
    Dim contador As Integer

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        contador = 1
        tmr1.Start()
        tmr1.Interval = 2000

    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        Select Case contador
            Case 1
                pnlVerde.BackColor = Color.Green
                pnlRojo.BackColor = Color.White
                pnlAmarillo.BackColor = Color.White
                lblResultado.Text = "Avance"
                contador += 1
            Case 2
                pnlAmarillo.BackColor = Color.Yellow
                pnlVerde.BackColor = Color.White
                pnlRojo.BackColor = Color.White
                lblResultado.Text = "Preparate para frenar"
                contador += 1
            Case 3
                pnlRojo.BackColor = Color.Red
                pnlVerde.BackColor = Color.White
                pnlAmarillo.BackColor = Color.White
                lblResultado.Text = "Detengase"
                contador -= 2
            Case Else

        End Select
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        tmr1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class