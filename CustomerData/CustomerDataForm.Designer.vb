<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDataForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CustomerInfoGroupBox = New GroupBox()
        SelectGroupBox = New GroupBox()
        CityRadioButton = New RadioButton()
        LastNameRadioButton = New RadioButton()
        FirstNameRadioButton = New RadioButton()
        AllRadioButton = New RadioButton()
        EmailTextBox = New TextBox()
        EmailLabel = New Label()
        CityTextBox = New TextBox()
        CityLabel = New Label()
        LastNameTextBox = New TextBox()
        LastLabel = New Label()
        FirstNameTextBox = New TextBox()
        FirstNameLabel = New Label()
        FilterGroupBox = New GroupBox()
        SearchButton = New Button()
        SearchLabel = New Label()
        SearchTextBox = New TextBox()
        CategoryLabel = New Label()
        CategoryComboBox = New ComboBox()
        DisplayGroupBox = New GroupBox()
        DisplayListBox = New ListBox()
        ButtonGroupBox = New GroupBox()
        ClearButton = New Button()
        SubmitButton = New Button()
        ExitButton = New Button()
        MenuStrip1 = New MenuStrip()
        FileTopMenuItem = New ToolStripMenuItem()
        OpenTopMenuItem = New ToolStripMenuItem()
        SaveTopMenuItem = New ToolStripMenuItem()
        ExitTopMenuItem = New ToolStripMenuItem()
        OpenFileDialog = New OpenFileDialog()
        StatusStrip = New StatusStrip()
        CurrentFileStatusLabel = New ToolStripStatusLabel()
        CustomerInfoGroupBox.SuspendLayout()
        SelectGroupBox.SuspendLayout()
        FilterGroupBox.SuspendLayout()
        DisplayGroupBox.SuspendLayout()
        ButtonGroupBox.SuspendLayout()
        MenuStrip1.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' CustomerInfoGroupBox
        ' 
        CustomerInfoGroupBox.Controls.Add(SelectGroupBox)
        CustomerInfoGroupBox.Controls.Add(EmailTextBox)
        CustomerInfoGroupBox.Controls.Add(EmailLabel)
        CustomerInfoGroupBox.Controls.Add(CityTextBox)
        CustomerInfoGroupBox.Controls.Add(CityLabel)
        CustomerInfoGroupBox.Controls.Add(LastNameTextBox)
        CustomerInfoGroupBox.Controls.Add(LastLabel)
        CustomerInfoGroupBox.Controls.Add(FirstNameTextBox)
        CustomerInfoGroupBox.Controls.Add(FirstNameLabel)
        CustomerInfoGroupBox.Location = New Point(19, 26)
        CustomerInfoGroupBox.Margin = New Padding(2)
        CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        CustomerInfoGroupBox.Padding = New Padding(2)
        CustomerInfoGroupBox.Size = New Size(253, 265)
        CustomerInfoGroupBox.TabIndex = 0
        CustomerInfoGroupBox.TabStop = False
        CustomerInfoGroupBox.Text = "Costomer Information"
        ' 
        ' SelectGroupBox
        ' 
        SelectGroupBox.Controls.Add(CityRadioButton)
        SelectGroupBox.Controls.Add(LastNameRadioButton)
        SelectGroupBox.Controls.Add(FirstNameRadioButton)
        SelectGroupBox.Controls.Add(AllRadioButton)
        SelectGroupBox.Location = New Point(10, 127)
        SelectGroupBox.Margin = New Padding(2)
        SelectGroupBox.Name = "SelectGroupBox"
        SelectGroupBox.Padding = New Padding(2)
        SelectGroupBox.Size = New Size(229, 122)
        SelectGroupBox.TabIndex = 8
        SelectGroupBox.TabStop = False
        ' 
        ' CityRadioButton
        ' 
        CityRadioButton.AutoSize = True
        CityRadioButton.Location = New Point(18, 88)
        CityRadioButton.Margin = New Padding(2)
        CityRadioButton.Name = "CityRadioButton"
        CityRadioButton.Size = New Size(46, 19)
        CityRadioButton.TabIndex = 3
        CityRadioButton.TabStop = True
        CityRadioButton.Text = "City"
        CityRadioButton.UseVisualStyleBackColor = True
        ' 
        ' LastNameRadioButton
        ' 
        LastNameRadioButton.AutoSize = True
        LastNameRadioButton.Location = New Point(18, 67)
        LastNameRadioButton.Margin = New Padding(2)
        LastNameRadioButton.Name = "LastNameRadioButton"
        LastNameRadioButton.Size = New Size(81, 19)
        LastNameRadioButton.TabIndex = 2
        LastNameRadioButton.TabStop = True
        LastNameRadioButton.Text = "Last Name"
        LastNameRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FirstNameRadioButton
        ' 
        FirstNameRadioButton.AutoSize = True
        FirstNameRadioButton.Location = New Point(18, 46)
        FirstNameRadioButton.Margin = New Padding(2)
        FirstNameRadioButton.Name = "FirstNameRadioButton"
        FirstNameRadioButton.Size = New Size(82, 19)
        FirstNameRadioButton.TabIndex = 1
        FirstNameRadioButton.TabStop = True
        FirstNameRadioButton.Text = "First Name"
        FirstNameRadioButton.UseVisualStyleBackColor = True
        ' 
        ' AllRadioButton
        ' 
        AllRadioButton.AutoSize = True
        AllRadioButton.Location = New Point(18, 25)
        AllRadioButton.Margin = New Padding(2)
        AllRadioButton.Name = "AllRadioButton"
        AllRadioButton.Size = New Size(39, 19)
        AllRadioButton.TabIndex = 0
        AllRadioButton.TabStop = True
        AllRadioButton.Text = "All"
        AllRadioButton.UseVisualStyleBackColor = True
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(59, 95)
        EmailTextBox.Margin = New Padding(2)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(182, 23)
        EmailTextBox.TabIndex = 7
        ' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.Location = New Point(10, 95)
        EmailLabel.Margin = New Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(36, 15)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email"
        ' 
        ' CityTextBox
        ' 
        CityTextBox.Location = New Point(59, 73)
        CityTextBox.Margin = New Padding(2)
        CityTextBox.Name = "CityTextBox"
        CityTextBox.Size = New Size(182, 23)
        CityTextBox.TabIndex = 5
        ' 
        ' CityLabel
        ' 
        CityLabel.AutoSize = True
        CityLabel.Location = New Point(10, 73)
        CityLabel.Margin = New Padding(2, 0, 2, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New Size(28, 15)
        CityLabel.TabIndex = 4
        CityLabel.Text = "City"
        ' 
        ' LastNameTextBox
        ' 
        LastNameTextBox.Location = New Point(59, 50)
        LastNameTextBox.Margin = New Padding(2)
        LastNameTextBox.Name = "LastNameTextBox"
        LastNameTextBox.Size = New Size(182, 23)
        LastNameTextBox.TabIndex = 3
        ' 
        ' LastLabel
        ' 
        LastLabel.AutoSize = True
        LastLabel.Location = New Point(10, 50)
        LastLabel.Margin = New Padding(2, 0, 2, 0)
        LastLabel.Name = "LastLabel"
        LastLabel.Size = New Size(28, 15)
        LastLabel.TabIndex = 2
        LastLabel.Text = "Last"
        ' 
        ' FirstNameTextBox
        ' 
        FirstNameTextBox.Location = New Point(59, 28)
        FirstNameTextBox.Margin = New Padding(2)
        FirstNameTextBox.Name = "FirstNameTextBox"
        FirstNameTextBox.Size = New Size(182, 23)
        FirstNameTextBox.TabIndex = 1
        ' 
        ' FirstNameLabel
        ' 
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New Point(10, 28)
        FirstNameLabel.Margin = New Padding(2, 0, 2, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New Size(29, 15)
        FirstNameLabel.TabIndex = 0
        FirstNameLabel.Text = "First"
        ' 
        ' FilterGroupBox
        ' 
        FilterGroupBox.Controls.Add(SearchButton)
        FilterGroupBox.Controls.Add(SearchLabel)
        FilterGroupBox.Controls.Add(SearchTextBox)
        FilterGroupBox.Controls.Add(CategoryLabel)
        FilterGroupBox.Controls.Add(CategoryComboBox)
        FilterGroupBox.Location = New Point(276, 26)
        FilterGroupBox.Margin = New Padding(2)
        FilterGroupBox.Name = "FilterGroupBox"
        FilterGroupBox.Padding = New Padding(2)
        FilterGroupBox.Size = New Size(417, 67)
        FilterGroupBox.TabIndex = 1
        FilterGroupBox.TabStop = False
        FilterGroupBox.Text = "Filter"
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(278, 11)
        SearchButton.Margin = New Padding(2)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(70, 23)
        SearchButton.TabIndex = 1
        SearchButton.Text = "&Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' SearchLabel
        ' 
        SearchLabel.AutoSize = True
        SearchLabel.Location = New Point(41, 14)
        SearchLabel.Margin = New Padding(2, 0, 2, 0)
        SearchLabel.Name = "SearchLabel"
        SearchLabel.Size = New Size(42, 15)
        SearchLabel.TabIndex = 3
        SearchLabel.Text = "Search"
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Location = New Point(90, 11)
        SearchTextBox.Margin = New Padding(2)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(185, 23)
        SearchTextBox.TabIndex = 2
        ' 
        ' CategoryLabel
        ' 
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New Point(26, 42)
        CategoryLabel.Margin = New Padding(2, 0, 2, 0)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New Size(55, 15)
        CategoryLabel.TabIndex = 1
        CategoryLabel.Text = "Category"
        ' 
        ' CategoryComboBox
        ' 
        CategoryComboBox.FormattingEnabled = True
        CategoryComboBox.Location = New Point(89, 42)
        CategoryComboBox.Margin = New Padding(2)
        CategoryComboBox.Name = "CategoryComboBox"
        CategoryComboBox.Size = New Size(185, 23)
        CategoryComboBox.TabIndex = 0
        ' 
        ' DisplayGroupBox
        ' 
        DisplayGroupBox.Controls.Add(DisplayListBox)
        DisplayGroupBox.Location = New Point(273, 97)
        DisplayGroupBox.Margin = New Padding(2)
        DisplayGroupBox.Name = "DisplayGroupBox"
        DisplayGroupBox.Padding = New Padding(2)
        DisplayGroupBox.Size = New Size(417, 194)
        DisplayGroupBox.TabIndex = 2
        DisplayGroupBox.TabStop = False
        ' 
        ' DisplayListBox
        ' 
        DisplayListBox.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DisplayListBox.FormattingEnabled = True
        DisplayListBox.ItemHeight = 14
        DisplayListBox.Location = New Point(4, 18)
        DisplayListBox.Margin = New Padding(2)
        DisplayListBox.Name = "DisplayListBox"
        DisplayListBox.Size = New Size(409, 158)
        DisplayListBox.TabIndex = 0
        ' 
        ' ButtonGroupBox
        ' 
        ButtonGroupBox.Controls.Add(ClearButton)
        ButtonGroupBox.Controls.Add(SubmitButton)
        ButtonGroupBox.Controls.Add(ExitButton)
        ButtonGroupBox.Location = New Point(19, 289)
        ButtonGroupBox.Margin = New Padding(2)
        ButtonGroupBox.Name = "ButtonGroupBox"
        ButtonGroupBox.Padding = New Padding(2)
        ButtonGroupBox.Size = New Size(675, 98)
        ButtonGroupBox.TabIndex = 3
        ButtonGroupBox.TabStop = False
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(113, 18)
        ClearButton.Margin = New Padding(2)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(105, 68)
        ClearButton.TabIndex = 2
        ClearButton.Text = "&Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(4, 18)
        SubmitButton.Margin = New Padding(2)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(105, 68)
        SubmitButton.TabIndex = 1
        SubmitButton.Text = "&Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(223, 18)
        ExitButton.Margin = New Padding(2)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(105, 68)
        ExitButton.TabIndex = 0
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileTopMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 1, 0, 1)
        MenuStrip1.Size = New Size(709, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileTopMenuItem
        ' 
        FileTopMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenTopMenuItem, SaveTopMenuItem, ExitTopMenuItem})
        FileTopMenuItem.Name = "FileTopMenuItem"
        FileTopMenuItem.Size = New Size(37, 22)
        FileTopMenuItem.Text = "&File"
        ' 
        ' OpenTopMenuItem
        ' 
        OpenTopMenuItem.Name = "OpenTopMenuItem"
        OpenTopMenuItem.Size = New Size(103, 22)
        OpenTopMenuItem.Text = "&Open"
        ' 
        ' SaveTopMenuItem
        ' 
        SaveTopMenuItem.Name = "SaveTopMenuItem"
        SaveTopMenuItem.Size = New Size(103, 22)
        SaveTopMenuItem.Text = "&Save"
        ' 
        ' ExitTopMenuItem
        ' 
        ExitTopMenuItem.Name = "ExitTopMenuItem"
        ExitTopMenuItem.Size = New Size(103, 22)
        ExitTopMenuItem.Text = "E&xit"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {CurrentFileStatusLabel})
        StatusStrip.Location = New Point(0, 392)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Size = New Size(709, 22)
        StatusStrip.TabIndex = 5
        StatusStrip.Text = "StatusStrip1"
        ' 
        ' CurrentFileStatusLabel
        ' 
        CurrentFileStatusLabel.Name = "CurrentFileStatusLabel"
        CurrentFileStatusLabel.Size = New Size(119, 17)
        CurrentFileStatusLabel.Text = "ToolStripStatusLabel1"
        ' 
        ' CustomerDataForm
        ' 
        AcceptButton = SubmitButton
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ClearButton
        ClientSize = New Size(709, 414)
        Controls.Add(StatusStrip)
        Controls.Add(ButtonGroupBox)
        Controls.Add(DisplayGroupBox)
        Controls.Add(FilterGroupBox)
        Controls.Add(CustomerInfoGroupBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        MaximumSize = New Size(1349, 664)
        Name = "CustomerDataForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer Data"
        CustomerInfoGroupBox.ResumeLayout(False)
        CustomerInfoGroupBox.PerformLayout()
        SelectGroupBox.ResumeLayout(False)
        SelectGroupBox.PerformLayout()
        FilterGroupBox.ResumeLayout(False)
        FilterGroupBox.PerformLayout()
        DisplayGroupBox.ResumeLayout(False)
        ButtonGroupBox.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CustomerInfoGroupBox As GroupBox
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SelectGroupBox As GroupBox
    Friend WithEvents CityRadioButton As RadioButton
    Friend WithEvents LastNameRadioButton As RadioButton
    Friend WithEvents FirstNameRadioButton As RadioButton
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTopMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTopMenuItem As ToolStripMenuItem
    Friend WithEvents ExitTopMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents CurrentFileStatusLabel As ToolStripStatusLabel
End Class
