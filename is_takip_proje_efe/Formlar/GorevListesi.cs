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
using DevExpress.Utils.Html.Internal;

namespace is_takip_proje_efe.Formlar
{
    public partial class GorevListesi : Form
    {
        public GorevListesi()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db=new DbIsTakipEntities();
        private void GorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           
                                           x.Aciklama,
                                       }).ToList();
            lblsayi1.Text = db.TblDepartmanlar.Count().ToString();
            lblsayi2.Text = db.TblGorevler.Where(x=>x.Durum==true).Count().ToString();
            lblsayi3.Text = db.TblGorevler.Where(x=>x.Durum==false).Count().ToString();
            //chartControl1.Series["Series 1"]. Points.AddPoint("Bilgi islem", 5);
            chartControl1.Series["Durumseries"].Points.AddPoint("Aktif Görevler", int.Parse(lblsayi2.Text));
            chartControl1.Series["Durumseries"].Points.AddPoint("Pasif Görevler", int.Parse(lblsayi3.Text));
            
        }

      
    } 

}
