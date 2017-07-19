using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmItemsComprobacion : Form
    {
        public FrmItemsComprobacion()
        {
            InitializeComponent();
        }

        private void FrmItemsComprobacion_Load(object sender, EventArgs e)
        {
            Limpiar();
            Listar();
            txtMetodo.Focus();
            txtItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        private void FrmItemsComprobacion_Paint(object sender, PaintEventArgs e)
        {
            Visuales.FondoDegradado(this, e);
            Visuales.LineaCabecera(this, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Paint(object sender, PaintEventArgs e)
        {
        //    Graphics g = e.Graphics;
        //    if (1==2)
        //    {
        //        g.DrawString("This is a diagonal line drawn on the control",
        //            new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
        //        g.DrawLine(System.Drawing.Pens.Red, btnCancelar.Left, btnCancelar.Top,
        //            btnCancelar.Right, btnCancelar.Bottom);
        //    }
        //    else {
        //        g.FillRectangle(
        //            new LinearGradientBrush(PointF.Empty, new PointF(0, btnCancelar.Height), Color.White, Color.Red),
        //            new RectangleF(PointF.Empty, btnCancelar.Size));
        //    }
        }

        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            Funciones.Formato_Decimal(TxtActual, e);
            if (e.KeyChar == Convert.ToChar(13))
            {
                SendKeys.Send("{TAB}");
                //textBox4.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(textBox4.Text));
            }
        }

        private void txtRango_Validated(object sender, EventArgs e)
        {
            TextBox TxtActual = (TextBox)sender;
            try
            {
                if (TxtActual.Text == string.Empty) TxtActual.Text = "0,00";
                TxtActual.Text = string.Format("{0:#,0.00###}", Convert.ToDecimal(TxtActual.Text));
            }
            catch (Exception)
            {
                //throw;
            }

        }

        //Limpia y Carga los Controles del Formulario
        private void Limpiar()
        {
            btnAgregar.Text = "&Agregar";
            btnNuevo.Enabled = false;
            CargarProximoItem();
            txtMetodo.Text = string.Empty;
            txtUnidad.Text = string.Empty;
            txtRango.Text = "0,00";
            txtResolucion.Text = "0,00";
            txtCriterio.Text = "0,00";
        }

        //Trae el Proximo codigo de Item a Registrar
        private void CargarProximoItem()
        {
            int iProx = NItemComprobacion.ProximoCodigo();
            txtItem.Text = Convert.ToString(iProx);
            //DataTable DT = new DataTable();
            //DT = NItemComprobacion.Ultimo();
            //if (DT.Rows.Count == 0)
            //    txtItem.Text = "1";
            //else
            //    txtItem.Text = Convert.ToString((int)(DT.Rows[0][0]) + 1) ;
        }

        private void Listar()
        {
            dataItems.DataSource = NItemComprobacion.Listar();
            dataItems.AutoResizeColumn(1);
            dataItems.Columns[1].Width = 250;
            dataItems.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItems.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItems.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataItems.Columns[3].DefaultCellStyle.Format = "#,0.00###";
            dataItems.Columns[4].DefaultCellStyle.Format = "#,0.00###";
            dataItems.Columns[5].DefaultCellStyle.Format = "#,0.00###";
            dataItems.ClearSelection();
            //dataItems.SelectedRows[0].Selected = false;
        }

        //Boton Agregar / Modificar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if (ValidarCampos())
            {
                switch (btnAgregar.Text.Replace("&",""))
                {
                    case "Agregar":
                        rpta = NItemComprobacion.Insertar(txtMetodo.Text,
                                                          txtUnidad.Text,
                                                          Funciones.ConvertStringToDouble(txtRango.Text),
                                                          Funciones.ConvertStringToDouble(txtResolucion.Text),
                                                          Funciones.ConvertStringToDouble(txtCriterio.Text));
                        break;
                    case "Actualizar":
                        rpta = NItemComprobacion.Actualizar(Convert.ToInt32(txtItem.Text),
                                                            txtMetodo.Text,
                                                            txtUnidad.Text,
                                                            Funciones.ConvertStringToDouble(txtRango.Text),
                                                            Funciones.ConvertStringToDouble(txtResolucion.Text),
                                                            Funciones.ConvertStringToDouble(txtCriterio.Text));
                        break;
                }

                if (rpta.Equals("OK"))
                {
                    if (btnAgregar.Text.Replace("&", "")== "Agregar")
                    {
                        this.MensajeOk("Se Insertó de forma correcta el registro");
                        Listar();
                        Limpiar();
                        dataItems.Rows[(dataItems.RowCount - 1)].Selected = true;
                        dataItems.FirstDisplayedScrollingRowIndex = dataItems.RowCount - 1;
                        CargarCampos(dataItems.RowCount - 1);
                        //DataGridViewCellEventArgs arg = new DataGridViewCellEventArgs(3, 3);
                        //this.dataItems_CellClick(this.dataItems, arg);
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta el registro");
                        int nRow = dataItems.CurrentRow.Index;
                        Listar();
                        dataItems.Rows[nRow].Selected = true;
                        //this.dataItems.CurrentCell = this.dataItems[1, (dataItems.Rows.Count - 1)];

                        //dataItems.Rows[(dataItems.Rows.Count - 1)].Selected = true;
                        //dataItems.Rows.OfType<DataGridViewRow>().Last().Selected = true;
                    }
                }
                else
                {
                    this.MensajeError(rpta);
                }

                
            }
        }

        //Valida Campos antes de Agregar o Modificar un Registro
        private bool ValidarCampos()
        {
            bool Valido = true;

           if (txtMetodo.Text==string.Empty)
            {
                errorIcono.SetError(txtMetodo, "Ingrese un Metodo");
                Valido = false;
            }
           else if (txtUnidad.Text == string.Empty)
            {
                errorIcono.SetError(txtUnidad, "Ingrese una Unidad de Medida");
                Valido = false;
            }

            return Valido;
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void txtMetodo_TextChanged(object sender, EventArgs e)
        {
            errorIcono.SetError(txtMetodo, "");
        }

        private void txtUnidad_TextChanged(object sender, EventArgs e)
        {
            errorIcono.SetError(txtUnidad, "");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            dataItems.ClearSelection();
            txtMetodo.Focus();
        }

        private void dataItems_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataItems.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverCol = dataItems.HitTest(e.X, e.Y).ColumnIndex;

            if (dataItems.Rows.Count > 0 && currentMouseOverRow >= 0)
            {
                dataItems.CurrentCell = dataItems[currentMouseOverCol, currentMouseOverRow];
                //CargarCampos(currentMouseOverRow);
            }

            if (e.Button == MouseButtons.Right)
            {
                //ContextMenu menu_contextual = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Cut"));
                //m.MenuItems.Add(new MenuItem("Copy"));
                //m.MenuItems.Add(new MenuItem("Paste"));

                if (currentMouseOverRow >= 0)
                {
                    // m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                    //menu_contextual.MenuItems.Add(new MenuItem("Eliminar"));

                }

                try
                {
                    dataItems.Rows[(currentMouseOverRow)].Selected = true;
                    this.MenuContextual.Show(dataItems, new Point(e.X, e.Y));
                    this.MenuContextual.Show(Cursor.Position);
                    //menu_contextual.Show(dataItems, new Point(e.X, e.Y));


                }
                catch (Exception) { }
            }
        }

        private void CargarCampos(int nRow)
        {
            btnAgregar.Text = "&Actualizar";
            btnNuevo.Enabled = true;

            txtItem.Text = Convert.ToString(dataItems.Rows[nRow].Cells[0].Value);
            txtMetodo.Text = Convert.ToString(dataItems.Rows[nRow].Cells[1].Value);
            txtUnidad.Text = Convert.ToString(dataItems.Rows[nRow].Cells[2].Value);
            txtRango.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[3].Value);
            txtResolucion.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[4].Value);
            txtCriterio.Text = string.Format("{0:#,0.00###}", dataItems.Rows[nRow].Cells[5].Value);
        }

        private void eliminarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rpta = "";
            int nCodigo = (int)dataItems[0, dataItems.CurrentRow.Index].Value;

            if (MessageBox.Show("Eliminar el Item '"+Convert.ToString(dataItems[1, dataItems.CurrentRow.Index].Value)+"'", "Sistema Mantenimiento", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                rpta = NItemComprobacion.Eliminar(nCodigo);
                Listar();
                Limpiar();
                
            }

            
        }

        private void dataItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dataItems.SelectedRows.Count > 0)
            {
                int indice = dataItems.SelectedRows[0].Index;
                CargarCampos(indice);
            }
        }
    }
}
