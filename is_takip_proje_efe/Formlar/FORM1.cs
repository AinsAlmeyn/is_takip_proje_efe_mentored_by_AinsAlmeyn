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
        Formlar.DepartmanFrm frmdepartman;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmdepartman==null || frmdepartman.IsDisposed)
            {
                frmdepartman = new Formlar.DepartmanFrm();
                frmdepartman.MdiParent = this;
                frmdepartman.Show();
            }
           
        }
        Formlar.PersonellerFrm personeller;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personeller==null || personeller.IsDisposed)
            {
                personeller = new Formlar.PersonellerFrm();
                personeller.MdiParent = this;
                personeller.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        Formlar.GorevListesi grvlist;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (grvlist == null || grvlist.IsDisposed)
            {
                grvlist = new Formlar.GorevListesi();
                grvlist.MdiParent = this;
                grvlist.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.GorevDetayFrm grvdtyfrm;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvdtyfrm==null || grvdtyfrm.IsDisposed)
            {
                grvdtyfrm = new Formlar.GorevDetayFrm();
                grvdtyfrm.MdiParent = this;
                grvdtyfrm.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        Formlar.Personelİstatistik frmPersonelIstatistik;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelIstatistik==null || frmPersonelIstatistik.IsDisposed)
            {
                frmPersonelIstatistik = new Formlar.Personelİstatistik();
                frmPersonelIstatistik.MdiParent = this;
                frmPersonelIstatistik.Show();
            }
           
        }
        Formlar.AnaAnaForm Aaform;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Aaform == null || Aaform. IsDisposed)
            {
                Aaform=new Formlar.AnaAnaForm();
                Aaform.MdiParent = this;
                Aaform.Show();
            }
        }
        Formlar.FrmAktifCagrilar aktifcagri;
        private void btnaktfic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aktifcagri == null || aktifcagri.IsDisposed)
            {
                aktifcagri = new Formlar.FrmAktifCagrilar();
                aktifcagri.MdiParent = this;
                aktifcagri.Show();
            }
        }
        Formlar.Gorevfrm grvfrm;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (grvfrm == null || grvfrm.IsDisposed)
            {
                grvfrm = new Formlar.Gorevfrm();
                
                grvfrm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        
    }
}
