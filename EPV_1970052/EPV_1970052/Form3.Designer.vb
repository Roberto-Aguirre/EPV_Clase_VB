<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTemperaturaInicial = New System.Windows.Forms.Label()
        Me.lblTemperaturaFinal = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboxInicial = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTempFinal = New System.Windows.Forms.Label()
        Me.cboxFinal = New System.Windows.Forms.ComboBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crea un programa que convierta temperaturas entre Celsius, Fahrenheit y Kelvin se" &
    "gún una opción dada por el usuario."
        '
        'lblTemperaturaInicial
        '
        Me.lblTemperaturaInicial.AutoSize = True
        Me.lblTemperaturaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperaturaInicial.Location = New System.Drawing.Point(69, 122)
        Me.lblTemperaturaInicial.Name = "lblTemperaturaInicial"
        Me.lblTemperaturaInicial.Size = New System.Drawing.Size(142, 20)
        Me.lblTemperaturaInicial.TabIndex = 1
        Me.lblTemperaturaInicial.Text = "Temperatura inicial"
        '
        'lblTemperaturaFinal
        '
        Me.lblTemperaturaFinal.AutoSize = True
        Me.lblTemperaturaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperaturaFinal.Location = New System.Drawing.Point(37, 202)
        Me.lblTemperaturaFinal.Name = "lblTemperaturaFinal"
        Me.lblTemperaturaFinal.Size = New System.Drawing.Size(144, 18)
        Me.lblTemperaturaFinal.TabIndex = 2
        Me.lblTemperaturaFinal.Text = "Temperatura Final"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(217, 119)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(303, 26)
        Me.txtTemperatura.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 4
        '
        'cboxInicial
        '
        Me.cboxInicial.AutoCompleteCustomSource.AddRange(New String() {"Celsius ", "Fahrenheit", "Kelvin"})
        Me.cboxInicial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboxInicial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboxInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxInicial.FormattingEnabled = True
        Me.cboxInicial.Items.AddRange(New Object() {"Celsius", "Fahrenheit", "Kelvin"})
        Me.cboxInicial.Location = New System.Drawing.Point(158, 158)
        Me.cboxInicial.Name = "cboxInicial"
        Me.cboxInicial.Size = New System.Drawing.Size(121, 28)
        Me.cboxInicial.TabIndex = 5
        Me.cboxInicial.Text = "Celsius"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "a"
        '
        'txtTempFinal
        '
        Me.txtTempFinal.AutoSize = True
        Me.txtTempFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempFinal.Location = New System.Drawing.Point(181, 202)
        Me.txtTempFinal.Name = "txtTempFinal"
        Me.txtTempFinal.Size = New System.Drawing.Size(0, 20)
        Me.txtTempFinal.TabIndex = 7
        '
        'cboxFinal
        '
        Me.cboxFinal.AutoCompleteCustomSource.AddRange(New String() {"Celsius ", "Fahrenheit", "Kelvin"})
        Me.cboxFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxFinal.FormattingEnabled = True
        Me.cboxFinal.Items.AddRange(New Object() {"Celsius", "Fahrenheit", "Kelvin"})
        Me.cboxFinal.Location = New System.Drawing.Point(336, 159)
        Me.cboxFinal.Name = "cboxFinal"
        Me.cboxFinal.Size = New System.Drawing.Size(121, 28)
        Me.cboxFinal.TabIndex = 5
        Me.cboxFinal.Text = "Celsius"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.Location = New System.Drawing.Point(521, 236)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 32)
        Me.btnMenu.TabIndex = 8
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(617, 280)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.txtTempFinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboxFinal)
        Me.Controls.Add(Me.cboxInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTemperatura)
        Me.Controls.Add(Me.lblTemperaturaFinal)
        Me.Controls.Add(Me.lblTemperaturaInicial)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTemperaturaInicial As Label
    Friend WithEvents lblTemperaturaFinal As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboxInicial As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTempFinal As Label
    Private WithEvents cboxFinal As ComboBox
    Friend WithEvents btnMenu As Button
End Class
