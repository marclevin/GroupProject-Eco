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
' Class name: Lion
' *****************************************************************
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
