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
    public partial class Personelİstatistik : Form
    {
        public Personelİstatistik()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db=new DbIsTakipEntities();
        private void Personelİstatistik_Load(object sender, EventArgs e)
        {
            lbldepartmansay.Text=db.TblDepartmanlar.Count().ToString();
            lbltoplampers.Text = db.TblPersoneller.Count().ToString();
            lblfirmasay.Text = db.TblFirmalar.Count().ToString();
        }
    }
}
