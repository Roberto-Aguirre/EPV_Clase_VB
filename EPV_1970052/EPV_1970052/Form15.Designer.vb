<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(270, 295)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 29)
        Me.lblResultado.TabIndex = 23
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.Location = New System.Drawing.Point(48, 295)
        Me.btnVerificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(134, 54)
        Me.btnVerificar.TabIndex = 22
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(635, 295)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 54)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(35, 232)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(242, 29)
        Me.lblNumero.TabIndex = 20
        Me.lblNumero.Text = "Ingresa la contraseña"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(304, 232)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(436, 26)
        Me.txtContrasenia.TabIndex = 19
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(18, 101)
        Me.lblText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(765, 109)
        Me.lblText.TabIndex = 18
        Me.lblText.Text = "Crea un programa que simule el funcionamiento de un semaforo. Según una opcion (1" &
    ":Rojo, 2:Amarillo, 3:Verde) muestra un mensaje indicando si el usuario debe dete" &
    "nerse, prepararse o avanzar."
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lblText)
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResultado As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents lblText As Label
End Class
