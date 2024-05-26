Public Class HomeMenu
    Public ReadOnly MusicPlayer As new BgmPlayer()
    Private _isStoryRead As Boolean = False

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim backgroundMusicImageName As String = If(MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        backgroundmusic.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)

        If MusicPlayer.GetPlayingType() <> 0
            MusicPlayer.SwitchType(0)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        _isStoryRead = Not _isStoryRead

        If _isStoryRead
            遊戲劇情.Show()

            Return
        End If

        Dim result As DialogResult = MessageBox.Show("您已看過劇情，是否繼續觀看", "提示", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            遊戲劇情.Show()
        Else
            LevelSelection.Show()
        End If
    End Sub

    Private Shared Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '退出
        '詢問是否離開
        Dim result As DialogResult = MessageBox.Show("是否離開此遊戲？", "提示", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles backgroundmusic.Click
        '靜音
        MusicPlayer.ToggleMute()

        Dim backgroundMusicImageName As String = If(MusicPlayer.GetIsMuted(), "靜音_關", "靜音_開")
        backgroundmusic.Image = CType(My.Resources.ResourceManager.GetObject(backgroundMusicImageName), Image)
    End Sub

    Private Shared Sub HomeMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class