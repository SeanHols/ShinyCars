Imports System
Imports System.IO
Imports System.Text

Public Class frmAddCar
    Dim FileNum As Integer = FreeFile()
    Dim FileName As String = "ShinyCarsDatabase.txt"
    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        If Not (File.Exists(FileName)) Then
            Dim fs As FileStream = File.Create(FileName)
            fs.Close()
        End If
        If Not txtAddReg.Text = "" Or Not txtAddMake.Text = "" Or Not txtAddModel.Text = "" Or Not txtAddYear.Text = "" Or Not txtAddOdometer.Text = "" Or Not txtAddCost.Text = "" Then
            If IsNumeric(txtAddYear.Text) And IsNumeric(txtAddOdometer.Text) And IsNumeric(txtAddCost.Text) Then
                If txtAddOdometer.Text > 0 And txtAddOdometer.Text < 1000000 Then
                    If txtAddCost.Text > 0 And txtAddCost.Text < 1000000 Then
                        Dim EnReg, EnMake, EnModel, EnYear, EnOdometer, EnCost As String
                        Dim TempReg As String = txtAddReg.Text
                        Dim TempMake As String = txtAddMake.Text
                        Dim TempModel As String = txtAddModel.Text
                        Dim TempYear As String = txtAddYear.Text
                        Dim TempOdometer As String = txtAddOdometer.Text
                        Dim TempCost As String = txtAddCost.Text
                        For Each c In TempReg
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
                        FileOpen(FileNum, FileName, OpenMode.Append)
                        PrintLine(FileNum, EnReg + vbCrLf + EnMake + vbCrLf + EnModel + vbCrLf + EnYear + vbCrLf + EnOdometer + vbCrLf + EnCost)
                        FileClose(FileNum)
                        txtAddReg.Text = ""
                        txtAddMake.Text = ""
                        txtAddModel.Text = ""
                        txtAddYear.Text = ""
                        txtAddOdometer.Text = ""
                        txtAddCost.Text = ""
                        Dim Back As New frmShinyCars
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
                MsgBox("Please insert only numbers in Year, Odometer and Cost")
            End If
        Else
            MsgBox("Please insert details")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Back As New frmShinyCars
        Back.Show()
        Back = Nothing
        Me.Hide()
    End Sub

    Private Sub frmAddCar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class