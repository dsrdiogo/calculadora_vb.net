Module CalcSub
    Public Sub Subtracao()
        Dim x As Double
        Dim y As Double
        Dim z As Double

        If IsNumeric(Calculadora.Valor1.Text) Then
            If IsNumeric(Calculadora.Valor2.Text) Then
                x = Calculadora.Valor1.Text
                y = Calculadora.Valor2.Text

                z = x - y

                Calculadora.Total.Text = z

            Else
                MsgBox("Favor verificar os valores!")
            End If

        Else
            MsgBox("Favor verificar os valores!")
        End If
    End Sub
End Module

