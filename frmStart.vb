Public Class frmStart
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        pName = txtName.Text
        frmGame.Show()
        Me.Hide()
    End Sub
End Class
