Imports System.Text.RegularExpressions
'Imports System.Data.
Public Class AddContacts
    Dim primaryKey As Integer = 0
    Dim generateNumber As New Random
    Dim V As New ViewContacts
    Dim mainObject As New Main
    Dim namePattern As Regex = New Regex("^[a-zA-Z-[0-9]]")
    Dim phonePattern As Regex = New Regex("^(\+\d{1,3}[- ]?)?\d{10}$", RegexOptions.Multiline)
    Dim emailPattern As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+")
    Private Sub CloseForm() Handles closeButton.Click
        Me.Close()
        mainObject.Show()
    End Sub

    Private Function verifyEmail(ByRef email As String) As Boolean
        If emailPattern.IsMatch(email) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(EmailAddressTextBox, "Enter a valid email")
            Return False
        End If
    End Function

    Private Function verifyName(ByRef name As String) As Boolean
        If namePattern.IsMatch(name) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(FullNameTextBox, "Enter a valid name, make sure you address them with a title.")
            Return False
        End If
    End Function

    Private Function verifyPhone(ByRef number As String) As Boolean
        If phonePattern.IsMatch(number) Then
            Validater.Clear()
            Return True
        Else
            Validater.SetError(PhoneNumberTextBox, "Enter a valid phone number, make sure you have selected the country code.")
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

    Private Function setPhone(phone) As String
        If countryCodes.SelectedIndex = -1 Then
            Return (phone)

        ElseIf countryCodes.SelectedIndex = 0 Then
            Return ("+91 " & phone)

        ElseIf countryCodes.SelectedIndex = 1 Then
            Return ("+1 " & phone)

        ElseIf countryCodes.SelectedIndex = 2 Then
            Return ("+61 " & phone)

        ElseIf countryCodes.SelectedIndex = 3 Then
            Return ("+1-242 " & phone)

        ElseIf countryCodes.SelectedIndex = 4 Then
            Return ("+32 " & phone)

        ElseIf countryCodes.SelectedIndex = 5 Then
            Return ("+81 " & phone)
        End If
    End Function

    Private Sub SaveContact() Handles saveButton.Click
        primaryKey = (generateNumber.Next / 325561)
        If FullNameTextBox.Text = "" Or PhoneNumberTextBox.Text = "" Or EmailAddressTextBox.Text = "" Or DateOfBirthDateTimePicker.Value.Date = DateTime.Now.Date Then
            MsgBox("Enter proper data. Some fields have been left blank or unchecked.", MsgBoxStyle.Critical, "Data incomplete")
        Else
            Dim name As String = title.SelectedItem & " " & FullNameTextBox.Text
            Dim phone As String = setPhone(PhoneNumberTextBox.Text)
            Dim emptyText As String = ""
            If (ExtraInfoTextBox.Text = "") Then
                emptyText = "-"
            End If
            If verifyName(name) Then
                If verifyPhone(phone) Then
                    If verifyEmail(EmailAddressTextBox.Text) Then
                        If verifyDOB(DateOfBirthDateTimePicker.Value.Date) Then
                            Try
                                V.ContactsTableAdapter2.AddData(primaryKey, name, phone, DateOfBirthDateTimePicker.Value.ToString, EmailAddressTextBox.Text, ExtraInfoTextBox.Text & emptyText)
                                MsgBox("The new contact has been added." & vbNewLine & "Contact ID is " & primaryKey & ".", MsgBoxStyle.Information, "Contact saved.")
                                If MsgBoxResult.Ok Then
                                    CloseForm()
                                End If
                            Catch p As System.Data.SqlClient.SqlException
                                primaryKey += 1
                                V.ContactsTableAdapter2.AddData(primaryKey, name, phone, DateOfBirthDateTimePicker.Value.ToString, EmailAddressTextBox.Text, ExtraInfoTextBox.Text)
                                MsgBox("The new contact has been added." & vbNewLine & "Contact ID is " & primaryKey & ".", MsgBoxStyle.Information, "Contact saved.")
                                If MsgBoxResult.Ok Then
                                    CloseForm()
                                End If
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class