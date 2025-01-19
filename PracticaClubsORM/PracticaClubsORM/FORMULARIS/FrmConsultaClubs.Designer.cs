namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmConsultaClubs
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
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lbContinentes = new System.Windows.Forms.Label();
            this.dgvClubs = new System.Windows.Forms.DataGridView();
            this.rbContinente = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(43, 51);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(665, 24);
            this.cbFiltro.TabIndex = 16;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // lbContinentes
            // 
            this.lbContinentes.AutoSize = true;
            this.lbContinentes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbContinentes.Font = new System.Drawing.Font("Verdana", 10F);
            this.lbContinentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContinentes.Location = new System.Drawing.Point(39, 17);
            this.lbContinentes.Name = "lbContinentes";
            this.lbContinentes.Padding = new System.Windows.Forms.Padding(5);
            this.lbContinentes.Size = new System.Drawing.Size(125, 30);
            this.lbContinentes.TabIndex = 19;
            this.lbContinentes.Text = "Clubes por :";
            // 
            // dgvClubs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvClubs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClubs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClubs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClubs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClubs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClubs.Location = new System.Drawing.Point(43, 81);
            this.dgvClubs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClubs.Name = "dgvClubs";
            this.dgvClubs.RowHeadersVisible = false;
            this.dgvClubs.RowHeadersWidth = 51;
            this.dgvClubs.RowTemplate.Height = 24;
            this.dgvClubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClubs.Size = new System.Drawing.Size(665, 463);
            this.dgvClubs.TabIndex = 21;
            // 
            // rbContinente
            // 
            this.rbContinente.AutoSize = true;
            this.rbContinente.Location = new System.Drawing.Point(184, 24);
            this.rbContinente.Name = "rbContinente";
            this.rbContinente.Size = new System.Drawing.Size(91, 20);
            this.rbContinente.TabIndex = 22;
            this.rbContinente.Text = "Continente";
            this.rbContinente.UseVisualStyleBackColor = true;
            this.rbContinente.CheckedChanged += new System.EventHandler(this.rbContinente_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(352, 24);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(87, 20);
            this.rbCategoria.TabIndex = 23;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbContinente_CheckedChanged);
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Location = new System.Drawing.Point(291, 24);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(55, 20);
            this.rbPais.TabIndex = 24;
            this.rbPais.Text = "Pais";
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.CheckedChanged += new System.EventHandler(this.rbContinente_CheckedChanged);
            // 
            // FrmConsultaClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 571);
            this.Controls.Add(this.rbPais);
            this.Controls.Add(this.rbCategoria);
            this.Controls.Add(this.rbContinente);
            this.Controls.Add(this.dgvClubs);
            this.Controls.Add(this.lbContinentes);
            this.Controls.Add(this.cbFiltro);
            this.Name = "FrmConsultaClubs";
            this.Text = "Consulta Clubs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lbContinentes;
        private System.Windows.Forms.DataGridView dgvClubs;
        private System.Windows.Forms.RadioButton rbContinente;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbPais;
    }
}