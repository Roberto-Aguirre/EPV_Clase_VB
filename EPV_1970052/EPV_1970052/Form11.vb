Public Class Form11
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim acumulado As Double
        Dim capital As Double
        Dim interes As Double
        Dim tiempo As Integer
        If IsNumeric(txtCapital.Text) And IsNumeric(txtInteres.Text) And IsNumeric(txtTiempo.Text) Then
            capital = txtCapital.Text
            tiempo = txtTiempo.Text
            acumulado = capital
            interes = (txtInteres.Text / 100) + 1
            For index = 1 To tiempo
                acumulado = acumulado * interes
            Next
            Dim textoResultado As String
            If acumulado > capital Then
                textoResultado = "positiva"
            Else
                textoResultado = "negativa"
            End If
            lblTasa.Text = $"La tasa es {textoResultado}"
            lblTotal.Text = $"El total es {acumulado}"
        Else
            lblTasa.Text = ""
            lblTotal.Text = "Valores incorrectos"
        End If
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class