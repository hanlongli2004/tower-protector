Public Class BgmPlayer
    Private _isMuted As Boolean = False
    Private _type As Short = 0

    Public Sub New()
        My.Computer.Audio.Play(My.Resources.主畫面music, AudioPlayMode.BackgroundLoop)
    End Sub

    Public Sub ToggleMute()
        _isMuted = not _isMuted

        If _isMuted
            ' 原本不是靜音
            My.Computer.Audio.Stop()
            Return
        End If

        HandlePlay()
    End Sub

    Public Sub SwitchType(newType As Short)
        _type = newType
        
        if _isMuted Then Return
        HandlePlay()
    End Sub

    Private Sub HandlePlay
        if _isMuted Then Return

        Select Case _type
            Case 0
                My.Computer.Audio.Play(My.Resources.主畫面music, AudioPlayMode.BackgroundLoop)
            Case 1
                My.Computer.Audio.Play(My.Resources.遊戲中, AudioPlayMode.BackgroundLoop)
        End Select
    End Sub

    Public Function GetIsMuted() As Boolean
        Return _isMuted
    End Function

    Public Function GetPlayingType() As Short
        Return _type
    End Function
End Class