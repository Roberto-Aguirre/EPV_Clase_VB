Public Class Form4
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If IsNumeric(tboxNumero.Text) Then
            Dim numeroIngresado = Integer.Parse(tboxNumero.Text)
            Dim inicio, fin As Integer
            Dim aux = numeroIngresado.ToString()
            Dim esCapi = True
            inicio = 1
            fin = Len(aux)

            While esCapi And (inicio < fin)
                Console.Write(Mid(aux, inicio) & " " & Mid(aux, fin) & vbCrLf)
                If Mid(aux, inicio) = Mid(aux, fin) Then
                    inicio += 1
                    fin -= 1
                Else
                    esCapi = False
                End If
            End While

            If esCapi Then
                lblResultado.Text = "Es numero Capicua"
            Else
                lblResultado.Text = "No numero Capicua"
            End If
        End If
    End Sub
End Class