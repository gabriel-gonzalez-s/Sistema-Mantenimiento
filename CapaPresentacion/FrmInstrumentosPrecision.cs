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
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class FrmInstrumentosPrecision : Form
    {
        private FrmInstrumentosPrecision instance;
        private bool BuscandoenDGV = false;
        private DataTable DTIndividualizacion;
        private DataTable DTIndividualizaFiltro;

        public FrmInstrumentosPrecision()
        {
            InitializeComponent();
            instance = this;

        }

        private void FrmInstrumentosPrecision_Load(object sender, EventArgs e)
        {
            ListarInstrumentos();
            ListarItemComprobacion();
            ListarIndividualizacion();
            ListarCalibracion();
            cmbBaja.SelectedItem = "Activos";
        }

        private void FrmInstrumentosPrecision_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarInstrumento Instrumento = new FrmAgregarInstrumento(this);
            Instrumento.ShowDialog();

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FrmItemsComprobacion Item = new FrmItemsComprobacion();
            Item.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrmIndividualizacion Individualizacion = new FrmIndividualizacion(dataIndividualizacion.RowCount == 0 ?  dataInstrumentos.Rows[dataInstrumentos.SelectedRows[0].Index]
                                                                                                     : dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index],"Agregar");
            Individualizacion.EnviarEvento += new FrmIndividualizacion.EnvEvent(ListarIndividualizacion); // Metodo Delegate para enviar ejecucion de evento desde FrmIndividualizacion
            Individualizacion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataIndividualizacion.RowCount > 0)
            {
                FrmIndividualizacion Individualizacion = new FrmIndividualizacion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index], "Actualizar");
                Individualizacion.EnviarEvento += new FrmIndividualizacion.EnvEvent(ListarIndividualizacion); // Metodo Delegate para enviar ejecucion de evento desde FrmIndividualizacion
                Individualizacion.ShowDialog();
            }

        }
        
        private void eliminarInstrumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rpta = "";
            int nId = Convert.ToInt32(dataInstrumentos.Rows[dataInstrumentos.CurrentRow.Index].Cells[0].Value);
            string nCodigo = Convert.ToString(dataInstrumentos[1, dataInstrumentos.CurrentRow.Index].Value);

            if (MessageBox.Show("Eliminar el Instrumento '" + Convert.ToString(dataInstrumentos[2, dataInstrumentos.CurrentRow.Index].Value) + "'", "Sistema Mantenimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                rpta = NInstrumento.Eliminar(nId, nCodigo);
                ListarInstrumentos();

            }
        }

        private void dataInstrumentos_MouseClick(object sender, MouseEventArgs e)
        {
            //ClickGridInstrumentos = true;
            int currentMouseOverRow = dataInstrumentos.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataInstrumentos.HitTest(e.X, e.Y).ColumnIndex;

            dataInstrumentos.CurrentCell = dataInstrumentos[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

            ListarItemComprobacion();
            //ListarIndividualizacion(); // La actualizacion del Grid de Individualizacion se hace en el evento SelectionChanged

            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataInstrumentos.Rows[(currentMouseOverRow)].Selected = true;
                    this.contextMenuInstru.Show(dataInstrumentos, new Point(e.X, e.Y));
                    this.contextMenuInstru.Show(Cursor.Position);
                    //menu_contextual.Show(dataItems, new Point(e.X, e.Y));


                }
                catch (Exception) { }
            }
        }

        private void dataInstrumentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell comboboxColumn1 = (DataGridViewComboBoxCell)dataInstrumentos.Rows[e.RowIndex].Cells[3];
                DataGridViewComboBoxCell comboboxColumn2 = (DataGridViewComboBoxCell)dataInstrumentos.Rows[e.RowIndex].Cells[4];

                if (e.ColumnIndex == comboboxColumn1.ColumnIndex || e.ColumnIndex == comboboxColumn2.ColumnIndex) //check if combobox column
                {
                    string rpta = NInstrumento.Actualizar( Convert.ToInt32(dataInstrumentos[0, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[1, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[2, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[3, dataInstrumentos.CurrentRow.Index].Value),
                                                           Convert.ToString(dataInstrumentos[4, dataInstrumentos.CurrentRow.Index].Value),
                                                           "A");
                    if(rpta!="OK")
                    {
                        this.MensajeError(rpta);
                    }
                    // object selectedValue = dataInstrumentos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
            }

        }


        private void btnAsociarItem_Click(object sender, EventArgs e)
        {
            FrmItemsInstrumento AsociarItem = new FrmItemsInstrumento(Convert.ToInt32(dataInstrumentos.Rows[dataInstrumentos.CurrentRow.Index].Cells[0].Value));
            AsociarItem.EnviarEvento += new FrmItemsInstrumento.EnvEvent(ListarItemComprobacion); // Metodo Delegate para enviar datos desde FrmEmplado
            AsociarItem.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCalibracion Calibracion = new FrmCalibracion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index],
                                                            (DataTable)dataItemsComp.DataSource,
                                                            dataCalibracion.Rows.Count == 0 ? null : dataCalibracion.Rows[dataCalibracion.SelectedRows[0].Index],
                                                            "Nuevo");
            Calibracion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCalibracion Calibracion = new FrmCalibracion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index],
                                                            (DataTable)dataItemsComp.DataSource,
                                                            dataCalibracion.Rows[dataCalibracion.SelectedRows[0].Index],
                                                            "Actualizar");
            Calibracion.ShowDialog();
        }

        private void dataInstrumentos_SelectionChanged(object sender, EventArgs e)
        {
            if (!BuscandoenDGV)
            {
                ListarItemComprobacion();
                ListarIndividualizacion();

            }
        }

        private void btnBuscarInstru_Click(object sender, EventArgs e)
        {
            if (this.txtInstru.Text == string.Empty)
            {
                errorIcono.SetError(txtInstru, "Ingrese Parte del Codigo o Descripcion a Buscar");
            }
            else
            {
                if (!BuscarDGV_LINQ(txtInstru.Text.ToUpper(), "2", dataInstrumentos))
                {
                    BuscarDGV_LINQ(txtInstru.Text.ToUpper(), "1", dataInstrumentos);
                }
            }
        }

        private void txtInstru_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.SetError(txtInstru, "");
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscarInstru.PerformClick();
            }
        }

        private void cmbBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarIndividualizacion();
        }


        private void dataIndividualizacion_SelectionChanged(object sender, EventArgs e)
        {
            ListarCalibracion();
            if (DTIndividualizaFiltro.Rows.Count == 0)
            {
                button4.Enabled = false;
                return;
            }
            else
                button4.Enabled = true;

        }

        private void dataIndividualizacion_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataIndividualizacion.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataIndividualizacion.HitTest(e.X, e.Y).ColumnIndex;

            dataIndividualizacion.CurrentCell = dataIndividualizacion[currentMouseOverCol, currentMouseOverRow < 0 ? 0 : currentMouseOverRow];

            if (e.Button == MouseButtons.Right && Convert.ToString(dataIndividualizacion[3, currentMouseOverRow].Value) != "Baja")
            {
                try
                {
                    dataIndividualizacion.Rows[(currentMouseOverRow)].Selected = true;
                    this.contextMenuIdent.Show(dataIndividualizacion, new Point(e.X, e.Y));
                    this.contextMenuIdent.Show(Cursor.Position);
                    //menu_contextual.Show(dataItems, new Point(e.X, e.Y));


                }
                catch (Exception) { }
            }
        }

        private void dataCalibracion_SelectionChanged(object sender, EventArgs e)
        {
            if (dataCalibracion.Rows.Count == 0)
            {
                button3.Enabled = false;
                return;
            }
            else
                button3.Enabled = true;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///  FUNIONES Y PROCEDIMIENTOS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Carga el DataGrid dataInstrumentos
        /// </summary>
        public void ListarInstrumentos()
        {
            // Asignar los datos a combos de frecuencia
            DataGridViewComboBoxColumn cmbfrecuencia = dataInstrumentos.Columns[3] as DataGridViewComboBoxColumn;

            cmbfrecuencia.DataSource = NFrecuencia.Listar();
            cmbfrecuencia.DisplayMember = "Descripcion";
            cmbfrecuencia.ValueMember = "Descripcion";

            cmbfrecuencia = dataInstrumentos.Columns[4] as DataGridViewComboBoxColumn;
            cmbfrecuencia.DataSource = NFrecuencia.Listar();
            cmbfrecuencia.DisplayMember = "Descripcion";
            cmbfrecuencia.ValueMember = "Descripcion";

            dataInstrumentos.AutoGenerateColumns = false;
            dataInstrumentos.DataSource = NInstrumento.Listar();
            dataInstrumentos.Columns[1].ReadOnly = true;
            dataInstrumentos.Columns[2].ReadOnly = true;
        }

        /// <summary>
        /// Carga el DataGrid dataItemsCompaa
        /// </summary>
        private void ListarItemComprobacion()
        {
            if (dataInstrumentos.SelectedRows.Count > 0)
            {
                int indice = dataInstrumentos.SelectedRows[0].Index;
                dataItemsComp.DataSource = NInstruItems.ListarAsignados(Convert.ToInt32(dataInstrumentos[0, indice].Value));
                dataItemsComp.AutoResizeColumns();
                dataItemsComp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataItemsComp.Columns[3].DefaultCellStyle.Format = "#,0.00###";
                dataItemsComp.Columns[4].DefaultCellStyle.Format = "#,0.00###";
                dataItemsComp.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            }

        }

        /// <summary>
        /// Carga el DataGrid dataIndividualizacion
        /// </summary>
        private void ListarIndividualizacion()
        {
            if (dataInstrumentos.SelectedRows.Count > 0)
            {
                int indice = dataInstrumentos.SelectedRows[0].Index;
                txtItemSelec.Text = Convert.ToString(dataInstrumentos[2, indice].Value);
                DTIndividualizacion = NIdentInstrumento.Listar(Convert.ToInt32(dataInstrumentos[0, indice].Value));
                DTIndividualizaFiltro = DTIndividualizacion.Clone();
                FiltrarIndividualizacion(cmbBaja.SelectedIndex);
                dataIndividualizacion.AutoResizeColumns();
            }

        }

        /// <summary>
        /// Carga el DataGrid dataIndividualizacion
        /// </summary>
        private void ListarCalibracion()
        {
            if (dataIndividualizacion.SelectedRows.Count > 0)
            {
                int indice = dataIndividualizacion.SelectedRows[0].Index;
                txtResponsable.Text = Convert.ToString(dataIndividualizacion[4, indice].Value) + " - " + Convert.ToString(dataIndividualizacion[5, indice].Value);
                dataCalibracion.DataSource = NCalibracion.Listar(Convert.ToInt32(dataIndividualizacion[0, indice].Value), Convert.ToInt32(dataIndividualizacion[1, indice].Value));
            }
            else
            {
                txtResponsable.Text = "-";
                //dataCalibracion.DataSource = null;
                DataTable DT = (DataTable)dataCalibracion.DataSource;
                if (DT != null)
                    DT.Clear();
                // if (dataCalibracion.Rows.Count > 0) dataCalibracion.Rows.Clear();
            }
        }


        /// <summary>
        /// Filta el DataGRid dataIndividualizacion de acuerdo al Estado del la Individualizacion
        /// </summary>
        /// <param name="IndiceCombo"></param>
        private void FiltrarIndividualizacion(int IndiceCombo)
        {
            try
            {
                DTIndividualizaFiltro = (from DataRow dr in DTIndividualizacion.Rows
                                         where (IndiceCombo == 0 ? dr[3].ToString() != "Baja"
                                                                 : IndiceCombo == 1 ? dr[3].ToString() == "Baja"
                                                                                    : true)
                                         select dr).CopyToDataTable();
            }
            catch 
            {

            }

            dataIndividualizacion.DataSource = DTIndividualizaFiltro;
        }

        /// <summary>
        ///   Buscar la primera coincidencia de una cadena en un DataGrid en una columna determinada
        ///   selecciona el row y ubica el scroll en dicha linea.
        /// </summary>
        /// <param name="TextoABuscar"></param>
        /// <param name="Columna"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        private bool BuscarDGV_LINQ(string TextoABuscar, string Columna, DataGridView grid)
        {
            BuscandoenDGV = true;
            bool encontrado = false;
            if (TextoABuscar == string.Empty) return false;
            if (grid.RowCount == 0) return false;
            //grid.ClearSelection();
            if (Columna == string.Empty)
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    from DataGridViewCell cells in row.Cells
                                                    where cells.OwningRow.Equals(row) && Convert.ToString(cells.Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    return true;
                }

            }
            else
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    where Convert.ToString(row.Cells[Convert.ToInt32(Columna)].Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    return true;
                }

            }
            BuscandoenDGV = false;
            return encontrado;


        }

        /// <summary>
        /// Mostrar Mensaje de Confirmación
        /// </summary>
        /// <param name="mensaje"></param>
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Mostrar Mensaje de Error
        /// </summary>
        /// <param name="mensaje"></param>
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void darDeBajaAIndividualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaIndividualizacion DarBaja = new FrmBajaIndividualizacion(dataIndividualizacion.Rows[dataIndividualizacion.SelectedRows[0].Index]);
            DarBaja.ShowDialog();
        }

    }
}
