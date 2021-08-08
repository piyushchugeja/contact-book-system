<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.extraLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.extraBox = New System.Windows.Forms.TextBox()
        Me.Validater = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Validater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Full name: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(87, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Edit the contact information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-155, 46)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(693, 24)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Phone number: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "E-mail address: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Date of birth: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Extra information:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updateButton
        '
        Me.updateButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.ForeColor = System.Drawing.Color.Black
        Me.updateButton.Location = New System.Drawing.Point(40, 477)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(108, 51)
        Me.updateButton.TabIndex = 23
        Me.updateButton.Text = "Update"
        Me.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.Black
        Me.closeButton.Location = New System.Drawing.Point(219, 477)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(108, 51)
        Me.closeButton.TabIndex = 22
        Me.closeButton.Text = "Cancel"
        Me.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(105, 102)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(88, 18)
        Me.nameLabel.TabIndex = 24
        Me.nameLabel.Text = "Full name"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLabel.Location = New System.Drawing.Point(143, 163)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(127, 18)
        Me.phoneLabel.TabIndex = 25
        Me.phoneLabel.Text = "Phone number"
        Me.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(141, 224)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(52, 18)
        Me.emailLabel.TabIndex = 26
        Me.emailLabel.Text = "Email"
        Me.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(127, 281)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(133, 26)
        Me.DateOfBirthDateTimePicker.TabIndex = 32
        '
        'extraLabel
        '
        Me.extraLabel.AutoSize = True
        Me.extraLabel.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extraLabel.Location = New System.Drawing.Point(12, 382)
        Me.extraLabel.Name = "extraLabel"
        Me.extraLabel.Size = New System.Drawing.Size(48, 18)
        Me.extraLabel.TabIndex = 33
        Me.extraLabel.Text = "Extra"
        Me.extraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameBox
        '
        Me.nameBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.nameBox.Location = New System.Drawing.Point(108, 99)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(245, 26)
        Me.nameBox.TabIndex = 34
        '
        'phoneBox
        '
        Me.phoneBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!)
        Me.phoneBox.Location = New System.Drawing.Point(144, 160)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(209, 26)
        Me.phoneBox.TabIndex = 35
        '
        'emailBox
        '
        Me.emailBox.Font = New System.Drawing.Font("Lucida Fax", 11.0!)
        Me.emailBox.Location = New System.Drawing.Point(144, 221)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(252, 25)
        Me.emailBox.TabIndex = 36
        '
        'extraBox
        '
        Me.extraBox.Font = New System.Drawing.Font("Lucida Fax", 11.0!)
        Me.extraBox.Location = New System.Drawing.Point(14, 380)
        Me.extraBox.Multiline = True
        Me.extraBox.Name = "extraBox"
        Me.extraBox.Size = New System.Drawing.Size(339, 71)
        Me.extraBox.TabIndex = 37
        '
        'Validater
        '
        Me.Validater.ContainerControl = Me
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.extraBox)
        Me.Controls.Add(Me.emailBox)
        Me.Controls.Add(Me.phoneBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.extraLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit your contact"
        CType(Me.Validater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents updateButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents extraLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents phoneBox As TextBox
    Friend WithEvents emailBox As TextBox
    Friend WithEvents extraBox As TextBox
    Friend WithEvents Validater As ErrorProvider
End Class
