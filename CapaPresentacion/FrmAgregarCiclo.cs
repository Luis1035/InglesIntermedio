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
    public partial class FrmAgregarCiclo : Form
    {
        public FrmAgregarCiclo()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Ciclo obj = new Ciclo();

                obj.Ciclo_ = txtCiclo.Text;


                fCiclo opc = new fCiclo();

                if (opc.AgregarCiclo(obj) == true)
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
