Option Explicit On
Option Strict On
Option Infer Off

Imports System.IO
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Messaging
Imports System.Runtime.Serialization.Formatters.Binary
Imports GridLib

' *****************************************************************
' Team Number: 17
' Team Member 1 Details: Musto, M.C.M (219104286)
' Team Member 2 Details: Bookatz, M.A (220141423)
' Team Member 3 Details: Haag, J.O (220149181)
' Team Member 4 Details: Levin, M (220001291)
' Practical: Team Project
' Class name: frm_Main
' *****************************************************************

Public Class frm_Main

    'File Variables
    Private FS As FileStream

    Private BF As BinaryFormatter
    Private display As BetterGrid

    Private Const FNAME As String = "animals.xyza"

    'Variables for animal
    Private Animals() As Animal

    Private NumberOfAnimals As Integer = 0

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Doing this here because grid object only created in MyBase.Load
        display = New BetterGrid(SomeGrid)
        display.EnterGrid(0, 0, "ID:")
        display.EnterGrid(1, 0, "Diet:")
        display.EnterGrid(2, 0, "Weight:")
        display.EnterGrid(3, 0, "Sightings:")
        display.EnterGrid(4, 0, "Type:")
    End Sub

    'sub routine to serialize derived classes
    Private Sub SerializeFiles()
        FS = New FileStream(FNAME, FileMode.Open, FileAccess.Write)
        BF = New BinaryFormatter()
        For x As Integer = 1 To NumberOfAnimals
            If Animals(x).GetType.ToString() = "GroupProject_Enviro.Lion" Then
                Dim tempLion As Lion
                tempLion = DirectCast(Animals(x), Lion)
                BF.Serialize(FS, tempLion)
            ElseIf Animals(x).GetType.ToString() = "GroupProject_Enviro.Addax" Then
                Dim tempAddax As Addax
                tempAddax = DirectCast(Animals(x), Addax)
                BF.Serialize(FS, tempAddax)
            End If
        Next
        FS.Close()
        BF = Nothing
        FS = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        display.Clear()
        display.EnterGrid(0, 0, "ID:")
        display.EnterGrid(1, 0, "Diet:")
        display.EnterGrid(2, 0, "Weight:")
        display.EnterGrid(3, 0, "Sightings:")
        display.EnterGrid(4, 0, "Type:")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SerializeFiles()
    End Sub

    Private Sub btnDisplayMap_Click(sender As Object, e As EventArgs) Handles btnDisplayMap.Click

    End Sub

    Private Function CheckUnique(ID As String) As Boolean
        Dim x As Integer
        If Animals(0) Is Nothing Then Return True
        For x = 0 To UBound(Animals)
            If ID = Animals(x).ID Then
                Return False
            Else
                Continue For
            End If
        Next x
        Return True
    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim localAnimal As Animal : localAnimal = Nothing
        Dim localID As String : localID = Nothing
        Dim rand As New Random
        Dim x As Integer
        If cbAnimals.Text = vbNullString Then
            Return
        End If
        ReDim Preserve Animals(NumberOfAnimals)
        While Not CheckUnique(localID)
            For x = 0 To 9
                localID += CStr(rand.Next(0, 9))
            Next x
        End While
        Select Case cbAnimals.Text
            Case "Addax"
                Dim localAddax As New Addax(CInt(InputBox("Enter the number of months to track the Addax for.", "Month Handler")))
                Dim check As DialogResult : check = MessageBox.Show("Does the Addax have round worms?", "Worm Check", MessageBoxButtons.YesNo)
                Select Case check
                    Case DialogResult.Yes
                        localAddax.HasRoundWorms = True
                    Case DialogResult.No
                        localAddax.HasRoundWorms = False
                End Select
                localAddax.HornLength = CDbl(InputBox("Enter the length of the Addax's horn.", "Horn Check"))
                localAnimal = DirectCast(localAddax, Animal)
            Case "Lion"
                Dim localLion As New Lion(CInt(InputBox("Enter the number of months to track the Lion for.", "Month Handler")))
                Dim check As DialogResult : check = MessageBox.Show("Is the Lion part of a pride?", "Pride Check", MessageBoxButtons.YesNo)
                Select Case check
                    Case DialogResult.Yes
                        localLion.IsSolitary = False
                    Case DialogResult.No
                        localLion.IsSolitary = True
                End Select
                localLion.TailLength = CDbl(InputBox("Enter the length of the Lion's tail", "Tail Length"))
                localAnimal = DirectCast(localLion, Animal)
        End Select
        For x = 0 To localAnimal.monthTracks
            localAnimal.Sightings(x) = CInt(InputBox($"Enter how many times the animal has been sighted during month {x + 1}", "Month Handler"))
        Next x
Reselect:
        Select Case CInt(InputBox($"Enter the diet code of the animal: {vbNewLine} 0: Carnivore {vbNewLine} 1: Herbivore {vbNewLine} 2: Omnivore"))
            Case DietEnum.Carnivore
                localAnimal.Diet = DietEnum.Carnivore
            Case DietEnum.Herbivore
                localAnimal.Diet = DietEnum.Herbivore
            Case DietEnum.Omnivore
                localAnimal.Diet = DietEnum.Omnivore
            Case Else
                GoTo Reselect
        End Select

        localAnimal.Weight = CDbl(InputBox("Enter the weight of the animal:"))
        localAnimal.ID = localID
        Animals(NumberOfAnimals) = localAnimal
        NumberOfAnimals += 1
    End Sub

    Private Sub PopGrid()
        Dim x, y As Integer
        Dim thing As Animal
        For Each thing In Animals
        Next thing
    End Sub

End Class