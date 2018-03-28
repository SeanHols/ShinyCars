<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCar
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
        Me.txtAddReg = New System.Windows.Forms.TextBox()
        Me.txtAddCost = New System.Windows.Forms.TextBox()
        Me.txtAddOdometer = New System.Windows.Forms.TextBox()
        Me.txtAddYear = New System.Windows.Forms.TextBox()
        Me.txtAddModel = New System.Windows.Forms.TextBox()
        Me.txtAddMake = New System.Windows.Forms.TextBox()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblOdometer = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblAddTitle = New System.Windows.Forms.Label()
        Me.btnAddCar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAddReg
        '
        Me.txtAddReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddReg.Location = New System.Drawing.Point(155, 53)
        Me.txtAddReg.MaxLength = 6
        Me.txtAddReg.Name = "txtAddReg"
        Me.txtAddReg.Size = New System.Drawing.Size(147, 26)
        Me.txtAddReg.TabIndex = 0
        '
        'txtAddCost
        '
        Me.txtAddCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCost.Location = New System.Drawing.Point(155, 213)
        Me.txtAddCost.MaxLength = 9
        Me.txtAddCost.Name = "txtAddCost"
        Me.txtAddCost.Size = New System.Drawing.Size(147, 26)
        Me.txtAddCost.TabIndex = 5
        '
        'txtAddOdometer
        '
        Me.txtAddOdometer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddOdometer.Location = New System.Drawing.Point(155, 181)
        Me.txtAddOdometer.MaxLength = 9
        Me.txtAddOdometer.Name = "txtAddOdometer"
        Me.txtAddOdometer.Size = New System.Drawing.Size(147, 26)
        Me.txtAddOdometer.TabIndex = 4
        '
        'txtAddYear
        '
        Me.txtAddYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddYear.Location = New System.Drawing.Point(155, 149)
        Me.txtAddYear.MaxLength = 4
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(147, 26)
        Me.txtAddYear.TabIndex = 3
        '
        'txtAddModel
        '
        Me.txtAddModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddModel.Location = New System.Drawing.Point(155, 117)
        Me.txtAddModel.MaxLength = 15
        Me.txtAddModel.Name = "txtAddModel"
        Me.txtAddModel.Size = New System.Drawing.Size(147, 26)
        Me.txtAddModel.TabIndex = 2
        '
        'txtAddMake
        '
        Me.txtAddMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddMake.Location = New System.Drawing.Point(155, 85)
        Me.txtAddMake.MaxLength = 15
        Me.txtAddMake.Name = "txtAddMake"
        Me.txtAddMake.Size = New System.Drawing.Size(147, 26)
        Me.txtAddMake.TabIndex = 1
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.Location = New System.Drawing.Point(22, 56)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(103, 20)
        Me.lblReg.TabIndex = 6
        Me.lblReg.Text = "Registration: "
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(22, 88)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(52, 20)
        Me.lblMake.TabIndex = 7
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(22, 120)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(56, 20)
        Me.lblModel.TabIndex = 8
        Me.lblModel.Text = "Model:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(22, 216)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(69, 20)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "Cost ($):"
        '
        'lblOdometer
        '
        Me.lblOdometer.AutoSize = True
        Me.lblOdometer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdometer.Location = New System.Drawing.Point(22, 184)
        Me.lblOdometer.Name = "lblOdometer"
        Me.lblOdometer.Size = New System.Drawing.Size(119, 20)
        Me.lblOdometer.TabIndex = 10
        Me.lblOdometer.Text = "Odometer (km):"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(22, 152)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 11
        Me.lblYear.Text = "Year:"
        '
        'lblAddTitle
        '
        Me.lblAddTitle.AutoSize = True
        Me.lblAddTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTitle.Location = New System.Drawing.Point(77, 9)
        Me.lblAddTitle.Name = "lblAddTitle"
        Me.lblAddTitle.Size = New System.Drawing.Size(177, 25)
        Me.lblAddTitle.TabIndex = 12
        Me.lblAddTitle.Text = "Add Car Details"
        '
        'btnAddCar
        '
        Me.btnAddCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCar.Location = New System.Drawing.Point(155, 245)
        Me.btnAddCar.Name = "btnAddCar"
        Me.btnAddCar.Size = New System.Drawing.Size(147, 29)
        Me.btnAddCar.TabIndex = 6
        Me.btnAddCar.Text = "Add Car"
        Me.btnAddCar.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(26, 245)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 29)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmAddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 284)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddCar)
        Me.Controls.Add(Me.lblAddTitle)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblOdometer)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.txtAddMake)
        Me.Controls.Add(Me.txtAddModel)
        Me.Controls.Add(Me.txtAddYear)
        Me.Controls.Add(Me.txtAddOdometer)
        Me.Controls.Add(Me.txtAddCost)
        Me.Controls.Add(Me.txtAddReg)
        Me.Name = "frmAddCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddReg As TextBox
    Friend WithEvents txtAddCost As TextBox
    Friend WithEvents txtAddOdometer As TextBox
    Friend WithEvents txtAddYear As TextBox
    Friend WithEvents txtAddModel As TextBox
    Friend WithEvents txtAddMake As TextBox
    Friend WithEvents lblReg As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblOdometer As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblAddTitle As Label
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnBack As Button
End Class
