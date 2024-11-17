Public Class Form16
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim edad = Integer.Parse(txtEdad.Text)

        If edad >= 0 And edad <= 11 Then

            lblResultado.Text = "Eres un niño"
        ElseIf edad >= 12 And edad <= 20 Then
            lblResultado.Text = "Eres un adolecente"
        ElseIf edad >= 21 And edad <= 30 Then
            lblResultado.Text = "Eres un adulto joven"
        ElseIf edad >= 31 And edad <= 59 Then
            lblResultado.Text = "Eres un adulto"
        Else
            lblResultado.Text = "Eres un adulto mayor"
        End If

    End Sub
End Class