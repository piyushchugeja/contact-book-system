Public Class LoadingForm
    Private Sub LoadingForm_Load() Handles MyBase.Load
        loader.Enabled = True
    End Sub

    Private Sub launchApp() Handles loader.Tick
        Dim m As New Main
        loader.Enabled = False
        Me.Hide()
        m.Show()
    End Sub
End Class