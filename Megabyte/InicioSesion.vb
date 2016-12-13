Public Class FRM_INICIO

    Private Sub BTN_INICIAR_Click(sender As Object, e As EventArgs) Handles BTN_INICIAR.Click
        Me.Hide()
        FRM_OPERACIONES.Show()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Beep()
        Close()
    End Sub

    Private Sub FRM_INICIO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FRM_OPERACIONES.Show()
    End Sub
End Class
