<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShinyCars
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
        Me.ltvCars = New System.Windows.Forms.ListView()
        Me.colReg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOdometer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ltvCars
        '
        Me.ltvCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colReg, Me.colMake, Me.colModel, Me.colYear, Me.colOdometer, Me.colCost})
        Me.ltvCars.GridLines = True
        Me.ltvCars.Location = New System.Drawing.Point(13, 46)
        Me.ltvCars.Name = "ltvCars"
        Me.ltvCars.Size = New System.Drawing.Size(424, 190)
        Me.ltvCars.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ltvCars.TabIndex = 0
        Me.ltvCars.UseCompatibleStateImageBehavior = False
        Me.ltvCars.View = System.Windows.Forms.View.Details
        '
        'colReg
        '
        Me.colReg.Text = "Registration"
        Me.colReg.Width = 70
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 70
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 70
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 50
        '
        'colOdometer
        '
        Me.colOdometer.Text = "Odometer (km)"
        Me.colOdometer.Width = 90
        '
        'colCost
        '
        Me.colCost.Text = "Cost ($)"
        Me.colCost.Width = 70
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(32, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 43)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Car"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(247, 256)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(169, 43)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search Car"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(167, 9)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(127, 25)
        Me.lblMainTitle.TabIndex = 3
        Me.lblMainTitle.Text = "Shiny Cars"
        '
        'frmShinyCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 315)
        Me.Controls.Add(Me.lblMainTitle)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ltvCars)
        Me.Name = "frmShinyCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shiny Cars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltvCars As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents colReg As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colOdometer As ColumnHeader
    Friend WithEvents colCost As ColumnHeader
End Class
