namespace CapaPresentacion
{
    partial class FrmListarCiclo
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
            this.dgvCiclo = new System.Windows.Forms.DataGridView();
            this.idCicloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cicloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCiclo
            // 
            this.dgvCiclo.AllowUserToAddRows = false;
            this.dgvCiclo.AllowUserToDeleteRows = false;
            this.dgvCiclo.AutoGenerateColumns = false;
            this.dgvCiclo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCiclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCicloDataGridViewTextBoxColumn,
            this.cicloDataGridViewTextBoxColumn});
            this.dgvCiclo.DataSource = this.cicloBindingSource;
            this.dgvCiclo.Location = new System.Drawing.Point(11, 69);
            this.dgvCiclo.MultiSelect = false;
            this.dgvCiclo.Name = "dgvCiclo";
            this.dgvCiclo.ReadOnly = true;
            this.dgvCiclo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiclo.Size = new System.Drawing.Size(445, 229);
            this.dgvCiclo.TabIndex = 0;
            // 
            // idCicloDataGridViewTextBoxColumn
            // 
            this.idCicloDataGridViewTextBoxColumn.DataPropertyName = "IdCiclo";
            this.idCicloDataGridViewTextBoxColumn.HeaderText = "IdCiclo";
            this.idCicloDataGridViewTextBoxColumn.Name = "idCicloDataGridViewTextBoxColumn";
            this.idCicloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cicloDataGridViewTextBoxColumn
            // 
            this.cicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo_";
            this.cicloDataGridViewTextBoxColumn.HeaderText = "Ciclo";
            this.cicloDataGridViewTextBoxColumn.Name = "cicloDataGridViewTextBoxColumn";
            this.cicloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cicloBindingSource
            // 
            this.cicloBindingSource.DataSource = typeof(CapaDatos.Ciclo);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 51);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.SteelBlue;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(356, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnDelete.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(223, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Del";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(11, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEdit.IconSize = 25;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(117, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblRegistros);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 55);
            this.panel2.TabIndex = 6;
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
            this.label2.Size = new System.Drawing.Size(444, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "IET : Ciclo";
            // 
            // FrmListarCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCiclo);
            this.Name = "FrmListarCiclo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmListarCiclo";
            this.Load += new System.EventHandler(this.FrmListarCiclo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cicloBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCiclo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCicloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cicloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cicloBindingSource;
    }
}