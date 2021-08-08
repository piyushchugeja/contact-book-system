Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Public Class Edit
    Dim mainObject As New Main
    Dim V As New ViewContacts
    Dim A As New AddContacts
    Dim key As Decimal
    Dim namePattern As Regex = New Regex("^[a-zA-Z-[0-9]]")
    Dim phonePattern As Regex = New Regex("^(\+\d{1,3}[- ]?)?\d{10}$", RegexOptions.Multiline)
    Dim emailPattern As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+")
    Dim mPrintDocument As PrintDocument
    Private Sub formLoad() Handles MyBase.Load
        If (V.ContactsTableAdapter2.GetCount() <= 0) Then
            MsgBox("No data present in database. Add a contact first.", MsgBoxStyle.Critical, "Cannot edit data.")
            If MsgBoxResult.Ok Then
                V.Hide()
                CloseForm()
            End If
        Else
            Try
                key = InputBox("Enter the Contact ID of the contact you want to update.")
                nameLabel.Text = V.ContactsTableAdapter2.GetFullName(key)
                phoneLabel.Text = V.ContactsTableAdapter2.GetPhoneNumber(key)
                DateOfBirthDateTimePicker.Value = V.ContactsTableAdapter2.GetDOB(key)
                emailLabel.Text = V.ContactsTableAdapter2.GetEmail(key)
                extraLabel.Text = V.ContactsTableAdapter2.GetExtra(key)
            Catch Ex As System.InvalidOperationException
                MsgBox("This contact does not exist! Try again later.", MsgBoxStyle.Exclamation, "Invalid Contact ID")
                formLoad()

            Catch Ex As System.InvalidCastException
                CloseForm()
            End Try
        End If
        nameBox.Visible = False
        emailBox.Visible = False
        phoneBox.Visible = False
        extraBox.Visible = False
    End Sub

    Private Sub editName() Handles nameLabel.Click
        nameLabel.Visible = False
        nameBox.Text = nameLabel.Text
        nameBox.Visible = True
        nameBox.Focus()
    End Sub

    Private Sub editNameDone() Handles nameBox.Leave
        nameLabel.Text = nameBox.Text
        nameBox.Visible = False
        nameLabel.Visible = True
    End Sub

    Private Sub editPhone() Handles phoneLabel.Click
        phoneLabel.Visible = False
        phoneBox.Text = phoneLabel.Text
        phoneBox.Visible = True
        phoneBox.Focus()
    End Sub

    Private Sub editPhoneDone() Handles phoneBox.Leave
        phoneLabel.Text = phoneBox.Text
        phoneBox.Visible = False
        phoneLabel.Visible = True
    End Sub

    Private Sub editEmail() Handles emailLabel.Click
        emailLabel.Visible = False
        emailBox.Text = emailLabel.Text
        emailBox.Visible = True
        emailBox.Focus()
    End Sub

    Private Sub editEmailDone() Handles emailBox.Leave
        emailLabel.Text = emailBox.Text
        emailBox.Visible = False
        emailLabel.Visible = True
    End Sub

    Private Sub editExtra() Handles extraLabel.Click
        extraLabel.Visible = False
        extraBox.Text = extraLabel.Text
        extraBox.Visible = True
        extraBox.Focus()
    End Sub

    Private Sub editExtraDone() Handles extraBox.Leave
        extraLabel.Text = extraBox.Text
        extraBox.Visible = False
        extraLabel.Visible = True
    End Sub

    Private Sub updateData() Handles updateButton.Click
        If verifyName(nameLabel.Text) Then
            If verifyPhone(phoneLabel.Text) Then
                If verifyEmail(emailLabel.Text) Then
                    If verifyDOB(DateOfBirthDateTimePicker.Value.Date) Then
                        V.ContactsTableAdapter2.UpdateData(nameLabel.Text, phoneLabel.Text, DateOfBirthDateTimePicker.Value.Date, emailLabel.Text, extraBox.Text, key)
                        MsgBox("The details for " & nameLabel.Text & " have been updated.", MsgBoxStyle.Information, "Edit complete.")
                        If MsgBoxResult.Ok Then
                            CloseForm()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CloseForm() Handles closeButton.Click
        Me.Close()
        mainObject.Show()
    End Sub

    Private Function verifyEmail(ByRef email As String) As Boolean
        If emailPattern.IsMatch(email) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(emailLabel, "Enter a valid email")
            Return False
        End If
    End Function

    Private Function verifyName(ByRef name As String) As Boolean
        If namePattern.IsMatch(name) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(nameLabel, "Enter a valid name, make sure you address them with a title.")
            Return False
        End If
    End Function

    Private Function verifyPhone(ByRef number As String) As Boolean
        If phonePattern.IsMatch(number) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(phoneLabel, "Enter a valid phone number, make sure you have selected the country code.")
            Return False
        End If
    End Function

    Private Function verifyDOB(ByRef DOB As Date) As Boolean
        If DOB > DateTime.Now.Date Then
            Validater.SetError(DateOfBirthDateTimePicker, "Your contact is about to be born?")
            Return False
        Else
            Validater.Clear()
            Return True
        End If
    End Function
End Class