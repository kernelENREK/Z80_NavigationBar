using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z80NavBarControl.Z80NavBar;
using Z80NavBarControl.Z80NavBar.Themes;

namespace DemoControlCS
{
    public partial class FrmDemo3 : Form
    {
        public FrmDemo3()
        {
            InitializeComponent();
            z80_Navigation1.SelectedItem += Z80_Navigation1_SelectedItem;
            z80_Navigation1.Initialize(new DemoItems().sample3, new ThemeSelector(Theme.Dark).CurrentTheme);
            z80_Navigation1.ItemSelect(1);
            chkAutoverticalScrollBar.Checked = z80_Navigation1.AutoVerticalScrollBar;
            chkShowItemsBorder.Checked = z80_Navigation1.ShowItemsBorder;
            this.Load += FrmDemo3_Load;
        }

        private void FrmDemo3_Load(object sender, EventArgs e)
        {
            z80_Navigation1.ItemSelect(1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            z80_Navigation1.ItemSelect(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            z80_Navigation1.ItemSelect(12009);
        }

        private void chkAutoverticalScrollBar_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.AutoVerticalScrollBar = chkAutoverticalScrollBar.Checked;
            if (!z80_Navigation1.AutoVerticalScrollBar)
                z80_Navigation1.ItemSelect(1);
        }

        private void chkShowItemsBorder_CheckedChanged(object sender, EventArgs e)
        {
            z80_Navigation1.ShowItemsBorder = chkShowItemsBorder.Checked;
            z80_Navigation1.ItemSelect(1);
        }
    }
}
