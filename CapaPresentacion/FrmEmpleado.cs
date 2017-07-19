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
    public partial class FrmEmpleado : Form
    {
        public delegate void EnviarEmpleado(String[] Empleado);
        public event EnviarEmpleado EnvEmple;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmplado_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void FrmEmplado_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar()
        {
            this.dataGridView1.DataSource = NEmpleadoIndustrial.Listar();
            dataGridView1.Columns[1].Width = 330;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtItem.Text == string.Empty)
            {
                errorIcono.SetError(txtItem, "Ingrese Parte del Codigo, Rut o Nombre a Buscar");
            }
            else
            {
                this.dataGridView1.DataSource = NEmpleadoIndustrial.Buscar(txtItem.Text.Trim() == "*" ? "" : txtItem.Text.Trim());
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] DatosEmpleado = new string[]
            {
                Convert.ToString(dataGridView1[0,dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1,dataGridView1.CurrentRow.Index].Value)
            };

            EnvEmple(DatosEmpleado);
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnAgregar.PerformClick();
        }
    }
}
