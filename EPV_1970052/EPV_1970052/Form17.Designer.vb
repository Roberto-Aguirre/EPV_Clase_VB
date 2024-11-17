<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblAnyos = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblDescuentoRespuesta = New System.Windows.Forms.Label()
        Me.lblBonificacionResultado = New System.Windows.Forms.Label()
        Me.lblBonififacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(239, 248)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblResultado.TabIndex = 23
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(91, 287)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(89, 35)
        Me.btnVerificar.TabIndex = 22
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(469, 287)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(89, 35)
        Me.btnMenu.TabIndex = 21
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblAnyos
        '
        Me.lblAnyos.AutoSize = True
        Me.lblAnyos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnyos.Location = New System.Drawing.Point(87, 126)
        Me.lblAnyos.Name = "lblAnyos"
        Me.lblAnyos.Size = New System.Drawing.Size(206, 20)
        Me.lblAnyos.TabIndex = 20
        Me.lblAnyos.Text = "Ingresa tus años de servicio"
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(15, 34)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(561, 71)
        Me.lblText.TabIndex = 18
        Me.lblText.Text = "Crea un programa que calcule el salario de un empleado con bonificaciones y descu" &
    "entos segun su antiguedad (1: menos de un año, 2: de 1 a 5 años, 3: más de 5 año" &
    "s)."
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalario.Location = New System.Drawing.Point(87, 160)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(139, 20)
        Me.lblSalario.TabIndex = 24
        Me.lblSalario.Text = "Ingresa tu salario: "
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(87, 248)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(206, 20)
        Me.lblDescuento.TabIndex = 25
        Me.lblDescuento.Text = "Descuento correspondiente"
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(303, 126)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(141, 20)
        Me.txtServicio.TabIndex = 19
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(243, 162)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(142, 20)
        Me.txtSalario.TabIndex = 26
        '
        'lblDescuentoRespuesta
        '
        Me.lblDescuentoRespuesta.AutoSize = True
        Me.lblDescuentoRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoRespuesta.Location = New System.Drawing.Point(309, 248)
        Me.lblDescuentoRespuesta.Name = "lblDescuentoRespuesta"
        Me.lblDescuentoRespuesta.Size = New System.Drawing.Size(0, 20)
        Me.lblDescuentoRespuesta.TabIndex = 27
        '
        'lblBonificacionResultado
        '
        Me.lblBonificacionResultado.AutoSize = True
        Me.lblBonificacionResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonificacionResultado.Location = New System.Drawing.Point(215, 206)
        Me.lblBonificacionResultado.Name = "lblBonificacionResultado"
        Me.lblBonificacionResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblBonificacionResultado.TabIndex = 29
        '
        'lblBonififacion
        '
        Me.lblBonififacion.AutoSize = True
        Me.lblBonififacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonififacion.Location = New System.Drawing.Point(87, 206)
        Me.lblBonififacion.Name = "lblBonififacion"
        Me.lblBonififacion.Size = New System.Drawing.Size(103, 20)
        Me.lblBonififacion.TabIndex = 28
        Me.lblBonififacion.Text = "Bonificacion: "
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 354)
        Me.Controls.Add(Me.lblBonificacionResultado)
        Me.Controls.Add(Me.lblBonififacion)
        Me.Controls.Add(Me.lblDescuentoRespuesta)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblSalario)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblAnyos)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.lblText)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form17"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResultado As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblAnyos As Label
    Friend WithEvents lblText As Label
    Friend WithEvents lblSalario As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents txtServicio As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents lblDescuentoRespuesta As Label
    Friend WithEvents lblBonificacionResultado As Label
    Friend WithEvents lblBonififacion As Label
End Class
