Option Strict On
Option Explicit On

Public Class CustomerDataForm
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'ShowTestData()
        If NameTextBox.Text <> "" Then
            DisplayListBox.Items.Add(NameTextBox.Text)
        Else
            MsgBox("Name is required")
        End If
        DefaultSetup()
    End Sub

    Private Sub DefaultSetup()
        NameTextBox.Text = ""
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
        NameTextBox.Text = DisplayListBox.SelectedItem.ToString
    End Sub

    Private Sub CustomerDataForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayListBox.Items.Add("Jimmy")
        DisplayListBox.Items.Add("Frank")
        DisplayListBox.Items.Add("Nancy")
        DisplayListBox.Items.Add("Bill")
        DisplayListBox.Items.Add("Sally")
    End Sub
End Class
