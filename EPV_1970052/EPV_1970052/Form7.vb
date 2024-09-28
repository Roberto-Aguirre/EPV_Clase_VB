Public Class Form7
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tboxUsuario.Text = "Aguirre" And tboxContraseña.Text = "1970052" Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Acceso denegado")
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        tboxUsuario.Text = ""
        tboxContraseña.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class