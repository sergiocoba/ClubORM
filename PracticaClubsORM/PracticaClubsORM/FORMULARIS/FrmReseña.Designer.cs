namespace PracticaClubsORM.FORMULARIS
{
    partial class FrmReseña
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
            this.estrella1 = new System.Windows.Forms.PictureBox();
            this.estrella2 = new System.Windows.Forms.PictureBox();
            this.estrella4 = new System.Windows.Forms.PictureBox();
            this.estrella3 = new System.Windows.Forms.PictureBox();
            this.estrella5 = new System.Windows.Forms.PictureBox();
            this.tbReseña = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbClubs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estrella1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella5)).BeginInit();
            this.SuspendLayout();
            // 
            // estrella1
            // 
            this.estrella1.Image = global::PracticaClubsORM.Properties.Resources.Estrella_vacia;
            this.estrella1.Location = new System.Drawing.Point(142, 90);
            this.estrella1.Name = "estrella1";
            this.estrella1.Size = new System.Drawing.Size(38, 43);
            this.estrella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrella1.TabIndex = 0;
            this.estrella1.TabStop = false;
            this.estrella1.Tag = "1";
            this.estrella1.Click += new System.EventHandler(this.Estrella5_Click);
            // 
            // estrella2
            // 
            this.estrella2.Image = global::PracticaClubsORM.Properties.Resources.Estrella_vacia;
            this.estrella2.Location = new System.Drawing.Point(186, 90);
            this.estrella2.Name = "estrella2";
            this.estrella2.Size = new System.Drawing.Size(38, 43);
            this.estrella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrella2.TabIndex = 1;
            this.estrella2.TabStop = false;
            this.estrella2.Tag = "2";
            this.estrella2.Click += new System.EventHandler(this.Estrella5_Click);
            // 
            // estrella4
            // 
            this.estrella4.Image = global::PracticaClubsORM.Properties.Resources.Estrella_vacia;
            this.estrella4.Location = new System.Drawing.Point(274, 90);
            this.estrella4.Name = "estrella4";
            this.estrella4.Size = new System.Drawing.Size(38, 43);
            this.estrella4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrella4.TabIndex = 2;
            this.estrella4.TabStop = false;
            this.estrella4.Tag = "4";
            this.estrella4.Click += new System.EventHandler(this.Estrella5_Click);
            // 
            // estrella3
            // 
            this.estrella3.Image = global::PracticaClubsORM.Properties.Resources.Estrella_vacia;
            this.estrella3.Location = new System.Drawing.Point(230, 90);
            this.estrella3.Name = "estrella3";
            this.estrella3.Size = new System.Drawing.Size(38, 43);
            this.estrella3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrella3.TabIndex = 3;
            this.estrella3.TabStop = false;
            this.estrella3.Tag = "3";
            this.estrella3.Click += new System.EventHandler(this.Estrella5_Click);
            // 
            // estrella5
            // 
            this.estrella5.Image = global::PracticaClubsORM.Properties.Resources.Estrella_vacia;
            this.estrella5.Location = new System.Drawing.Point(318, 90);
            this.estrella5.Name = "estrella5";
            this.estrella5.Size = new System.Drawing.Size(38, 43);
            this.estrella5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrella5.TabIndex = 4;
            this.estrella5.TabStop = false;
            this.estrella5.Tag = "5";
            this.estrella5.Click += new System.EventHandler(this.Estrella5_Click);
            // 
            // tbReseña
            // 
            this.tbReseña.Location = new System.Drawing.Point(12, 176);
            this.tbReseña.Multiline = true;
            this.tbReseña.Name = "tbReseña";
            this.tbReseña.Size = new System.Drawing.Size(474, 181);
            this.tbReseña.TabIndex = 5;
            this.tbReseña.Text = "Escribe una reseña sobre el club";
            this.tbReseña.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbReseña.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(411, 373);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 150);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(474, 20);
            this.tbNombre.TabIndex = 7;
            this.tbNombre.Text = "Nombre y apellidos";
            this.tbNombre.Enter += new System.EventHandler(this.textBox2_Enter);
            this.tbNombre.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // cbClubs
            // 
            this.cbClubs.FormattingEnabled = true;
            this.cbClubs.Location = new System.Drawing.Point(12, 36);
            this.cbClubs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbClubs.Name = "cbClubs";
            this.cbClubs.Size = new System.Drawing.Size(474, 21);
            this.cbClubs.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Consultar Reseñas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmReseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClubs);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbReseña);
            this.Controls.Add(this.estrella5);
            this.Controls.Add(this.estrella3);
            this.Controls.Add(this.estrella4);
            this.Controls.Add(this.estrella2);
            this.Controls.Add(this.estrella1);
            this.Name = "FrmReseña";
            this.Text = "FrmReseña";
            this.Load += new System.EventHandler(this.FrmReseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estrella1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrella5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox estrella1;
        private System.Windows.Forms.PictureBox estrella2;
        private System.Windows.Forms.PictureBox estrella4;
        private System.Windows.Forms.PictureBox estrella3;
        private System.Windows.Forms.PictureBox estrella5;
        private System.Windows.Forms.TextBox tbReseña;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbClubs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}