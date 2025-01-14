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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvDisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisp.Location = new System.Drawing.Point(360, 161);
            this.dgvDisp.Name = "dgvDisp";
            this.dgvDisp.ReadOnly = true;
            this.dgvDisp.RowHeadersVisible = false;
            this.dgvDisp.RowHeadersWidth = 51;
            this.dgvDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisp.Size = new System.Drawing.Size(250, 311);
            this.dgvDisp.TabIndex = 24;
            // 
            // dgvInscrit
            // 
            this.dgvInscrit.AllowUserToAddRows = false;
            this.dgvInscrit.AllowUserToDeleteRows = false;
            this.dgvInscrit.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvInscrit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInscrit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInscrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscrit.Location = new System.Drawing.Point(45, 161);
            this.dgvInscrit.Name = "dgvInscrit";
            this.dgvInscrit.ReadOnly = true;
            this.dgvInscrit.RowHeadersVisible = false;
            this.dgvInscrit.RowHeadersWidth = 51;
            this.dgvInscrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscrit.Size = new System.Drawing.Size(252, 311);
            this.dgvInscrit.TabIndex = 23;
            this.dgvInscrit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscrit_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 123);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(36, 2, 40, 2);
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categories Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 123);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 2, 50, 2);
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Categories Inscrites";
            // 
            // lbClubs
            // 
            this.lbClubs.AutoSize = true;
            this.lbClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClubs.Location = new System.Drawing.Point(56, 52);
            this.lbClubs.Name = "lbClubs";
            this.lbClubs.Size = new System.Drawing.Size(41, 16);
            this.lbClubs.TabIndex = 18;
            this.lbClubs.Text = "Clubs";
            // 
            // cbEstudiants
            // 
            this.cbEstudiants.FormattingEnabled = true;
            this.cbEstudiants.Location = new System.Drawing.Point(146, 51);
            this.cbEstudiants.Name = "cbEstudiants";
            this.cbEstudiants.Size = new System.Drawing.Size(421, 21);
            this.cbEstudiants.TabIndex = 17;
            this.cbEstudiants.SelectedIndexChanged += new System.EventHandler(this.cbEstudiants_SelectedIndexChanged);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::PracticaClubsORM.Properties.Resources.cancel50;
            this.pbDelete.Location = new System.Drawing.Point(45, 505);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(50, 50);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDelete.TabIndex = 22;
            this.pbDelete.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::PracticaClubsORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(541, 505);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(50, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 21;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 602);
            this.Controls.Add(this.dgvDisp);
            this.Controls.Add(this.dgvInscrit);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClubs);
            this.Controls.Add(this.cbEstudiants);
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