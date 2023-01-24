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

namespace is_takip_proje_efe.Formlar
{
    public partial class GorevListesi : Form
    {
        public GorevListesi()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db=new DbIsTakipEntities();
        private void GorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           
                                           x.Aciklama,
                                       }).ToList();
        }

      
    } 

}
