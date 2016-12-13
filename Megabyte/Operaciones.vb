Public Class FRM_OPERACIONES

    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        Me.Close()
        FRM_INICIO.Show()
    End Sub

    Private Sub BTN_REGEQUIPO_Click(sender As Object, e As EventArgs) Handles BTN_REGEQUIPO.Click
        Me.Hide()
        FRM_RegistroEquipos.Show()
    End Sub

    Private Sub FRM_OPERACIONES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FRM_INICIO.Show()
    End Sub

    Private Sub BTN_REGCLIENTES_Click(sender As Object, e As EventArgs) Handles BTN_REGCLIENTES.Click
        Me.Hide()
        FRM_REGCLIENTE.Show()
    End Sub

    Private Sub BTN_CONEQUIPO_Click(sender As Object, e As EventArgs) Handles BTN_CONEQUIPO.Click
        Me.Hide()
        FRM_CONEQUIPO.Show()
    End Sub
End Class