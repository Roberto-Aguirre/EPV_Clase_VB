Public Class Form5
    Private Sub txtHora_TextChanged(sender As Object, e As EventArgs) Handles txtHora.TextChanged

        If IsNumeric(txtHora.Text) Then
            Dim horaIngresada = Integer.Parse(txtHora.Text)
            If horaIngresada >= 1 And horaIngresada <= 24 Then
                Dim horaTotal = 24
                Dim horasFaltantes = horaTotal - horaIngresada
                'Console.WriteLine(horasFaltantes)
                If horasFaltantes = 1 Then
                    lblFalta.Text = "Falta " & horasFaltantes & " hora para medianoche"
                Else
                    lblFalta.Text = "Faltan " & horasFaltantes & " horas para medianoche"
                End If
            Else
                lblFalta.Text = "No valores menores que 0 o mayores de 24 horas"
            End If
        Else
            lblFalta.Text = "Valor no reconocible"
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class