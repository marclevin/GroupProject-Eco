Public Class Addax
    Inherits Animal
    Private _HornLength As Double
    Private _HasRoundWorms As Boolean
    Public Sub New(NumMonths As Integer)
        MyBase.New(NumMonths, 1)
    End Sub

    Public Property HornLength As Double
        Get
            Return _HornLength
        End Get
        Set(value As Double)
            _HornLength = value
        End Set
    End Property

    Public Property HasRoundWorms As Boolean
        Get
            Return _HasRoundWorms
        End Get
        Set(value As Boolean)
            _HasRoundWorms = value
        End Set
    End Property
End Class
