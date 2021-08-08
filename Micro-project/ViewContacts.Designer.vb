<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewContacts
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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsData = New Micro_project.ContactsData()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContactsTableAdapter2 = New Micro_project.ContactsDataTableAdapters.ContactsTableAdapter()
        Me.TableAdapterManager2 = New Micro_project.ContactsDataTableAdapters.TableAdapterManager()
        Me.noContactsLabel = New System.Windows.Forms.Label()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.Black
        Me.closeButton.Location = New System.Drawing.Point(531, 353)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(96, 53)
        Me.closeButton.TabIndex = 8
        Me.closeButton.Text = "Close"
        Me.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.Black
        Me.editButton.Location = New System.Drawing.Point(221, 353)
        Me.editButton.Margin = New System.Windows.Forms.Padding(2)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(96, 53)
        Me.editButton.TabIndex = 9
        Me.editButton.Text = "Edit a contact"
        Me.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.editButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(341, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "All your contacts are stored here."
        '
        'ContactsDataGridView
        '
        Me.ContactsDataGridView.AutoGenerateColumns = False
        Me.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ContactsDataGridView.DataSource = Me.ContactsBindingSource1
        Me.ContactsDataGridView.Location = New System.Drawing.Point(19, 91)
        Me.ContactsDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactsDataGridView.Name = "ContactsDataGridView"
        Me.ContactsDataGridView.Size = New System.Drawing.Size(851, 246)
        Me.ContactsDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contact ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Full name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "phoneNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 130
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "dateOfBirth"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date of birth"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "emailAddress"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Email address"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "extraInfo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Note or extra information"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 200
        '
        'ContactsBindingSource1
        '
        Me.ContactsBindingSource1.DataMember = "Contacts"
        Me.ContactsBindingSource1.DataSource = Me.ContactsData
        '
        'ContactsData
        '
        Me.ContactsData.DataSetName = "ContactsData"
        Me.ContactsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 34)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(904, 24)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'ContactsTableAdapter2
        '
        Me.ContactsTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ContactsTableAdapter = Me.ContactsTableAdapter2
        Me.TableAdapterManager2.UpdateOrder = Micro_project.ContactsDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'noContactsLabel
        '
        Me.noContactsLabel.AutoSize = True
        Me.noContactsLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noContactsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.noContactsLabel.Location = New System.Drawing.Point(254, 184)
        Me.noContactsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.noContactsLabel.Name = "noContactsLabel"
        Me.noContactsLabel.Size = New System.Drawing.Size(441, 21)
        Me.noContactsLabel.TabIndex = 27
        Me.noContactsLabel.Text = "You have no contacts for now, please add some contacts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ViewContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.noContactsLabel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ContactsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.closeButton)
        Me.Font = New System.Drawing.Font("Segoe UI Historic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ViewContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All contacts"
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
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
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ContactsDataGridView As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Public WithEvents ContactsData As ContactsData
    Public WithEvents ContactsBindingSource1 As BindingSource
    Public WithEvents ContactsTableAdapter2 As ContactsDataTableAdapters.ContactsTableAdapter
    Public WithEvents TableAdapterManager2 As ContactsDataTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents noContactsLabel As Label
End Class
