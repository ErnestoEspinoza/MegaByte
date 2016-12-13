

Public Class FRM_CONEQUIPO



    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        Me.Close()
        FRM_OPERACIONES.Show()
    End Sub

    Private Sub FRM_CONEQUIPO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FRM_OPERACIONES.Show()
    End Sub


End Class