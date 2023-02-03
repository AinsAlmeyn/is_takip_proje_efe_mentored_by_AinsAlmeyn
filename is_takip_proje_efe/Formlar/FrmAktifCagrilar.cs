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

namespace is_takip_proje_efe.Formlar
{
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            DbIsTakipEntities db = new DbIsTakipEntities();
            var degerler = (from x in db.Cagrilartbl
                            select new
                            {
                                x.ID,
                                x.Konu,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Aciklama,
                                x.Durum
                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
