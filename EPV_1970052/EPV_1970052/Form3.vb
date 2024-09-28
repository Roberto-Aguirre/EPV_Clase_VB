Public Class Form3
    Private Sub txtTemperatura_TextChanged(sender As Object, e As EventArgs) Handles txtTemperatura.TextChanged
        If IsNumeric(txtTemperatura.Text) Then
            txtTempFinal.Text = ConvertirTemperatura(cboxInicial.SelectedItem, cboxFinal.SelectedItem, Double.Parse(txtTemperatura.Text))
        Else
            txtTempFinal.Text = "Valor sin reconocible"
        End If
    End Sub
    Private Sub cboxInicial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxInicial.SelectedIndexChanged
        If IsNumeric(txtTemperatura.Text) Then
            txtTempFinal.Text = ConvertirTemperatura(cboxInicial.SelectedItem, cboxFinal.SelectedItem, Double.Parse(txtTemperatura.Text))
        Else
            txtTempFinal.Text = "Valor sin reconocible"
        End If
    End Sub

    Private Sub cboxFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxFinal.SelectedIndexChanged
        If IsNumeric(txtTemperatura.Text) Then
            txtTempFinal.Text = ConvertirTemperatura(cboxInicial.SelectedItem, cboxFinal.SelectedItem, Double.Parse(txtTemperatura.Text))
        Else
            txtTempFinal.Text = "Valor sin reconocible"
        End If
    End Sub
    Private Function ConvertirTemperatura(inicial As String, final As String, temp As Double) As Double
        If inicial = "Celsius" Then
            If final = "Celsius" Then
                Return temp
            ElseIf final = "Fahrenheit" Then
                Return (temp * (9 / 5)) + 32
            Else
                Return temp + 273.15
            End If
        End If

        If inicial = "Fahrenheit" Then
            If final = "Fahrenheit" Then
                Return temp
            ElseIf final = "Celsius" Then
                Return (temp - 32) * (5 / 9)
            Else
                Return (temp - 32) * (5 / 9) + 273.15
            End If
        End If
        If inicial = "Kelvin" Then
            If final = "Kelvin" Then
                Return temp
            ElseIf final = "Fahrenheit" Then
                Return (temp - 273.15) * (9 / 5) + 32
            Else
                Return temp - 273.15
            End If
        End If
        Return 0
    End Function

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class