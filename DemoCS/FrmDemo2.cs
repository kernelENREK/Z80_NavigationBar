using System;
using System.Windows.Forms;
using Z80NavBar;
using Z80NavBar.Themes;

namespace DemoCS
{
    public partial class FrmDemo2 : Form
    {
        public FrmDemo2()
        {
            InitializeComponent();
            z80_Navigation1.SelectedItem += Z80_Navigation1_SelectedItem;
            z80_Navigation1.Initialize(new DemoItems().sample2, new ThemeSelector(Theme.Dark).CurrentTheme);
        }
        private void Z80_Navigation1_SelectedItem(NavBarItem item)
        {
            LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}";
        }

        private int auxDemoAdd = 1;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            z80_Navigation1.AddItem(1, $"NewItem #{auxDemoAdd}", 1007 + auxDemoAdd, 30);
            auxDemoAdd += 1;
            BtnAdd.Text = $"Add new Item: Desktop >> NewItem #{auxDemoAdd}";
        }

        private void ChkBoxDisable1_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.ItemChangeEnable(!ChkBoxDisable1.Checked, 1008);
        }

        private void ChkBoxDisableStore_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.ItemChangeEnable(!ChkBoxDisableStore.Checked, 2);
        }

        private void ChkBoxHide2_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.ItemChangeVisibility(!ChkBoxHide2.Checked, 1009);
        }

        private void ChkBoxHideStore_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.ItemChangeVisibility(!ChkBoxHideStore.Checked, 2);
        }

        private void BtnUnselect_Click(object sender, EventArgs e)
        {
            z80_Navigation1.ItemUnselectAll();
        }

        private void BtnSelect1004_Click(object sender, EventArgs e)
        {
            z80_Navigation1.ItemSelect(1004);
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
