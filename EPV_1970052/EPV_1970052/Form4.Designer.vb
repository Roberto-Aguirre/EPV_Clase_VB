<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.tboxNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(32, 23)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(422, 38)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Números Capicúa: Crea un programa que verifique si un número de varias cifras es " &
    "capicúa (se lee igual de izquierda a derecha y de derecha a izquierda)."
        '
        'btnVerificar
        '
        Me.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVerificar.Location = New System.Drawing.Point(160, 165)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenu.Location = New System.Drawing.Point(300, 165)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'tboxNumero
        '
        Me.tboxNumero.Location = New System.Drawing.Point(216, 103)
        Me.tboxNumero.Name = "tboxNumero"
        Me.tboxNumero.Size = New System.Drawing.Size(217, 20)
        Me.tboxNumero.TabIndex = 2
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(100, 106)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(95, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Ingresa un numero"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(235, 140)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblResultado.TabIndex = 3
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 231)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.tboxNumero)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.lblTexto)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexto As Label
    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents tboxNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblResultado As Label
End Class
