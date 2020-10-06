Public Class Lion
    Inherits Animal
    Private _TailLength As Double
    Private _IsSolitary As Boolean

    Public Sub New(NumMonths As Integer)
        MyBase.New(NumMonths, 0)
    End Sub

    Public Property TailLength As Double
        Get
            Return _TailLength
        End Get
        Set(value As Double)
            _TailLength = value
        End Set
    End Property

    Public Property IsSolitary As Boolean
        Get
            Return _IsSolitary
        End Get
        Set(value As Boolean)
            _IsSolitary = value
        End Set
    End Property
End Class
