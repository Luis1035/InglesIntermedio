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
    public partial class FrmAgregarCapitulo : Form
    {
        public int idCiclo { get; set; }


        public FrmAgregarCapitulo()
        {
            InitializeComponent();
        }

      

        private void FrmAgregarCapitulo_Load(object sender, EventArgs e)
        {
            CargarCiclo();
            cboCiclo.SelectedValue = idCiclo;

        }

        private void CargarCiclo()
        {
            fCiclo fun = new fCiclo();
            cboCiclo.DataSource =  fun.ListarCiclo();
            cboCiclo.DisplayMember = "Ciclo_";
            cboCiclo.ValueMember = "IdCiclo";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Capitulo obj = new Capitulo();

                obj.Capitulo_ = txtCapitulo.Text;
                obj.IdCiclo = (int)cboCiclo.SelectedValue;


                fCapitulo opc = new fCapitulo();

                if (opc.AgregarCapitulo(obj) == true)
                {
                    MessageBox.Show("Registro Guardado ...", "Grabar Registro");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registro No Guardado ...\nRegistro Duplicado", "Grabar Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
