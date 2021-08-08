<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddContacts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddContacts))
        Me.closeButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Validater = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.countryCodes = New System.Windows.Forms.ComboBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExtraInfoTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Validater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.Black
        Me.closeButton.Location = New System.Drawing.Point(235, 450)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(108, 51)
        Me.closeButton.TabIndex = 7
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.Color.Black
        Me.saveButton.Location = New System.Drawing.Point(43, 450)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(108, 51)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Save"
        Me.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'title
        '
        Me.title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.title.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.FormattingEnabled = True
        Me.title.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms."})
        Me.title.Location = New System.Drawing.Point(17, 107)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(56, 26)
        Me.title.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(90, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter the contact information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-152, 44)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(693, 24)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Title"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Full name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Phone number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Email address"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Date of birth"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Any other information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Validater
        '
        Me.Validater.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Country code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'countryCodes
        '
        Me.countryCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.countryCodes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.countryCodes.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countryCodes.FormattingEnabled = True
        Me.countryCodes.Items.AddRange(New Object() {"India (+91)", "United States (+1)", "Australia (+61)", "Bahamas (+1-242)", "Belgium (+32)", "Japan (+81)"})
        Me.countryCodes.Location = New System.Drawing.Point(17, 184)
        Me.countryCodes.Name = "countryCodes"
        Me.countryCodes.Size = New System.Drawing.Size(156, 25)
        Me.countryCodes.TabIndex = 25
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullNameTextBox.Location = New System.Drawing.Point(83, 107)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(241, 26)
        Me.FullNameTextBox.TabIndex = 28
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(183, 183)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(182, 26)
        Me.PhoneNumberTextBox.TabIndex = 29
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(17, 257)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(344, 26)
        Me.EmailAddressTextBox.TabIndex = 30
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(142, 303)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(133, 26)
        Me.DateOfBirthDateTimePicker.TabIndex = 31
        '
        'ExtraInfoTextBox
        '
        Me.ExtraInfoTextBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraInfoTextBox.Location = New System.Drawing.Point(17, 369)
        Me.ExtraInfoTextBox.Multiline = True
        Me.ExtraInfoTextBox.Name = "ExtraInfoTextBox"
        Me.ExtraInfoTextBox.Size = New System.Drawing.Size(348, 66)
        Me.ExtraInfoTextBox.TabIndex = 32
        '
        'AddContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExtraInfoTextBox)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.countryCodes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a contact"
        CType(Me.Validater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents title As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Validater As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents countryCodes As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents ExtraInfoTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents EmailAddressTextBox As TextBox
End Class
