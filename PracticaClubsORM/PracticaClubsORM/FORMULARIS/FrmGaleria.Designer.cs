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
            this.cbClubs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnterior = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbFotos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClubs
            // 
            this.cbClubs.FormattingEnabled = true;
            this.cbClubs.Location = new System.Drawing.Point(287, 75);
            this.cbClubs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbClubs.Name = "cbClubs";
            this.cbClubs.Size = new System.Drawing.Size(489, 21);
            this.cbClubs.TabIndex = 1;
            this.cbClubs.SelectedIndexChanged += new System.EventHandler(this.cbClubs_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "GALERIA DE IMAGENES";
            // 
            // pbAnterior
            // 
            this.pbAnterior.Location = new System.Drawing.Point(47, 264);
            this.pbAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAnterior.Name = "pbAnterior";
            this.pbAnterior.Size = new System.Drawing.Size(88, 23);
            this.pbAnterior.TabIndex = 3;
            this.pbAnterior.Text = "ANTERIOR";
            this.pbAnterior.UseVisualStyleBackColor = true;
            this.pbAnterior.Click += new System.EventHandler(this.pbAnterior_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(951, 264);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(88, 23);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = "SIGUIENTE";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::PracticaClubsORM.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(522, 512);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(58, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 22;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbFotos
            // 
            this.pbFotos.Location = new System.Drawing.Point(231, 119);
            this.pbFotos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbFotos.Name = "pbFotos";
            this.pbFotos.Size = new System.Drawing.Size(640, 376);
            this.pbFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotos.TabIndex = 0;
            this.pbFotos.TabStop = false;
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbAnterior);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.cbClubs);
            this.Controls.Add(this.pbFotos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmGaleria";
            this.Text = "FrmGaleria";
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotos;
        private System.Windows.Forms.ComboBox cbClubs;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button pbAnterior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label label1;
    }
}