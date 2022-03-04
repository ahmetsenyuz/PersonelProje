using PersonelProje.Context;
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
    public partial class frmPerAnonim : Form
    {
        public frmPerAnonim()
        {
            InitializeComponent();
        }
        PersonelContext db = DbConnect.GetConnection();
        private void frmPerAnonim_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            var plist = db.Set<Personel>().Select(x => new //plist list anonim bir değişken oldu.Ne olduğu belli değil.
            {
                Id = x.Id,
                Name = x.Ad, //böyle de sütun adı değiştirilir.
                x.Soyad,
                x.Maas,
                x.Sehir.SehirAd,
                Cinsiyet = x.Cins
            }).ToList();
            dataGridView1.DataSource = plist;
        }
    }
}
