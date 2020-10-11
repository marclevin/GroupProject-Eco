Option Explicit On
Option Strict On
Option Infer Off

Imports System.IO
Imports System.Net.Http.Headers
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

'Github Repo Link: https://github.com/marclevin/GroupProject-Eco

Public Class frm_Main

    'File Variables
    Private FS As FileStream
    Private Const MapMax_X As Integer = 8
    Private Const MapMax_Y As Integer = 12
    Private BF As BinaryFormatter
    Private display As BetterGrid

    Private totalSight As Double

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
        display.EnterGrid(4, 0, "Months:")
        display.EnterGrid(5, 0, "Type:")
    End Sub

    'sub routine to serialize derived classes
    Private Sub SerializeFiles()
        FS = New FileStream(FNAME, FileMode.OpenOrCreate, FileAccess.Write)
        BF = New BinaryFormatter()
        For x As Integer = 0 To NumberOfAnimals - 1
            Dim tempAnimal As Animal
            tempAnimal = DirectCast(Animals(x), Animal)
            BF.Serialize(FS, tempAnimal)
        Next
        FS.Close()
        BF = Nothing
        FS = Nothing
        MessageBox.Show("Animals recorded.")
    End Sub

    'sub routine to deserialize derived class
    Private Sub DeserializeFiles()
        Dim tempAnimal As Animal
        Dim i As Integer = 0
        'Empty and unbind index
        ReDim Animals(-1)
        FS = New FileStream(FNAME, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        While FS.Position < FS.Length
            tempAnimal = DirectCast(BF.Deserialize(FS), Animal)
            ReDim Preserve Animals(i)
            Animals(i) = tempAnimal
        End While
        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        display.Clear()
        display.EnterGrid(0, 0, "ID:")
        display.EnterGrid(1, 0, "Diet:")
        display.EnterGrid(2, 0, "Weight:")
        display.EnterGrid(3, 0, "Sightings:")
        display.EnterGrid(4, 0, "Months:")
        display.EnterGrid(5, 0, "Type:")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim check As DialogResult : check = MessageBox.Show($"Warning: All unsaved data will be lost.{vbNewLine}Continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If Not check = DialogResult.OK Then
            Return
        End If
        DeserializeFiles()
        PopGrid()
        UpdateInfo()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SerializeFiles()
    End Sub

    Private Sub btnDisplayMap_Click(sender As Object, e As EventArgs) Handles btnDisplayMap.Click
        Dim newMap As New mapInt
        newMap.AnimalMap = Animals
        newMap.displayMap()
        newMap.ShowDialog()
    End Sub

    Private Function CheckUnique(ID As String) As Boolean
        Dim x As Integer
        'Making sure we don't check an empty ID or try and check against an empty array
        If ID Is Nothing Then Return False
        If Animals(0) Is Nothing Then Return True
        For x = 0 To UBound(Animals) - 1
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
        'Making a unique ID for our animal
        While Not CheckUnique(localID)
            localID = ""
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
            Case "Elephant"
                Dim localAge As Integer : localAge = CInt(InputBox("How old is the Elephant?", "Age Handler"))
                Dim localBool As Boolean
                Dim check As DialogResult : check = MessageBox.Show("Are the Elephant's tusks fitted with trackers?", "Tracker Handler", MessageBoxButtons.YesNo)
                Select Case check
                    Case DialogResult.Yes
                        localBool = True
                    Case DialogResult.No
                        localBool = False
                End Select
                Dim localElephant As New Elephant(CInt(InputBox("Enter the number of months to track the Elephant for.", "Month handler")), localAge, localBool)
                localAnimal = DirectCast(localElephant, Animal)

            Case "Baboon"
                Dim numBabies, numMonths As Integer
                numBabies = CInt(InputBox("Enter the number of babies the Baboon has (If Female):", "Baboon handler"))
                numMonths = CInt(InputBox("Enter the number of months to track the Baboon for.", "Baboon Handler"))
                Dim localBaboon As New Baboon(numMonths, numBabies)
                localAnimal = DirectCast(localBaboon, Animal)

        End Select
        For x = 0 To localAnimal.monthTracks
            localAnimal.Sightings(x) = CInt(InputBox($"Enter how many times the animal has been sighted during month {x + 1}", "Month Handler"))
        Next x
        'GoTo Label as we want to be sure the user selects a valid number.
Reselect:
        Select Case CInt(InputBox($"Enter the diet code of the animal: {vbNewLine}0: Carnivore {vbNewLine}1: Herbivore {vbNewLine}2: Omnivore", "Diet Handler"))
            Case DietEnum.Carnivore
                localAnimal.Diet = DietEnum.Carnivore
            Case DietEnum.Herbivore
                localAnimal.Diet = DietEnum.Herbivore
            Case DietEnum.Omnivore
                localAnimal.Diet = DietEnum.Omnivore
            Case Else
                GoTo Reselect
        End Select

        localAnimal.Weight = CDbl(InputBox("Enter the weight of the animal (KG):", "Weight Handler"))
        'Random positions'
        localAnimal.X = rand.Next(0, MapMax_X)
        localAnimal.Y = rand.Next(0, MapMax_Y)
        localAnimal.ID = localID
        Animals(NumberOfAnimals) = localAnimal
        NumberOfAnimals += 1
        PopGrid()
        UpdateInfo()
    End Sub

    Private Sub PopGrid()
        Dim x, i As Integer
        Dim total As Double
        i = 0
        Dim thing As Animal
        Dim localDiet As String : localDiet = vbNullString

        For Each thing In Animals
            total = 0
            Select Case thing.Diet
                Case DietEnum.Carnivore
                    localDiet = "Carnivore"
                Case DietEnum.Herbivore
                    localDiet = "Herbivore"
                Case DietEnum.Omnivore
                    localDiet = "Omnivore"
            End Select
            display.EnterGrid(0, i + 1, thing.ID)
            display.EnterGrid(1, i + 1, localDiet)
            display.EnterGrid(2, i + 1, thing.Weight)
            For x = 0 To thing.monthTracks
                total += thing.Sightings(x)
            Next x
            totalSight = total

            display.EnterGrid(3, i + 1, total)
            display.EnterGrid(4, i + 1, thing.monthTracks + 1)
            display.EnterGrid(5, i + 1, thing.GetType.Name)
            i += 1
        Next thing
    End Sub

    Public Sub UpdateInfo()
        Dim animalLocal As Animal
        Dim cAddax, cLion As Double
        Dim localAddax As Addax
        Dim avgMonths As Double
        Dim localLion As Lion
        Dim localElephant As Elephant
        Dim cElephant As Integer
        Dim localBaboon As Baboon
        Dim cBaboon As Integer
        Dim i As Integer : i = 0
        tbInfo.Clear()
        For Each animalLocal In Animals
            avgMonths += animalLocal.monthTracks + 1
            localAddax = TryCast(animalLocal, Addax)
            If Not localAddax Is Nothing Then
                cAddax += 1
                Continue For
            End If
            localLion = TryCast(animalLocal, Lion)
            If Not localLion Is Nothing Then
                cLion += 1
                Continue For
            End If
            localElephant = TryCast(animalLocal, Elephant)
            If Not localElephant Is Nothing Then
                cElephant += 1
                Continue For
            End If
            localBaboon = TryCast(animalLocal, Baboon)
            If Not localBaboon Is Nothing Then
                cBaboon += 1
                Continue For
            End If
        Next animalLocal

        tbInfo.Text += $"Addax Count: {cAddax & vbNewLine}Lion Count: {cLion & vbNewLine}Baboon Count: {cBaboon & vbNewLine}Elephant Count:{cElephant & vbNewLine}"
        tbInfo.Text += $"Average Sightings: {totalSight / avgMonths}"
    End Sub

End Class