<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.lblTasa = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(754, 278)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 54)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(228, 126)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(191, 29)
        Me.lblNumero.TabIndex = 12
        Me.lblNumero.Text = "Capital inicial ($)"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(422, 129)
        Me.txtCapital.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(292, 26)
        Me.txtCapital.TabIndex = 11
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(57, 37)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(920, 89)
        Me.lblText.TabIndex = 10
        Me.lblText.Text = "Solicita el capital inicial, la tasa de interes y el tiempo para calcular el valo" &
    "r final usando la formula del interes compuesto y valida si la tasa es positiva " &
    "o negativa."
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(117, 278)
        Me.btnVerificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(134, 54)
        Me.btnVerificar.TabIndex = 17
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tasa de interes (% anual)"
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(422, 169)
        Me.txtInteres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(292, 26)
        Me.txtInteres.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tiempo (años)"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(422, 209)
        Me.txtTiempo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(292, 26)
        Me.txtTiempo.TabIndex = 20
        '
        'lblTasa
        '
        Me.lblTasa.AutoSize = True
        Me.lblTasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTasa.Location = New System.Drawing.Point(340, 278)
        Me.lblTasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTasa.Name = "lblTasa"
        Me.lblTasa.Size = New System.Drawing.Size(0, 29)
        Me.lblTasa.TabIndex = 22
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(340, 312)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 29)
        Me.lblTotal.TabIndex = 23
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 380)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTasa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.lblText)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents action_btn As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents lblTasa As Label
    Friend WithEvents lblTotal As Label
End Class
