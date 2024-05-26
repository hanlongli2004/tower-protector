Public Class LevelFailed
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FirstRound.Show()
        Hide()
    End Sub

    Private Sub 遊戲失敗_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("Restart"), Image)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject("關卡選擇"), Image)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LevelSelection.Show()
        Hide()
    End Sub
End Class