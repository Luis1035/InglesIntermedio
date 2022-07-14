namespace CapaPresentacion
{
    partial class FrmAgregarCapitulo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGrabar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 50);
            this.panel1.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnCancelar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(12, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancel";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.White;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGrabar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnGrabar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrabar.IconSize = 25;
            this.btnGrabar.Location = new System.Drawing.Point(126, 10);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(101, 30);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Save";
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Capitulo";
            // 
            // txtCapitulo
            // 
            this.txtCapitulo.Location = new System.Drawing.Point(63, 38);
            this.txtCapitulo.Name = "txtCapitulo";
            this.txtCapitulo.Size = new System.Drawing.Size(164, 20);
            this.txtCapitulo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ciclo:";
            // 
            // cboCiclo
            // 
            this.cboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(63, 12);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(164, 21);
            this.cboCiclo.TabIndex = 22;
            // 
            // FrmAgregarCapitulo
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(239, 135);
            this.Controls.Add(this.cboCiclo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapitulo);
            this.Controls.Add(this.label6);
            this.Name = "FrmAgregarCapitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregarCapitulo";
            this.Load += new System.EventHandler(this.FrmAgregarCapitulo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCiclo;
    }
}