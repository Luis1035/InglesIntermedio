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
using  CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            FrmListarCiclo frm = new FrmListarCiclo();
            frm.ShowDialog();
            
        }

        private void btnPalabras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListarPalabra frm = new FrmListarPalabra();
            frm.ShowDialog();
            this.Show();
        }
    }
}
