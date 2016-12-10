using System.Drawing;

namespace Z80NavBar.Themes
{

    /// <summary>
    /// Z80_Navigation control theme interface
    /// </summary>
    public interface ITheme
    {
        Color BackgroundColor(int depth);
        Color SelectedBackgroundColor(int depth);
        Color HoverBackgroundColor(int depth);
        Color ItemDisableBackgroudColor { get; }
        SolidBrush BrushFontItemDisable { get; }
        SolidBrush BrushFontItemSelected(int depth);
        SolidBrush BrushFontItemNotSelected(int depth);
        SolidBrush BrushFontHover(int depth);
        Font FontItem(int depth);
        Font FontItemSelected(int depth);
        Theme ThemeEnum { get; }
    }
}

