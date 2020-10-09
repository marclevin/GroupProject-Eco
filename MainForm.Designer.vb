<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SomeGrid = New UJGrid.UJGrid()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGrid = New System.Windows.Forms.Label()
        Me.btnDisplayMap = New System.Windows.Forms.Button()
        Me.cbAnimals = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(449, 283)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(203, 35)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Data.."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SomeGrid
        '
        Me.SomeGrid.FixedCols = 1
        Me.SomeGrid.FixedRows = 1
        Me.SomeGrid.Location = New System.Drawing.Point(145, 58)
        Me.SomeGrid.Name = "SomeGrid"
        Me.SomeGrid.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.SomeGrid.Size = New System.Drawing.Size(507, 178)
        Me.SomeGrid.TabIndex = 1
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(12, 178)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(127, 31)
        Me.btnAddNew.TabIndex = 2
        Me.btnAddNew.Text = "Add new Animal"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(449, 242)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(203, 35)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load Data.."
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(145, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(203, 35)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Grid.."
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblGrid
        '
        Me.lblGrid.AutoSize = True
        Me.lblGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid.Location = New System.Drawing.Point(164, 35)
        Me.lblGrid.Name = "lblGrid"
        Me.lblGrid.Size = New System.Drawing.Size(90, 20)
        Me.lblGrid.TabIndex = 5
        Me.lblGrid.Text = "Animal List:"
        '
        'btnDisplayMap
        '
        Me.btnDisplayMap.Location = New System.Drawing.Point(145, 283)
        Me.btnDisplayMap.Name = "btnDisplayMap"
        Me.btnDisplayMap.Size = New System.Drawing.Size(203, 35)
        Me.btnDisplayMap.TabIndex = 6
        Me.btnDisplayMap.Text = "Display Map.."
        Me.btnDisplayMap.UseVisualStyleBackColor = True
        '
        'cbAnimals
        '
        Me.cbAnimals.FormattingEnabled = True
        Me.cbAnimals.Items.AddRange(New Object() {"Addax", "Lion", "temp1", "temp2"})
        Me.cbAnimals.Location = New System.Drawing.Point(12, 215)
        Me.cbAnimals.Name = "cbAnimals"
        Me.cbAnimals.Size = New System.Drawing.Size(127, 21)
        Me.cbAnimals.TabIndex = 7
        '
        'frm_Main
        '
        Me.ClientSize = New System.Drawing.Size(682, 342)
        Me.Controls.Add(Me.cbAnimals)
        Me.Controls.Add(Me.btnDisplayMap)
        Me.Controls.Add(Me.lblGrid)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.SomeGrid)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frm_Main"
        Me.Text = "Willdlife Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As UJGrid.UJGrid
    Friend WithEvents btn_Load As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents SomeGrid As UJGrid.UJGrid
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblGrid As Label
    Friend WithEvents btnDisplayMap As Button
    Friend WithEvents cbAnimals As ComboBox
End Class
