Imports System
Imports System.IO
Imports System.Text

Public Class frmSearchCar
    Dim FileNum As Integer = FreeFile()
    Dim FileName As String = "ShinyCarsDatabase.txt"
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Back As New frmShinyCars                                                                                    'Takes user to frmShinyCars.
        Back.Show()
        Back = Nothing
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Reg, Make, Model, Year, Odometer, Cost As String
        Dim EnReg, EnMake, EnModel, EnYear, EnOdometer, EnCost As String
        Dim Details As ListViewItem
        Dim Found As Boolean = False
        ltvSearchResult.Items.Clear()
        If Not txtSearch.Text = "" Then                                                                                 'Checks search bar is not empty. Otherwise send message.
            FileOpen(FileNum, FileName, OpenMode.Input)
            Do Until EOF(FileNum)                                                                                       'Decrypts car details from text file.
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
                Dim Search As String = LCase(txtSearch.Text)
                If LCase(EnReg).Contains(Search) = True Or LCase(EnMake).Contains(Search) = True Or LCase(EnModel).Contains(Search) = True Or LCase(EnYear).Contains(Search) = True Or LCase(EnOdometer).Contains(Search) = True Or LCase(EnCost).Contains(Search) = True Then
                    Details = ltvSearchResult.Items.Add(EnReg)                                                          'If car details contain the search text, add to listview.
                    Details.SubItems.Add(EnMake)
                    Details.SubItems.Add(EnModel)
                    Details.SubItems.Add(EnYear)
                    Details.SubItems.Add(EnOdometer)
                    Details.SubItems.Add(EnCost)
                    Found = True
                End If
                EnReg = ""
                EnMake = ""
                EnModel = ""
                EnYear = ""
                EnOdometer = ""
                EnCost = ""
            Loop
            If Found = False Then
                MsgBox("No results found")                                                                              'If no results were found, send message.
            End If
            FileClose(FileNum)
        Else
            MsgBox("Search bar is blank")
        End If
    End Sub

    Private Sub frmSearchCar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End                                                                                                             'If the form is closed then terminate the whole program.
    End Sub
End Class