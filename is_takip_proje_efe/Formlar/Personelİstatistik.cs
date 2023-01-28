using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using is_takip_proje_efe.Entity;
using System.Windows.Forms;

namespace is_takip_proje_efe.Formlar
{
    public partial class Personelİstatistik : Form
    {
        public Personelİstatistik()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db=new DbIsTakipEntities();
        private void Personelİstatistik_Load(object sender, EventArgs e)
        {
            lbldepartmansay.Text = db.TblDepartmanlar.Count().ToString();
            lbltoplampers.Text = db.TblPersoneller.Count().ToString();
            lblfirmasay.Text = db.TblFirmalar.Count().ToString();
            lblaktifis.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            lblpasifissay.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            lblsongorev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblisyapılansahir.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            lblsektorsay.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugün = DateTime.Today;
            lblbgnacılanggrvler.Text = db.TblGorevler.Count(x => x.Tarih == bugün).ToString();
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblayınpers.Text = db.TblPersoneller.Where(x => x.ID == d1).Select(y => y.Ad + y.Soyad).FirstOrDefault().ToString();
            lblayındep.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersoneller.Where(t => t.ID == d1).Select(p => p.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
            var d2 = db.TblGorevDetaylar.GroupBy(x => x.Gorev).OrderByDescending(y => y.Count()).Select(z => z.Key).FirstOrDefault();
            lblsongorevdetayı.Text = db.TblGorevDetaylar.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
        }
    }
}
