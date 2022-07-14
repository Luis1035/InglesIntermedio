namespace CapaPresentacion
{
    partial class FrmEditarPalabras
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCapitulo = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtTraduccion = new System.Windows.Forms.TextBox();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGrabar = new FontAwesome.Sharp.IconButton();
            this.TxtIdPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Traduccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Palabra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Capitulo:";
            // 
            // cboCapitulo
            // 
            this.cboCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapitulo.FormattingEnabled = true;
            this.cboCapitulo.Location = new System.Drawing.Point(93, 42);
            this.cboCapitulo.Name = "cboCapitulo";
            this.cboCapitulo.Size = new System.Drawing.Size(416, 21);
            this.cboCapitulo.TabIndex = 3;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(93, 121);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(416, 20);
            this.txtObservacion.TabIndex = 2;
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Location = new System.Drawing.Point(93, 95);
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(416, 20);
            this.txtTraduccion.TabIndex = 1;
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(93, 69);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(416, 20);
            this.txtPalabra.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 51);
            this.panel1.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnCancelar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(12, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGrabar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnGrabar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrabar.IconSize = 25;
            this.btnGrabar.Location = new System.Drawing.Point(392, 8);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(120, 37);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Save";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // TxtIdPalabra
            // 
            this.TxtIdPalabra.Location = new System.Drawing.Point(652, 14);
            this.TxtIdPalabra.Name = "TxtIdPalabra";
            this.TxtIdPalabra.ReadOnly = true;
            this.TxtIdPalabra.Size = new System.Drawing.Size(165, 20);
            this.TxtIdPalabra.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id:";
            // 
            // cboCiclo
            // 
            this.cboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(93, 15);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(416, 21);
            this.cboCiclo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ciclo:";
            // 
            // FrmEditarPalabras
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(523, 230);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCiclo);
            this.Controls.Add(this.cboCapitulo);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdPalabra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEditarPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".: Editar Registro";
            this.Load += new System.EventHandler(this.FrmEditarPalabras_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCapitulo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtTraduccion;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGrabar;
        private System.Windows.Forms.TextBox TxtIdPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.Label label6;
    }
}