using System;
using System.Windows.Forms;
using Z80NavBar;
using Z80NavBar.Themes;

namespace DemoCS
{
    public partial class FrmDemo1 : Form
    {
        public FrmDemo1()
        {
            InitializeComponent();
            z80_Navigation1.SelectedItem += Z80_Navigation1_SelectedItem;
            z80_Navigation1.Initialize(new DemoItems().sample1, new ThemeSelector(Theme.Dark).CurrentTheme);
        }

        private void Z80_Navigation1_SelectedItem(NavBarItem item)
        {
            LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}";
        }

        private int distanceCopy;
        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance > 37)
            {
                distanceCopy = splitContainer1.SplitterDistance;
                splitContainer1.SplitterDistance = 37;
            }
            else
                splitContainer1.SplitterDistance = distanceCopy;
        }
    }
}
