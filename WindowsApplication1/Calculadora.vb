Public Class Calculadora

    Public Sub Soma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Soma.Click
        Call CalcSoma.Soma()

    End Sub

    Private Sub Subtracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subtracao.Click
        Call CalcSub.Subtracao()
    End Sub

    Private Sub Multiplicacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiplicacao.Click
        Call CalcMult.Multiplicacao()
    End Sub

    Private Sub Divisao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divisao.Click
        Call CalcDiv.Divisao()
    End Sub
End Class
