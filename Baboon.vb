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
<Serializable()>
Public Class Baboon
    Inherits Animal
    Private _isAgressive As Boolean
    Private _numBabies As Integer

    Public Sub New(NumMonths As Integer, numBabies As Integer)
        MyBase.New(NumMonths, ChildType.Baboon)
        _numBabies = numBabies 'checkBabies() has to happen after _isAgressive is set incase the value gets changed
        checkBabies(numBabies)
    End Sub

    'Changed to sub since it just sets a value.
    'commmit 605ead9
    Private Sub checkBabies(ByVal numBabies As Integer)
        If Not numBabies <= 0 Then
            _isAgressive = True 'all baboons that have babies are agressive
        End If
    End Sub

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
            _numBabies = value
            checkBabies(NumBabies)
        End Set
    End Property

End Class