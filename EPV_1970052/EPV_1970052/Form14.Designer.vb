<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSalida = New System.Windows.Forms.ComboBox()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(16, 289)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(89, 35)
        Me.btnCalcular.TabIndex = 22
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(408, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 35)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(23, 126)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(176, 20)
        Me.lblBase.TabIndex = 20
        Me.lblBase.Text = "Ingresa la base decimal"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(205, 126)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(292, 20)
        Me.txtBase.TabIndex = 19
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(12, 39)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(510, 71)
        Me.lblText.TabIndex = 18
        Me.lblText.Text = "Solicita un numero en base decimal y permite al usuario convertirlo a binario, oc" &
    "tal o hexadecimal dependiendo de la opcion seleccionada."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Salida:"
        '
        'cboSalida
        '
        Me.cboSalida.FormattingEnabled = True
        Me.cboSalida.Items.AddRange(New Object() {"Binario", "Octal", "Hexadecimal"})
        Me.cboSalida.Location = New System.Drawing.Point(205, 163)
        Me.cboSalida.Name = "cboSalida"
        Me.cboSalida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSalida.Size = New System.Drawing.Size(172, 21)
        Me.cboSalida.TabIndex = 25
        Me.cboSalida.Text = "Binario"
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.Location = New System.Drawing.Point(142, 212)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(0, 20)
        Me.lblSalida.TabIndex = 26
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 354)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.cboSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblText)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form14"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblBase As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSalida As ComboBox
    Friend WithEvents lblSalida As Label
End Class
