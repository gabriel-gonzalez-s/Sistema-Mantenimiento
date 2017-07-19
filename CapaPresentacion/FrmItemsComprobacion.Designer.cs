namespace CapaPresentacion
{
    partial class FrmItemsComprobacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtMetodo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dataItems = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.MenuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCriterio);
            this.groupBox1.Controls.Add(this.txtResolucion);
            this.groupBox1.Controls.Add(this.txtRango);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtMetodo);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.dataItems);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenedor Item de Comprobacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Criterio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resolucion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rango a Medir Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unidad de Medicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Metodo Comprobacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(583, 350);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(100, 20);
            this.txtCriterio.TabIndex = 7;
            this.txtCriterio.Text = "0,00";
            this.txtCriterio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtCriterio.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(583, 327);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(100, 20);
            this.txtResolucion.TabIndex = 6;
            this.txtResolucion.Text = "0,00";
            this.txtResolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtResolucion.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(583, 304);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(100, 20);
            this.txtRango.TabIndex = 5;
            this.txtRango.Text = "0.00";
            this.txtRango.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRango.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRango_KeyPress);
            this.txtRango.Validated += new System.EventHandler(this.txtRango_Validated);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(160, 350);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 4;
            this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnidad.TextChanged += new System.EventHandler(this.txtUnidad_TextChanged);
            // 
            // txtMetodo
            // 
            this.txtMetodo.Location = new System.Drawing.Point(160, 327);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(277, 20);
            this.txtMetodo.TabIndex = 3;
            this.txtMetodo.TextChanged += new System.EventHandler(this.txtMetodo_TextChanged);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(160, 304);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 2;
            this.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataItems
            // 
            this.dataItems.AllowUserToAddRows = false;
            this.dataItems.AllowUserToDeleteRows = false;
            this.dataItems.AllowUserToOrderColumns = true;
            this.dataItems.AllowUserToResizeColumns = false;
            this.dataItems.AllowUserToResizeRows = false;
            this.dataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataItems.Location = new System.Drawing.Point(25, 25);
            this.dataItems.MultiSelect = false;
            this.dataItems.Name = "dataItems";
            this.dataItems.ReadOnly = true;
            this.dataItems.RowHeadersVisible = false;
            this.dataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItems.Size = new System.Drawing.Size(775, 271);
            this.dataItems.TabIndex = 1;
            this.dataItems.SelectionChanged += new System.EventHandler(this.dataItems_SelectionChanged);
            this.dataItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataItems_MouseClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Bnt;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(176, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCancelar_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BtnDfto1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(16, 412);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Khaki;
            this.btnNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.Bnt;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(96, 412);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 24);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // MenuContextual
            // 
            this.MenuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarItemToolStripMenuItem});
            this.MenuContextual.Name = "MenuContextual";
            this.MenuContextual.Size = new System.Drawing.Size(145, 26);
            // 
            // eliminarItemToolStripMenuItem
            // 
            this.eliminarItemToolStripMenuItem.Name = "eliminarItemToolStripMenuItem";
            this.eliminarItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarItemToolStripMenuItem.Text = "Eliminar Item";
            this.eliminarItemToolStripMenuItem.Click += new System.EventHandler(this.eliminarItemToolStripMenuItem_Click);
            // 
            // FrmItemsComprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 445);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmItemsComprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items de Comprobacion";
            this.Load += new System.EventHandler(this.FrmItemsComprobacion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmItemsComprobacion_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.MenuContextual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.DataGridView dataItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ContextMenuStrip MenuContextual;
        private System.Windows.Forms.ToolStripMenuItem eliminarItemToolStripMenuItem;
    }
}