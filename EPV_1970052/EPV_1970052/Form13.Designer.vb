<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.cboOpcion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(209, 229)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblResultado.TabIndex = 23
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(46, 282)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(89, 35)
        Me.btnVerificar.TabIndex = 22
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(501, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(42, 156)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(143, 20)
        Me.lblNumero.TabIndex = 20
        Me.lblNumero.Text = "Ingresa un numero"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(203, 156)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(292, 20)
        Me.txtNumero.TabIndex = 19
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(23, 57)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(601, 71)
        Me.lblText.TabIndex = 18
        Me.lblText.Text = "Crea una calculadora que permite realizar operaciones avanzadas como trigonometri" &
    "a (seno,coseno), logaritmos, potencias, factorizacion, etc. según la opcion que " &
    "elija el usuario."
        '
        'cboOpcion
        '
        Me.cboOpcion.FormattingEnabled = True
        Me.cboOpcion.Items.AddRange(New Object() {"Potencia", "Factorizacion", "Seno", "Coseno", "Logaritmo"})
        Me.cboOpcion.Location = New System.Drawing.Point(203, 124)
        Me.cboOpcion.Name = "cboOpcion"
        Me.cboOpcion.Size = New System.Drawing.Size(121, 21)
        Me.cboOpcion.TabIndex = 24
        Me.cboOpcion.Text = "Potencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ingrese potencia o factorizacion"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(283, 189)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 25
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 329)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.cboOpcion)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblText)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResultado As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents cboOpcion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
End Class
