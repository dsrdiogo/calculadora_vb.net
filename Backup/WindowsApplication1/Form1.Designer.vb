<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Soma = New System.Windows.Forms.Button
        Me.Valor1 = New System.Windows.Forms.TextBox
        Me.Valor2 = New System.Windows.Forms.TextBox
        Me.Subtracao = New System.Windows.Forms.Button
        Me.Multiplicacao = New System.Windows.Forms.Button
        Me.Divisao = New System.Windows.Forms.Button
        Me.Total = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Soma
        '
        Me.Soma.Location = New System.Drawing.Point(13, 92)
        Me.Soma.Name = "Soma"
        Me.Soma.Size = New System.Drawing.Size(99, 23)
        Me.Soma.TabIndex = 0
        Me.Soma.Text = "Soma"
        Me.Soma.UseVisualStyleBackColor = True
        '
        'Valor1
        '
        Me.Valor1.Location = New System.Drawing.Point(12, 31)
        Me.Valor1.Name = "Valor1"
        Me.Valor1.Size = New System.Drawing.Size(100, 20)
        Me.Valor1.TabIndex = 1
        '
        'Valor2
        '
        Me.Valor2.Location = New System.Drawing.Point(172, 31)
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Size = New System.Drawing.Size(100, 20)
        Me.Valor2.TabIndex = 2
        '
        'Subtracao
        '
        Me.Subtracao.Location = New System.Drawing.Point(185, 91)
        Me.Subtracao.Name = "Subtracao"
        Me.Subtracao.Size = New System.Drawing.Size(87, 23)
        Me.Subtracao.TabIndex = 3
        Me.Subtracao.Text = "Subtração"
        Me.Subtracao.UseVisualStyleBackColor = True
        '
        'Multiplicacao
        '
        Me.Multiplicacao.Location = New System.Drawing.Point(13, 146)
        Me.Multiplicacao.Name = "Multiplicacao"
        Me.Multiplicacao.Size = New System.Drawing.Size(100, 23)
        Me.Multiplicacao.TabIndex = 4
        Me.Multiplicacao.Text = "Multiplicação"
        Me.Multiplicacao.UseVisualStyleBackColor = True
        '
        'Divisao
        '
        Me.Divisao.Location = New System.Drawing.Point(185, 146)
        Me.Divisao.Name = "Divisao"
        Me.Divisao.Size = New System.Drawing.Size(87, 23)
        Me.Divisao.TabIndex = 5
        Me.Divisao.Text = "Divisão"
        Me.Divisao.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(13, 212)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(260, 20)
        Me.Total.TabIndex = 6
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Divisao)
        Me.Controls.Add(Me.Multiplicacao)
        Me.Controls.Add(Me.Subtracao)
        Me.Controls.Add(Me.Valor2)
        Me.Controls.Add(Me.Valor1)
        Me.Controls.Add(Me.Soma)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Soma As System.Windows.Forms.Button
    Friend WithEvents Valor1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor2 As System.Windows.Forms.TextBox
    Friend WithEvents Subtracao As System.Windows.Forms.Button
    Friend WithEvents Multiplicacao As System.Windows.Forms.Button
    Friend WithEvents Divisao As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.TextBox

End Class
