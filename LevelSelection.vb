Public Class LevelSelection
    '追蹤是否通關
    Public PassStatus As short = 0
    
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        Dim backgroundMusicImageName As String = If(HomeMenu.MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        HomeMenu.backgroundmusic.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)
        HomeMenu.Show()
    End Sub

    Private Sub 選擇關卡_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim backgroundMusicImageName As String = If(HomeMenu.MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        backgroundmusic.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles backgroundmusic.Click
        '靜音開關
        HomeMenu.MusicPlayer.ToggleMute()

        Dim backgroundMusicImageName As String = If(HomeMenu.MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        backgroundmusic.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '第一關
        FirstRound.SetCurrentLevel(0)
        
        FirstRound.Show()
        Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '第二關
        If PassStatus = 1 Then
            FirstRound.SetCurrentLevel(1)

            FirstRound.Show()
            Hide()
        Else
            MessageBox.Show("你需要通過前面的關卡才能進入這一關。")
        End If
    End Sub


    Private Shared Sub 選擇關卡_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class