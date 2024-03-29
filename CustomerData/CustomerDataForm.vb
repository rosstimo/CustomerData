﻿Option Strict On
Option Explicit On
Imports System.Drawing.Design

'TODO
'**Add clean customer records to global array
'**display contents of array in listbox "LastName, FirstName"
'**populate textboxes with correct customer data when selected in the list box
'**add filtered data array, display it, index alignment with this array and list box
'**to ensure properly populated text box fields when selecting items in the list box
'
'add filter choices populate combobox with unique sorted choices.
'for example city would have all available cities listed in the combo box.
'selecting a city would populate the listbox with all records matching the selected city.

'update records and save to data file

Public Class CustomerDataForm

    Dim names(9) As String
    Dim customerData(3, 210) As String
    Dim filteredData(3, 210) As String
    Dim currentFile As String

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'ShowTestData()
        If FirstNameTextBox.Text <> "" Then
            DisplayListBox.Items.Add(FirstNameTextBox.Text)
        Else
            MsgBox("Name is required")
        End If
        DefaultSetup()
    End Sub

    Private Sub DefaultSetup()
        FirstNameTextBox.Text = ""
        AllRadioButton.Checked = True
    End Sub

    Private Sub DisplayData()
        For i = LBound(Me.names) To UBound(Me.names)
            If Me.names(i) <> "" Then
                DisplayListBox.Items.Add(Me.names(i))
            End If
        Next
    End Sub

    Sub ShowTestData()
        Dim columnData As String
        Dim rowData As String

        For row = 1 To 12
            For column = 1 To 12
                columnData = CStr(row * column) & " |"
                rowData &= columnData.PadLeft(6)
            Next
            DisplayListBox.Items.Add(rowData)
            rowData = ""
        Next

    End Sub

    Private Sub LoadCustomerData()
        Dim fileName As String = Me.currentFile
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim tempData() As String
        Dim currentRow As Integer

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)

            ' FileOpen(fileNumber, fileName, OpenMode.Input)
            currentRow = 0
            Do Until EOF(fileNumber)
                currentRecord = LineInput(fileNumber)
                tempData = Split(currentRecord, ",")
                Me.customerData(0, currentRow) = Strings.Right(tempData(0), Len(tempData(0)) - 3)
                Me.customerData(1, currentRow) = tempData(1)
                Me.customerData(2, currentRow) = tempData(2)
                Me.customerData(3, currentRow) = tempData(3)
                currentRow += 1
            Loop
            FileClose(fileNumber)
            ReDim Preserve Me.customerData(3, currentRow - 1)
        Catch ex As Exception
            'OpenFileDialog.ShowDialog()
            'fileName = OpenFileDialog.FileName
        End Try
    End Sub

    Private Sub LoadFilteredData()
        Dim filterIndex As Integer
        Dim matchfound As Boolean

        'clear all the previous data from the filtered data array
        ReDim Me.filteredData(3, 210)
        'search all rows of primary data array
        For dataIndex = Me.customerData.GetLowerBound(1) To Me.customerData.GetUpperBound(1)
            matchfound = False
            'search each data field except email for search term
            For field = 0 To 2
                If InStr(customerData(field, dataIndex), SearchTextBox.Text, CompareMethod.Text) > 0 Then
                    matchfound = True
                End If
            Next
            'If match is found add the record to the filtered data array
            'and increment the array index
            If matchfound Then
                Me.filteredData(0, filterIndex) = Me.customerData(0, dataIndex)
                Me.filteredData(1, filterIndex) = Me.customerData(1, dataIndex)
                Me.filteredData(2, filterIndex) = Me.customerData(2, dataIndex)
                Me.filteredData(3, filterIndex) = Me.customerData(3, dataIndex)
                filterIndex += 1
            End If
        Next
        'trim all the empty indexes off the end of filtered data array
        ReDim Preserve Me.filteredData(3, filterIndex - 1)
        'should data display be called here?
        DisplayCustomerData()
    End Sub

    Private Sub DisplayCustomerData()
        Dim currentRow As String

        DisplayListBox.Items.Clear()

        For row = LBound(Me.filteredData) To Me.filteredData.GetUpperBound(1) ' UBound(Me.customerData)
            currentRow = $"{Me.filteredData(1, row)}, {Me.filteredData(0, row)}"
            DisplayListBox.Items.Add(currentRow)
        Next
    End Sub

    '--------------------Event handlers --------------------

    Private Sub CustomerDataForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Text = $"W:{Me.Width}, H:{Me.Height}"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DefaultSetup()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        'FirstNameTextBox.Text = DisplayListBox.SelectedItem.ToString
        Me.Text = DisplayListBox.SelectedIndex.ToString
        FirstNameTextBox.Text = Me.filteredData(0, DisplayListBox.SelectedIndex)
        LastNameTextBox.Text = Me.filteredData(1, DisplayListBox.SelectedIndex)
        CityTextBox.Text = Me.filteredData(2, DisplayListBox.SelectedIndex)
        EmailTextBox.Text = Me.filteredData(3, DisplayListBox.SelectedIndex)
    End Sub

    Private Sub CustomerDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DisplayListBox.Items.Add("Jimmy")
        'DisplayListBox.Items.Add("Frank")
        'DisplayListBox.Items.Add("Nancy")
        'DisplayListBox.Items.Add("Bill")
        'DisplayListBox.Items.Add("Sally")
        'Me.names(0) = "Jimmy"
        'Me.names(1) = "Frank"
        'Me.names(2) = "Nancy"
        'Me.names(3) = "Bill"
        'Me.names(4) = "Sally"
        'DisplayData()
        DefaultSetup()
        Me.currentFile = "../../../Resources/UserData.txt"
        CurrentFileStatusLabel.Text = "UserData.txt"
        LoadCustomerData()
        LoadFilteredData()
        DisplayCustomerData()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'Dim currentRow As String

        'DisplayListBox.Items.Clear()

        'For row = Me.customerData.GetLowerBound(1) To Me.customerData.GetUpperBound(1)
        '    For column = Me.customerData.GetLowerBound(0) To Me.customerData.GetUpperBound(0)
        '        If InStr(Me.customerData(column, row), SearchTextBox.Text) > 0 Then
        '            currentRow = $"{Me.customerData(1, row)},{Me.customerData(0, row)}"
        '            If Not (DisplayListBox.Items.Contains(currentRow)) Then
        '                DisplayListBox.Items.Add(currentRow)
        '            End If
        '        End If
        '    Next
        'Next
        LoadFilteredData()
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        'TODO
        'select city then treat selection as a search term
    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles AllRadioButton.CheckedChanged,
                                                                                       CityRadioButton.CheckedChanged
        Dim column As Integer
        CategoryComboBox.Items.Clear()

        Try
            Select Case True
                Case FirstNameRadioButton.Checked
                    column = 0
                Case LastNameRadioButton.Checked
                    column = 1
                Case CityRadioButton.Checked
                    column = 2
                Case Else
                    CategoryComboBox.Items.Clear()
            End Select
            'don't add empty records or duplicates
            For row = Me.customerData.GetLowerBound(1) To Me.customerData.GetUpperBound(1)
                If Me.customerData(column, row) <> "" And CategoryComboBox.Items.Contains(Me.customerData(column, row)) = False Then
                    CategoryComboBox.Items.Add(Me.customerData(column, row))
                End If
            Next
            CategoryComboBox.Sorted = True
            CategoryComboBox.SelectedText = ""
        Catch ex As Exception
            'TODO
            ' MsgBox($"row:{row}, column:{column}")
            'MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try


    End Sub

    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click
        OpenFileDialog.ShowDialog()
        Me.currentFile = OpenFileDialog.FileName
        CurrentFileStatusLabel.Text = Me.currentFile
        LoadCustomerData()
        DisplayCustomerData()
    End Sub
End Class
