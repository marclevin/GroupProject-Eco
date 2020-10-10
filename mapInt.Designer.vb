<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mapInt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gridMap = New UJGrid.UJGrid()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gridMap
        '
        Me.gridMap.Cols = 8
        Me.gridMap.FixedCols = 1
        Me.gridMap.FixedRows = 1
        Me.gridMap.Location = New System.Drawing.Point(12, 12)
        Me.gridMap.Name = "gridMap"
        Me.gridMap.Rows = 12
        Me.gridMap.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.gridMap.Size = New System.Drawing.Size(803, 293)
        Me.gridMap.TabIndex = 0
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.Location = New System.Drawing.Point(7, 308)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(135, 125)
        Me.lblKey.TabIndex = 1
        Me.lblKey.Text = "Key:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A = Addax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B = Baboon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E = Elephant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L = Lion"
        '
        'mapInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 456)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.gridMap)
        Me.Name = "mapInt"
        Me.Text = "Map"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridMap As UJGrid.UJGrid
    Friend WithEvents lblKey As Label
End Class
