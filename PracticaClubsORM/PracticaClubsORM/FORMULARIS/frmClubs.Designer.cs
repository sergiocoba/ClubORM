namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmClubs
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
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.dgvClubs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdd
            // 
            this.pbAdd.ErrorImage = null;
            this.pbAdd.Image = global::PracticaClubsORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(556, 391);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(50, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 14;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
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
            this.dgvClubs.Location = new System.Drawing.Point(20, 11);
            this.dgvClubs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClubs.Name = "dgvClubs";
            this.dgvClubs.RowHeadersWidth = 51;
            this.dgvClubs.RowTemplate.Height = 24;
            this.dgvClubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClubs.Size = new System.Drawing.Size(586, 375);
            this.dgvClubs.TabIndex = 13;
            // 
            // FrmClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 448);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgvClubs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmClubs";
            this.Text = "FrmClubs";
            this.Load += new System.EventHandler(this.FrmClubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridView dgvClubs;
    }
}