Public Class Form8
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If IsNumeric(txtNumero.Text) Then
            Dim anyo = Integer.Parse(txtNumero.Text)
            If ((anyo Mod 4) <> 0) Or (anyo Mod 100 = 0 And anyo Mod 400 <> 0) Then
                MostarTexto("No es año bisiesto")
            Else
                MostarTexto("Es año bisiesto")
            End If
        Else
            MostarTexto("Valor incompatible")
        End If
    End Sub

    Function MostarTexto(texto As String) As Nullable
        lblResultado.Text = texto
    End Function
End Class