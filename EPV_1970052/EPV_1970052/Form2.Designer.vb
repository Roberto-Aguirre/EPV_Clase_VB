<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(52, 47)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(420, 41)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Escribe un programa que verifique si un número ingresado es un número perfecto (u" &
    "n número perfecto es igual a la suma de sus divisores propios)."
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(106, 234)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(408, 234)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(277, 117)
        Me.txtNumero.Multiline = True
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(153, 24)
        Me.txtNumero.TabIndex = 2
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(137, 120)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(95, 13)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Escriba un numero"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtResultado
        '
        Me.txtResultado.AutoSize = True
        Me.txtResultado.Location = New System.Drawing.Point(283, 175)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(0, 13)
        Me.txtResultado.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 325)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblTexto As Label
    Friend WithEvents txtResultado As Label
End Class
