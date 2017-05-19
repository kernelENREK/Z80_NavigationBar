Namespace Z80NavBar.Themes

    ''' <summary>
    ''' Z80_Navigation control theme interface
    ''' </summary>
    Public Interface ITheme
        Function BackgroundColor(depth As Integer) As Color
        Function SelectedBackgroundColor(depth As Integer) As Color
        Function HoverBackgroundColor(depth As Integer) As Color
        ReadOnly Property ItemDisableBackgroudColor As Color
        ReadOnly Property BrushFontItemDisable As SolidBrush
        Function BrushFontItemSelected(depth As Integer) As SolidBrush
        Function BrushFontItemNotSelected(depth As Integer) As SolidBrush
        Function BrushFontHover(depth As Integer) As SolidBrush
        Function FontItem(depth As Integer) As Font
        Function FontItemSelected(depth As Integer) As Font
        Function BorderSolidColor(depth As Integer) As Pen
        ReadOnly Property ThemeEnum As Theme
    End Interface

End Namespace
