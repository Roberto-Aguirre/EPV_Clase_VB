Public Class Form12
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim contraseia = txtContrasenia.Text
        If ValidarContraseña(contraseia) Then
            lblResultado.Text = "Contraseña segura"
        Else
            lblResultado.Text = "Contraseña insegura"
        End If
    End Sub

    Private Function ValidarContraseña(contraseia As String) As Boolean
        Dim mayusculas As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim minusculas As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim numeros As New System.Text.RegularExpressions.Regex("[0-9]")

        If Len(contraseia) <= 8 Then
            Return False
        End If
        If mayusculas.Matches(contraseia).Count < 1 Then
            Return False
        End If
        If minusculas.Matches(contraseia).Count < 1 Then
            Return False
        End If
        If numeros.Matches(contraseia).Count < 1 Then
            Return False
        End If
        Return True
    End Function


End Class