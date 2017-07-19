using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmBajaIndividualizacion : Form
    {
        private DataGridViewRow DataIdentidad;

        public FrmBajaIndividualizacion(DataGridViewRow DataIdent)
        {
            DataIdentidad = DataIdent;
            InitializeComponent();
        }

        private void FrmBajaIndividualizacion_Load(object sender, EventArgs e)
        {
            CargarEncabezado();
        }

        private void FrmBajaIndividualizacion_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado Empleado = new FrmEmpleado();
            Empleado.EnvEmple += new FrmEmpleado.EnviarEmpleado(CargarDatosEmpleado); // Metodo Delegate para enviar datos desde FrmEmplado
            Empleado.ShowDialog();
        }

        private void CargarEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(Convert.ToInt32(DataIdentidad.Cells[0].Value));
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);

            txtId.Text = Convert.ToString(DataIdentidad.Cells[1].Value);
            //txtEstado.Text = Convert.ToString(DataIdentidad.Cells[3].Value);
            txtCodEmp.Text = Convert.ToString(DataIdentidad.Cells[4].Value);
            txtNomEmp.Text = Convert.ToString(DataIdentidad.Cells[5].Value);
            txtCertificado.Text = Convert.ToString(DataIdentidad.Cells[9].Value);
            txtMarca.Text = Convert.ToString(DataIdentidad.Cells[10].Value);
        }

        public void CargarDatosEmpleado(string[] DatosEmpleado)
        {
            txtCodIns.Text = DatosEmpleado[0];
            TxtNomIns.Text = DatosEmpleado[1];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
