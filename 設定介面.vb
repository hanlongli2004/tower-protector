Public Class 設定介面
    
    Private Sub 設定介面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim backgroundMusicImageName As String = If(HomeMenu.MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)

        FirstRound.MainTimer.Stop()
    End Sub
    Private Sub 設定介面_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FirstRound.MainTimer.Start()
        FirstRound.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '回主頁

        '詢問是否回主頁
        Dim result As DialogResult = MessageBox.Show("是否回主頁？", "提示", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Close()
            FirstRound.Enabled = True
            FirstRound.Close()
            HomeMenu.Form1_Load(Nothing, EventArgs.Empty)
            HomeMenu.Show()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Back
        Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '靜音
        HomeMenu.MusicPlayer.ToggleMute()

        Dim backgroundMusicImageName As String = If(HomeMenu.MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '重新開始
        Resetgame()
    End Sub

    Private Sub Resetgame()
        Call FirstRound.FirstRound_Load(Nothing, EventArgs.Empty)
        Close() ' 隱藏當前表單而不是關閉
        FirstRound.Close()
        FirstRound.Show()
        HomeMenu.Hide()
    End Sub
End Class