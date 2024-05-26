Public Class RobotProperty
    Public Property Health As Integer
    Public Property CP As Integer
End Class

Public Class RobotParams
    Public Property MovementSpeed As Integer
    Public Property SummonTime As Integer
    Public Property Properties As List(Of RobotProperty)
End Class

Public Class Human
    Public Property Cost As Integer
    Public Property Health As Integer
End Class

Public Class BulletProperty
    Public Property CP As Integer
End Class

Public Class BulletParams
    Public Property Interval As Double
    Public Property Properties As List(Of BulletProperty)
End Class

Public Class LevelParams
    Public Property Robot As RobotParams
    Public Property Human As List(Of Human)
    Public Property Bullet As BulletParams
End Class