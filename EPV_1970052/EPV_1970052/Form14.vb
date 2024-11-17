Public Class Form14
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor = Integer.Parse(txtBase.Text)
        Dim opcion = cboSalida.Text
        Dim respuesta = ""

        Select Case opcion
            Case "Binario"
                While valor <> 0
                    If valor Mod 2 = 0 Then
                        valor = valor / 2
                        respuesta = $"{respuesta}0"
                    Else
                        respuesta = $"{respuesta}1"
                        valor -= 1
                        valor = valor / 2
                    End If
                End While
                respuesta = StrReverse(respuesta)
                lblSalida.Text = $"El numero binario es: {respuesta}"
            Case "Octal"
                lblSalida.Text = $"El numero octal es: {Oct(valor)}"
            Case "Hexadecimal"
                lblSalida.Text = $"El numero hexadecimal es: {Hex(valor)}"
            Case Else
                lblSalida.Text = "Valor incorrecto"
        End Select

    End Sub
End Class