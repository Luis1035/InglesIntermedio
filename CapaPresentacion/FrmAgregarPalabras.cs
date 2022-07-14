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
    public partial class FrmAgregarPalabras : Form
    {
        public int idcapitulo { get;  set; }
        public int idciclo { get;  set; }
        public bool Agregado { get; set; }


        public FrmAgregarPalabras()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMantenimientoPalabras_Load(object sender, EventArgs e)
        {
            CargarCiclo();
            CargarCapitulos();
        }

        private void CargarCiclo()
        {
            fCiclo opc = new fCiclo();
            cboCiclo.DataSource = opc.ListarCiclo();
            cboCiclo.DisplayMember = "Ciclo_";
            cboCiclo.ValueMember = "IdCiclo";
            cboCiclo.SelectedValue = idciclo;
        }

        private void CargarCapitulos()
        {
            
            fCapitulo opc = new fCapitulo();
            cboCapitulo.DataSource = opc.ListarCapitulo();
            cboCapitulo.DisplayMember = "Capitulo_";
            cboCapitulo.ValueMember = "IdCapitulo";
            cboCapitulo.SelectedValue = idcapitulo;
          

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Palabra obj = new Palabra();

                obj.Palabra_ = txtPalabra.Text.ToUpper();
                obj.Traduccion = txtTraduccion.Text.ToUpper();
                obj.Observacion = txtObservacion.Text.ToUpper();
                obj.IdCapitulo = Convert.ToInt32(cboCapitulo.SelectedValue);

                fPalabra opc = new fPalabra();

                if (opc.AgregarPalabra(obj) == true)
                {
                    Agregado = true;
                    MessageBox.Show("Registro Guardado ...","Grabar Registro");
                    this.Close();
                }
                else
                {
                    Agregado = false;
                    MessageBox.Show("Registro No Guardado ...\nRegistro Duplicado", "Grabar Registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
