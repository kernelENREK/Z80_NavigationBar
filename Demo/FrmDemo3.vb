Imports Demo.Z80NavBar
Imports Demo.Z80NavBar.Themes
Public Class FrmDemo3
    Public Sub New()
        InitializeComponent()
        Z80_Navigation1.Initialize(New DemoItems().sample3, New ThemeSelector(Theme.Dark).CurrentTheme)
    End Sub

    Private Sub Z80_Navigation1_SelectedItem(item As NavBarItem) Handles Z80_Navigation1.SelectedItem
        LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}"
    End Sub

    Private Sub BtnUnselect_Click(sender As Object, e As EventArgs) Handles BtnUnselect.Click
        Z80_Navigation1.ItemUnselectAll()
    End Sub

    Private fTheme As Integer = 0
    Private Sub BtnSwitchTheme_Click(sender As Object, e As EventArgs) Handles BtnSwitchTheme.Click
        If (fTheme = 0) Then
            Z80_Navigation1.SetTheme(New ThemeSelector(Theme.Blue).CurrentTheme)
            fTheme = 1
        Else
            Z80_Navigation1.SetTheme(New ThemeSelector(Theme.Dark).CurrentTheme)
            fTheme = 0
        End If
    End Sub

End Class