namespace CapaPresentacion
{
    partial class FrmCalibracion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalibracion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataItemCalibracion = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProxCalib = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.dtpFecCalib = new System.Windows.Forms.DateTimePicker();
            this.txtCalibra = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescInstru = new System.Windows.Forms.TextBox();
            this.txtCodInstru = new System.Windows.Forms.TextBox();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.Aplica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Analisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Espe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif_Med_Obte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCalibracion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataItemCalibracion);
            this.groupBox1.Location = new System.Drawing.Point(17, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibracion por Items";
            // 
            // dataItemCalibracion
            // 
            this.dataItemCalibracion.AllowUserToAddRows = false;
            this.dataItemCalibracion.AllowUserToDeleteRows = false;
            this.dataItemCalibracion.AllowUserToOrderColumns = true;
            this.dataItemCalibracion.AllowUserToResizeColumns = false;
            this.dataItemCalibracion.AllowUserToResizeRows = false;
            this.dataItemCalibracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItemCalibracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aplica,
            this.Item,
            this.Tipo_Analisis,
            this.Med_Espe,
            this.Med_Obte,
            this.Dif_Med_Esp,
            this.Dif_Med_Obte,
            this.Evaluacion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemCalibracion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataItemCalibracion.Location = new System.Drawing.Point(19, 27);
            this.dataItemCalibracion.MultiSelect = false;
            this.dataItemCalibracion.Name = "dataItemCalibracion";
            this.dataItemCalibracion.RowHeadersVisible = false;
            this.dataItemCalibracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemCalibracion.Size = new System.Drawing.Size(833, 180);
            this.dataItemCalibracion.TabIndex = 1;
            this.dataItemCalibracion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellClick);
            this.dataItemCalibracion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellContentClick);
            this.dataItemCalibracion.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCalibracion_CellLeave);
            this.dataItemCalibracion.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataItemCalibracion_CurrentCellDirtyStateChanged);
            this.dataItemCalibracion.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataItemCalibracion_EditingControlShowing);
            this.dataItemCalibracion.SelectionChanged += new System.EventHandler(this.dataItemCalibracion_SelectionChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(96, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BtnDfto1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(15, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpProxCalib);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.txtCertificado);
            this.groupBox2.Controls.Add(this.dtpFecCalib);
            this.groupBox2.Controls.Add(this.txtCalibra);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtDescInstru);
            this.groupBox2.Controls.Add(this.txtCodInstru);
            this.groupBox2.Controls.Add(this.txtNomEmp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodEmp);
            this.groupBox2.Location = new System.Drawing.Point(20, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 148);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Calibracion Instrumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Proxima";
            // 
            // dtpProxCalib
            // 
            this.dtpProxCalib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProxCalib.Location = new System.Drawing.Point(757, 68);
            this.dtpProxCalib.Name = "dtpProxCalib";
            this.dtpProxCalib.Size = new System.Drawing.Size(92, 20);
            this.dtpProxCalib.TabIndex = 42;
            this.dtpProxCalib.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEstado.Location = new System.Drawing.Point(757, 22);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(92, 20);
            this.txtEstado.TabIndex = 41;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Marca Instrumento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "N° Serie Instrumento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Usuario Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha Calibracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(694, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Calibracion N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Codigo Identificador";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtMarca.Location = new System.Drawing.Point(122, 114);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(245, 20);
            this.txtMarca.TabIndex = 33;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Enabled = false;
            this.txtCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCertificado.Location = new System.Drawing.Point(122, 91);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(245, 20);
            this.txtCertificado.TabIndex = 32;
            // 
            // dtpFecCalib
            // 
            this.dtpFecCalib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecCalib.Location = new System.Drawing.Point(757, 45);
            this.dtpFecCalib.Name = "dtpFecCalib";
            this.dtpFecCalib.Size = new System.Drawing.Size(92, 20);
            this.dtpFecCalib.TabIndex = 31;
            this.dtpFecCalib.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtCalibra
            // 
            this.txtCalibra.Enabled = false;
            this.txtCalibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCalibra.Location = new System.Drawing.Point(256, 45);
            this.txtCalibra.Name = "txtCalibra";
            this.txtCalibra.Size = new System.Drawing.Size(50, 20);
            this.txtCalibra.TabIndex = 30;
            this.txtCalibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(122, 45);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 29;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescInstru
            // 
            this.txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescInstru.Enabled = false;
            this.txtDescInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDescInstru.Location = new System.Drawing.Point(256, 22);
            this.txtDescInstru.Name = "txtDescInstru";
            this.txtDescInstru.Size = new System.Drawing.Size(333, 20);
            this.txtDescInstru.TabIndex = 28;
            // 
            // txtCodInstru
            // 
            this.txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodInstru.Enabled = false;
            this.txtCodInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCodInstru.Location = new System.Drawing.Point(122, 22);
            this.txtCodInstru.Name = "txtCodInstru";
            this.txtCodInstru.Size = new System.Drawing.Size(129, 20);
            this.txtCodInstru.TabIndex = 27;
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomEmp.Enabled = false;
            this.txtNomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNomEmp.Location = new System.Drawing.Point(256, 68);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.ReadOnly = true;
            this.txtNomEmp.Size = new System.Drawing.Size(333, 20);
            this.txtNomEmp.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Instrumento ";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodEmp.Enabled = false;
            this.txtCodEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCodEmp.Location = new System.Drawing.Point(122, 68);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.ReadOnly = true;
            this.txtCodEmp.Size = new System.Drawing.Size(129, 20);
            this.txtCodEmp.TabIndex = 24;
            // 
            // Aplica
            // 
            this.Aplica.HeaderText = "Aplica";
            this.Aplica.Name = "Aplica";
            this.Aplica.Width = 45;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Codigo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Item.DefaultCellStyle = dataGridViewCellStyle1;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 45;
            // 
            // Tipo_Analisis
            // 
            this.Tipo_Analisis.DataPropertyName = "Metodo";
            this.Tipo_Analisis.HeaderText = "Tipo Analisis";
            this.Tipo_Analisis.Name = "Tipo_Analisis";
            this.Tipo_Analisis.ReadOnly = true;
            this.Tipo_Analisis.Width = 250;
            // 
            // Med_Espe
            // 
            this.Med_Espe.DataPropertyName = "Rango";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Med_Espe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Med_Espe.HeaderText = "Medicion Esperada";
            this.Med_Espe.Name = "Med_Espe";
            this.Med_Espe.ReadOnly = true;
            // 
            // Med_Obte
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0,00";
            this.Med_Obte.DefaultCellStyle = dataGridViewCellStyle3;
            this.Med_Obte.HeaderText = "Medicion Obtenida";
            this.Med_Obte.Name = "Med_Obte";
            // 
            // Dif_Med_Esp
            // 
            this.Dif_Med_Esp.DataPropertyName = "Criterio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Dif_Med_Esp.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dif_Med_Esp.HeaderText = "Diferencia Med Esperada";
            this.Dif_Med_Esp.Name = "Dif_Med_Esp";
            this.Dif_Med_Esp.ReadOnly = true;
            // 
            // Dif_Med_Obte
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0,00";
            this.Dif_Med_Obte.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dif_Med_Obte.HeaderText = "Diferencia Med Obtenida";
            this.Dif_Med_Obte.Name = "Dif_Med_Obte";
            this.Dif_Med_Obte.ReadOnly = true;
            // 
            // Evaluacion
            // 
            this.Evaluacion.DisplayStyleForCurrentCellOnly = true;
            this.Evaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Evaluacion.HeaderText = "Evaluacion";
            this.Evaluacion.Items.AddRange(new object[] {
            "Aprobado",
            "Rechazado"});
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Width = 80;
            // 
            // FrmCalibracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalibracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Calibracion y Mantencion por Instrumento";
            this.Load += new System.EventHandler(this.FrmCalibracion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCalibracion_Paint);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCalibracion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataItemCalibracion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProxCalib;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.DateTimePicker dtpFecCalib;
        private System.Windows.Forms.TextBox txtCalibra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescInstru;
        private System.Windows.Forms.TextBox txtCodInstru;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aplica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Analisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Espe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Med_Obte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Esp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif_Med_Obte;
        private System.Windows.Forms.DataGridViewComboBoxColumn Evaluacion;
    }
}