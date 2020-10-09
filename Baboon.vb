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
' Class name: Baboon
' *****************************************************************
Public Class Baboon
    Inherits Animal
    Private _isAgressive As Boolean
    Private _numBabies As Integer

    Public Sub New(NumMonths As Integer, isAgressive As Boolean, numBabies As Integer)
        MyBase.New(NumMonths, 3)
        Diet = 3
        _isAgressive = isAgressive
        _numBabies = checkBabies(numBabies) 'checkBabies() has to happen after _isAgressive is set incase the value gets changed
    End Sub
    Private Function checkBabies(ByVal numBabies As Integer) As Integer
        If numBabies <= 0 Then
            Return 0
        Else
            _isAgressive = True 'all baboons that have babies are agressive
            Return numBabies
        End If
    End Function

    Public Property IsAgressive As Boolean
        Get
            Return _isAgressive
        End Get
        Set(value As Boolean)
            _isAgressive = value
        End Set
    End Property

    Public Property NumBabies As Integer
        Get
            Return _numBabies
        End Get
        Set(value As Integer)
            _numBabies = checkBabies(value)
        End Set
    End Property
End Class
