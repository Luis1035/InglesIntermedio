namespace CapaPresentacion
{
    partial class FrmListarPalabra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarPalabra));
            this.dgvPalabra = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckContiene = new System.Windows.Forms.CheckBox();
            this.chkPrimerPlano = new System.Windows.Forms.CheckBox();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCapitulo = new System.Windows.Forms.ComboBox();
            this.chkMultiLine = new System.Windows.Forms.CheckBox();
            this.btnAgregarCiclo = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCapitulo = new FontAwesome.Sharp.IconButton();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckObservacionContine = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGrammar_01 = new FontAwesome.Sharp.IconButton();
            this.btnGrammar_02 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabra)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPalabra
            // 
            this.dgvPalabra.AllowUserToAddRows = false;
            this.dgvPalabra.AllowUserToDeleteRows = false;
            this.dgvPalabra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPalabra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalabra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalabra.Location = new System.Drawing.Point(0, 0);
            this.dgvPalabra.MultiSelect = false;
            this.dgvPalabra.Name = "dgvPalabra";
            this.dgvPalabra.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalabra.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPalabra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalabra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalabra.Size = new System.Drawing.Size(1054, 185);
            this.dgvPalabra.TabIndex = 0;
            this.dgvPalabra.DoubleClick += new System.EventHandler(this.dgvPalabra_DoubleClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(79, 114);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(155, 23);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.SteelBlue;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(925, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnDelete.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(289, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Del";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(11, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEdit.IconSize = 25;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(149, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblRegistros);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 55);
            this.panel2.TabIndex = 5;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(1061, 19);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(194, 21);
            this.lblRegistros.TabIndex = 7;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "IET : Intermediate English Tool ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1006, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ckContiene
            // 
            this.ckContiene.AutoSize = true;
            this.ckContiene.Location = new System.Drawing.Point(240, 123);
            this.ckContiene.Name = "ckContiene";
            this.ckContiene.Size = new System.Drawing.Size(15, 14);
            this.ckContiene.TabIndex = 6;
            this.ckContiene.UseVisualStyleBackColor = true;
            this.ckContiene.CheckedChanged += new System.EventHandler(this.ckContiene_CheckedChanged);
            // 
            // chkPrimerPlano
            // 
            this.chkPrimerPlano.AutoSize = true;
            this.chkPrimerPlano.Location = new System.Drawing.Point(593, 66);
            this.chkPrimerPlano.Name = "chkPrimerPlano";
            this.chkPrimerPlano.Size = new System.Drawing.Size(85, 17);
            this.chkPrimerPlano.TabIndex = 8;
            this.chkPrimerPlano.Text = "Primer Plano";
            this.chkPrimerPlano.UseVisualStyleBackColor = true;
            this.chkPrimerPlano.CheckedChanged += new System.EventHandler(this.chkPrimerPlano_CheckedChanged);
            // 
            // cboCiclo
            // 
            this.cboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(79, 81);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(155, 23);
            this.cboCiclo.TabIndex = 9;
            this.cboCiclo.SelectionChangeCommitted += new System.EventHandler(this.cboCiclo_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capitulo:";
            // 
            // cboCapitulo
            // 
            this.cboCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapitulo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCapitulo.FormattingEnabled = true;
            this.cboCapitulo.Location = new System.Drawing.Point(396, 81);
            this.cboCapitulo.Name = "cboCapitulo";
            this.cboCapitulo.Size = new System.Drawing.Size(155, 23);
            this.cboCapitulo.TabIndex = 9;
            this.cboCapitulo.SelectionChangeCommitted += new System.EventHandler(this.cboCapitulo_SelectionChangeCommitted);
            // 
            // chkMultiLine
            // 
            this.chkMultiLine.AutoSize = true;
            this.chkMultiLine.Checked = true;
            this.chkMultiLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiLine.Location = new System.Drawing.Point(593, 89);
            this.chkMultiLine.Name = "chkMultiLine";
            this.chkMultiLine.Size = new System.Drawing.Size(68, 17);
            this.chkMultiLine.TabIndex = 10;
            this.chkMultiLine.Text = "MultiLine";
            this.chkMultiLine.UseVisualStyleBackColor = true;
            this.chkMultiLine.CheckedChanged += new System.EventHandler(this.chkMultiLine_CheckedChanged);
            // 
            // btnAgregarCiclo
            // 
            this.btnAgregarCiclo.BackColor = System.Drawing.Color.White;
            this.btnAgregarCiclo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCiclo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCiclo.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnAgregarCiclo.IconColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCiclo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCiclo.IconSize = 20;
            this.btnAgregarCiclo.Location = new System.Drawing.Point(240, 81);
            this.btnAgregarCiclo.Name = "btnAgregarCiclo";
            this.btnAgregarCiclo.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarCiclo.TabIndex = 3;
            this.btnAgregarCiclo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarCiclo.UseVisualStyleBackColor = false;
            this.btnAgregarCiclo.Click += new System.EventHandler(this.btnAgregarCiclo_Click);
            // 
            // btnAgregarCapitulo
            // 
            this.btnAgregarCapitulo.BackColor = System.Drawing.Color.White;
            this.btnAgregarCapitulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarCapitulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarCapitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCapitulo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCapitulo.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnAgregarCapitulo.IconColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCapitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCapitulo.IconSize = 20;
            this.btnAgregarCapitulo.Location = new System.Drawing.Point(557, 81);
            this.btnAgregarCapitulo.Name = "btnAgregarCapitulo";
            this.btnAgregarCapitulo.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarCapitulo.TabIndex = 11;
            this.btnAgregarCapitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarCapitulo.UseVisualStyleBackColor = false;
            this.btnAgregarCapitulo.Click += new System.EventHandler(this.btnAgregarCapitulo_Click);
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro2.Location = new System.Drawing.Point(593, 113);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(155, 23);
            this.txtFiltro2.TabIndex = 2;
            this.txtFiltro2.TextChanged += new System.EventHandler(this.txtFiltro2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Filtro Observacion:";
            // 
            // ckObservacionContine
            // 
            this.ckObservacionContine.AutoSize = true;
            this.ckObservacionContine.Location = new System.Drawing.Point(754, 121);
            this.ckObservacionContine.Name = "ckObservacionContine";
            this.ckObservacionContine.Size = new System.Drawing.Size(15, 14);
            this.ckObservacionContine.TabIndex = 6;
            this.ckObservacionContine.UseVisualStyleBackColor = true;
            this.ckObservacionContine.CheckedChanged += new System.EventHandler(this.ckContiene_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPalabra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 185);
            this.panel3.TabIndex = 12;
            // 
            // btnGrammar_01
            // 
            this.btnGrammar_01.BackColor = System.Drawing.Color.White;
            this.btnGrammar_01.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrammar_01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGrammar_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrammar_01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrammar_01.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.btnGrammar_01.IconColor = System.Drawing.Color.SteelBlue;
            this.btnGrammar_01.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrammar_01.IconSize = 20;
            this.btnGrammar_01.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrammar_01.Location = new System.Drawing.Point(822, 59);
            this.btnGrammar_01.Name = "btnGrammar_01";
            this.btnGrammar_01.Size = new System.Drawing.Size(220, 27);
            this.btnGrammar_01.TabIndex = 13;
            this.btnGrammar_01.Text = "Future Continuos and Perfect";
            this.btnGrammar_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrammar_01.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrammar_01.UseVisualStyleBackColor = false;
            this.btnGrammar_01.Click += new System.EventHandler(this.btnGrammar_01_Click);
            // 
            // btnGrammar_02
            // 
            this.btnGrammar_02.BackColor = System.Drawing.Color.White;
            this.btnGrammar_02.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrammar_02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGrammar_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrammar_02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrammar_02.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.btnGrammar_02.IconColor = System.Drawing.Color.SteelBlue;
            this.btnGrammar_02.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrammar_02.IconSize = 20;
            this.btnGrammar_02.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrammar_02.Location = new System.Drawing.Point(822, 87);
            this.btnGrammar_02.Name = "btnGrammar_02";
            this.btnGrammar_02.Size = new System.Drawing.Size(220, 27);
            this.btnGrammar_02.TabIndex = 13;
            this.btnGrammar_02.Text = "Future Form";
            this.btnGrammar_02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrammar_02.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrammar_02.UseVisualStyleBackColor = false;
            this.btnGrammar_02.Click += new System.EventHandler(this.btnGrammar_02_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Splotch;
            this.iconButton2.IconColor = System.Drawing.Color.SteelBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(822, 115);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(220, 27);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.Text = "Future Continuos and Perfect";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.btnGrammar_01_Click);
            // 
            // FrmListarPalabra
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1054, 383);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnGrammar_02);
            this.Controls.Add(this.btnGrammar_01);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAgregarCapitulo);
            this.Controls.Add(this.btnAgregarCiclo);
            this.Controls.Add(this.chkMultiLine);
            this.Controls.Add(this.cboCapitulo);
            this.Controls.Add(this.cboCiclo);
            this.Controls.Add(this.chkPrimerPlano);
            this.Controls.Add(this.ckObservacionContine);
            this.Controls.Add(this.ckContiene);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro2);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmListarPalabra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: IET ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalabra;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckContiene;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.CheckBox chkPrimerPlano;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCapitulo;
        private System.Windows.Forms.CheckBox chkMultiLine;
        private FontAwesome.Sharp.IconButton btnAgregarCiclo;
        private FontAwesome.Sharp.IconButton btnAgregarCapitulo;
        private System.Windows.Forms.TextBox txtFiltro2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckObservacionContine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnGrammar_01;
        private FontAwesome.Sharp.IconButton btnGrammar_02;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

