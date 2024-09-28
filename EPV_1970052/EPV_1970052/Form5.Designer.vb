<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lblFalta = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTexto
        '
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(21, 21)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(489, 52)
        Me.lblTexto.TabIndex = 0
        Me.lblTexto.Text = "Cálculo del tiempo restante: Solicita una hora del día en formato de 24 horas y m" &
    "uestra cuánto tiempo falta hasta la medianoche."
        '
        'lblFalta
        '
        Me.lblFalta.AutoSize = True
        Me.lblFalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFalta.Location = New System.Drawing.Point(158, 130)
        Me.lblFalta.Name = "lblFalta"
        Me.lblFalta.Size = New System.Drawing.Size(0, 20)
        Me.lblFalta.TabIndex = 1
        '
        'txtHora
        '
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(241, 90)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(208, 26)
        Me.txtHora.TabIndex = 2
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(66, 93)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(169, 20)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "Ingresa la hora del día:"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(435, 186)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 28)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 226)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.lblFalta)
        Me.Controls.Add(Me.lblTexto)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTexto As Label
    Friend WithEvents lblFalta As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents lblHora As Label
    Friend WithEvents btnMenu As Button
End Class
