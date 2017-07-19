namespace CapaPresentacion
{
    partial class FrmInstrumentosPrecision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstrumentosPrecision));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataInstrumentos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frec_Nvo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Frec_Usa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarInstru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstru = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataItemsComp = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnAsociarItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitButton1 = new wyDay.Controls.SplitButton();
            this.contextMenuIdent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.darDeBajaAIndividualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaja = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataIndividualizacion = new System.Windows.Forms.DataGridView();
            this.id_instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_indivual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calib_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Trab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Trab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultima_Calib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prox_Calib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataCalibracion = new System.Windows.Forms.DataGridView();
            this.Id_Intrumento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_identidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Calibracion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Calibracion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuInstru = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarInstrumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtItemSelec = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataInstrumentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsComp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuIdent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndividualizacion)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCalibracion)).BeginInit();
            this.contextMenuInstru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInstrumentos
            // 
            this.dataInstrumentos.AllowUserToAddRows = false;
            this.dataInstrumentos.AllowUserToDeleteRows = false;
            this.dataInstrumentos.AllowUserToOrderColumns = true;
            this.dataInstrumentos.AllowUserToResizeRows = false;
            this.dataInstrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstrumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Descripcion,
            this.Frec_Nvo,
            this.Frec_Usa});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataInstrumentos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataInstrumentos.Location = new System.Drawing.Point(12, 24);
            this.dataInstrumentos.MultiSelect = false;
            this.dataInstrumentos.Name = "dataInstrumentos";
            this.dataInstrumentos.RowHeadersVisible = false;
            this.dataInstrumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInstrumentos.Size = new System.Drawing.Size(608, 271);
            this.dataInstrumentos.TabIndex = 0;
            this.dataInstrumentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInstrumentos_CellValueChanged);
            this.dataInstrumentos.CurrentCellDirtyStateChanged += new System.EventHandler(this.cmbBaja_SelectedIndexChanged);
            this.dataInstrumentos.SelectionChanged += new System.EventHandler(this.dataInstrumentos_SelectionChanged);
            this.dataInstrumentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataInstrumentos_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 270;
            // 
            // Frec_Nvo
            // 
            this.Frec_Nvo.DataPropertyName = "Frecuencia_Nvo";
            this.Frec_Nvo.DisplayStyleForCurrentCellOnly = true;
            this.Frec_Nvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frec_Nvo.HeaderText = "Calib. Nvo.";
            this.Frec_Nvo.Name = "Frec_Nvo";
            this.Frec_Nvo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Frec_Nvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Frec_Nvo.Width = 95;
            // 
            // Frec_Usa
            // 
            this.Frec_Usa.DataPropertyName = "Frecuencia_Usa";
            this.Frec_Usa.DisplayStyleForCurrentCellOnly = true;
            this.Frec_Usa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frec_Usa.HeaderText = "Calib. Usa.";
            this.Frec_Usa.Name = "Frec_Usa";
            this.Frec_Usa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Frec_Usa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Frec_Usa.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscarInstru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInstru);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.dataInstrumentos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Instrumentos de Precision";
            // 
            // btnBuscarInstru
            // 
            this.btnBuscarInstru.BackgroundImage = global::CapaPresentacion.Properties.Resources.Bnt;
            this.btnBuscarInstru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarInstru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarInstru.Image = global::CapaPresentacion.Properties.Resources.LupaP2;
            this.btnBuscarInstru.Location = new System.Drawing.Point(595, 304);
            this.btnBuscarInstru.Name = "btnBuscarInstru";
            this.btnBuscarInstru.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarInstru.TabIndex = 4;
            this.btnBuscarInstru.UseVisualStyleBackColor = true;
            this.btnBuscarInstru.Click += new System.EventHandler(this.btnBuscarInstru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar    ";
            // 
            // txtInstru
            // 
            this.txtInstru.Location = new System.Drawing.Point(374, 305);
            this.txtInstru.Name = "txtInstru";
            this.txtInstru.Size = new System.Drawing.Size(202, 21);
            this.txtInstru.TabIndex = 2;
            this.txtInstru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstru_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Khaki;
            this.BtnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Bnt;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(12, 303);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "&Agregar Intrumento";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dataItemsComp
            // 
            this.dataItemsComp.AllowUserToAddRows = false;
            this.dataItemsComp.AllowUserToDeleteRows = false;
            this.dataItemsComp.AllowUserToOrderColumns = true;
            this.dataItemsComp.AllowUserToResizeRows = false;
            this.dataItemsComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemsComp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataItemsComp.Location = new System.Drawing.Point(13, 24);
            this.dataItemsComp.MultiSelect = false;
            this.dataItemsComp.Name = "dataItemsComp";
            this.dataItemsComp.ReadOnly = true;
            this.dataItemsComp.RowHeadersVisible = false;
            this.dataItemsComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemsComp.Size = new System.Drawing.Size(587, 270);
            this.dataItemsComp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnItems);
            this.groupBox2.Controls.Add(this.btnAsociarItem);
            this.groupBox2.Controls.Add(this.dataItemsComp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(661, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items de Comprobacion Asociados al Instrumento";
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Khaki;
            this.btnItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItems.BackgroundImage")));
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItems.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Location = new System.Drawing.Point(480, 303);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(120, 23);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "&Items Comprobacion";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnAsociarItem
            // 
            this.btnAsociarItem.BackColor = System.Drawing.Color.Khaki;
            this.btnAsociarItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsociarItem.BackgroundImage")));
            this.btnAsociarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsociarItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAsociarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsociarItem.Location = new System.Drawing.Point(13, 303);
            this.btnAsociarItem.Name = "btnAsociarItem";
            this.btnAsociarItem.Size = new System.Drawing.Size(120, 23);
            this.btnAsociarItem.TabIndex = 1;
            this.btnAsociarItem.Text = "As&ociar Item";
            this.btnAsociarItem.UseVisualStyleBackColor = false;
            this.btnAsociarItem.Click += new System.EventHandler(this.btnAsociarItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.splitButton1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbBaja);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.dataIndividualizacion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 356);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Individualizacion de Instrumentos";
            // 
            // splitButton1
            // 
            this.splitButton1.AutoSize = true;
            this.splitButton1.BackColor = System.Drawing.Color.Khaki;
            this.splitButton1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Bnt;
            this.splitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitButton1.ContextMenuStrip = this.contextMenuIdent;
            this.splitButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splitButton1.Location = new System.Drawing.Point(283, 321);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(99, 25);
            this.splitButton1.SplitMenuStrip = this.contextMenuIdent;
            this.splitButton1.TabIndex = 5;
            this.splitButton1.Text = "splitButton1";
            this.splitButton1.UseVisualStyleBackColor = false;
            // 
            // contextMenuIdent
            // 
            this.contextMenuIdent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeBajaAIndividualizacionToolStripMenuItem});
            this.contextMenuIdent.Name = "contextMenuIdent";
            this.contextMenuIdent.Size = new System.Drawing.Size(235, 26);
            // 
            // darDeBajaAIndividualizacionToolStripMenuItem
            // 
            this.darDeBajaAIndividualizacionToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.darDeBajaAIndividualizacionToolStripMenuItem.Name = "darDeBajaAIndividualizacionToolStripMenuItem";
            this.darDeBajaAIndividualizacionToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.darDeBajaAIndividualizacionToolStripMenuItem.Text = "Dar de Baja a Individualizacion";
            this.darDeBajaAIndividualizacionToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaAIndividualizacionToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mostrar           ";
            // 
            // cmbBaja
            // 
            this.cmbBaja.FormattingEnabled = true;
            this.cmbBaja.Items.AddRange(new object[] {
            "Activos",
            "Dados de Baja",
            "Todos"});
            this.cmbBaja.Location = new System.Drawing.Point(678, 322);
            this.cmbBaja.Name = "cmbBaja";
            this.cmbBaja.Size = new System.Drawing.Size(117, 23);
            this.cmbBaja.TabIndex = 3;
            this.cmbBaja.SelectedIndexChanged += new System.EventHandler(this.cmbBaja_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Act&ualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "A&gregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataIndividualizacion
            // 
            this.dataIndividualizacion.AllowUserToAddRows = false;
            this.dataIndividualizacion.AllowUserToDeleteRows = false;
            this.dataIndividualizacion.AllowUserToOrderColumns = true;
            this.dataIndividualizacion.AllowUserToResizeRows = false;
            this.dataIndividualizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIndividualizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_instrumento,
            this.id_indivual,
            this.Calib_Num,
            this.Estado,
            this.Cod_Trab,
            this.Nom_Trab,
            this.Ultima_Calib,
            this.Prox_Calib,
            this.Certificado,
            this.Marca,
            this.id2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataIndividualizacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataIndividualizacion.Location = new System.Drawing.Point(12, 22);
            this.dataIndividualizacion.MultiSelect = false;
            this.dataIndividualizacion.Name = "dataIndividualizacion";
            this.dataIndividualizacion.ReadOnly = true;
            this.dataIndividualizacion.RowHeadersVisible = false;
            this.dataIndividualizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataIndividualizacion.Size = new System.Drawing.Size(783, 292);
            this.dataIndividualizacion.TabIndex = 0;
            this.dataIndividualizacion.SelectionChanged += new System.EventHandler(this.dataIndividualizacion_SelectionChanged);
            this.dataIndividualizacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataIndividualizacion_MouseClick);
            // 
            // id_instrumento
            // 
            this.id_instrumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_instrumento.DataPropertyName = "id_instrumento";
            this.id_instrumento.HeaderText = "Instrumento";
            this.id_instrumento.Name = "id_instrumento";
            this.id_instrumento.ReadOnly = true;
            this.id_instrumento.Visible = false;
            // 
            // id_indivual
            // 
            this.id_indivual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_indivual.DataPropertyName = "id_indivual";
            this.id_indivual.HeaderText = "Identificador";
            this.id_indivual.Name = "id_indivual";
            this.id_indivual.ReadOnly = true;
            this.id_indivual.Width = 99;
            // 
            // Calib_Num
            // 
            this.Calib_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Calib_Num.DataPropertyName = "Calib_Num";
            this.Calib_Num.HeaderText = "N° Calibracion";
            this.Calib_Num.Name = "Calib_Num";
            this.Calib_Num.ReadOnly = true;
            this.Calib_Num.Width = 111;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // Cod_Trab
            // 
            this.Cod_Trab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cod_Trab.DataPropertyName = "Cod_Trab";
            this.Cod_Trab.HeaderText = "Codigo";
            this.Cod_Trab.Name = "Cod_Trab";
            this.Cod_Trab.ReadOnly = true;
            this.Cod_Trab.Width = 71;
            // 
            // Nom_Trab
            // 
            this.Nom_Trab.DataPropertyName = "Nom_Trab";
            this.Nom_Trab.HeaderText = "Responsable";
            this.Nom_Trab.Name = "Nom_Trab";
            this.Nom_Trab.ReadOnly = true;
            // 
            // Ultima_Calib
            // 
            this.Ultima_Calib.DataPropertyName = "Ultima_Calib";
            this.Ultima_Calib.HeaderText = "Ultima";
            this.Ultima_Calib.Name = "Ultima_Calib";
            this.Ultima_Calib.ReadOnly = true;
            // 
            // Prox_Calib
            // 
            this.Prox_Calib.DataPropertyName = "Prox_Calib";
            this.Prox_Calib.HeaderText = "Proxima";
            this.Prox_Calib.Name = "Prox_Calib";
            this.Prox_Calib.ReadOnly = true;
            // 
            // Certificado
            // 
            this.Certificado.DataPropertyName = "Certificado";
            this.Certificado.HeaderText = "N° de Serie";
            this.Certificado.Name = "Certificado";
            this.Certificado.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "id";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtResponsable);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.dataCalibracion);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(837, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 356);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calibracion";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(183)))), ((int)(((byte)(18)))));
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponsable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResponsable.Location = new System.Drawing.Point(13, 18);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(415, 20);
            this.txtResponsable.TabIndex = 6;
            this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(137, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Actuali&zar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "&Nueva Calibracion";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataCalibracion
            // 
            this.dataCalibracion.AllowUserToAddRows = false;
            this.dataCalibracion.AllowUserToDeleteRows = false;
            this.dataCalibracion.AllowUserToOrderColumns = true;
            this.dataCalibracion.AllowUserToResizeRows = false;
            this.dataCalibracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCalibracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Intrumento2,
            this.Codigo2,
            this.id_identidad2,
            this.id_Calibracion2,
            this.Fec_Calibracion2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCalibracion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataCalibracion.Location = new System.Drawing.Point(13, 47);
            this.dataCalibracion.MultiSelect = false;
            this.dataCalibracion.Name = "dataCalibracion";
            this.dataCalibracion.ReadOnly = true;
            this.dataCalibracion.RowHeadersVisible = false;
            this.dataCalibracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCalibracion.Size = new System.Drawing.Size(415, 267);
            this.dataCalibracion.TabIndex = 0;
            this.dataCalibracion.SelectionChanged += new System.EventHandler(this.dataCalibracion_SelectionChanged);
            // 
            // Id_Intrumento2
            // 
            this.Id_Intrumento2.DataPropertyName = "Id_Instrumento";
            this.Id_Intrumento2.HeaderText = "Id Instrumento";
            this.Id_Intrumento2.Name = "Id_Intrumento2";
            this.Id_Intrumento2.ReadOnly = true;
            this.Id_Intrumento2.Visible = false;
            this.Id_Intrumento2.Width = 110;
            // 
            // Codigo2
            // 
            this.Codigo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo2.DataPropertyName = "Codigo";
            this.Codigo2.HeaderText = "Codigo ";
            this.Codigo2.Name = "Codigo2";
            this.Codigo2.ReadOnly = true;
            this.Codigo2.Width = 74;
            // 
            // id_identidad2
            // 
            this.id_identidad2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_identidad2.DataPropertyName = "id_Identidad";
            this.id_identidad2.HeaderText = "Identidad N°";
            this.id_identidad2.Name = "id_identidad2";
            this.id_identidad2.ReadOnly = true;
            // 
            // id_Calibracion2
            // 
            this.id_Calibracion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_Calibracion2.DataPropertyName = "id_Calibracion";
            this.id_Calibracion2.HeaderText = "Calibracion N°";
            this.id_Calibracion2.Name = "id_Calibracion2";
            this.id_Calibracion2.ReadOnly = true;
            this.id_Calibracion2.Width = 111;
            // 
            // Fec_Calibracion2
            // 
            this.Fec_Calibracion2.DataPropertyName = "Fec_Calibracion";
            this.Fec_Calibracion2.HeaderText = "Fecha";
            this.Fec_Calibracion2.Name = "Fec_Calibracion2";
            this.Fec_Calibracion2.ReadOnly = true;
            this.Fec_Calibracion2.Width = 90;
            // 
            // contextMenuInstru
            // 
            this.contextMenuInstru.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarInstrumentoToolStripMenuItem});
            this.contextMenuInstru.Name = "contextMenuInstru";
            this.contextMenuInstru.Size = new System.Drawing.Size(186, 26);
            // 
            // eliminarInstrumentoToolStripMenuItem
            // 
            this.eliminarInstrumentoToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.eliminarInstrumentoToolStripMenuItem.Name = "eliminarInstrumentoToolStripMenuItem";
            this.eliminarInstrumentoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminarInstrumentoToolStripMenuItem.Text = "Eliminar Instrumento";
            this.eliminarInstrumentoToolStripMenuItem.Click += new System.EventHandler(this.eliminarInstrumentoToolStripMenuItem_Click);
            // 
            // txtItemSelec
            // 
            this.txtItemSelec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(183)))), ((int)(((byte)(18)))));
            this.txtItemSelec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemSelec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSelec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItemSelec.Location = new System.Drawing.Point(14, 357);
            this.txtItemSelec.Name = "txtItemSelec";
            this.txtItemSelec.ReadOnly = true;
            this.txtItemSelec.Size = new System.Drawing.Size(1260, 20);
            this.txtItemSelec.TabIndex = 4;
            this.txtItemSelec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmInstrumentosPrecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1290, 749);
            this.Controls.Add(this.txtItemSelec);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInstrumentosPrecision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Instrumentos de Precision";
            this.Load += new System.EventHandler(this.FrmInstrumentosPrecision_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmInstrumentosPrecision_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataInstrumentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemsComp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuIdent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataIndividualizacion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCalibracion)).EndInit();
            this.contextMenuInstru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInstrumentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstru;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button btnAsociarItem;
        private System.Windows.Forms.DataGridView dataItemsComp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataIndividualizacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataCalibracion;
        private System.Windows.Forms.ContextMenuStrip contextMenuInstru;
        private System.Windows.Forms.ToolStripMenuItem eliminarInstrumentoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtItemSelec;
        private System.Windows.Forms.Button btnBuscarInstru;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Intrumento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_identidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Calibracion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_Calibracion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Frec_Nvo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Frec_Usa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_instrumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_indivual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calib_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Trab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Trab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ultima_Calib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prox_Calib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.ContextMenuStrip contextMenuIdent;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaAIndividualizacionToolStripMenuItem;
        private wyDay.Controls.SplitButton splitButton1;
    }
}