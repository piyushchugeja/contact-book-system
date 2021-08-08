Public Class Main
    Dim V As New ViewContacts
    Dim key As Decimal
    'Private Sub formLoad() Handles MyBase.Load
    '    logoBox.SizeMode = PictureBoxSizeMode.Zoom
    '    addLogo.SizeMode = PictureBoxSizeMode.Zoom
    '    viewLogo.SizeMode = PictureBoxSizeMode.Zoom
    '    updateLogo.SizeMode = PictureBoxSizeMode.Zoom
    '    deleteLogo.SizeMode = PictureBoxSizeMode.Zoom
    '    logoBox.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\1.png")
    '    addLogo.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\2.png")
    '    viewLogo.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\5.png")
    '    updateLogo.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\3.png")
    '    deleteLogo.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\4.png")
    '    exitButton.Image = Image.FromFile("D:\Projects\Programs\4th sem\GAD\Contact management system\images\FirstLogo\6.png")
    'End Sub

    Public Sub ExecuteAdd()
        Dim add As New AddContacts
        add.Show()
        Me.Hide()
    End Sub

    Public Sub launchEdit()
        Dim e As New Edit
        e.Show()
        Me.Hide()
    End Sub

    Private Sub closeForm() Handles exitButton.Click
        Dim c As New Closing
        c.Show()
        Me.Hide()
    End Sub

    Private Sub add() Handles AddButton.Click
        ExecuteAdd()
    End Sub

    Public Sub exitOperation()
        End
    End Sub

    Private Sub executeEdit() Handles updateButton.Click
        launchEdit()
    End Sub

    Private Sub executeView() Handles viewAllButton.Click
        V.Show()
        Me.Hide()
    End Sub

    Private Sub deleteContact() Handles deleteButton.Click
        If (V.ContactsTableAdapter2.GetCount() <= 0) Then
            MsgBox("No data present in database. Add a contact first.", MsgBoxStyle.Critical, "Cannot edit data.")
            If MsgBoxResult.Ok Then
            End If
        Else
            Try
                key = InputBox("Enter the Contact ID of the contact you want to update.")
                MsgBox("Contact of " & V.ContactsTableAdapter2.GetFullName(key) & " has been deleted.", MsgBoxStyle.Information, "Deletion complete")
                V.ContactsTableAdapter2.DeleteContact(key)
            Catch ex As System.InvalidOperationException
                MsgBox("This contact does not exist! Try again later.", MsgBoxStyle.Exclamation, "Invalid Contact ID")
            Catch Ex As System.InvalidCastException
            End Try
        End If
    End Sub

    Private Sub formLoad(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class