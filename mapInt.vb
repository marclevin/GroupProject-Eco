Option Explicit On
Option Strict On
Option Infer Off
Imports System.Runtime.InteropServices
Imports System.Xml
Imports GridLib

' *****************************************************************
' Team Number: 17
' Team Member 1 Details: Musto, M.C.M (219104286)
' Team Member 2 Details: Bookatz, M.A (220141423)
' Team Member 3 Details: Haag, J.O (220149181)
' Team Member 4 Details: Levin, M (220001291)
' Practical: Team Project
' Class name: mapInt
' *****************************************************************

Public Class mapInt
    'This is our map, shows animal locations
    Private _AniMap As Animal()
    Private localG As BetterGrid
    Private Const MapMax_X As Integer = 8
    Private Const MapMax_Y As Integer = 12
    Private Sub mapInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public WriteOnly Property AnimalMap As Animal()
        Set(value As Animal())
            _AniMap = value
        End Set
    End Property

    Public Sub displayMap()
        Dim x As Integer
        Dim animalChar As Char
        Dim rand As New Random
        localG = New BetterGrid(gridMap)
        For x = 0 To UBound(_AniMap)
            Select Case _AniMap(x).GetType
                Case GetType(Lion)
                    animalChar = CChar("L")
                Case GetType(Baboon)
                    animalChar = CChar("B")
                Case GetType(Elephant)
                    animalChar = CChar("E")
                Case GetType(Addax)
                    animalChar = CChar("A")
            End Select
            localG.EnterGrid(_AniMap(x).X, _AniMap(x).Y, animalChar)
        Next x
    End Sub

End Class