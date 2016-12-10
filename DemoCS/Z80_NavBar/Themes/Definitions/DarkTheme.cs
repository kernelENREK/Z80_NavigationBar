using System.Collections.Generic;
using System.Drawing;

namespace Z80NavBar.Themes
{

    /// <summary>
    /// Z80_Navigation control 'Dark' theme
    /// </summary>
    public class DarkTheme : ITheme
    {

        #region ITheme implementation

        public SolidBrush BrushFontItemDisable
        {
            get { return new SolidBrush(Color.DarkGray); }
        }

        public Color ItemDisableBackgroudColor
        {
            get { return Color.LightGray; }
        }

        public Theme ThemeEnum
        {
            get { return Theme.Dark; }
        }

        public Color BackgroundColor(int depth)
        {
            if (depth < GetBackgroundColor.Count)
                return GetBackgroundColor[depth];
            else
                return DEFAULT_BACKGROUND_COLOR_NO_DEPHT;
        }

        public SolidBrush BrushFontHover(int depth)
        {
            if (depth < GetBrushFontHover.Count)
                return GetBrushFontHover[depth];
            else
                return DEFAULT_BRUSH_FONT_HOVER_NO_DEPTH;
        }

        public SolidBrush BrushFontItemNotSelected(int depth)
        {
            if (depth < GetBrushFontItemNotSelected.Count)
                return GetBrushFontItemNotSelected[depth];
            else
                return DEFAULT_BRUSH_FONT_ITEM_NOT_SELECTED_NO_DEPTH;
        }

        public SolidBrush BrushFontItemSelected(int depth)
        {
            if (depth < GetBrushFontItemSelected.Count)
                return GetBrushFontItemSelected[depth];
            else
                return DEFAULT_BRUSH_FONT_ITEM_SELECTED_NO_DEPTH;
        }

        public Color HoverBackgroundColor(int depth)
        {
            if (depth < GetHoverBackgroundColor.Count)
                return GetHoverBackgroundColor[depth];
            else
                return DEFAULT_HOVER_BACKGROUND_COLOR_NO_DEPTH;
        }

        public Color SelectedBackgroundColor(int depth)
        {
            if (depth < GetSelectedBackgroundColor.Count)
                return GetSelectedBackgroundColor[depth];
            else
                return DEFAULT_SELECTED_BACKGROUND_COLOR_NO_DEPTH;
        }

        public Font FontItem(int depth)
        {
            if (depth < GetFontItem.Count)
                return GetFontItem[depth];
            else
                return DEFAULT_FONT_ITEM_NO_DEPTH;
        }

        public Font FontItemSelected(int depth)
        {
            if (depth < GetFontItemNotSelected.Count)
                return GetFontItemNotSelected[depth];
            else
                return DEFAULT_FONT_ITEM_SELECTED_NO_DEPTH;
        }

        #endregion

        #region Theme 'colors'

        private Color DEFAULT_BACKGROUND_COLOR_NO_DEPHT = Color.FromArgb(50, 55, 60);
        private Color DEFAULT_SELECTED_BACKGROUND_COLOR_NO_DEPTH = Color.FromArgb(0, 68, 124);
        private Color DEFAULT_HOVER_BACKGROUND_COLOR_NO_DEPTH = Color.FromArgb(15, 45, 60);
        private SolidBrush DEFAULT_BRUSH_FONT_ITEM_SELECTED_NO_DEPTH = new SolidBrush(Color.White);
        private SolidBrush DEFAULT_BRUSH_FONT_ITEM_NOT_SELECTED_NO_DEPTH = new SolidBrush(Color.DarkGray);
        private SolidBrush DEFAULT_BRUSH_FONT_HOVER_NO_DEPTH = new SolidBrush(Color.FromArgb(0, 185, 235));
        private Font DEFAULT_FONT_ITEM_NO_DEPTH = new Font("Segoe UI", 8.25f, FontStyle.Regular);
        private Font DEFAULT_FONT_ITEM_SELECTED_NO_DEPTH = new Font("Segoe UI", 8.25f, FontStyle.Bold);
        
        // Note: If you want more 'depth' colors/brushes or fonts, just add it on l list of each Getxxxxxxx Property

        private List<Color> GetBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(35, 40, 45));
                l.Add(Color.FromArgb(50, 55, 60));
                l.Add(Color.FromArgb(60, 65, 70));
                l.Add(Color.FromArgb(70, 75, 80));
                l.Add(Color.FromArgb(80, 85, 90));

                return l;
            }
        }

        private List<Color> GetSelectedBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(0, 115, 170));
                l.Add(Color.FromArgb(0, 68, 124));
                l.Add(Color.FromArgb(0, 47, 78));
                l.Add(Color.FromArgb(0, 27, 58));

                return l;
            }
        }

        private List<Color> GetHoverBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(25, 30, 35));
                l.Add(Color.FromArgb(15, 45, 60));
                l.Add(Color.FromArgb(5, 60, 85));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontItemSelected
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();

                l.Add(new SolidBrush(Color.White));
                l.Add(new SolidBrush(Color.FromArgb(220, 220, 220)));
                l.Add(new SolidBrush(Color.FromArgb(180, 190, 200)));
                l.Add(new SolidBrush(Color.FromArgb(160, 170, 180)));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontItemNotSelected
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();

                l.Add(new SolidBrush(Color.White));
                l.Add(new SolidBrush(Color.DarkGray));
                l.Add(new SolidBrush(Color.FromArgb(140, 154, 164)));
                l.Add(new SolidBrush(Color.FromArgb(120, 134, 144)));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontHover
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();

                l.Add(new SolidBrush(Color.FromArgb(0, 185, 235)));
                l.Add(new SolidBrush(Color.FromArgb(0, 125, 215)));
                l.Add(new SolidBrush(Color.FromArgb(30, 155, 15)));

                return l;
            }
        }

        private List<Font> GetFontItem
        {
            get
            {
                List<Font> l = new List<Font>();

                l.Add(new Font("Segoe UI", 10.5f, FontStyle.Regular));
                l.Add(new Font("Segoe UI", 10.5f, FontStyle.Regular));
                l.Add(new Font("Segoe UI", 9.25f, FontStyle.Regular));

                return l;
            }
        }

        private List<Font> GetFontItemNotSelected
        {
            get
            {
                List<Font> l = new List<Font>();

                l.Add(new Font("Segoe UI", 10.5f, FontStyle.Bold));
                l.Add(new Font("Segoe UI", 10.5f, FontStyle.Bold));
                l.Add(new Font("Segoe UI", 9.25f, FontStyle.Bold));

                return l;
            }
        }

        #endregion

    }
}
