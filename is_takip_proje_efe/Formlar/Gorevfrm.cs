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
using DevExpress.XtraRichEdit.Model.History;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace is_takip_proje_efe.Formlar
{
    public partial class Gorevfrm : Form
    {
        public Gorevfrm()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db=new DbIsTakipEntities();
        private void btnsil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            TblGorevler t=new TblGorevler();
            t.Aciklama = aciklamatext.Text;
            t.Durum = true;
            t.GorevAlan =int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih =DateTime.Parse(lookUpEdit2.Text);
            t.GorevVeren =int.Parse(gorevverentxt.Text);
            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("görev başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Gorevfrm_Load(object sender, EventArgs e)
        {
            var departmanlar = (from x in db.TblPersoneller
                                select new
                                {

                                    x.ID,
                                    adsoyad=x.Ad + x.Soyad,
                                    
                                }).ToList();
            lookUpEdit1.Properties.ValueMember= "ID";
            lookUpEdit1.Properties.DisplayMember = "adsoyad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }
    }
}
