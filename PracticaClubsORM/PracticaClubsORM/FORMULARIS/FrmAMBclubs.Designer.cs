namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmAMBclubs
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
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(316, 294);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 42);
            this.btNo.TabIndex = 15;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(157, 294);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(143, 82);
            this.tbNom.MaxLength = 20;
            this.tbNom.Name = "tbNom";
            this.tbNom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNom.Size = new System.Drawing.Size(188, 20);
            this.tbNom.TabIndex = 9;
            this.tbNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.SaddleBrown;
            this.Nom.ForeColor = System.Drawing.Color.White;
            this.Nom.Location = new System.Drawing.Point(36, 82);
            this.Nom.MinimumSize = new System.Drawing.Size(100, 0);
            this.Nom.Name = "Nom";
            this.Nom.Padding = new System.Windows.Forms.Padding(3);
            this.Nom.Size = new System.Drawing.Size(100, 19);
            this.Nom.TabIndex = 8;
            this.Nom.Text = "Nom";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbPais.ForeColor = System.Drawing.Color.White;
            this.lbPais.Location = new System.Drawing.Point(36, 129);
            this.lbPais.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbPais.Name = "lbPais";
            this.lbPais.Padding = new System.Windows.Forms.Padding(3);
            this.lbPais.Size = new System.Drawing.Size(100, 19);
            this.lbPais.TabIndex = 16;
            this.lbPais.Text = "Pais";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // FrmAMBclubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.Nom);
            this.Name = "FrmAMBclubs";
            this.Text = "FrmAMBclubs";
            this.Load += new System.EventHandler(this.FrmAMBclubs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}