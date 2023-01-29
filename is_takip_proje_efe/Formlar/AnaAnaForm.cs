using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using is_takip_proje_efe.Entity;

namespace is_takip_proje_efe.Formlar
{
    public partial class AnaAnaForm : Form
    {
        public AnaAnaForm()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void AnaAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personeller = x.TblPersoneller.Ad + " " + x.TblPersoneller.Soyad,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView1.Columns["Durum"].Visible = false;
            //bugün Yapılan Görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            var dataSource = (from x in db.TblGorevDetaylar
                              select new
                              {
                                  gorev = x.TblGorevler.Aciklama,
                                  x.Aciklama,
                                  x.Tarih
                              }).Where(x => x.Tarih == bugun).ToList();



            //aktif çağrı listesi
            gridControl3.DataSource = (from x in db.Cagrilartbl
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;
            //fihrist kontrolleri
            gridControl4.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail,

                                       }).ToList();

            int aktifcagrılar = db.Cagrilartbl.Where(x => x.Durum == true).Count();
            int pasifCAgrılar = db.Cagrilartbl.Where(x => x.Durum == false).Count();
            //chartControl1.Series["Series 1"]. Points.AddPoint("Bilgi islem", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Görevler", (aktifcagrılar));
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Görevler", (pasifCAgrılar));

        }

    }
    
}
