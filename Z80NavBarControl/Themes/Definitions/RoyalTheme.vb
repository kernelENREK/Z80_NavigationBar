Namespace Z80NavBar.Themes

    Public Class RoyalTheme
        Implements ITheme

#Region "ITheme implementation"

        Public ReadOnly Property BrushFontItemDisable As SolidBrush Implements ITheme.BrushFontItemDisable
            Get
                Return New SolidBrush(Color.DarkGray)
            End Get
        End Property

        Public ReadOnly Property ItemDisableBackgroudColor As Color Implements ITheme.ItemDisableBackgroudColor
            Get
                Return Color.LightGray
            End Get
        End Property

        Public ReadOnly Property ThemeEnum As Theme Implements ITheme.ThemeEnum
            Get
                Return Theme.RoyalBlue
            End Get
        End Property

        Public Function BackgroundColor(depth As Integer) As Color Implements ITheme.BackgroundColor
            If (depth < GetBackgroundColor.Count) Then
                Return GetBackgroundColor(depth)
            Else
                Return DEFAULT_BACKGROUND_COLOR_NO_DEPTH
            End If
        End Function

        Public Function BrushFontHover(depth As Integer) As SolidBrush Implements ITheme.BrushFontHover
            If (depth < GetBrushFontHover.Count) Then
                Return GetBrushFontHover(depth)
            Else
                Return DEFAULT_BRUSH_FONT_HOVER_NO_DEPTH
            End If
        End Function

        Public Function BrushFontItemNotSelected(depth As Integer) As SolidBrush Implements ITheme.BrushFontItemNotSelected
            If (depth < GetBrushFontItemNotSelected.Count) Then
                Return GetBrushFontItemNotSelected(depth)
            Else
                Return DEFAULT_BRUSH_FONT_ITEM_NOT_SELECTED_NO_DEPTH
            End If
        End Function

        Public Function BrushFontItemSelected(depth As Integer) As SolidBrush Implements ITheme.BrushFontItemSelected
            If (depth < GetBrushFontItemSelected.Count) Then
                Return GetBrushFontItemSelected(depth)
            Else
                Return DEFAULT_BRUSH_FONT_ITEM_SELECTED_NO_DEPTH
            End If
        End Function

        Public Function HoverBackgroundColor(depth As Integer) As Color Implements ITheme.HoverBackgroundColor
            If (depth < GetHoverBackgroundColor.Count) Then
                Return GetHoverBackgroundColor(depth)
            Else
                Return DEFAULT_HOVER_BACKGROUND_COLOR_NO_DEPTH
            End If
        End Function

        Public Function SelectedBackgroundColor(depth As Integer) As Color Implements ITheme.SelectedBackgroundColor
            If (depth < GetSelectedBackgroundColor.Count) Then
                Return GetSelectedBackgroundColor(depth)
            Else
                Return DEFAULT_SELECTED_BACKGROUND_COLOR_NO_DEPTH
            End If
        End Function

        Public Function FontItem(depth As Integer) As Font Implements ITheme.FontItem
            If (depth < GetFontItem.Count) Then
                Return GetFontItem(depth)
            Else
                Return DEFAULT_FONT_ITEM_NO_DEPTH
            End If
        End Function

        Public Function FontItemSelected(depth As Integer) As Font Implements ITheme.FontItemSelected
            If (depth < GetFontItemNotSelected.Count) Then
                Return GetFontItemNotSelected(depth)
            Else
                Return DEFAULT_FONT_ITEM_SELECTED_NO_DEPTH
            End If
        End Function

        Public Function BorderSolidColor(depth As Integer) As Pen Implements ITheme.BorderSolidColor
            If (depth < GetFontItemNotSelected.Count) Then
                Return GetPenBorderSolidColor(depth)
            Else
                Return DEFAULT_PEN_BORDER_NO_DEPTH
            End If
        End Function

#End Region

#Region "Theme 'colors'"

        Private DEFAULT_BACKGROUND_COLOR_NO_DEPTH As Color = Color.FromArgb(26, 32, 40)
        Private DEFAULT_SELECTED_BACKGROUND_COLOR_NO_DEPTH As Color = Color.FromArgb(0, 102, 204)
        Private DEFAULT_HOVER_BACKGROUND_COLOR_NO_DEPTH As Color = Color.FromArgb(15, 45, 60)
        Private DEFAULT_BRUSH_FONT_ITEM_SELECTED_NO_DEPTH As SolidBrush = New SolidBrush(Color.White)
        Private DEFAULT_BRUSH_FONT_ITEM_NOT_SELECTED_NO_DEPTH As SolidBrush = New SolidBrush(Color.DarkGray)
        Private DEFAULT_BRUSH_FONT_HOVER_NO_DEPTH As SolidBrush = New SolidBrush(Color.FromArgb(0, 185, 235))
        Private DEFAULT_FONT_ITEM_NO_DEPTH As Font = New Font("Segoe UI", 8.25, FontStyle.Regular)
        Private DEFAULT_FONT_ITEM_SELECTED_NO_DEPTH As Font = New Font("Segoe UI", 8.25, FontStyle.Bold)
        Private DEFAULT_PEN_BORDER_NO_DEPTH As Pen = New Pen(Color.DimGray)

        ' Note: If you want more 'depth' colors/brushes or fonts, just add it on l list of each Getxxxxxxx Property

        Private ReadOnly Property GetBackgroundColor As List(Of Color)
            Get
                Dim l As List(Of Color) = New List(Of Color)()
                l.Add(Color.FromArgb(26, 32, 40))
                l.Add(Color.FromArgb(41, 47, 55))
                l.Add(Color.FromArgb(60, 65, 70))
                l.Add(Color.FromArgb(70, 75, 80))
                l.Add(Color.FromArgb(80, 85, 90))

                Return l
            End Get
        End Property

        Private ReadOnly Property GetSelectedBackgroundColor As List(Of Color)
            Get
                Dim l As List(Of Color) = New List(Of Color)()
                l.Add(Color.FromArgb(0, 102, 204))
                l.Add(Color.FromArgb(0, 68, 124))
                l.Add(Color.FromArgb(0, 47, 78))
                l.Add(Color.FromArgb(0, 27, 58))

                Return l
            End Get
        End Property

        Private ReadOnly Property GetHoverBackgroundColor As List(Of Color)
            Get
                Dim l As List(Of Color) = New List(Of Color)()
                l.Add(Color.FromArgb(48, 60, 76))
                l.Add(Color.FromArgb(28, 40, 56))
                l.Add(Color.FromArgb(5, 60, 85))

                Return l
            End Get
        End Property

        Private ReadOnly Property GetBrushFontItemSelected As List(Of SolidBrush)
            Get
                Dim l As List(Of SolidBrush) = New List(Of SolidBrush)()

                l.Add(New SolidBrush(Color.White))
                l.Add(New SolidBrush(Color.FromArgb(255, 255, 255)))
                l.Add(New SolidBrush(Color.FromArgb(180, 190, 200)))
                l.Add(New SolidBrush(Color.FromArgb(160, 170, 180)))
                Return l
            End Get
        End Property

        Private ReadOnly Property GetBrushFontItemNotSelected As List(Of SolidBrush)
            Get
                Dim l As List(Of SolidBrush) = New List(Of SolidBrush)()

                l.Add(New SolidBrush(Color.White))
                l.Add(New SolidBrush(Color.DarkGray))
                l.Add(New SolidBrush(Color.FromArgb(140, 154, 164)))
                l.Add(New SolidBrush(Color.FromArgb(120, 134, 144)))
                Return l
            End Get
        End Property

        Private ReadOnly Property GetBrushFontHover As List(Of SolidBrush)
            Get
                Dim l As List(Of SolidBrush) = New List(Of SolidBrush)()
                l.Add(New SolidBrush(Color.White))
                l.Add(New SolidBrush(Color.FromArgb(0, 112, 224)))
                l.Add(New SolidBrush(Color.FromArgb(0, 125, 215)))
                l.Add(New SolidBrush(Color.FromArgb(30, 155, 15)))
                Return l
            End Get
        End Property

        Private ReadOnly Property GetFontItem As List(Of Font)
            Get
                Dim l As List(Of Font) = New List(Of Font)()

                l.Add(New Font("Segoe UI", 10.5, FontStyle.Regular))
                l.Add(New Font("Segoe UI", 10.5, FontStyle.Regular))
                l.Add(New Font("Segoe UI", 9.25, FontStyle.Regular))
                Return l
            End Get
        End Property

        Private ReadOnly Property GetFontItemNotSelected As List(Of Font)
            Get
                Dim l As List(Of Font) = New List(Of Font)()

                l.Add(New Font("Segoe UI", 10.5, FontStyle.Regular))
                l.Add(New Font("Segoe UI", 10.5, FontStyle.Regular))
                l.Add(New Font("Segoe UI", 9.25, FontStyle.Regular))
                Return l
            End Get
        End Property

        Private ReadOnly Property GetPenBorderSolidColor As List(Of Pen)
            Get
                Dim l As List(Of Pen) = New List(Of Pen)()

                l.Add(New Pen(Color.FromArgb(35 * 2, 40 * 2, 45 * 2)))
                l.Add(New Pen(Color.FromArgb(50 * 2, 50 * 2, 60 * 2)))
                l.Add(New Pen(Color.FromArgb(60 * 2, 65 * 2, 70 * 2)))
                l.Add(New Pen(Color.FromArgb(70 * 2, 75 * 2, 80 * 2)))
                l.Add(New Pen(Color.FromArgb(80 * 2, 85 * 2, 90 * 2)))
                Return l
            End Get
        End Property

#End Region

    End Class

End Namespace
