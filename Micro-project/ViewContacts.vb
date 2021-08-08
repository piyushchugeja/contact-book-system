Public Class ViewContacts
    Private Sub closeForm() Handles closeButton.Click
        Dim m As New Main
        Me.Close()
        m.Show()
    End Sub

    Private Sub goToEdit() Handles editButton.Click
        Dim m As New Main
        Me.Close()
        m.launchEdit()
    End Sub

    Private Sub AddAllContactsToTable() Handles MyBase.Load
        Me.ContactsTableAdapter2.Fill(Me.ContactsData.Contacts)
        noContactsLabel.Visible = False
        If Me.ContactsTableAdapter2.GetCount <= 0 Then
            editButton.Visible = False
            closeButton.Location = New Point(414, 353)
            ContactsDataGridView.Visible = False
            noContactsLabel.Visible = True
        End If
    End Sub
End Class