Option Explicit On
Option Strict On
Option Infer Off

' *****************************************************************
' Team Number: 17
' Team Member 1 Details: Musto, M.C.M (219104286)
' Team Member 2 Details: Bookatz, M.A (220141423)
' Team Member 3 Details: Haag, J.O (220149181)
' Team Member 4 Details: Levin, M (220001291)
' Practical: Team Project
' Class name: Addax
' *****************************************************************
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