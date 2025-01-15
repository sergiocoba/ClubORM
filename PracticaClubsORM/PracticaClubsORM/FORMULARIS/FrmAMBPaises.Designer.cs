namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmAMBPaises
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
            this.tbNomPais = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbContinente = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbNomPais
            // 
            this.tbNomPais.Location = new System.Drawing.Point(163, 14);
            this.tbNomPais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNomPais.MaxLength = 20;
            this.tbNomPais.Name = "tbNomPais";
            this.tbNomPais.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNomPais.Size = new System.Drawing.Size(251, 22);
            this.tbNomPais.TabIndex = 11;
            this.tbNomPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.SaddleBrown;
            this.Nom.ForeColor = System.Drawing.Color.White;
            this.Nom.Location = new System.Drawing.Point(22, 14);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom.MinimumSize = new System.Drawing.Size(133, 0);
            this.Nom.Name = "Nom";
            this.Nom.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nom.Size = new System.Drawing.Size(133, 22);
            this.Nom.TabIndex = 10;
            this.Nom.Text = "Pais";
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(286, 125);
            this.btNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(152, 45);
            this.btNo.TabIndex = 17;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(25, 125);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(152, 45);
            this.btOK.TabIndex = 16;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbContinente
            // 
            this.lbContinente.AutoSize = true;
            this.lbContinente.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbContinente.ForeColor = System.Drawing.Color.White;
            this.lbContinente.Location = new System.Drawing.Point(22, 50);
            this.lbContinente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContinente.MinimumSize = new System.Drawing.Size(133, 0);
            this.lbContinente.Name = "lbContinente";
            this.lbContinente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbContinente.Size = new System.Drawing.Size(133, 22);
            this.lbContinente.TabIndex = 18;
            this.lbContinente.Text = "Continente";
            // 
            // cbContinente
            // 
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(163, 50);
            this.cbContinente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(251, 24);
            this.cbContinente.TabIndex = 19;
            // 
            // FrmAMBPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(463, 182);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.lbContinente);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNomPais);
            this.Controls.Add(this.Nom);
            this.Name = "FrmAMBPaises";
            this.Text = "FrmAMBPaises";
            this.Load += new System.EventHandler(this.FrmAMBPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomPais;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbContinente;
        private System.Windows.Forms.ComboBox cbContinente;
    }
}