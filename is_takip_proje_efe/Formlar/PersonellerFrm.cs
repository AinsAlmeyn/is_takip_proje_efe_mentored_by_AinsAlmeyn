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
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;

namespace is_takip_proje_efe.Formlar
{
    public partial class PersonellerFrm : Form
    {
        public PersonellerFrm()
        {
            
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        
        void personeller()
        {
            var degerler = (from x in db.TblPersoneller
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Mail,
                                //x.Departman,
                                //aynı ad olduğu için on bir departman değerinde bir değişkene atadık
                                departman=x.TblDepartmanlar.Ad,
                                x.Telefon,
                                x.Gorsel,
                                x.Durum
                                
                            });
            gridControl1.DataSource = degerler.Where(x=>x.Durum==true).ToList();
        }
        private void PersonellerFrm_Load(object sender, EventArgs e)
        {
           personeller();
            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad
                                }).ToList();
           

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TblPersoneller pers = new TblPersoneller();
            pers.Ad = textad.Text;
            pers.Soyad = Textsoyad.Text;
            pers.Mail = textmail.Text;
            pers.Gorsel = textgorsel.Text;
            pers.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblPersoneller.Add(pers);
            db.SaveChanges();
            XtraMessageBox.Show("veriler başarıyla eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            personeller();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(textİd.Text);
            var deger = db.TblPersoneller.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("personeller  başarılı bir şekilde silindi,silinen" +
                " personeller listesinden  tüm silinmiş personel bilgilerine ulşabilirsiniz...","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            personeller();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {

        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textİd.Text);
            var deger = db.TblPersoneller.Find(x);
            deger.Ad = textad.Text;
            deger.Soyad =Textsoyad.Text;
            deger.Mail = textmail.Text;
            deger.Gorsel =textgorsel.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            personeller();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textİd.Text=gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text=gridView1.GetFocusedRowCellValue("Ad").ToString();
            Textsoyad.Text=gridView1.GetFocusedRowCellValue("Soyad").ToString();
            textmail.Text=gridView1.GetFocusedRowCellValue("Mail").ToString();
            //textgorsel.Text=gridView1.GetFocusedRowCellValue("Gorsel").ToString();
            //lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }
    }
}
