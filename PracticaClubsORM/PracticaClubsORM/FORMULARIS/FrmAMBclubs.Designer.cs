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
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(515, 426);
            this.btNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(152, 45);
            this.btNo.TabIndex = 15;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(256, 426);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(152, 45);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(189, 79);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNom.MaxLength = 20;
            this.tbNom.Name = "tbNom";
            this.tbNom.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNom.Size = new System.Drawing.Size(251, 22);
            this.tbNom.TabIndex = 9;
            this.tbNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.SaddleBrown;
            this.Nom.ForeColor = System.Drawing.Color.White;
            this.Nom.Location = new System.Drawing.Point(48, 81);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom.MinimumSize = new System.Drawing.Size(133, 0);
            this.Nom.Name = "Nom";
            this.Nom.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nom.Size = new System.Drawing.Size(133, 20);
            this.Nom.TabIndex = 8;
            this.Nom.Text = "Nom";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbPais.ForeColor = System.Drawing.Color.White;
            this.lbPais.Location = new System.Drawing.Point(48, 234);
            this.lbPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPais.MinimumSize = new System.Drawing.Size(133, 0);
            this.lbPais.Name = "lbPais";
            this.lbPais.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPais.Size = new System.Drawing.Size(133, 20);
            this.lbPais.TabIndex = 16;
            this.lbPais.Text = "Pais";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(189, 231);
            this.cbPais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(251, 22);
            this.cbPais.TabIndex = 17;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(189, 110);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTelefono.MaxLength = 20;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbTelefono.Size = new System.Drawing.Size(251, 22);
            this.tbTelefono.TabIndex = 19;
            this.tbTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbTelefono.ForeColor = System.Drawing.Color.White;
            this.lbTelefono.Location = new System.Drawing.Point(48, 110);
            this.lbTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefono.MinimumSize = new System.Drawing.Size(133, 0);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbTelefono.Size = new System.Drawing.Size(133, 20);
            this.lbTelefono.TabIndex = 18;
            this.lbTelefono.Text = "Telefono";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(189, 168);
            this.tbCiudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCiudad.MaxLength = 20;
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCiudad.Size = new System.Drawing.Size(251, 22);
            this.tbCiudad.TabIndex = 21;
            this.tbCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(133, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ciudad";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(189, 201);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDireccion.MaxLength = 20;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDireccion.Size = new System.Drawing.Size(251, 22);
            this.tbDireccion.TabIndex = 23;
            this.tbDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(133, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Direccion";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "Subir Logo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(189, 138);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCorreo.MaxLength = 20;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCorreo.Size = new System.Drawing.Size(251, 22);
            this.tbCorreo.TabIndex = 26;
            this.tbCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCorreo.ForeColor = System.Drawing.Color.White;
            this.lbCorreo.Location = new System.Drawing.Point(48, 138);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorreo.MinimumSize = new System.Drawing.Size(133, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbCorreo.Size = new System.Drawing.Size(133, 20);
            this.lbCorreo.TabIndex = 25;
            this.lbCorreo.Text = "Correo";
            // 
            // FrmAMBclubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(859, 485);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.Nom);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lbCorreo;
    }
}