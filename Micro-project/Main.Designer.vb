<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.viewAllButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.logoBox = New System.Windows.Forms.PictureBox()
        Me.deleteLogo = New System.Windows.Forms.PictureBox()
        Me.updateLogo = New System.Windows.Forms.PictureBox()
        Me.addLogo = New System.Windows.Forms.PictureBox()
        Me.viewLogo = New System.Windows.Forms.PictureBox()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 130)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(693, 22)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(285, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage all your contacts," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " at one place"
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.SeaShell
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(13, 286)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(138, 58)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add a contact"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'updateButton
        '
        Me.updateButton.BackColor = System.Drawing.Color.SeaShell
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.updateButton.Location = New System.Drawing.Point(174, 286)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(138, 58)
        Me.updateButton.TabIndex = 3
        Me.updateButton.Text = "Edit a contact"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.SeaShell
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.deleteButton.Location = New System.Drawing.Point(339, 286)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(138, 58)
        Me.deleteButton.TabIndex = 4
        Me.deleteButton.Text = "Delete a contact"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'viewAllButton
        '
        Me.viewAllButton.BackColor = System.Drawing.Color.SeaShell
        Me.viewAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewAllButton.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewAllButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.viewAllButton.Location = New System.Drawing.Point(508, 286)
        Me.viewAllButton.Name = "viewAllButton"
        Me.viewAllButton.Size = New System.Drawing.Size(138, 58)
        Me.viewAllButton.TabIndex = 5
        Me.viewAllButton.Text = "View all contacts"
        Me.viewAllButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.SeaShell
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.exitButton.Image = Global.Micro_project.My.Resources.Resources._6
        Me.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exitButton.Location = New System.Drawing.Point(217, 390)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(209, 67)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "   Exit application  "
        Me.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'logoBox
        '
        Me.logoBox.Image = Global.Micro_project.My.Resources.Resources._1
        Me.logoBox.Location = New System.Drawing.Point(160, 12)
        Me.logoBox.Name = "logoBox"
        Me.logoBox.Size = New System.Drawing.Size(100, 100)
        Me.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoBox.TabIndex = 7
        Me.logoBox.TabStop = False
        '
        'deleteLogo
        '
        Me.deleteLogo.Image = Global.Micro_project.My.Resources.Resources._4
        Me.deleteLogo.Location = New System.Drawing.Point(360, 171)
        Me.deleteLogo.Name = "deleteLogo"
        Me.deleteLogo.Size = New System.Drawing.Size(100, 100)
        Me.deleteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deleteLogo.TabIndex = 8
        Me.deleteLogo.TabStop = False
        '
        'updateLogo
        '
        Me.updateLogo.Image = Global.Micro_project.My.Resources.Resources._3
        Me.updateLogo.Location = New System.Drawing.Point(194, 171)
        Me.updateLogo.Name = "updateLogo"
        Me.updateLogo.Size = New System.Drawing.Size(100, 100)
        Me.updateLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.updateLogo.TabIndex = 9
        Me.updateLogo.TabStop = False
        '
        'addLogo
        '
        Me.addLogo.Image = Global.Micro_project.My.Resources.Resources._2
        Me.addLogo.Location = New System.Drawing.Point(32, 171)
        Me.addLogo.Name = "addLogo"
        Me.addLogo.Size = New System.Drawing.Size(100, 100)
        Me.addLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addLogo.TabIndex = 10
        Me.addLogo.TabStop = False
        '
        'viewLogo
        '
        Me.viewLogo.Image = Global.Micro_project.My.Resources.Resources._5
        Me.viewLogo.Location = New System.Drawing.Point(527, 171)
        Me.viewLogo.Name = "viewLogo"
        Me.viewLogo.Size = New System.Drawing.Size(100, 100)
        Me.viewLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewLogo.TabIndex = 11
        Me.viewLogo.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 482)
        Me.Controls.Add(Me.viewLogo)
        Me.Controls.Add(Me.addLogo)
        Me.Controls.Add(Me.updateLogo)
        Me.Controls.Add(Me.deleteLogo)
        Me.Controls.Add(Me.logoBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.viewAllButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main menu"
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents viewAllButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents logoBox As PictureBox
    Friend WithEvents deleteLogo As PictureBox
    Friend WithEvents updateLogo As PictureBox
    Friend WithEvents addLogo As PictureBox
    Friend WithEvents viewLogo As PictureBox
End Class
