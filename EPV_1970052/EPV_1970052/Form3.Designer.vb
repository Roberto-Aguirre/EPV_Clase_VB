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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Crea un programa que convierta temperaturas entre Celsius, Fahrenheit y Kelvin se" &
    "gún una opción dada por el usuario."
        '
        'lblTemperaturaInicial
        '
        Me.lblTemperaturaInicial.AutoSize = True
        Me.lblTemperaturaInicial.Location = New System.Drawing.Point(124, 122)
        Me.lblTemperaturaInicial.Name = "lblTemperaturaInicial"
        Me.lblTemperaturaInicial.Size = New System.Drawing.Size(96, 13)
        Me.lblTemperaturaInicial.TabIndex = 1
        Me.lblTemperaturaInicial.Text = "Temperatura inicial"
        '
        'lblTemperaturaFinal
        '
        Me.lblTemperaturaFinal.AutoSize = True
        Me.lblTemperaturaFinal.Location = New System.Drawing.Point(124, 202)
        Me.lblTemperaturaFinal.Name = "lblTemperaturaFinal"
        Me.lblTemperaturaFinal.Size = New System.Drawing.Size(92, 13)
        Me.lblTemperaturaFinal.TabIndex = 2
        Me.lblTemperaturaFinal.Text = "Temperatura Final"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(241, 119)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(303, 20)
        Me.txtTemperatura.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'cboxInicial
        '
        Me.cboxInicial.AutoCompleteCustomSource.AddRange(New String() {"Celsius ", "Fahrenheit", "Kelvin"})
        Me.cboxInicial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboxInicial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboxInicial.FormattingEnabled = True
        Me.cboxInicial.Items.AddRange(New Object() {"Celsius", "Fahrenheit", "Kelvin"})
        Me.cboxInicial.Location = New System.Drawing.Point(206, 159)
        Me.cboxInicial.Name = "cboxInicial"
        Me.cboxInicial.Size = New System.Drawing.Size(121, 21)
        Me.cboxInicial.TabIndex = 5
        Me.cboxInicial.Text = "Celsius"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "a"
        '
        'txtTempFinal
        '
        Me.txtTempFinal.AutoSize = True
        Me.txtTempFinal.Location = New System.Drawing.Point(229, 202)
        Me.txtTempFinal.Name = "txtTempFinal"
        Me.txtTempFinal.Size = New System.Drawing.Size(0, 13)
        Me.txtTempFinal.TabIndex = 7
        '
        'cboxFinal
        '
        Me.cboxFinal.AutoCompleteCustomSource.AddRange(New String() {"Celsius ", "Fahrenheit", "Kelvin"})
        Me.cboxFinal.FormattingEnabled = True
        Me.cboxFinal.Items.AddRange(New Object() {"Celsius", "Fahrenheit", "Kelvin"})
        Me.cboxFinal.Location = New System.Drawing.Point(351, 159)
        Me.cboxFinal.Name = "cboxFinal"
        Me.cboxFinal.Size = New System.Drawing.Size(121, 21)
        Me.cboxFinal.TabIndex = 5
        Me.cboxFinal.Text = "Celsius"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(538, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 300)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As Button
End Class
