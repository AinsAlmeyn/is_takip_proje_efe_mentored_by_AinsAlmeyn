using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje_efe.Entity;
using is_takip_proje_efe.PersonelGorevFormlari;

namespace is_takip_proje_efe.Formlar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FrmPersonelForm fr = new PersonelGorevFormlari.FrmPersonelForm();
            fr.Show();
        }


        DbIsTakipEntities db = new DbIsTakipEntities();
        private void Adminbtn_Click(object sender, EventArgs e)
        {
            var AdminD = db.TblAdminler.Where(x => x.Kullanici == txtkullaniciadi.Text && x.Sifre == txtsifre.Text).FirstOrDefault();
            if (AdminD != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Formlar.Form1 fr = new Formlar.Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }




        }

        private void kullanicibtn_Click(object sender, EventArgs e)
        {
            var PersonelD = db.TblPersoneller.Where(x => x.Mail == txtkullaniciadi.Text && x.Sifre == txtsifre.Text).FirstOrDefault();
            if (PersonelD != null)
            {

                XtraMessageBox.Show("Hoşgeldiniz");
                PersonelGorevFormlari.FrmPersonelForm fr = new PersonelGorevFormlari.FrmPersonelForm();
                fr.mail = txtkullaniciadi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
