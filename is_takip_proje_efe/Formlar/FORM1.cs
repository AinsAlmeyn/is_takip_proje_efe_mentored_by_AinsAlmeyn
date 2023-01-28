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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepartmanFrm frmDepartmanlar = new DepartmanFrm();
            frmDepartmanlar.MdiParent = this;
            frmDepartmanlar.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonellerFrm frmPersoneller = new PersonellerFrm();
            frmPersoneller.MdiParent = this;
            frmPersoneller.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Gorevfrm gorevfrm = new Gorevfrm();
            gorevfrm.MdiParent = this;
            gorevfrm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GorevDetayFrm grvdtyfrm = new GorevDetayFrm();
            grvdtyfrm.MdiParent = this;
            grvdtyfrm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Personelİstatistik frmPersonelIstatistik = new Personelİstatistik();
            frmPersonelIstatistik.MdiParent = this;
            frmPersonelIstatistik.Show();
        }
    }
}
