namespace Z80NavBar.Themes
{

    /// <summary>
    /// Z80_Navigation control theme selector
    /// </summary>
    public class ThemeSelector
    {

        public ITheme CurrentTheme;

        public ThemeSelector(Theme theme)
        {
            // Note: If you implement more themes or your own themes, just add CurrentTheme here

            switch (theme)
            {
                case Theme.Dark:
                    CurrentTheme = new DarkTheme();
                    break;
                case Theme.Blue:
                    CurrentTheme = new BlueTheme();
                    break;
            }
        }

    }
}
