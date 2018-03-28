Imports System
Imports System.IO
Imports System.Text

Public Class frmAddCar
    Dim FileNum As Integer = FreeFile()                                                                                 'Declares name of file to be used and the file number.
    Dim FileName As String = "ShinyCarsDatabase.txt"
    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        If Not (File.Exists(FileName)) Then                                                                             'Checks whether file exists. If not, the file is created.
            Dim fs As FileStream = File.Create(FileName)
            fs.Close()
        End If
        If Not txtAddReg.Text = "" And Not txtAddMake.Text = "" And Not txtAddModel.Text = "" And Not txtAddYear.Text = "" And Not txtAddOdometer.Text = "" And Not txtAddCost.Text = "" Then
            If IsNumeric(txtAddYear.Text) And IsNumeric(txtAddOdometer.Text) And IsNumeric(txtAddCost.Text) Then        'Validation for all the textboxes.
                If txtAddYear.Text > 1800 Then
                    If txtAddOdometer.Text > 0 And txtAddOdometer.Text < 1000000 Then
                        If txtAddCost.Text > 0 And txtAddCost.Text < 1000000 Then
                            Dim EnReg, EnMake, EnModel, EnYear, EnOdometer, EnCost As String
                            Dim TempReg As String = txtAddReg.Text                                                      'Transfers text in textboxes to variables.
                            Dim TempMake As String = txtAddMake.Text
                            Dim TempModel As String = txtAddModel.Text
                            Dim TempYear As String = txtAddYear.Text
                            Dim TempOdometer As String = txtAddOdometer.Text
                            Dim TempCost As String = txtAddCost.Text
                            For Each c In TempReg                                                                       'Encrypts all the car details.
                                c = Chr(Asc(c) Xor 12)
                                EnReg = EnReg + c
                            Next
                            For Each c In TempMake
                                c = Chr(Asc(c) Xor 12)
                                EnMake = EnMake + c
                            Next
                            For Each c In TempModel
                                c = Chr(Asc(c) Xor 12)
                                EnModel = EnModel + c
                            Next
                            For Each c In TempYear
                                c = Chr(Asc(c) Xor 12)
                                EnYear = EnYear + c
                            Next
                            For Each c In TempOdometer
                                c = Chr(Asc(c) Xor 12)
                                EnOdometer = EnOdometer + c
                            Next
                            For Each c In TempCost
                                c = Chr(Asc(c) Xor 12)
                                EnCost = EnCost + c
                            Next
                            FileOpen(FileNum, FileName, OpenMode.Append)                                                'Writes encrypted car details to text file.
                            PrintLine(FileNum, EnReg + vbCrLf + EnMake + vbCrLf + EnModel + vbCrLf + EnYear + vbCrLf + EnOdometer + vbCrLf + EnCost)
                            FileClose(FileNum)
                            txtAddReg.Text = ""                                                                         'Clears textboxes.
                            txtAddMake.Text = ""
                            txtAddModel.Text = ""
                            txtAddYear.Text = ""
                            txtAddOdometer.Text = ""
                            txtAddCost.Text = ""
                            Dim Back As New frmShinyCars                                                                'Takes user back to frmShinyCars
                            Back.Show()
                            Back = Nothing
                            Me.Hide()
                        Else
                            MsgBox("Please add a cost from 0 to 999999.99")
                        End If
                    Else
                        MsgBox("Please add a distance from 0 to 999999.99")
                    End If
                Else
                    MsgBox("Please add a year above 1800")
                End If
            Else
                MsgBox("Please insert only numbers in Year, Odometer and Cost")
            End If
        Else
            MsgBox("Please insert details")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Back As New frmShinyCars                                                                                    'Takes user back to frmShinyCars
        Back.Show()
        Back = Nothing
        Me.Hide()
    End Sub

    Private Sub frmAddCar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End                                                                                                             'If user closes the form then terminate the whole program.
    End Sub
End Class