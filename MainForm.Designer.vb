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
        Me.grid = New UJGrid.UJGrid()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.FixedCols = 1
        Me.grid.FixedRows = 1
        Me.grid.Location = New System.Drawing.Point(475, 31)
        Me.grid.Name = "grid"
        Me.grid.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grid.Size = New System.Drawing.Size(450, 157)
        Me.grid.TabIndex = 0
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(475, 194)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(97, 24)
        Me.btn_Load.TabIndex = 1
        Me.btn_Load.Text = "Load Data.."
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(578, 194)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(97, 24)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "Save Data.."
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 443)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.grid)
        Me.Name = "frm_Main"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As UJGrid.UJGrid
    Friend WithEvents btn_Load As Button
    Friend WithEvents btn_Save As Button
End Class
