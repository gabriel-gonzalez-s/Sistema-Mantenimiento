namespace CapaPresentacion
{
    partial class FrmBajaIndividualizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaIndividualizacion));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.TxtNomIns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodIns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtCalibra = new System.Windows.Forms.TextBox();
            this.txtCodInstru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescInstru = new System.Windows.Forms.TextBox();
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(93, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtResponsable);
            this.groupBox1.Controls.Add(this.TxtNomIns);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCodIns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpIngreso);
            this.groupBox1.Controls.Add(this.txtCalibra);
            this.groupBox1.Controls.Add(this.txtCodInstru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 381);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Baja";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(183)))), ((int)(((byte)(18)))));
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponsable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResponsable.Location = new System.Drawing.Point(14, 162);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(601, 20);
            this.txtResponsable.TabIndex = 29;
            this.txtResponsable.Text = "INFORME INSPECCION Y ENSAYO";
            this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNomIns
            // 
            this.TxtNomIns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNomIns.Location = new System.Drawing.Point(233, 191);
            this.TxtNomIns.Name = "TxtNomIns";
            this.TxtNomIns.ReadOnly = true;
            this.TxtNomIns.Size = new System.Drawing.Size(245, 20);
            this.TxtNomIns.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha Inspeccion";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.foldersearchico;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(483, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodIns
            // 
            this.txtCodIns.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodIns.Location = new System.Drawing.Point(135, 191);
            this.txtCodIns.Name = "txtCodIns";
            this.txtCodIns.ReadOnly = true;
            this.txtCodIns.Size = new System.Drawing.Size(93, 20);
            this.txtCodIns.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Usuario Inspector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observaciones";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(135, 214);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(92, 20);
            this.dtpIngreso.TabIndex = 9;
            this.dtpIngreso.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // txtCalibra
            // 
            this.txtCalibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalibra.Location = new System.Drawing.Point(134, 237);
            this.txtCalibra.Multiline = true;
            this.txtCalibra.Name = "txtCalibra";
            this.txtCalibra.Size = new System.Drawing.Size(479, 132);
            this.txtCalibra.TabIndex = 8;
            // 
            // txtCodInstru
            // 
            this.txtCodInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodInstru.Location = new System.Drawing.Point(135, 31);
            this.txtCodInstru.Name = "txtCodInstru";
            this.txtCodInstru.ReadOnly = true;
            this.txtCodInstru.Size = new System.Drawing.Size(87, 20);
            this.txtCodInstru.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrumento   ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDescInstru);
            this.panel1.Controls.Add(this.txtNomEmp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCodEmp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCertificado);
            this.panel1.Controls.Add(this.txtBaja);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(14, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 132);
            this.panel1.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(213, 8);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.Size = new System.Drawing.Size(47, 20);
            this.txtId.TabIndex = 7;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Feha P. en Servicio";
            // 
            // txtDescInstru
            // 
            this.txtDescInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescInstru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescInstru.Location = new System.Drawing.Point(120, 31);
            this.txtDescInstru.Name = "txtDescInstru";
            this.txtDescInstru.ReadOnly = true;
            this.txtDescInstru.Size = new System.Drawing.Size(339, 20);
            this.txtDescInstru.TabIndex = 5;
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomEmp.Location = new System.Drawing.Point(214, 54);
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.ReadOnly = true;
            this.txtNomEmp.Size = new System.Drawing.Size(245, 20);
            this.txtNomEmp.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Marca Instrumento";
            // 
            // txtCodEmp
            // 
            this.txtCodEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodEmp.Location = new System.Drawing.Point(120, 54);
            this.txtCodEmp.Name = "txtCodEmp";
            this.txtCodEmp.ReadOnly = true;
            this.txtCodEmp.Size = new System.Drawing.Size(87, 20);
            this.txtCodEmp.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "N° Serie Instrumento";
            // 
            // txtCertificado
            // 
            this.txtCertificado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCertificado.Location = new System.Drawing.Point(120, 77);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.ReadOnly = true;
            this.txtCertificado.Size = new System.Drawing.Size(245, 20);
            this.txtCertificado.TabIndex = 14;
            // 
            // txtBaja
            // 
            this.txtBaja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBaja.Location = new System.Drawing.Point(494, 77);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.ReadOnly = true;
            this.txtBaja.Size = new System.Drawing.Size(88, 20);
            this.txtBaja.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Usuario Responsable";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMarca.Location = new System.Drawing.Point(120, 101);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(245, 20);
            this.txtMarca.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BtnDfto1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::CapaPresentacion.Properties.Resources.printer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(556, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Ver Acta";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmBajaIndividualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmBajaIndividualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acta para Dar de Baja ";
            this.Load += new System.EventHandler(this.FrmBajaIndividualizacion_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmBajaIndividualizacion_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescInstru;
        private System.Windows.Forms.TextBox txtCodInstru;
        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TxtNomIns;
        private System.Windows.Forms.TextBox txtCodIns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalibra;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Button button2;
    }
}