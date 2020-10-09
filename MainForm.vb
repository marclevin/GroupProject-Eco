Option Explicit On
Option Strict On
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
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
    Private Const FNAME As String = "220149181.ipb"

    'Variables for animal
    Private Animals() As Animal
    Private NumberOfAnimals As Integer = 0


    Private localFile As FileStream
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        Dim x As Integer
        x += 1
    End Sub

    Private Sub frm_Main_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
