namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmCreseñas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReseñas = new System.Windows.Forms.DataGridView();
            this.cbClubs = new System.Windows.Forms.ComboBox();
            this.chBTodas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReseñas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReseñas
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvReseñas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReseñas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReseñas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReseñas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReseñas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReseñas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReseñas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReseñas.Location = new System.Drawing.Point(11, 74);
            this.dgvReseñas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReseñas.Name = "dgvReseñas";
            this.dgvReseñas.RowHeadersVisible = false;
            this.dgvReseñas.RowHeadersWidth = 51;
            this.dgvReseñas.RowTemplate.Height = 24;
            this.dgvReseñas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReseñas.Size = new System.Drawing.Size(586, 433);
            this.dgvReseñas.TabIndex = 14;
            // 
            // cbClubs
            // 
            this.cbClubs.FormattingEnabled = true;
            this.cbClubs.Location = new System.Drawing.Point(11, 48);
            this.cbClubs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbClubs.Name = "cbClubs";
            this.cbClubs.Size = new System.Drawing.Size(381, 21);
            this.cbClubs.TabIndex = 15;
            this.cbClubs.SelectedIndexChanged += new System.EventHandler(this.cbClubs_SelectedIndexChanged);
            // 
            // chBTodas
            // 
            this.chBTodas.AutoSize = true;
            this.chBTodas.Location = new System.Drawing.Point(439, 48);
            this.chBTodas.Name = "chBTodas";
            this.chBTodas.Size = new System.Drawing.Size(112, 17);
            this.chBTodas.TabIndex = 16;
            this.chBTodas.Text = "Todas las reseñas";
            this.chBTodas.UseVisualStyleBackColor = true;
            this.chBTodas.CheckedChanged += new System.EventHandler(this.chBTodas_CheckedChanged);
            // 
            // FrmCreseñas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 518);
            this.Controls.Add(this.chBTodas);
            this.Controls.Add(this.cbClubs);
            this.Controls.Add(this.dgvReseñas);
            this.Name = "FrmCreseñas";
            this.Text = "Consulta de reseñas";
            this.Load += new System.EventHandler(this.FrmCreseñas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReseñas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReseñas;
        private System.Windows.Forms.ComboBox cbClubs;
        private System.Windows.Forms.CheckBox chBTodas;
    }
}