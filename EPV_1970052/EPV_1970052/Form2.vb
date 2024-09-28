Public Class Form2
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim suma As Double
        suma = 1
        If IsNumeric(txtNumero.Text) Then
            Dim numero As Double
            numero = Double.Parse(txtNumero.Text)
            For i = 2 To numero Step 1
                If numero Mod i = 0 Then
                    If numero = i Then

                    Else
                        suma += i
                    End If
                End If
            Next
            If numero = suma Then
                txtResultado.Text = "El numero es perfecto"
            Else
                txtResultado.Text = "El numero no es perfecto"
            End If
        Else
            txtResultado.Text = "Valor incompatible"
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class