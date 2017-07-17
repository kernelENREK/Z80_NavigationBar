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
    public partial class FrmDemoOrion : Form
    {
        const int COLLAPSE_DISTANCE = 36;

        public FrmDemoOrion()
        {
            InitializeComponent();
            z80_Navigation1.SelectedItem += Z80_Navigation1_SelectedItem;
            z80_Navigation1.Initialize(new DemoItems().sample4Orion, new ThemeSelector(Theme.RoyalBlue).CurrentTheme);

            z80_Navigation1.ItemSelect(1); // Default item selected
        }

        private void Z80_Navigation1_SelectedItem(NavBarItem item)
        {
            LblInfo.Text = $"CONTENT SAMPLE -> ID: {item.ID} Text: {item.Text}";
            if (splitContainer1.SplitterDistance == COLLAPSE_DISTANCE) //AutoExpand on child nodes
            {
                switch (item.ID)
                {
                    case 4001:
                    case 4002:
                    case 4003:
                    case 4004:
                        splitContainer1.SplitterDistance = distanceCopy;
                        pictureBox1.Visible = true;
                        pictureCollapse.Location = collapseGizmoLocation;
                        break;
                }
            }
        }

        private int distanceCopy;
        private Point collapseGizmoLocation;
        private void pictureCollapse_Click(object sender, EventArgs e)
        {
            {
                if (splitContainer1.SplitterDistance > COLLAPSE_DISTANCE)
                {
                    collapseGizmoLocation = new Point() { X = pictureCollapse.Location.X, Y = pictureCollapse.Location.Y };
                    distanceCopy = splitContainer1.SplitterDistance;
                    splitContainer1.SplitterDistance = COLLAPSE_DISTANCE;
                    pictureBox1.Visible = false;
                    pictureCollapse.Location = new Point(8, 12);
                }
                else
                {
                    splitContainer1.SplitterDistance = distanceCopy;
                    pictureBox1.Visible = true;
                    pictureCollapse.Location = collapseGizmoLocation;
                }
            }
        }
    }
}
