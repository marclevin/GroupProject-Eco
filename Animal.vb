
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
' Class name: frm_Main
' *****************************************************************
Enum Diet
    Carnivore
    Herbivore
    Omnivore
End Enum
Enum ChildType
    'List the types of children possible 
    'this will make reading it from an array of animals easier if you only want to look as say Rhinos
    'as an example 
    Lion
    Rhino
End Enum
<Serializable()>
Public MustInherit Class Animal
    Private _ID As String
    Private _Type As Integer
    Private _Weight As Double
    Private _Diet As Integer
    Private _Sightings() As Integer

    Public Sub New(NumMonths As Integer, ChildType As Integer)
        'NumMonths is the number of months we are recording the number of sightings across
        ReDim _Sightings(NumMonths)
        _Type = ChildType
    End Sub

    Public Property ID As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return _Weight
        End Get
        Set(value As Double)
            If (value <= 0.0) Then
                _Weight = 0.0
            Else
                _Weight = value
            End If
        End Set
    End Property

    Public Property Deit As Integer
        Get
            Return _Diet
        End Get
        Set(value As Integer)
            Select Case (value)
                'used a select case to make it more clear what the selections are
                'we just need to make sure that we set it with integers
                Case Diet.Carnivore
                    _Diet = 1
                Case Diet.Herbivore
                    _Diet = 2
                Case Diet.Omnivore
                    _Diet = 3
            End Select
        End Set
    End Property

    Public Property Sightings(Index As Integer) As Integer
        Get
            Return _Sightings(Index)
        End Get
        Set(value As Integer)
            _Sightings(Index) = value
        End Set
    End Property
End Class
