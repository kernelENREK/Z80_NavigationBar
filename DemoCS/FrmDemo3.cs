using System;
using System.Windows.Forms;
using Z80NavBar;
using Z80NavBar.Themes;

namespace DemoCS
{
    public partial class FrmDemo3 : Form
    {
        public FrmDemo3()
        {
            InitializeComponent();
            z80_Navigation1.SelectedItem += Z80_Navigation1_SelectedItem;
            z80_Navigation1.Initialize(new DemoItems().sample3, new ThemeSelector(Theme.Dark).CurrentTheme);
        }

        private void Z80_Navigation1_SelectedItem(NavBarItem item)
        {
            LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}";
        }

        private void BtnUnselect_Click(object sender, EventArgs e)
        {
            z80_Navigation1.ItemUnselectAll();
        }

        private int fTheme = 0;
        private void BtnSwitchTheme_Click(object sender, EventArgs e)
        {
            if (fTheme == 0)
            {
                z80_Navigation1.SetTheme(new ThemeSelector(Theme.Blue).CurrentTheme);
                fTheme = 1;
            }
            else
            {
                z80_Navigation1.SetTheme(new ThemeSelector(Theme.Dark).CurrentTheme);
                fTheme = 0;
            }
        }
    }
}
