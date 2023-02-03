using DevExpress.XtraEditors;
using is_takip_proje_efe.Formlar;
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
    public partial class FrmPersonelForm : Form
    {
        public FrmPersonelForm()
        {
            InitializeComponent();
        }
        public string mail;
        PersonelGorevFormlari.FrmAktifgorevler aktifform;
        private void btnaktifgrv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (aktifform == null || aktifform.IsDisposed)
            {
                aktifform = new PersonelGorevFormlari.FrmAktifgorevler();
                aktifform.MdiParent = this;
                aktifform.mail2 = mail;
                aktifform.Show();
            }
        }
        PersonelGorevFormlari.FrmPasifGorevler pasform;
        private void btnpasifgtv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pasform == null || pasform.IsDisposed)
            {
                pasform = new PersonelGorevFormlari.FrmPasifGorevler();
                pasform.MdiParent = this;
                pasform.mail2 = mail;
                pasform.Show();
            }
        }
        PersonelGorevFormlari.FrmPersonelForm persform;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (persform == null || persform.IsDisposed)
            {
                persform = new PersonelGorevFormlari.FrmPersonelForm();
                persform.MdiParent = this;
                persform.Show();
            }
        }

        private void FrmPersonelForm_Load(object sender, EventArgs e)
        {
            this.Text = mail.ToString();
            this.Text = "Personel Paneli";
        }
    }
}
