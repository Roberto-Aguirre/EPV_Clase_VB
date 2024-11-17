Public Class Form17

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Años de servicio
    'caso 1: bonificacion de 5%
    'caso 2: bonificacion de 10%
    'caso 3: bonificacion de 15%

    'Descuento
    'caso 1: 5%,
    'caso 2: 8%,
    'caso 3: 12%
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        Dim anyoServicio = Double.Parse(txtServicio.Text)
        Dim salario = Double.Parse(txtSalario.Text)
        Dim bonificacion, descuento As Double


        If anyoServicio <= 0 Then

            bonificacion = 0.05
            descuento = 5

            lblBonificacionResultado.Text = $"De ${bonificacion * salario}"
            lblDescuentoRespuesta.Text = $"De {descuento}%"

        ElseIf anyoServicio >= 1 And anyoServicio <= 5 Then

            bonificacion = 0.1
                descuento = 8

            lblBonificacionResultado.Text = $"De ${bonificacion * salario}"
            lblDescuentoRespuesta.Text = $"De {descuento}%"

        Else
                bonificacion = 0.15
                descuento = 12
            lblBonificacionResultado.Text = $"De ${bonificacion * salario}"
            lblDescuentoRespuesta.Text = $"De {descuento}%"

        End If

        If True Then
        End If


    End Sub
End Class