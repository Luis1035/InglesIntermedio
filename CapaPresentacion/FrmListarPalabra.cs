using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;
// ReSharper disable All

namespace CapaPresentacion
{
    public partial class FrmListarPalabra : Form
    {
        private int posicion;

        public FrmListarPalabra()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvPalabra,
               new object[] { true });
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarCiclo();
            CargarCapitulo();
            CargarPalabras();
            ConfiguraGrilla();
            //CargarPalabraEnlazada();
            var fun = new fPalabra();
               dgvPalabra.DataSource =  fun.ListarPalabra((int)cboCiclo.SelectedValue,(int)cboCapitulo.SelectedValue);
        }

        private void ConfiguraGrilla()
        {
            //dgvPalabra.Columns["IdPalabra"].Width = 60;
            dgvPalabra.Columns["Palabra"].Width = 380;
            dgvPalabra.Columns["Traduccion"].Width = 380;
            dgvPalabra.Columns["Observacion"].Width = 200;

            //dgvPalabra.Columns["Capitulo"].Width = 60;
            //dgvPalabra.Columns["Ciclo"].Width = 60;

            dgvPalabra.Columns["IdPalabra"].Visible = false;

            //Capitulo --------------
            dgvPalabra.Columns["IdCapitulo"].Visible = false;
            dgvPalabra.Columns["Capitulo"].Visible = false;
            

            //Ciclo -----------------
            dgvPalabra.Columns["IdCiclo"].Visible = false;
            dgvPalabra.Columns["Ciclo"].Visible = false;
        }

        private void CargarPalabras()
        {
            var qr = new fPalabra();
            dgvPalabra.DataSource = qr.ListarPalabra(Convert.ToInt32(cboCiclo.SelectedValue), Convert.ToInt32(cboCapitulo.SelectedValue));
        }

        private void CargarCiclo()
        {
            var fun = new fCiclo();
            cboCiclo.DataSource = fun.ListarCiclo();
            cboCiclo.DisplayMember = "Ciclo_";
            cboCiclo.ValueMember = "IdCiclo";

        }

        private void CargarCapitulo()
        {
            var fun = new fCapitulo();
            cboCapitulo.DataSource = fun.ListarCapituloIdCiclo((int)cboCiclo.SelectedValue);
            cboCapitulo.DisplayMember = "Capitulo_";
            cboCapitulo.ValueMember = "IdCapitulo";
        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAgregarPalabras frm = new FrmAgregarPalabras();
            frm.idcapitulo = (int) cboCapitulo.SelectedValue;
            frm.idciclo =(int) cboCiclo.SelectedValue;
            frm.ShowDialog();

            if (frm.Agregado == true)
            {
                CargarPalabras();

                posicion = dgvPalabra.RowCount - 1;
                //dgvPalabra.FirstDisplayedScrollingRowIndex = dgvPalabra.RowCount-1;
                //dgvPalabra.Refresh();
                dgvPalabra.CurrentCell = dgvPalabra.Rows[posicion].Cells[1];
                dgvPalabra.Rows[posicion].Selected = true;

            }

            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         

            fPalabra opc = new fPalabra();
            if (dgvPalabra.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPalabra.CurrentRow.Cells[0].Value);

                // ReSharper disable once CommentTypo
                posicion = dgvPalabra.CurrentRow.Index; // guardar posicion actual

                // ReSharper disable once LocalizableElement
                DialogResult query = MessageBox.Show("Eliminacion de Registro", "Eliminar", buttons: MessageBoxButtons.YesNo);

                if (query == DialogResult.Yes)
                {
                    opc.EliminarPalabra(id);

                    CargarPalabras();

                    dgvPalabra.CurrentCell = dgvPalabra.Rows[posicion-1].Cells[1];
                    //dgvPalabra.Rows[posicion-1].Selected = true;

                    return;
                }
                else
                {
                    return;

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

            if (dgvPalabra.CurrentRow != null) posicion = dgvPalabra.CurrentRow.Index;// revisar posicion para cuando se pase informacio


            EditarRegistro();
         
        }

        private void EditarRegistro()
        {
            // mandamos informacion entre los formularios: FrmListarPalabra --> FrmEditarPalabras

            FrmEditarPalabras frm = new FrmEditarPalabras();
            
            frm.idPalabra = Convert.ToInt32(dgvPalabra.CurrentRow.Cells[0].Value);
            frm.palabra = Convert.ToString(dgvPalabra.CurrentRow.Cells[1].Value).ToUpper();
            frm.traduccion = Convert.ToString(dgvPalabra.CurrentRow.Cells[2].Value).ToUpper();
            frm.observacion = Convert.ToString(dgvPalabra.CurrentRow.Cells[3].Value).ToUpper();

            //esta informacion lo sacamos del datagridview, solo el Id de los campos
            frm.idCapitulo = Convert.ToInt32(dgvPalabra.CurrentRow.Cells[4].Value);
            frm.idCiclo = Convert.ToInt32(dgvPalabra.CurrentRow.Cells[6].Value);

            frm.ShowDialog();

            if (frm.actualizado == true)
            {
                CargarPalabras();
                RecuperarPosicion();
            }




        }

        private void RecuperarPosicion()
        {
            //dgvPalabra.FirstDisplayedScrollingRowIndex = posicion;
            //dgvPalabra.Refresh();
            dgvPalabra.CurrentCell = dgvPalabra.Rows[posicion].Cells["Palabra"];
            //dgvPalabra.Rows[posicion].Selected = true;
        }

        private void dgvPalabra_DoubleClick(object sender, EventArgs e)
        {
            posicion = dgvPalabra.CurrentCell.RowIndex;
            EditarRegistro();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (ckContiene.Checked == false)
            {
                fPalabra fun = new fPalabra();
                dgvPalabra.DataSource = fun.FiltrarPalabra(txtFiltro.Text, (int)cboCiclo.SelectedValue, (int)cboCapitulo.SelectedValue);
            }
            else
            {
                fPalabra fun = new fPalabra();
                dgvPalabra.DataSource = fun.FiltrarPalabra2(txtFiltro.Text, (int)cboCiclo.SelectedValue, (int)cboCapitulo.SelectedValue);
            }

            

            
        }

        private void ckContiene_CheckedChanged(object sender, EventArgs e)
        {
            //CargarPalabraEnlazada();
        }

        private void chkPrimerPlano_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrimerPlano.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void cboCiclo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCapitulo();
            CargarPalabras();
            //CargarPalabraEnlazada();

        }

        private void cboCapitulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarPalabras();
        }

        private void chkMultiLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultiLine.Checked == true)
            {
                dgvPalabra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPalabra.MultiSelect = false;
            }
            else
            {
                dgvPalabra.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvPalabra.MultiSelect = true;
            }
        }

        private void btnAgregarCiclo_Click(object sender, EventArgs e)
        {
            FrmListarCiclo frm = new FrmListarCiclo();
            frm.ShowDialog();
            CargarCiclo();

        }

        private void btnAgregarCapitulo_Click(object sender, EventArgs e)
        {
            FrmListarCapitulo frm = new FrmListarCapitulo();
            frm.idCiclo = this.cboCiclo.SelectedValue;
            frm.ShowDialog();
            CargarCapitulo();
        }

        private void txtFiltro2_TextChanged(object sender, EventArgs e)
        {
            if (ckObservacionContine.Checked == false)
            {
                fPalabra fun = new fPalabra();
                dgvPalabra.DataSource = fun.FiltrarObservacion(txtFiltro2.Text, (int)cboCiclo.SelectedValue, (int)cboCapitulo.SelectedValue);
            }

            else
            {
                fPalabra fun = new fPalabra();
                dgvPalabra.DataSource = fun.FiltrarObservacion2(txtFiltro2.Text, (int)cboCiclo.SelectedValue, (int)cboCapitulo.SelectedValue);
            }
        }

        private void btnGrammar_01_Click(object sender, EventArgs e)
        {
            frmGrammar01 frm = new frmGrammar01();
            frm.ShowDialog();

        }

        private void btnGrammar_02_Click(object sender, EventArgs e)
        {
            frmGrammar02 frm = new frmGrammar02();
            frm.ShowDialog();
        }
    }
}
