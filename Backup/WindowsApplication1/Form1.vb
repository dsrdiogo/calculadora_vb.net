Public Class Calculadora

    Dim x As Decimal
    Dim y As Decimal
    Dim z As Decimal

    Private Sub Soma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Soma.Click
        x = Valor1.Text
        y = Valor2.Text
        z = x + y
        Total.Text = z

    End Sub

    Private Sub Subtracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subtracao.Click
        x = Valor1.Text
        y = Valor2.Text
        z = x - y
        Total.Text = z
    End Sub

    Private Sub Multiplicacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiplicacao.Click
        x = Valor1.Text
        y = Valor2.Text
        z = x * y
        Total.Text = z
    End Sub

    Private Sub Divisao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divisao.Click
        x = Valor1.Text
        y = Valor2.Text
        z = x / y
        Total.Text = z
    End Sub

    Private Sub Valor1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor1.TextChanged

    End Sub

    Private Sub Valor2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor2.TextChanged

    End Sub

    Private Sub Total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total.TextChanged

    End Sub
End Class
