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
    public partial class FrmItemsInstrumento : Form
    {
        public delegate void EnvEvent();
        public event EnvEvent EnviarEvento;

        private int IDInstrumento;
        public FrmItemsInstrumento(int IDInstrument)
        {
            IDInstrumento = IDInstrument;
            InitializeComponent();
        }

        private void FrmItemsInstrumento_Load(object sender, EventArgs e)
        {
            CargaEncabezado();
            ListarNoAsignados();
            ListarAsignados();
        }

        private void FrmItemsInstrumento_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void CargaEncabezado()
        {
            DataTable DTInstru = new DataTable();
            DTInstru = NInstrumento.Buscar(IDInstrumento);
            txtCodInstru.Text = Convert.ToString(DTInstru.Rows[0][1]);
            txtDescInstru.Text = Convert.ToString(DTInstru.Rows[0][2]);

            txtCodInstru.Enabled = false;
            txtDescInstru.Enabled = false;

            txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;

        }

        private void ListarNoAsignados()
        {
            dataItemsNA.DataSource = NInstruItems.ListarNoAsignados(IDInstrumento);
            dataItemsNA.AutoResizeColumns();
            dataItemsNA.Columns[1].Width = 250;
            dataItemsNA.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsNA.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsNA.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsNA.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsNA.Columns[3].DefaultCellStyle.Format = "#,0.00###";
            dataItemsNA.Columns[4].DefaultCellStyle.Format = "#,0.00###";
            dataItemsNA.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            dataItemsNA.ClearSelection();
            //dataItems.SelectedRows[0].Selected = false;
        }

        private void ListarAsignados()
        {
            dataItemsAS.DataSource = NInstruItems.ListarAsignados(IDInstrumento);
            dataItemsAS.AutoResizeColumns();
            dataItemsAS.Columns[1].Width = 250;
            dataItemsAS.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsAS.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsAS.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsAS.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItemsAS.Columns[3].DefaultCellStyle.Format = "#,0.00###";
            dataItemsAS.Columns[4].DefaultCellStyle.Format = "#,0.00###";
            dataItemsAS.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            dataItemsAS.ClearSelection();
            //dataItems.SelectedRows[0].Selected = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataItemsNA.SelectedRows.Count > 0 )
            {
                int indice = dataItemsNA.SelectedRows[0].Index;
                DataGridViewRow RowDG = dataItemsNA.Rows[indice];
                DataTable DTNA = (DataTable)dataItemsNA.DataSource;
                DataRow RowDTNA =  DTNA.Rows[indice];

                DataTable DTAS = (DataTable)dataItemsAS.DataSource;
                DTAS.ImportRow(RowDTNA);
                DTNA.Rows.Remove(RowDTNA);
                //dataItemsNA.Rows.Remove(RowDG);

                dataItemsNA.Sort(dataItemsNA.Columns[0], ListSortDirection.Ascending);
                dataItemsAS.Sort(dataItemsAS.Columns[0], ListSortDirection.Ascending);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable DTNA = (DataTable)dataItemsNA.DataSource;
            DataTable DTAS = (DataTable)dataItemsAS.DataSource;

            foreach (DataRow RowDTNA in DTNA.Rows)
            {
                DTAS.ImportRow(RowDTNA);
            }

            DTNA.Rows.Clear();
            dataItemsAS.Sort(dataItemsAS.Columns[0], ListSortDirection.Ascending);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataItemsAS.SelectedRows.Count > 0)
            {
                int indice = dataItemsAS.SelectedRows[0].Index;
                DataGridViewRow RowDG = dataItemsAS.Rows[indice];
                DataTable DTAS = (DataTable)dataItemsAS.DataSource;
                DataRow RowDTAS = DTAS.Rows[indice];

                DataTable DTNA = (DataTable)dataItemsNA.DataSource;
                DTNA.ImportRow(RowDTAS);
                DTAS.Rows.Remove(RowDTAS);
                //dataItemsAS.Rows.Remove(RowDG);

                dataItemsNA.Sort(dataItemsNA.Columns[0], ListSortDirection.Ascending);
                dataItemsAS.Sort(dataItemsAS.Columns[0], ListSortDirection.Ascending);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable DTNA = (DataTable)dataItemsNA.DataSource;
            DataTable DTAS = (DataTable)dataItemsAS.DataSource;

            foreach (DataRow RowDTSA in DTAS.Rows)
            {
                DTNA.ImportRow(RowDTSA);
            }

            DTAS.Rows.Clear();
            dataItemsNA.Sort(dataItemsNA.Columns[0], ListSortDirection.Ascending);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Eliminar los Items Actuales Asociados
            NInstruItems.Eliminar(IDInstrumento);

            foreach(DataGridViewRow RowDG in dataItemsAS.Rows)
            {
                NInstruItems.Insertar(IDInstrumento, 
                                      Convert.ToInt32(RowDG.Cells[0].Value),
                                      Convert.ToString(RowDG.Cells[1].Value),
                                      Convert.ToString(RowDG.Cells[2].Value), 
                                      Convert.ToDouble(RowDG.Cells[3].Value),
                                      Convert.ToDouble(RowDG.Cells[4].Value),
                                      Convert.ToDouble(RowDG.Cells[5].Value));
            }

            EnviarEvento();
            this.Close();
        }
    }
}
