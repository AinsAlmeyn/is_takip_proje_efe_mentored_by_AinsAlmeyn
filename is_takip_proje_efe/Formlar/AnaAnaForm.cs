using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                                           Personeller=x.TblPersoneller.Ad+" "+x.TblPersoneller.Soyad,
                                           x.Durum
                                       }).Where(y=>y.Durum==true).ToList();
            gridView1.Columns["Durum"].Visible = false;

        }
    }
}
