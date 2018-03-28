<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCar
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ltvSearchResult = New System.Windows.Forms.ListView()
        Me.colReg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOdometer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 48)
        Me.txtSearch.MaxLength = 99
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(315, 26)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.AutoSize = True
        Me.lblSearchTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTitle.Location = New System.Drawing.Point(151, 9)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(142, 25)
        Me.lblSearchTitle.TabIndex = 4
        Me.lblSearchTitle.Text = "Search Cars"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(334, 218)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 31)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ltvSearchResult
        '
        Me.ltvSearchResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colReg, Me.colMake, Me.colModel, Me.colYear, Me.colOdometer, Me.colCost})
        Me.ltvSearchResult.GridLines = True
        Me.ltvSearchResult.Location = New System.Drawing.Point(12, 92)
        Me.ltvSearchResult.Name = "ltvSearchResult"
        Me.ltvSearchResult.Size = New System.Drawing.Size(421, 111)
        Me.ltvSearchResult.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ltvSearchResult.TabIndex = 16
        Me.ltvSearchResult.UseCompatibleStateImageBehavior = False
        Me.ltvSearchResult.View = System.Windows.Forms.View.Details
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
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(334, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 26)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmSearchCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 277)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.ltvSearchResult)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSearchTitle)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "frmSearchCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents ltvSearchResult As ListView
    Friend WithEvents colReg As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colOdometer As ColumnHeader
    Friend WithEvents colCost As ColumnHeader
    Friend WithEvents btnSearch As Button
End Class
