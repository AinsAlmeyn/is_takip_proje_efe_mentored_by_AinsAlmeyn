using DevExpress.XtraGrid;
using is_takip_proje_efe.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje_efe.PersonelGorevFormlari
{
    public partial class FrmPasifGorevler : Form
    {
        public FrmPasifGorevler()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        public string mail2;
        private void FrmPasifGorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersoneller.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            var degerler = (from x in db.TblGorevler
                                select new
                                {
                                    x.ID,
                                    x.Aciklama,
                                    x.Tarih,
                                    x.GorevAlan,
                                    x.Durum
                                }).Where(x => x.GorevAlan == personelid && x.Durum == false);

                gridControl1.DataSource = degerler.ToList();
                gridView1.Columns["GorevAlan"].Visible = false;
                gridView1.Columns["Durum"].Visible = false;
            
        }
    }
}
