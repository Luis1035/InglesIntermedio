using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmListarCiclo : Form
    {
        public FrmListarCiclo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmListarCiclo_Load(object sender, EventArgs e)
        {
            ListarCiclo();

        }

        private void ListarCiclo()
        {
            using (dbIntermedioEntities db = new dbIntermedioEntities())
            {
                dgvCiclo.DataSource = db.Ciclo.ToList();

            }

               
         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAgregarCiclo frm = new FrmAgregarCiclo();
            frm.ShowDialog();
            ListarCiclo();
            
        }
    }
}
