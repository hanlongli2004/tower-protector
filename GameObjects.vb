Public Class Robot
    Private _health As Integer
    Private Readonly _level As Short
    Private _combatPower As Integer
    Private ReadOnly _row As Integer
    Private ReadOnly _rand As New Random()
    Dim _robotPicure As New PictureBox

    Public Sub New(level As Short)
        Dim row As Integer = _rand.Next(1, 6)
        _row = row
        _level = level
        
        SetRandomRobotType()

        With _robotPicure
            .BackColor = Color.Transparent
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Width = 58
            .Height = 58
            .Location = New Point(FirstRound.ClientSize.Width - _robotPicure.Width, 68*row)
        End With

        FirstRound.Controls.Add(_robotPicure)
        _robotPicure.BringToFront()
        
        Console.Write(_health)
    End Sub

    Private Sub SetRandomRobotType()
        ' 隨機產生 0、1、2、3 中的一個數字
        Randomize()
        Dim randomNumber As Integer = _rand.Next(0, 4)

        _health = FirstRound.LevelParams(_level).Robot.Properties(randomNumber).Health
        _combatPower = FirstRound.LevelParams(_level).Robot.Properties(randomNumber).CP
        
        Select Case randomNumber
            Case 0
                _robotPicure.Image = My.Resources.夾夾怪
            Case 1
                _robotPicure.Image = My.Resources.橘色機器人
            Case 2
                _robotPicure.Image = My.Resources.長腿怪
            Case 3
                _robotPicure.Image = My.Resources.電擊怪
        End Select
    End Sub

    Public Sub DetectBulletCollision(bullets As List(Of Bullet))
        For Each bullet In bullets
            If _robotPicure.Bounds.IntersectsWith(bullet.GetBounds()) Then
                Dim bulletType As Integer = bullet.GetBulletType()
                Dim firePosition As Point = bullet.GetFirePosition()
                Dim firingIndex As Integer = bullet.GetFiringINdex()

                bullet.RemoveBullet()
                bullets.Remove(bullet)
                
                _health -= bullet.GetCombatPower()
                
                Dim newBullet As New Bullet(bulletType, firePosition, _level, firingIndex)
                bullets.Add(newBullet)

                Exit For
            End If
        Next
    End Sub

    Public Function GetX() As Integer
        Return _robotPicure.Location.X
    End Function

    Public Sub RemoveRobot()
        FirstRound.Controls.Remove(_robotPicure)
        _robotPicure.Dispose()
        _robotPicure = Nothing
        GC.Collect()
    End Sub

    Public Sub MoveForward()
        _robotPicure.Location = New Point(_robotPicure.Location.X - 1, _robotPicure.Location.Y)
        _robotPicure.BringToFront()
    End Sub 
    
    Public Function GetBounds() As Rectangle
        Return _robotPicure.Bounds
    End Function
    
    Public Function GetHealth() As Integer
        Return _health
    End Function
End Class


Public Class Bullet
    Private Readonly _combatPower As Integer
    ReadOnly _bulletPicture As New PictureBox
    Private ReadOnly _bulletType As Integer
    Private ReadOnly _firePosition As Point
    Private ReadOnly _level As Short
    Private Readonly _firingIndex As Integer
    
    Public Sub New(bulletType As Integer, firePosition As Point, level As Short, firingIndex AS Integer)
        ' set attributes
        _level = level
        _bulletType = bulletType
        _firePosition = firePosition
        _combatPower = FirstRound.LevelParams(_level).Bullet.Properties(_bulletType).CP
        _firingIndex = firingIndex
        
        UpdateBulletPictureBoxImage(_bulletType)

        With _bulletPicture
            .BackColor = Color.Transparent
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Location = _firePosition
            .Width = 30
            .Height = 30
        End With

        FirstRound.Controls.Add(_bulletPicture)
        _bulletPicture.BringToFront()
    End Sub

    Private Sub UpdateBulletPictureBoxImage(bulletType As Integer)
        Select Case bulletType
            Case 0
                _bulletPicture.Image = My.Resources.步槍兵子彈
            Case 1
                _bulletPicture.Image = My.Resources.魔法藥水
            Case 2
                _bulletPicture.Image = My.Resources.武士劍氣_彩色
            Case 3
                _bulletPicture.Image = My.Resources.木魚
        End Select
    End Sub

    Public Sub MoveForward()
        _bulletPicture.Location = New Point(_bulletPicture.Location.X + 10, _bulletPicture.Location.Y)
        _bulletPicture.BringToFront()
    End Sub

    Public Function GetBounds() As Rectangle
        Return _bulletPicture.Bounds
    End Function

    Public Function GetX() As Integer
        Return _bulletPicture.Location.X
    End Function

    Public Function GetBulletType() As Integer
        Return _bulletType
    End Function
    
    Public Function GetCombatPower() As Integer
        Return _combatPower
    End Function

    Public Function GetFirePosition() As Point
        Return _firePosition
    End Function

    Public Function GetFiringINdex() As Integer
        Return _firingIndex
    End Function
    
    Public Sub RemoveBullet()
        FirstRound.Controls.Remove(_bulletPicture)
        _bulletPicture.Dispose()
        GC.Collect()
    End Sub
End Class