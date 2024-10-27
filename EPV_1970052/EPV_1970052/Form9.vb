Public Class Form9
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If IsNumeric(txtAltura.Text) Or IsNumeric(txtPeso.Text) Then
            Dim altura = Double.Parse(txtAltura.Text)
            Dim peso = Double.Parse(txtPeso.Text)
            Dim IMC = peso / (altura ^ 2)
            lblIMC.Text = String.Format("{0:0.##}", IMC)

            lblResultado.Text = TextoIMC(IMC)
        Else
            lblResultado.Text = "Algun valor incorrecto"
        End If
    End Sub

    Private Function TextoIMC(iMC As Double) As String
        Select Case iMC
            Case 1 To 18.5
                Return "Bajo peso"
            Case 18.5 To 24.9
                Return "Peso normal"
            Case 25 To 29.9
                Return "Sobrepeso"
            Case 30 To 34.9
                Return "Obesidad"
            Case Else
                Return "Obesidad Severa"
        End Select
    End Function
End Class