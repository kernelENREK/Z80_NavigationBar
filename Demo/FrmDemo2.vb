Imports Demo.Z80NavBar
Imports Demo.Z80NavBar.Themes

Public Class FrmDemo2
    Public Sub New()
        InitializeComponent()
        Z80_Navigation1.Initialize(New DemoItems().sample2, New ThemeSelector(Theme.Dark).CurrentTheme)
    End Sub

    Private Sub Z80_Navigation1_SelectedItem(item As NavBarItem) Handles Z80_Navigation1.SelectedItem
        LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}"
    End Sub

    Private auxDemoAdd As Integer = 1
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Z80_Navigation1.AddItem(1, $"NewItem #{auxDemoAdd}", 1007 + auxDemoAdd, 30)
        auxDemoAdd += 1
        BtnAdd.Text = $"Add new Item: Desktop >> NewItem #{auxDemoAdd}"
    End Sub

    Private Sub ChkBoxDisable1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxDisable1.CheckedChanged
        Z80_Navigation1.ItemChangeEnable(Not ChkBoxDisable1.Checked, 1008)
    End Sub

    Private Sub ChkBoxDisableStore_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxDisableStore.CheckedChanged
        Z80_Navigation1.ItemChangeEnable(Not ChkBoxDisableStore.Checked, 2)
    End Sub

    Private Sub ChkBoxHide2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxHide2.CheckedChanged
        Z80_Navigation1.ItemChangeVisibility(Not ChkBoxHide2.Checked, 1009)
    End Sub

    Private Sub ChkBoxHideStore_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxHideStore.CheckedChanged
        Z80_Navigation1.ItemChangeVisibility(Not ChkBoxHideStore.Checked, 2)
    End Sub

    Private Sub BtnUnselect_Click(sender As Object, e As EventArgs) Handles BtnUnselect.Click
        Z80_Navigation1.ItemUnselectAll()
    End Sub

    Private Sub BtnSelect1004_Click(sender As Object, e As EventArgs) Handles BtnSelect1004.Click
        Z80_Navigation1.ItemSelect(1004)
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