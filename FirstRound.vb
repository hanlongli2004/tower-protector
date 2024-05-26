Imports System.IO
Imports Newtonsoft.Json

Public Class FirstRound
    Const Row As Integer = 8
    Const Col As Integer = 4
    Readonly _board As PictureBox(,) = New PictureBox(Row, Col) {}
    Readonly _humanSelectionBar As PictureBox() = New PictureBox(4) {}

    Readonly _setLocation As Integer() = New Integer(45) {}

    Dim ReadOnly c0 As Cursor = New Cursor(New MemoryStream(My.Resources.步槍兵1))
    Dim ReadOnly c1 As Cursor = New Cursor(New MemoryStream(My.Resources.巫婆1))
    Dim ReadOnly c2 As Cursor = New Cursor(New MemoryStream(My.Resources.日本武士1))
    Dim ReadOnly c3 As Cursor = New Cursor(New MemoryStream(My.Resources.和尚1))

    Private ReadOnly _robotList As New list(Of Robot)
    Private ReadOnly _bulletList As New List(Of Bullet)

    Dim _tickCount As Integer = 0

    Public WithEvents MainTimer As New Timer()

    Private ReadOnly _bulletRemovalList As New List(Of Bullet)
    Private ReadOnly _robotRemovalList As New List(Of Robot)

    Public ReadOnly _
        LevelParams As List(Of LevelParams) =
            JsonConvert.DeserializeObject (Of List(Of LevelParams))(My.Resources.levelParams)

    Private _currentLevel = 0

    Private _currentMoney As Integer = 500

    Private _birthCount As Short = 0

    Public Sub SetCurrentLevel(newlevel As Integer)
        _currentLevel = newlevel
    End Sub

    Public Sub FirstRound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainTimer.Interval = 100
        MainTimer.Start()

        SuspendLayout()
        ' 設定視窗大小禁用 Resizable 功能
        FormBorderStyle = FormBorderStyle.FixedSingle ' 設定邊框樣式為固定的
        MaximizeBox = False ' 禁用最大化按鈕
        MinimizeBox = False ' 禁用最小化按鈕

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("Setting"), Image)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage ' 調整圖片大小模式
        PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject("金幣數量"), Image)

        For i = 0 To Row
            For j = 0 To Col
                _board(i, j) = New PictureBox
                Controls.Add(_board(i, j))

                With _board(i, j)
                    .Name = ((5)*i + j + 1)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .BorderStyle = BorderStyle.None
                    .Visible = True
                    .Width = 58
                    .Height = 65
                    .BackColor = Color.Transparent
                    .Top = (72*j) + 59
                    .Left = (62.5*i) + 88
                    .Image = Nothing
                    .Tag = 0
                End With

                AddHandler _board(i, j).Click, AddressOf setDefense_click
            Next
        Next

        For i = 0 To 3
            _humanSelectionBar(i) = New PictureBox
            Controls.Add(_humanSelectionBar(i))

            With _humanSelectionBar(i)
                .Name = "PictureBox" & (3*i + 1)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.None
                .Visible = True
                .Width = 50
                .Height = 35
                .BackColor = Color.Transparent
                .Left = (62.5*i) + 160
                .Tag = i
            End With

            AddHandler _humanSelectionBar(i).Click, AddressOf Human_click
        Next

        _humanSelectionBar(0).Image = My.Resources.步槍兵
        _humanSelectionBar(1).Image = My.Resources.巫婆
        _humanSelectionBar(2).Image = My.Resources.日本武士
        _humanSelectionBar(3).Image = My.Resources.和尚
        '_humanSelectionBar(3).Image = My.Resources.搥子

        ResumeLayout()

        HomeMenu.MusicPlayer.SwitchType(1)
        _tickCount = 0

        GC.Collect()
    End Sub

    Private Sub FirstRound_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainTimer.Stop()
        HomeMenu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '設定
        Enabled = False
        MainTimer.Stop()
        設定介面.Show()
    End Sub

    Private Sub CreateRobot()
        Dim newRobot As New Robot(0)
        _robotList.Add(newRobot)
    End Sub

    Private Sub CreateBullet(bulletType As Integer, firePosition As Point, firingIndex As Integer)
        Dim newBullet As New Bullet(bulletType, firePosition, _currentLevel, firingIndex)
        _bulletList.Add(newBullet)
    End Sub

    Private Sub MainTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
        _robotRemovalList.Clear()
        For Each item As Robot In _robotList
            item.MoveForward()

            item.DetectBulletCollision(_bulletList)

            If item.GetHealth() <= 0 Then
                _robotRemovalList.Add(item)
            End If

            If item.GetX() <= 1 Then
                Close()
                LevelFailed.Show()
            End If
        Next

        _bulletRemovalList.Clear()
        For Each item As Bullet In _bulletList
            item.MoveForward()

            If item.GetX() >= 650 Then
                _bulletRemovalList.Add(item)
            End If
        Next

        For Each item As Bullet In _bulletRemovalList
            Dim bulletType = item.GetBulletType()
            Dim firePosition = item.GetFirePosition()
            Dim firingIndex = item.GetFiringINdex()

            item.RemoveBullet()
            _bulletList.Remove(item)

            Dim newBullet As New Bullet(bulletType, firePosition, _currentLevel, firingIndex)
            _bulletList.Add(newBullet)
        Next

        For Each item As Robot In _robotRemovalList
            item.RemoveRobot()
            _robotList.Remove(item)
        Next

        For i = 0 To Row
            For j = 0 To Col
                If _board(i, j).Image Is Nothing Then
                    Continue For
                End If

                For Each item As Robot In _robotList
                    If _board(i, j).Bounds.IntersectsWith(item.GetBounds()) Then
                        _board(i, j).Image = Nothing

                        Dim removingBullet As Bullet
                        For Each currentBullet As Bullet In _bulletList
                            If currentBullet.GetFiringINdex() = i*5 + j + 1 Then
                                removingBullet = currentBullet
                                Exit For
                            End If
                        Next
                        removingBullet.RemoveBullet()
                        _bulletList.Remove(removingBullet)
                    End If
                Next
            Next
        Next

        If _tickCount Mod 50 = 0 Then
            CreateRobot()

            _birthCount += 1
            If _birthCount >= 15 Then
                Close()

                If _currentLevel = 0 Then
                    LevelFinish.Show()
                Else
                    GameEnd.Show()
                End If
            End If
        End If
        
        If _tickCount Mod 100 = 0 Then
            _currentMoney += 200
            Money.Text = _currentMoney
        End If

        If _tickCount = 10000 Then
            _tickCount = 1
        End If

        _tickCount += 1
    End Sub

    Private Sub Human_click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim human = CType(sender, PictureBox)

        Dim cost = LevelParams(_currentLevel).Human(CInt(Tag)).Cost
        _currentMoney -= cost
        Money.Text = _currentMoney

        Select Case human.Tag
            Case "0"
                Cursor = c0
            Case "1"
                Cursor = c1
            Case "2"
                Cursor = c2
            Case "3"
                Cursor = c3
        End Select
    End Sub

    Private Sub setDefense_click(sender As Object, e As EventArgs)
        Dim map = CType(sender, PictureBox)
        If Not IsNothing(map.Image) Then
            Return
        End If

        Select Case Cursor
            Case c0
                CreateBullet(0, New Point(map.Location.X, map.Location.Y), map.Name)
                map.Image = My.Resources.步槍兵
            Case c1
                CreateBullet(1, New Point(map.Location.X, map.Location.Y), map.name)
                map.Image = My.Resources.巫婆
            Case c2
                CreateBullet(2, New Point(map.Location.X, map.Location.Y), map.name)
                map.Image = My.Resources.日本武士
            Case c3
                CreateBullet(3, New Point(map.Location.X, map.Location.Y), map.name)
                map.Image = My.Resources.和尚
        End Select

        Cursor = Nothing
        map.Tag = 1

        For i = 0 To 45
            If _setLocation(i) = 0 Then
                _setLocation(i) = map.Name
            End If
        Next
    End Sub

End Class
