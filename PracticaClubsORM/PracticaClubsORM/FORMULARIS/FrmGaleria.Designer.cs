namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmGaleria
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
            this.pbFotos = new System.Windows.Forms.PictureBox();
            this.cbClubs = new System.Windows.Forms.ComboBox();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.pbAnterior = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotos
            // 
            this.pbFotos.Location = new System.Drawing.Point(194, 130);
            this.pbFotos.Name = "pbFotos";
            this.pbFotos.Size = new System.Drawing.Size(549, 376);
            this.pbFotos.TabIndex = 0;
            this.pbFotos.TabStop = false;
            // 
            // cbClubs
            // 
            this.cbClubs.FormattingEnabled = true;
            this.cbClubs.Location = new System.Drawing.Point(254, 57);
            this.cbClubs.Name = "cbClubs";
            this.cbClubs.Size = new System.Drawing.Size(420, 21);
            this.cbClubs.TabIndex = 1;
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(815, 264);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = "SIGUIENTE";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // pbAnterior
            // 
            this.pbAnterior.Location = new System.Drawing.Point(40, 264);
            this.pbAnterior.Name = "pbAnterior";
            this.pbAnterior.Size = new System.Drawing.Size(75, 23);
            this.pbAnterior.TabIndex = 3;
            this.pbAnterior.Text = "ANTERIOR";
            this.pbAnterior.UseVisualStyleBackColor = true;
            this.pbAnterior.Click += new System.EventHandler(this.pbAnterior_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbAnterior);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.cbClubs);
            this.Controls.Add(this.pbFotos);
            this.Name = "FrmGaleria";
            this.Text = "FrmGaleria";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotos;
        private System.Windows.Forms.ComboBox cbClubs;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button pbAnterior;
        private System.Windows.Forms.Button button1;
    }
}