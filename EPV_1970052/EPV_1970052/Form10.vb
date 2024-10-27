Imports System.Text.RegularExpressions

Public Class Form10
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim correoIntroducido = txtCorreo.Text
        If Regex.IsMatch(correoIntroducido, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            lblResultado.Text = "Correo valido"
        Else
            lblResultado.Text = "Correo invalido"
        End If
    End Sub
End Class