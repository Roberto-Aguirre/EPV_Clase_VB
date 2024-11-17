<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form15
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlVerde = New System.Windows.Forms.Panel()
        Me.pnlAmarillo = New System.Windows.Forms.Panel()
        Me.pnlRojo = New System.Windows.Forms.Panel()
        Me.lblSenal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(220, 178)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblResultado.TabIndex = 23
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(16, 297)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(89, 35)
        Me.btnIniciar.TabIndex = 22
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 297)
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
        Me.lblNumero.Location = New System.Drawing.Point(32, 214)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(52, 20)
        Me.lblNumero.TabIndex = 20
        Me.lblNumero.Text = "Verde"
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(12, 27)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(510, 71)
        Me.lblText.TabIndex = 18
        Me.lblText.Text = "Crea un programa que simule el funcionamiento de un semaforo. Según una opcion (1" &
    ":Rojo, 2:Amarillo, 3:Verde) muestra un mensaje indicando si el usuario debe dete" &
    "nerse, prepararse o avanzar."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Amarillo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Rojo"
        '
        'pnlVerde
        '
        Me.pnlVerde.BackColor = System.Drawing.Color.Lime
        Me.pnlVerde.Location = New System.Drawing.Point(100, 209)
        Me.pnlVerde.Name = "pnlVerde"
        Me.pnlVerde.Size = New System.Drawing.Size(27, 30)
        Me.pnlVerde.TabIndex = 27
        '
        'pnlAmarillo
        '
        Me.pnlAmarillo.BackColor = System.Drawing.Color.Yellow
        Me.pnlAmarillo.Location = New System.Drawing.Point(100, 168)
        Me.pnlAmarillo.Name = "pnlAmarillo"
        Me.pnlAmarillo.Size = New System.Drawing.Size(27, 30)
        Me.pnlAmarillo.TabIndex = 28
        '
        'pnlRojo
        '
        Me.pnlRojo.BackColor = System.Drawing.Color.Red
        Me.pnlRojo.Location = New System.Drawing.Point(100, 124)
        Me.pnlRojo.Name = "pnlRojo"
        Me.pnlRojo.Size = New System.Drawing.Size(27, 30)
        Me.pnlRojo.TabIndex = 29
        '
        'lblSenal
        '
        Me.lblSenal.AutoSize = True
        Me.lblSenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenal.Location = New System.Drawing.Point(263, 110)
        Me.lblSenal.Name = "lblSenal"
        Me.lblSenal.Size = New System.Drawing.Size(58, 20)
        Me.lblSenal.TabIndex = 30
        Me.lblSenal.Text = "Señal: "
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(111, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 35)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Detener"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        Me.tmr1.Interval = 5000
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 344)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblSenal)
        Me.Controls.Add(Me.pnlRojo)
        Me.Controls.Add(Me.pnlAmarillo)
        Me.Controls.Add(Me.pnlVerde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblText)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResultado As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlVerde As Panel
    Friend WithEvents pnlAmarillo As Panel
    Friend WithEvents pnlRojo As Panel
    Friend WithEvents lblSenal As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents tmr1 As Timer
End Class
