using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoControlCS
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDemoOrion f = new FrmDemoOrion();
            f.ShowDialog();
        }
    }
}
