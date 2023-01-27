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

namespace is_takip_proje_efe.Formlar
{
    public partial class DepartmanFrm : Form
    {
        public DepartmanFrm()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        void listele()
        {         
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {x.ID,x.Ad                             
                            });
            gridControl1.DataSource = degerler.ToList();
        }
        private void btnlist_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar ekle=new TblDepartmanlar();
            ekle.Ad = textad.Text;
            db.TblDepartmanlar.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("departman başarılı bir şekilde eklendi", "bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            listele();

        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            
            int sil = int.Parse(textid.Text);
            var deger = db.TblDepartmanlar.Find(sil);
            db.TblDepartmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("silme işlemi başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textid.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int sil = int.Parse(textid.Text);
            var deger = db.TblDepartmanlar.Find(sil);
            deger.Ad = textad.Text;  
            db.SaveChanges();
            XtraMessageBox.Show("güncelleme işlemi başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

        private void DepartmanFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
