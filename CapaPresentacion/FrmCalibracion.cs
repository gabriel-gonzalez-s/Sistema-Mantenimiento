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
    public partial class FrmCalibracion : Form
    {
        private DataGridViewRow DataIdentidad;
        private DataTable DataItemsCalibracion;
        private DataGridViewRow DataCalibracion;
        private string AccionEnviada;
        public FrmCalibracion(DataGridViewRow DataIdent, DataTable DataItemCalib, DataGridViewRow DataCalibra, string Accion)
        {
            DataIdentidad = DataIdent;
            DataItemsCalibracion = DataItemCalib;
            DataCalibracion = DataCalibra;
            AccionEnviada = Accion;
            InitializeComponent();
            CargarEncabezado();
            CargarDetalles();
            //DataIdentidad.DefaultCellStyle.SelectionBackColor = DataIdentidad.DefaultCellStyle.BackColor;
        }

        private void FrmCalibracion_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataItemCalibracion.Rows)
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)Row.Cells[0];
                //chk.Value = chk.TrueValue;//!(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                //Row.Cells["Aplica"].Value = true;
                if (Convert.ToBoolean(Row.Cells["Aplica"].Value))
                {
                    Row.Cells["Aplica"].Value = true;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                    Row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    Row.Cells["Aplica"].Value = false;
                    Row.DefaultCellStyle.BackColor = Color.White;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        private void FrmCalibracion_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void dataItemCalibracion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // Detecta si se ha seleccionado el header de la grilla
            //
            if (e.RowIndex == -1)
                return;

            if (dataItemCalibracion.Columns[e.ColumnIndex].Name == "Aplica")
            {

                //
                // Se toma la fila seleccionada
                //
                DataGridViewRow row = dataItemCalibracion.Rows[e.RowIndex];

                //
                // Se selecciona la celda del checkbox
                //
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Aplica"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                {
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
                }

            }
        }

        private void dataItemCalibracion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dataItemCalibracion.IsCurrentCellDirty)
            {
                dataItemCalibracion.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (dataItemCalibracion.CurrentRow.Index == -1)
                    return;

                DataGridViewCheckBoxCell cellSelecion = (DataGridViewCheckBoxCell)dataItemCalibracion[0, dataItemCalibracion.CurrentRow.Index];
                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                else
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;

                dataItemCalibracion[4, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
                dataItemCalibracion[6, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
                dataItemCalibracion[7, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor;
            }
        }

        private void dataItemCalibracion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Style.BackColor = Color.White;
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Selected = true;
                dataItemCalibracion.BeginEdit(true);
            }
        }

        private void dataItemCalibracion_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                dataItemCalibracion[e.ColumnIndex, dataItemCalibracion.CurrentRow.Index].Style.BackColor = dataItemCalibracion.DefaultCellStyle.SelectionBackColor ;

            if (e.ColumnIndex == 4)
            try
            {
                string Obtenido = Convert.ToString(dataItemCalibracion[e.ColumnIndex, e.RowIndex].Value);
                if (Obtenido == string.Empty) Obtenido = "0,00";
                dataItemCalibracion[e.ColumnIndex, e.RowIndex].Value = string.Format("{0:#,0.00###}", Convert.ToDecimal(Obtenido));
                
                decimal Esperado = Convert.ToDecimal(dataItemCalibracion[3, e.RowIndex].Value);
                Decimal Diferencia = Convert.ToDecimal(Obtenido) - Esperado;
                dataItemCalibracion[6, e.RowIndex].Value = Diferencia;

                }
            catch (Exception)
            {
                //throw;
            }

        }

        private void dataItemCalibracion_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell cellSelecion = (DataGridViewCheckBoxCell)dataItemCalibracion[0, dataItemCalibracion.CurrentRow.Index];
                if (Convert.ToBoolean(cellSelecion.Value == DBNull.Value ? false : cellSelecion.Value))
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.DarkSeaGreen;
                else
                    dataItemCalibracion.DefaultCellStyle.SelectionBackColor = Color.White;
            }
            catch
            {
                return;
            }

        }

        private void dataItemCalibracion_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataItemCalibracion.CurrentRow.Index == -1)
                return;

            if (dataItemCalibracion.CurrentCell.ColumnIndex == 4 || dataItemCalibracion.CurrentCell.ColumnIndex == 6)
            {
                TextBox TxtActual = e.Control as TextBox;
                TxtActual.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            }
                
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(Convert.ToInt32(DataIdentidad.Cells[0].Value));
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);

            txtId.Text = Convert.ToString(DataIdentidad.Cells[1].Value);
            txtEstado.Text = Convert.ToString(DataIdentidad.Cells[3].Value);
            txtCodEmp.Text = Convert.ToString(DataIdentidad.Cells[4].Value);
            txtNomEmp.Text = Convert.ToString(DataIdentidad.Cells[5].Value);
            txtCertificado.Text = Convert.ToString(DataIdentidad.Cells[9].Value);
            txtMarca.Text = Convert.ToString(DataIdentidad.Cells[10].Value);

            if (AccionEnviada == "Nuevo")
            {
                txtCalibra.Text = Convert.ToString(NCalibracion.ProximoCodigoIndividual(Convert.ToInt32(DataIdentidad.Cells[0].Value), Convert.ToInt32(DataIdentidad.Cells[1].Value)));
                dtpFecCalib.Text = Convert.ToString(DataIdentidad.Cells[8].Value);
                dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
            }
            else if (AccionEnviada == "Actualizar")
            {
                txtCalibra.Text = Convert.ToString(DataCalibracion.Cells[3].Value);
                dtpFecCalib.Text = Convert.ToString(DataCalibracion.Cells[4].Value);
                dtpProxCalib.Text = Convert.ToString(Funciones.ProximaFechaCalibracion(Convert.ToInt32(DataIdentidad.Cells[0].Value), txtEstado.Text.Trim(), dtpFecCalib.Value));
            }


            txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCodEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtNomEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCertificado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtCalibra.BackColor = System.Drawing.SystemColors.ControlLightLight;

        }

        private void CargarDetalles()
        {
            dataItemCalibracion.AutoGenerateColumns = false;
            if (AccionEnviada == "Nuevo")
            {
                dataItemCalibracion.DataSource = DataItemsCalibracion;
                dataItemCalibracion.ClearSelection();
            }
            else if (AccionEnviada == "Actualizar")
            {
                DataTable DTDeta = NCalibracion.BuscarDetalles(Convert.ToInt32(DataCalibracion.Cells[3].Value)
                                                               , Convert.ToInt32(DataIdentidad.Cells[1].Value)
                                                               , Convert.ToInt32(DataIdentidad.Cells[0].Value));
                dataItemCalibracion.Columns[0].DataPropertyName = "Selecc";
                dataItemCalibracion.Columns[1].DataPropertyName = "id_Item";
                dataItemCalibracion.Columns[4].DataPropertyName = "MediObtenida";
                dataItemCalibracion.Columns[6].DataPropertyName = "DiferObtenida";
                dataItemCalibracion.Columns[7].DataPropertyName = "Estado";

                dataItemCalibracion.DataSource = DTDeta;

            }

            for (int i = 0; i <= dataItemCalibracion.ColumnCount - 1; i++)
            {
                dataItemCalibracion.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

    }

}
