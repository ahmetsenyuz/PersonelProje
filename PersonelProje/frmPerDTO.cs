using PersonelProje.Context;
using PersonelProje.DTO;
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
    public partial class frmPerDTO : Form
    {
        public frmPerDTO()
        {
            InitializeComponent();
        }
        PersonelContext db = DbConnect.GetConnection();
        Personel secPersonel;
        List<PersonelDTO> plist = new List<PersonelDTO>(); 
        private void frmPerDTO_Load(object sender, EventArgs e)
        {
            Doldur();
            CbDoldur();
        }

        private void CbDoldur()
        {
            var slist = db.Set<Sehir>().Select(x => new
            {
              SehirId =  x.SehirId,
              SehirAd =  x.SehirAd
            }).ToList();
            cbPer.DataSource = slist;
            cbPer.DisplayMember = "SehirAd";//cboxta seçilen değer. Burdan seçiyon seçilene karşılık gelen aşağıdaki değer geliyor.
            cbPer.ValueMember = "SehirId";//comboboxta alınan değer
        }

        private void Doldur()
        {
            plist = db.Set<Personel>().Select(x => new PersonelDTO
            {
                Id = x.Id,
                Ad = x.Ad,
                Surname = x.Soyad,
                Maas = x.Maas,
                SehirAd = x.Sehir.SehirAd,
                Cins = x.Cins
                //inner join yapmış olduk.
            }).ToList();//x personeli temsil ediyor.Sol taraf da PersonelDTO'yu temsil ediyor.
            dataGridView1.DataSource = plist;
            //decimal tmaas = 0;
            //foreach (var item in plist)
            //{
            //    tmaas += item.Maas;
            //}1.yolu
            //decimal tmaas = plist.Sum(item => item.Maas);//lambda expressions Yukarıdaki kodla aynı işi görür
            txtToplam.Text = plist.Sum(item => item.Maas).ToString();
            txtOrt.Text = plist.Average(item => item.Maas).ToString();
            txtPers.Text = plist.Count.ToString();
            txtTopErMaas.Text = plist.Where(x=> x.Cins == "E").Sum(x => x.Maas).ToString();
            txtOrtErMaas.Text = plist.Where(x=> x.Cins == "E").Average(x => x.Maas).ToString();
            txtTopErPer.Text = plist.Where(x=> x.Cins == "E").Count().ToString();
            txtTopKadMaas.Text = plist.Where(x => x.Cins == "K").Sum(x => x.Maas).ToString();
            txtOrtKadMaas.Text = plist.Where(x=> x.Cins == "K").Average(x => x.Maas).ToString();
            txtTopKadPer.Text = plist.Where(x => x.Cins == "K").Count().ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secId = (int)dataGridView1.CurrentRow.Cells[0].Value;//seçilen satırın ilk elemanının değerini verir. Buradaki durumda bu id
            secPersonel = db.Set<Personel>().Find(secId);//personel listesinden int secId değerli satırı buluyor. Personel tipinde.
            txtAd.Text = secPersonel.Ad;
            txtSoyad.Text = secPersonel.Soyad;
            txtMaas.Text =Convert.ToString(secPersonel.Maas);
            txtCins.Text = secPersonel.Cins;
            cbPer.SelectedValue = secPersonel.SehirId;

        }

        private void cbAdGore_CheckedChanged(object sender, EventArgs e)
        {
            //plist = plist.OrderBy(x => x.Ad).ToList();
            //dataGridView1.DataSource = plist;
        }

        private void cbAdGore_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbAdGore.Checked)
            {
                plist = plist.OrderBy(x => x.Ad).ToList();
                dataGridView1.DataSource = plist;
            }
            else
            {
                plist = plist.OrderBy(x => x.Id).ToList();
                dataGridView1.DataSource = plist;
            }
        }

        private void cbMaasaGore_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbMaasaGore.Checked)
            {
                plist = plist.OrderByDescending(x => x.Maas).ToList();
                dataGridView1.DataSource = plist;
            }
            else
            {
                plist = plist.OrderBy(x => x.Maas).ToList();
                dataGridView1.DataSource = plist;
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAra.Text))
            {
                plist = plist.Where(x => x.Ad.ToLower().Contains(txtAra.Text.ToLower()) || x.Surname.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                dataGridView1.DataSource = plist;
            }
            else
            {
                Doldur();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personel yeniPer = new Personel();
            yeniPer.Ad = txtAd.Text;
            yeniPer.Soyad = txtSoyad.Text;
            yeniPer.Maas = Convert.ToDecimal(txtMaas.Text);
            yeniPer.Cins = txtCins.Text;
            yeniPer.SehirId =(int)cbPer.SelectedValue;
            db.Set<Personel>().Add(yeniPer);
            db.SaveChanges();
            Doldur();
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            secPersonel.Ad = txtAd.Text;
            secPersonel.Soyad = txtSoyad.Text;
            secPersonel.Maas = Convert.ToDecimal(txtMaas.Text);
            secPersonel.Cins = txtCins.Text;
            secPersonel.SehirId = Convert.ToInt32(cbPer.SelectedValue);//değerleri kullanırken selected value kullanıyoruz. Ekranda ona karşılık gelen display value gözükğyor.
            db.SaveChanges();
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Set<Personel>().Remove(secPersonel);
            db.SaveChanges();
            Doldur();
        }
    }
}
