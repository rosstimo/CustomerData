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
        Me.CustomerInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.CityRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.CustomerInfoGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SelectGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerInfoGroupBox
        '
        Me.CustomerInfoGroupBox.Controls.Add(Me.SelectGroupBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.EmailTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.EmailLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.CityLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.LastLabel)
        Me.CustomerInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.CustomerInfoGroupBox.Location = New System.Drawing.Point(27, 35)
        Me.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        Me.CustomerInfoGroupBox.Size = New System.Drawing.Size(362, 441)
        Me.CustomerInfoGroupBox.TabIndex = 0
        Me.CustomerInfoGroupBox.TabStop = False
        Me.CustomerInfoGroupBox.Text = "Costomer Information"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(84, 158)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(258, 31)
        Me.EmailTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(15, 158)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(54, 25)
        Me.EmailLabel.TabIndex = 6
        Me.EmailLabel.Text = "Email"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(84, 121)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(258, 31)
        Me.CityTextBox.TabIndex = 5
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(15, 121)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(42, 25)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(84, 84)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(258, 31)
        Me.LastNameTextBox.TabIndex = 3
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(15, 84)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(43, 25)
        Me.LastLabel.TabIndex = 2
        Me.LastLabel.Text = "Last"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(84, 47)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(258, 31)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(15, 47)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(45, 25)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First"
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.SearchButton)
        Me.FilterGroupBox.Controls.Add(Me.SearchLabel)
        Me.FilterGroupBox.Controls.Add(Me.SearchTextBox)
        Me.FilterGroupBox.Controls.Add(Me.CategoryLabel)
        Me.FilterGroupBox.Controls.Add(Me.CategoryComboBox)
        Me.FilterGroupBox.Location = New System.Drawing.Point(395, 35)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(596, 111)
        Me.FilterGroupBox.TabIndex = 1
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(397, 18)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(93, 31)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(58, 24)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(64, 25)
        Me.SearchLabel.TabIndex = 3
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(128, 18)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(263, 31)
        Me.SearchTextBox.TabIndex = 2
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(37, 70)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(84, 25)
        Me.CategoryLabel.TabIndex = 1
        Me.CategoryLabel.Text = "Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(127, 70)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(263, 33)
        Me.CategoryComboBox.TabIndex = 0
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.DisplayListBox)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(395, 152)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(596, 324)
        Me.DisplayGroupBox.TabIndex = 2
        Me.DisplayGroupBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 22
        Me.DisplayListBox.Location = New System.Drawing.Point(6, 30)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(582, 268)
        Me.DisplayListBox.TabIndex = 0
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(27, 482)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(964, 164)
        Me.ButtonGroupBox.TabIndex = 3
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(162, 30)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 114)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 30)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(150, 114)
        Me.SubmitButton.TabIndex = 1
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(318, 30)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(150, 114)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1010, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectGroupBox
        '
        Me.SelectGroupBox.Controls.Add(Me.CityRadioButton)
        Me.SelectGroupBox.Controls.Add(Me.LastNameRadioButton)
        Me.SelectGroupBox.Controls.Add(Me.FirstNameRadioButton)
        Me.SelectGroupBox.Controls.Add(Me.AllRadioButton)
        Me.SelectGroupBox.Location = New System.Drawing.Point(15, 212)
        Me.SelectGroupBox.Name = "SelectGroupBox"
        Me.SelectGroupBox.Size = New System.Drawing.Size(327, 203)
        Me.SelectGroupBox.TabIndex = 8
        Me.SelectGroupBox.TabStop = False
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Location = New System.Drawing.Point(25, 41)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(57, 29)
        Me.AllRadioButton.TabIndex = 0
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'FirstNameRadioButton
        '
        Me.FirstNameRadioButton.AutoSize = True
        Me.FirstNameRadioButton.Location = New System.Drawing.Point(25, 76)
        Me.FirstNameRadioButton.Name = "FirstNameRadioButton"
        Me.FirstNameRadioButton.Size = New System.Drawing.Size(122, 29)
        Me.FirstNameRadioButton.TabIndex = 1
        Me.FirstNameRadioButton.TabStop = True
        Me.FirstNameRadioButton.Text = "First Name"
        Me.FirstNameRadioButton.UseVisualStyleBackColor = True
        '
        'CityRadioButton
        '
        Me.CityRadioButton.AutoSize = True
        Me.CityRadioButton.Location = New System.Drawing.Point(25, 146)
        Me.CityRadioButton.Name = "CityRadioButton"
        Me.CityRadioButton.Size = New System.Drawing.Size(67, 29)
        Me.CityRadioButton.TabIndex = 3
        Me.CityRadioButton.TabStop = True
        Me.CityRadioButton.Text = "City"
        Me.CityRadioButton.UseVisualStyleBackColor = True
        '
        'LastNameRadioButton
        '
        Me.LastNameRadioButton.AutoSize = True
        Me.LastNameRadioButton.Location = New System.Drawing.Point(25, 111)
        Me.LastNameRadioButton.Name = "LastNameRadioButton"
        Me.LastNameRadioButton.Size = New System.Drawing.Size(120, 29)
        Me.LastNameRadioButton.TabIndex = 2
        Me.LastNameRadioButton.TabStop = True
        Me.LastNameRadioButton.Text = "Last Name"
        Me.LastNameRadioButton.UseVisualStyleBackColor = True
        '
        'CustomerDataForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1010, 676)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.CustomerInfoGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "CustomerDataForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Data"
        Me.CustomerInfoGroupBox.ResumeLayout(False)
        Me.CustomerInfoGroupBox.PerformLayout()
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.SelectGroupBox.ResumeLayout(False)
        Me.SelectGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
