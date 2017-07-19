using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{


    public partial class FrmAgregarInstrumento : Form
    {

        private FrmInstrumentosPrecision FrmInstrumentoHandler;

        public FrmAgregarInstrumento(FrmInstrumentosPrecision formInstru)
        {
            InitializeComponent();
            FrmInstrumentoHandler = formInstru;
        }

        private void FrmAgregarInstrumento_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void FrmAgregarInstrumento_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            this.dataGridView1.DataSource = NItemIndustrial.Listar();
            dataGridView1.AutoResizeColumn(1);
            //dataGridView1.Columns[1].Width = 300;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtItem.Text == string.Empty)
            {
                errorIcono.SetError(txtItem, "Ingrese Parte del Codigo o Nombre a Buscar");
            }
            else
            {
                this.dataGridView1.DataSource = NItemIndustrial.Buscar(txtItem.Text.Trim() == "*" ? "" : txtItem.Text.Trim());
                //dataGridView1.Columns[1].Width = 300;
            }
            
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.SetError(txtItem, "");
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string rpta = "";

                rpta = NInstrumento.Insertar(Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                                      Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value),
                                      cmbFrecuenciaN.Text,
                                      cmbFrecuenciaU.Text,
                                      "A");
                if (rpta == "OK")
                {
                    btnCancelar.PerformClick();
                    FrmInstrumentoHandler.ListarInstrumentos();
                }
                else
                {
                    this.MensajeError(rpta);
                }

            }

        }

        private bool ValidarCampos()
        {
            bool valido = true;

            if (cmbFrecuenciaN.SelectedIndex == -1)
            {
                errorIcono.SetError(cmbFrecuenciaN, "Ingrese Una Frecuencia Recomendada");
                valido = false;
            }
            else if (cmbFrecuenciaU.SelectedIndex == -1)
            {
                errorIcono.SetError(cmbFrecuenciaU, "Ingrese Una Frecuencia Recomendada");
                valido = false;
            }

            return valido;
        }

        private void cmbFrecuenciaN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrecuenciaN.SelectedIndex == -1)
            {
                errorIcono.SetError(cmbFrecuenciaN, "Ingrese Una Frecuencia Recomendada");
            }
            else
            {
                errorIcono.SetError(cmbFrecuenciaN, "");
            }
        }

        private void cmbFrecuenciaU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFrecuenciaU.SelectedIndex == -1)
            {
                errorIcono.SetError(cmbFrecuenciaU, "Ingrese Una Frecuencia Recomendada");
            }
            else
            {
                errorIcono.SetError(cmbFrecuenciaU, "");
            }
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

}
