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
        FirstNameTextBox.Text = DisplayListBox.SelectedItem.ToString
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
        LoadCustomerData()
        DisplayCustomerData()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If DisplayListBox.Items.Contains(SearchTextBox.Text) Then
            DisplayListBox.SelectedItem = SearchTextBox.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub LastLabel_Click(sender As Object, e As EventArgs) Handles LastLabel.Click

    End Sub
End Class
