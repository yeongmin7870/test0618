

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '으아ㅣ아아아
        Dim dlls = New dllTest.Class1()
        Dim test = dlls.add("코딩 어렵다.")
        Dim Message = String.Empty
        Message = String.Format(TextBox1.Text)
        MessageBox.Show(Message)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

End Class
