Option Strict On
Option Explicit On
Imports System.Drawing.Design

'TODO
'**Add clean customer records to global array
'**display contents of array in listbox "LastName, FirstName"
'populate textboxes with correct customer data when selected in the list box
'
'add filter choices and search, listbox should only display matches
'
'update records and save to data file

Public Class CustomerDataForm

    Dim names(9) As String
    Dim customerData(3, 210) As String

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
        Dim fileName As String = ""
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim tempData() As String
        Dim currentRow As Integer

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
        Catch ex As Exception
            OpenFileDialog.ShowDialog()
            fileName = OpenFileDialog.FileName
        End Try

        FileOpen(fileNumber, fileName, OpenMode.Input)
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
    End Sub

    Private Sub DisplayCustomerData()
        Dim currentRow As String


        For row = LBound(Me.customerData) To Me.customerData.GetUpperBound(1) ' UBound(Me.customerData)
            currentRow = $"{Me.customerData(1, row)}, {Me.customerData(0, row)}"
            DisplayListBox.Items.Add(currentRow)
        Next
    End Sub

    '--------------------Event handlers --------------------

    Private Sub CustomerDataForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
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
        FirstNameTextBox.Text = Me.customerData(0, DisplayListBox.SelectedIndex)
        LastNameTextBox.Text = Me.customerData(1, DisplayListBox.SelectedIndex)
        CityTextBox.Text = Me.customerData(2, DisplayListBox.SelectedIndex)
        EmailTextBox.Text = Me.customerData(3, DisplayListBox.SelectedIndex)
    End Sub

    Private Sub CustomerDataForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        LoadCustomerData()
        DisplayCustomerData()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim currentRow As String

        DisplayListBox.Items.Clear()

        For row = Me.customerData.GetLowerBound(1) To Me.customerData.GetUpperBound(1)
            For column = Me.customerData.GetLowerBound(0) To Me.customerData.GetUpperBound(0)
                If InStr(Me.customerData(column, row), SearchTextBox.Text) > 0 Then
                    currentRow = $"{Me.customerData(1, row)},{Me.customerData(0, row)}"
                    If Not (DisplayListBox.Items.Contains(currentRow)) Then
                        DisplayListBox.Items.Add(currentRow)
                    End If
                End If
            Next
        Next

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
End Class
