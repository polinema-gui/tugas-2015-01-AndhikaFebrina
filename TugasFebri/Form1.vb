Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.LightGreen Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightGreen

    End Sub
End Class
