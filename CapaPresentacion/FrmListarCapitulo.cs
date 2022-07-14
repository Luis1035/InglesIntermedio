using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmListarCapitulo : Form
    {
        public object idCiclo { get; internal set; }

        public FrmListarCapitulo()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvCapitulo,
               new object[] { true });
        }

        private void FrmListarCapitulo_Load(object sender, EventArgs e)
        {
            CargarCiclo();
            cboCiclo.SelectedValue = idCiclo;
            
            
           
            var fun = new fCapitulo();
            dgvCapitulo.DataSource = fun.ListarCapituloCiclo((int)cboCiclo.SelectedValue);
            ConfiguraGrilla();
        }

        private void ConfiguraGrilla()
        {
            dgvCapitulo.Columns["IdCapitulo"].Width = 60;
            dgvCapitulo.Columns["IdCiclo"].Width = 60;
            //dgvPalabra.Columns["Palabra"].Width = 400;
            //dgvPalabra.Columns["Traduccion"].Width = 400;
            //dgvPalabra.Columns["Observacion"].Width = 300;
            //dgvPalabra.Columns["Capitulo"].Width = 60;
            //dgvPalabra.Columns["Ciclo"].Width = 60;

            dgvCapitulo.Columns["IdCapitulo"].Visible = false;
            dgvCapitulo.Columns["IdCiclo"].Visible = false;
        }

        private void CargarCiclo()
        {
            var fun = new fCiclo();
            cboCiclo.DataSource = fun.ListarCiclo();
            cboCiclo.DisplayMember = "Ciclo_";
            cboCiclo.ValueMember = "IdCiclo";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCiclo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var fun = new fCapitulo();
            dgvCapitulo.DataSource = fun.ListarCapituloCiclo((int)cboCiclo.SelectedValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            FrmAgregarCapitulo frm = new FrmAgregarCapitulo();
            frm.idCiclo = (int)cboCiclo.SelectedValue;
            frm.ShowDialog();
            

            var fun = new fCapitulo();
            dgvCapitulo.DataSource = fun.ListarCapituloCiclo((int)cboCiclo.SelectedValue);

        }
    }
}
