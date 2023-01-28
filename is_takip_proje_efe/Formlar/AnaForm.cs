using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje_efe
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btndepartmanliste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.DepartmanFrm frm=new Formlar.DepartmanFrm();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personelİstatistik frm3=new Formlar.Personelİstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void görevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Formlar.GorevListesi frm4=new Formlar.GorevListesi();
            frm4.MdiParent = this;  
            frm4.Show();    
        }


                }
                private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
                {
                    Formlar.Personelİstatistik frm3 = new Formlar.Personelİstatistik();
                    frm3.MdiParent = this;
                    frm3.Show();
                }
            }
            private void görevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
            {
                Formlar.GorevListesi frm4 = new Formlar.GorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
        
    }
}