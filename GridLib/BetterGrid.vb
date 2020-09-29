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
' Class name: Bettergrid
' *****************************************************************

Public Class BetterGrid
    Private _Columns, _Rows As Integer
    Private _SetterGrid As UJGrid.UJGrid
    ''' <summary>
    ''' Creates the betterGrid object. This allows easier input to the grid.
    ''' </summary>
    ''' <param name="grid"></param>
    Public Sub New(ByRef grid As UJGrid.UJGrid)
        _Columns = grid.Cols
        _Rows = grid.Rows
        _SetterGrid = grid
    End Sub
    ''' <summary>
    ''' Allows access to the grid.
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <param name="data"></param>
    Public Sub EnterGrid(ByVal x As Integer, ByVal y As Integer, ByVal data As Object)
        If x > _SetterGrid.Cols - 1 Then
            _SetterGrid.Cols = x + 1
        End If
        If y > _SetterGrid.Rows - 1 Then
            _SetterGrid.Rows = y + 1
        End If
        _SetterGrid.Row = y
        _SetterGrid.Col = x
        _SetterGrid.Text = CStr(data)
    End Sub
    ''' <summary>
    ''' This will clear the grid of all data.
    ''' </summary>
    Public Sub Clear()
        Dim x, y As Integer
        For x = 0 To _SetterGrid.Cols - 1
            For y = 0 To _SetterGrid.Rows - 1
                _SetterGrid.Row = y
                _SetterGrid.Col = x
                _SetterGrid.Text = ""
            Next y
        Next x
    End Sub

End Class
