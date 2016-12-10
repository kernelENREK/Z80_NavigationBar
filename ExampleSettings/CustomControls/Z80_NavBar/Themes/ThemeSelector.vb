Namespace Z80NavBar.Themes

    ''' <summary>
    ''' Z80_Navigation control theme selector
    ''' </summary>
    Public Class ThemeSelector
        Public CurrentTheme As ITheme

        Public Sub New(theme As Theme)

            ' Note: If you implement more themes or your own themes, just add CurrentTheme here

            Select Case theme
                Case Theme.Dark
                    CurrentTheme = New DarkTheme
                Case Theme.Blue
                    CurrentTheme = New BlueTheme
            End Select
        End Sub

    End Class

End Namespace
