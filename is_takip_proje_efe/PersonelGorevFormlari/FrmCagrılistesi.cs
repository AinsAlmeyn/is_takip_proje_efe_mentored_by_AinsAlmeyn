using DevExpress.XtraEditors;
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
    public partial class FrmCagrılistesi : Form
    {
        public FrmCagrılistesi()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void FrmCagrılistesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Cagrilartbl
                                       select new
                                       {

                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.Durum,

                                       }).Where(y => y.Durum == true).ToList();
             gridView1.Columns["Durum"].Visible = false;

        }
    }
}
