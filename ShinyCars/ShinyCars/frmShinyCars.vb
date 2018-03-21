Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Public Class frmShinyCars

    'Name:          Sean Holschier
    'Date Started:  20/03/18
    'Date Finished:
    'Description:   

    Dim FileNum As Integer = FreeFile()
    Dim FileName As String = "ShinyCarsDatabase.txt"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Add As New frmAddCar
        Add.Show()
        Add = Nothing
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Search As New frmSearchCar
        Search.Show()
        Search = Nothing
        Me.Hide()
    End Sub

    Private Sub frmShinyCars_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Reg, Make, Model, Year, Odometer, Cost As String
        Dim EnReg, EnMake, EnModel, EnYear, EnOdometer, EnCost As String
        Dim Details As ListViewItem
        ltvCars.Items.Clear()
        FileOpen(FileNum, FileName, OpenMode.Input)
        Do Until EOF(FileNum)
            Reg = LineInput(FileNum)
            Make = LineInput(FileNum)
            Model = LineInput(FileNum)
            Year = LineInput(FileNum)
            Odometer = LineInput(FileNum)
            Cost = LineInput(FileNum)
            For Each c In Reg
                c = Chr(Asc(c) Xor 12)
                EnReg = EnReg + c
            Next
            For Each c In Make
                c = Chr(Asc(c) Xor 12)
                EnMake = EnMake + c
            Next
            For Each c In Model
                c = Chr(Asc(c) Xor 12)
                EnModel = EnModel + c
            Next
            For Each c In Year
                c = Chr(Asc(c) Xor 12)
                EnYear = EnYear + c
            Next
            For Each c In Odometer
                c = Chr(Asc(c) Xor 12)
                EnOdometer = EnOdometer + c
            Next
            For Each c In Cost
                c = Chr(Asc(c) Xor 12)
                EnCost = EnCost + c
            Next
            Details = ltvCars.Items.Add(EnReg)
            Details.SubItems.Add(EnMake)
            Details.SubItems.Add(EnModel)
            Details.SubItems.Add(EnYear)
            Details.SubItems.Add(EnOdometer)
            Details.SubItems.Add(EnCost)
            EnReg = ""
            EnMake = ""
            EnModel = ""
            EnYear = ""
            EnOdometer = ""
            EnCost = ""
        Loop
        FileClose(FileNum)
    End Sub

    Private Sub frmShinyCars_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class
