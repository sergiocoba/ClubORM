namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmPaises
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbContinentes = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContinentes
            // 
            this.lbContinentes.AutoSize = true;
            this.lbContinentes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbContinentes.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbContinentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContinentes.Location = new System.Drawing.Point(22, 25);
            this.lbContinentes.Name = "lbContinentes";
            this.lbContinentes.Padding = new System.Windows.Forms.Padding(5);
            this.lbContinentes.Size = new System.Drawing.Size(133, 30);
            this.lbContinentes.TabIndex = 4;
            this.lbContinentes.Text = "CONTINENTE";
            // 
            // cbContinente
            // 
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(163, 26);
            this.cbContinente.Margin = new System.Windows.Forms.Padding(5);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbContinente.Size = new System.Drawing.Size(378, 24);
            this.cbContinente.TabIndex = 5;
            this.cbContinente.SelectedIndexChanged += new System.EventHandler(this.cbContinente_SelectedIndexChanged);
            // 
            // dgvPais
            // 
            this.dgvPais.AllowUserToAddRows = false;
            this.dgvPais.AllowUserToDeleteRows = false;
            this.dgvPais.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvPais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Location = new System.Drawing.Point(26, 73);
            this.dgvPais.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.ReadOnly = true;
            this.dgvPais.RowHeadersVisible = false;
            this.dgvPais.RowHeadersWidth = 51;
            this.dgvPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPais.Size = new System.Drawing.Size(515, 383);
            this.dgvPais.TabIndex = 24;
            this.dgvPais.DoubleClick += new System.EventHandler(this.dgvPais_DoubleClick);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::PracticaClubsORM.Properties.Resources.cancel50;
            this.pbDelete.Location = new System.Drawing.Point(549, 394);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(67, 62);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDelete.TabIndex = 26;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::PracticaClubsORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(549, 324);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 62);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 25;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 477);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgvPais);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.lbContinentes);
            this.Name = "FrmPaises";
            this.Text = "FrmPaises";
            this.Load += new System.EventHandler(this.FrmPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContinentes;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.DataGridView dgvPais;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbAdd;
    }
}