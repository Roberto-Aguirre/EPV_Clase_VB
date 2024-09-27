Public Class Form1
    Private Sub NumeroPerfectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroPerfectoToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ConversionDeTemperaturaAvanzadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionDeTemperaturaAvanzadaToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub NumeroCapicúaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroCapicúaToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub CálculoDeTiempoRestanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CálculoDeTiempoRestanteToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub NumeroEnSecuenciaFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroEnSecuenciaFibonacciToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class
