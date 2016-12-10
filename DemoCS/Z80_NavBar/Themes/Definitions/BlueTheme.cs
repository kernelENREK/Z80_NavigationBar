using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z80NavBar.Themes
{

    /// <summary>
    /// Z80_Navigation control 'Blue' theme
    /// </summary>
    public class BlueTheme : ITheme
    {

        #region ITheme implementation

        public SolidBrush BrushFontItemDisable
        {
            get { return new SolidBrush(Color.LightGray); }
        }

        public Color ItemDisableBackgroudColor
        {
            get { return Color.FromArgb(153, 153, 153); }
        }

        public Theme ThemeEnum
        {
            get { return Theme.Blue; }
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

        private Color DEFAULT_BACKGROUND_COLOR_NO_DEPHT = Color.FromArgb(50, 105, 190);
        private Color DEFAULT_SELECTED_BACKGROUND_COLOR_NO_DEPTH = Color.FromArgb(0, 68, 124);
        private Color DEFAULT_HOVER_BACKGROUND_COLOR_NO_DEPTH = Color.FromArgb(15, 45, 60);
        private SolidBrush DEFAULT_BRUSH_FONT_ITEM_SELECTED_NO_DEPTH = new SolidBrush(Color.White);
        private SolidBrush DEFAULT_BRUSH_FONT_ITEM_NOT_SELECTED_NO_DEPTH = new SolidBrush(Color.DarkGray);
        private SolidBrush DEFAULT_BRUSH_FONT_HOVER_NO_DEPTH = new SolidBrush(Color.FromArgb(54, 239, 124));
        private Font DEFAULT_FONT_ITEM_NO_DEPTH = new Font("Segoe UI", 8.25f, FontStyle.Regular);
        private Font DEFAULT_FONT_ITEM_SELECTED_NO_DEPTH = new Font("Segoe UI", 8.25f, FontStyle.Bold);
        
        // Note: If you want more 'depth' colors/brushes or fonts, just add it on l list of each Getxxxxxxx Property

        private List<Color> GetBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(35, 80, 175));
                l.Add(Color.FromArgb(50, 105, 190));
                l.Add(Color.FromArgb(60, 115, 200));
                l.Add(Color.FromArgb(70, 125, 210));

                return l;
            }
        }

        private List<Color> GetSelectedBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(150, 0, 229));
                l.Add(Color.FromArgb(130, 0, 209));
                l.Add(Color.FromArgb(120, 0, 199));
                l.Add(Color.FromArgb(110, 0, 189));

                return l;
            }
        }

        private List<Color> GetHoverBackgroundColor
        {
            get
            {
                List<Color> l = new List<Color>();
                l.Add(Color.FromArgb(25, 70, 165));
                l.Add(Color.FromArgb(15, 85, 180));
                l.Add(Color.FromArgb(5, 100, 195));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontItemSelected
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();
                l.Add(new SolidBrush(Color.White));
                l.Add(new SolidBrush(Color.FromArgb(180, 190, 200)));
                l.Add(new SolidBrush(Color.FromArgb(160, 170, 180)));
                l.Add(new SolidBrush(Color.FromArgb(150, 160, 170)));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontItemNotSelected
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();
                l.Add(new SolidBrush(Color.FromArgb(230, 230, 230)));
                l.Add(new SolidBrush(Color.FromArgb(180, 190, 200)));
                l.Add(new SolidBrush(Color.FromArgb(160, 170, 180)));
                l.Add(new SolidBrush(Color.FromArgb(150, 160, 170)));

                return l;
            }
        }

        private List<SolidBrush> GetBrushFontHover
        {
            get
            {
                List<SolidBrush> l = new List<SolidBrush>();
                l.Add(new SolidBrush(Color.FromArgb(54, 239, 124)));
                l.Add(new SolidBrush(Color.FromArgb(0, 185, 235)));
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
