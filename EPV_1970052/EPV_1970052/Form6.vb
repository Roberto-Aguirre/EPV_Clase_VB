Public Class Form6
    Dim serie = serieFiboacci()

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        If IsNumeric(txtNumero.Text) Then
            If verificarNumero(txtNumero.Text) Then
                lblResultado.Text = "Forma parte de la secuencia fibonacci"
            Else
                lblResultado.Text = "No es parte de la secuencia fibonacci"
            End If
        Else
            lblResultado.Text = "Valor no identificado"
        End If
    End Sub
    Private Function verificarNumero(numero) As Boolean
        If serie.Contains(numero) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function serieFiboacci() As List(Of Integer)
        Dim fibonacci As New List(Of Integer)
        Dim primerNumero, segundoNumero As Integer
        primerNumero = 0
        segundoNumero = 1
        For i = 0 To 20 Step 1
            Dim suma = primerNumero
            primerNumero = segundoNumero
            segundoNumero += suma
            fibonacci.Add(suma)
        Next
        Return fibonacci
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class