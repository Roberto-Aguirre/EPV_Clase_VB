Public Class Form2
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim suma As Double
        suma = 1
        Dim numero As Double
        numero = Double.Parse(txtNumero.Text)
        For i = 2 To numero Step 1
            'Console.WriteLine("i:" & i)
            If numero Mod i = 0 Then
                'Console.WriteLine("Suma:" & suma & " + " & i)
                If numero = i Then

                Else
                    suma += i
                End If
            End If
        Next
        'Console.WriteLine("DIV" & suma)
        'Console.WriteLine("NUMERO" & numero)
        If numero = suma Then
            txtResultado.Text = "El numero es perfecto"
        Else
            txtResultado.Text = "El numero no es perfecto"
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class