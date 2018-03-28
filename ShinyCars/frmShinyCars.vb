Imports System
Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class frmShinyCars
    'Name:          Sean Holschier
    'Date Started:  20/03/18
    'Date Finished: 28/03/18
    'Description:   A program that stores the details of secondhand cars in stock. The program allows you to add cars and search for details within the database.
    'Data Dictionary:   Name: Found         Type: boolean   Size: 1   Scope: local    Description: A flag for when a car matches the search
    '                   Name: FileNum       Type: integer   Size: 3   Scope: global   Description: The file number available for use
    '                   Name: FileName      Type: string    Size: 30  Scope: global   Description: Name of file that stores the car details
    '                   Name: Reg           Type: string    Size: 6   Scope: local    Description: car registration 
    '                   Name: Make          Type: string    Size: 15  Scope: local    Description: car make
    '                   Name: Model         Type: string    Size: 15  Scope: local    Description: car model
    '                   Name: Year          Type: integer   Size: 4   Scope: local    Description: car creation year
    '                   Name: Odometer      Type: real      Size: 6.2 Scope: local    Description: car's odometer in kilometers
    '                   Name: Cost          Type: real      Size: 6.2 Scope: local    Description: car cost
    '                   Name: EnReg         Type: string    Size: 6   Scope: local    Description: car registration (for encryption)
    '                   Name: EnMake        Type: string    Size: 15  Scope: local    Description: car make (for encryption)
    '                   Name: EnModel       Type: string    Size: 15  Scope: local    Description: car model (for encryption)
    '                   Name: EnYear        Type: integer   Size: 4   Scope: local    Description: car creation year (for encryption)
    '                   Name: EnOdometer    Type: real      Size: 6.2 Scope: local    Description: car's odometer in kilometers (for encryption)
    '                   Name: EnCost        Type: real      Size: 6.2 Scope: local    Description: car cost (for encryption)
    '                   Name: TempReg       Type: string    Size: 6   Scope: local    Description: car registration (temporary)
    '                   Name: TempMake      Type: string    Size: 15  Scope: local    Description: car make (temporary)
    '                   Name: TempModel     Type: string    Size: 15  Scope: local    Description: car model (temporary)
    '                   Name: TempYear      Type: integer   Size: 4   Scope: local    Description: car creation year (temporary)
    '                   Name: TempOdometer  Type: real      Size: 6.2 Scope: local    Description: car's odometer in kilometers (temporary)
    '                   Name: TempCost      Type: real      Size: 6.2 Scope: local    Description: car cost (temporary)
    '                   Name: Search        Type: string    Size: 99  Scope: local    Description: What user is searching for    

    Dim FileNum As Integer = FreeFile()                                                                                 'Declares name of file to be used and the file number.
    Dim FileName As String = "ShinyCarsDatabase.txt"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Add As New frmAddCar                                                                                        'Takes user to frmAddCar
        Add.Show()
        Add = Nothing
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Search As New frmSearchCar                                                                                  'Takes user to frmSearchCar
        Search.Show()
        Search = Nothing
        Me.Hide()
    End Sub

    Private Sub frmShinyCars_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Reg, Make, Model, Year, Odometer, Cost As String
        Dim EnReg, EnMake, EnModel, EnYear, EnOdometer, EnCost As String
        Dim Details As ListViewItem
        ltvCars.Items.Clear()
        If Not (File.Exists(FileName)) Then                                                                             'Checks whether file exists. If not, a message comes up and only the add car button is enabled.
            MsgBox("There is no data to read. Please add a new record.")
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
            FileOpen(FileNum, FileName, OpenMode.Input)                                                                 'Decrypts car details from text file.
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
                Details = ltvCars.Items.Add(EnReg)                                                                      'Adds decrypted car details to the listview
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
        End If
    End Sub

    Private Sub frmShinyCars_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End                                                                                                             'If user closes the form then terminate the whole program.
    End Sub
End Class
