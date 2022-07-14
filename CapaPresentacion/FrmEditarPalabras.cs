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
    public partial class FrmEditarPalabras : Form
    {
        

        public FrmEditarPalabras()
        {
            InitializeComponent();
        }

        public int idPalabra { get; internal set; }
        public int idCapitulo { get; internal set; }
      
        public string traduccion { get; internal set; }
        public string observacion { get; internal set; }
        public string palabra { get; internal set; }
        public bool actualizado { get; internal set; }
        public object idCiclo { get; internal set; }

        private void FrmEditarPalabras_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            //recuperamos la informacion del Capitulo mediante su id
            fCapitulo opc =  new fCapitulo();
            cboCapitulo.DataSource =  opc.ListarCapituloIdCiclo((int)idCiclo);
            cboCapitulo.DisplayMember = "Capitulo_";
            cboCapitulo.ValueMember = "IdCapitulo";
            cboCapitulo.SelectedValue = idCapitulo;


            //recuperamos la infomacion del Ciclo mediante su id
            fCiclo opc1 = new fCiclo();
            cboCiclo.DataSource = opc1.ListarCiclo();
            cboCiclo.DisplayMember = "Ciclo_";
            cboCiclo.ValueMember = "IdCiclo";
            cboCiclo.SelectedValue = idCiclo;




            TxtIdPalabra.Text = idPalabra.ToString();
            txtPalabra.Text = palabra.ToString();
            txtTraduccion.Text = traduccion.ToString();
            txtObservacion.Text = observacion.ToString();

           
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Palabra obj = new Palabra();
            obj.IdPalabra = Convert.ToInt32(TxtIdPalabra.Text);
            obj.Palabra_ = txtPalabra.Text.ToUpper();
            obj.Traduccion = txtTraduccion.Text.ToUpper();
            obj.Observacion = txtObservacion.Text.ToUpper();
            obj.IdCapitulo = Convert.ToInt32 ( cboCapitulo.SelectedValue);

            fPalabra opc = new fPalabra();
            if (opc.ActualizarPalabra(obj))
            {
                actualizado = true;
                this.Close();
            }
            else
            {
                actualizado = false;
            }
          


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
