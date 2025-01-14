namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmCategoria
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
            this.dgvDisp = new System.Windows.Forms.DataGridView();
            this.dgvInscrit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClubs = new System.Windows.Forms.Label();
            this.cbEstudiants = new System.Windows.Forms.ComboBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisp
            // 
            this.dgvDisp.AllowUserToAddRows = false;
            this.dgvDisp.AllowUserToDeleteRows = false;
            this.dgvDisp.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvDisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(480, 198);
            this.dgvDisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.ReadOnly = true;
            this.dgvDisp.RowHeadersVisible = false;
            this.dgvDisp.RowHeadersWidth = 51;
            this.dgvDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisp.Size = new System.Drawing.Size(316, 383);
            this.dgvDisp.TabIndex = 24;
            // 
            // dgvInscrit
            // 
            this.dgvInscrit.AllowUserToAddRows = false;
            this.dgvInscrit.AllowUserToDeleteRows = false;
            this.dgvInscrit.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvInscrit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInscrit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscrit.Location = new System.Drawing.Point(60, 198);
            this.dgvInscrit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInscrit.Name = "dgvInscrit";
            this.dgvInscrit.ReadOnly = true;
            this.dgvInscrit.RowHeadersVisible = false;
            this.dgvInscrit.RowHeadersWidth = 51;
            this.dgvInscrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscrit.Size = new System.Drawing.Size(320, 383);
            this.dgvInscrit.TabIndex = 23;
            this.dgvInscrit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscrit_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(48, 2, 53, 2);
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categories Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(67, 2, 67, 2);
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Categories Inscrites";
            // 
            // lbClubs
            // 
            this.lbClubs.AutoSize = true;
            this.lbClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClubs.Location = new System.Drawing.Point(75, 64);
            this.lbClubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClubs.Name = "lbClubs";
            this.lbClubs.Size = new System.Drawing.Size(52, 20);
            this.lbClubs.TabIndex = 18;
            this.lbClubs.Text = "Clubs";
            // 
            // cbEstudiants
            // 
            this.cbEstudiants.FormattingEnabled = true;
            this.cbEstudiants.Location = new System.Drawing.Point(195, 63);
            this.cbEstudiants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstudiants.Name = "cbEstudiants";
            this.cbEstudiants.Size = new System.Drawing.Size(560, 24);
            this.cbEstudiants.TabIndex = 17;
            this.cbEstudiants.SelectedIndexChanged += new System.EventHandler(this.cbEstudiants_SelectedIndexChanged);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::PracticaClubsORM.Properties.Resources.cancel50;
            this.pbDelete.Location = new System.Drawing.Point(60, 622);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(67, 62);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDelete.TabIndex = 22;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::PracticaClubsORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(721, 622);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 62);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 21;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 741);
            this.Controls.Add(this.dgvDisp);
            this.Controls.Add(this.dgvInscrit);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClubs);
            this.Controls.Add(this.cbEstudiants);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisp;
        private System.Windows.Forms.DataGridView dgvInscrit;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClubs;
        private System.Windows.Forms.ComboBox cbEstudiants;
    }
}