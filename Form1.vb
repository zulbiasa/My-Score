Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer
        Dim Result As String

        score = InputBox("Enter score")
        If score >= 0 And score <= 49 Then
            Result = "Failed"
        ElseIf score <= 74 And score >= 50 Then
            Result = "Pass"
        ElseIf score <= 89 And score >= 75 Then
            Result = "Very Good"
        ElseIf score >= 90 And score <= 100 Then
            Result = "Excellent"
        Else
            Result = "Please input your score between 0 - 100"
        End If

        Label1.Text = Result
    End Sub
End Class
