using System;
using System.Windows.Forms;

namespace DemoCS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDemo1_Click(object sender, EventArgs e)
        {
            FrmDemo1 f = new FrmDemo1();
            f.ShowDialog();
        }

        private void BtnDemo2_Click(object sender, EventArgs e)
        {
            FrmDemo2 f = new FrmDemo2();
            f.ShowDialog();
        }

        private void BtnDemo3_Click(object sender, EventArgs e)
        {
            FrmDemo3 f = new FrmDemo3();
            f.ShowDialog();
        }
    }
}
