Public Class Form13
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim opcion = cboOpcion.Text

        Dim valor1 = txtNumero.Text
        Dim valor2 = txtValor.Text

        Select Case opcion
            Case "Potencia"
                lblResultado.Text = $"Resultado: {Math.Pow(valor1, valor2)}"
            Case "Factorizacion"
                lblResultado.Text = $"Resultado: {Math.Sqrt(valor1)}"
            Case "Seno"
                lblResultado.Text = $"Resultado: {Math.Sin(valor1)}"
            Case "Coseno"
                lblResultado.Text = $"Resultado: {Math.Cos(valor1)}"
            Case "Logaritmo"
                lblResultado.Text = $"Resultado: {Math.Log10(valor1)}"
            Case Else
                lblResultado.Text = "Valor erroneo"
        End Select
    End Sub

    Private Sub cboOpcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcion.SelectedIndexChanged
        If cboOpcion.Text = "Potencia" Then
            txtValor.Enabled = True
        Else
            txtValor.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class