using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void şehirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehir frm = new frmSehir();
            frm.Show();
            
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonel frm = new frmPersonel();
            frm.Show();
        }

        private void dTOYaklaşımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerDTO frm = new frmPerDTO();
            frm.Show();
        }

        private void anonimYaklaşımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerAnonim frm = new frmPerAnonim();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
