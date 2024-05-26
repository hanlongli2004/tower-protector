Public Class GameEnd
    Private Sub GameEnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fromclose(sender As Object, e As EventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub
End Class