Public Class LevelFinish
    Private Sub 恭喜過關_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedSingle ' 設定邊框樣式為固定的
        MaximizeBox = False ' 禁用最大化按鈕
        MinimizeBox = False ' 禁用最小化按鈕
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("關卡選擇"), Image)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject("第二關"), Image)
    End Sub
    
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        LevelSelection.PassStatus = 1
        FirstRound.SetCurrentLevel(1)

        FirstRound.Show()
        Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LevelSelection.Show()
        Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class