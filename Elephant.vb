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
' Class name: Elephant
' *****************************************************************
<Serializable()>
Public Class Elephant
    Inherits Animal
    Private _age As Integer
    Private _tusksHaveTrackers As Boolean

    Public Sub New(NumMonths As Integer, age As Integer, tusksHaveTrackers As Boolean)
        MyBase.New(NumMonths, ChildType.Elephant)
        _age = age
        _tusksHaveTrackers = tusksHaveTrackers
    End Sub

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property TusksHaveTrackers As Boolean
        Get
            Return _tusksHaveTrackers
        End Get
        Set(value As Boolean)
            _tusksHaveTrackers = value
        End Set
    End Property

End Class