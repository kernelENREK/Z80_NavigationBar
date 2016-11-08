Public Class FrmMain
    Private Sub BtnDemo1_Click(sender As Object, e As EventArgs) Handles BtnDemo1.Click
        Dim f As FrmDemo1 = New FrmDemo1()
        f.ShowDialog()
    End Sub

    Private Sub BtnDemo2_Click(sender As Object, e As EventArgs) Handles BtnDemo2.Click
        Dim f As FrmDemo2 = New FrmDemo2()
        f.ShowDialog()
    End Sub

    Private Sub BtnDemo3_Click(sender As Object, e As EventArgs) Handles BtnDemo3.Click
        Dim f As FrmDemo3 = New FrmDemo3()
        f.ShowDialog()
    End Sub
End Class