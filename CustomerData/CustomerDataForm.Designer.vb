﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.CustomerInfoGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerInfoGroupBox
        '
        Me.CustomerInfoGroupBox.Controls.Add(Me.TextBox3)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Label3)
        Me.CustomerInfoGroupBox.Controls.Add(Me.TextBox2)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Label2)
        Me.CustomerInfoGroupBox.Controls.Add(Me.TextBox1)
        Me.CustomerInfoGroupBox.Controls.Add(Me.Label1)
        Me.CustomerInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.CustomerInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.CustomerInfoGroupBox.Location = New System.Drawing.Point(27, 35)
        Me.CustomerInfoGroupBox.Name = "CustomerInfoGroupBox"
        Me.CustomerInfoGroupBox.Size = New System.Drawing.Size(362, 441)
        Me.CustomerInfoGroupBox.TabIndex = 0
        Me.CustomerInfoGroupBox.TabStop = False
        Me.CustomerInfoGroupBox.Text = "Costomer Information"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(84, 47)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(258, 31)
        Me.NameTextBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(15, 47)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(59, 25)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 31)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 31)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(84, 158)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 31)
        Me.TextBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name"
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
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
