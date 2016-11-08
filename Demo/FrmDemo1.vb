Imports Demo.Z80NavBar
Imports Demo.Z80NavBar.Themes

Public Class FrmDemo1
    Public Sub New()
        InitializeComponent()
        Z80_Navigation1.Initialize(New DemoItems().sample1, New ThemeSelector(Theme.Dark).CurrentTheme)
    End Sub

    Private Sub Z80_Navigation1_SelectedItem(item As NavBarItem) Handles Z80_Navigation1.SelectedItem
        LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}"
    End Sub

    Private distanceCopy As Integer
    Private Sub BtnShowHide_Click(sender As Object, e As EventArgs) Handles BtnShowHide.Click
        If (SplitContainer1.SplitterDistance > 37) Then
            distanceCopy = SplitContainer1.SplitterDistance
            SplitContainer1.SplitterDistance = 37
        Else
            SplitContainer1.SplitterDistance = distanceCopy
        End If
    End Sub
End Class