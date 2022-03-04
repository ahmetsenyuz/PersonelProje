using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelProje;
using PersonelProje.Context;

namespace PersonelProje
{
    public partial class frmSehir : Form
    {
        public frmSehir()
        {
            InitializeComponent();
        }
        PersonelContext db = DbConnect.GetConnection();
        Sehir ss;
        private void frmSehir_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            //List<Sehir> slist = db.Sehir.ToList();//bu da olur ama alttaki daha iyi
            List<Sehir> slist = db.Set<Sehir>().ToList();
            dataGridView1.DataSource = slist;
            // select*from sehir
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ss = (Sehir)dataGridView1.CurrentRow.DataBoundItem;
            txtSehir.Text = ss.SehirAd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sehir ys = new Sehir();
            ys.SehirAd = txtSehir.Text;
            //db.Sehir.Add(ys); 1.Yol
            //db.Entry(ys).State = System.Data.Entity.EntityState.Added; 2. Yol
            db.Set<Sehir>().Add(ys);//insert into...
            db.SaveChanges();
            doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //db.Sehir.Remove(ss); 1.yol
            //db.Entry(ss).State = System.Data.Entity.EntityState.Deleted; 2. yol
            db.Set<Sehir>().Remove(ss);
            db.SaveChanges();
            //delete ... from sehir
            doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ss.SehirAd = txtSehir.Text;
            db.Entry(ss).State = System.Data.Entity.EntityState.Modified;//kullanmasan da olur
            db.SaveChanges();
            doldur();
        }
    }
}
