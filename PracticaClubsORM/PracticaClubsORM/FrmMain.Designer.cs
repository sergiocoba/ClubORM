namespace PracticaClubsORM
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConnexioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.gestioToolStripMenuItem,
            this.consultesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testConnexioToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // testConnexioToolStripMenuItem
            // 
            this.testConnexioToolStripMenuItem.Name = "testConnexioToolStripMenuItem";
            this.testConnexioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testConnexioToolStripMenuItem.Text = "Test Connexio";
            this.testConnexioToolStripMenuItem.Click += new System.EventHandler(this.testConnexioToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // gestioToolStripMenuItem
            // 
            this.gestioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.paisesToolStripMenuItem});
            this.gestioToolStripMenuItem.Enabled = false;
            this.gestioToolStripMenuItem.Name = "gestioToolStripMenuItem";
            this.gestioToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gestioToolStripMenuItem.Text = "Gestio";
            // 
            // clubsToolStripMenuItem
            // 
            this.clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            this.clubsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clubsToolStripMenuItem.Text = "Clubs";
            this.clubsToolStripMenuItem.Click += new System.EventHandler(this.clubsToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.paisesToolStripMenuItem.Text = "Paises";
            this.paisesToolStripMenuItem.Click += new System.EventHandler(this.paisesToolStripMenuItem_Click);
            // 
            // consultesToolStripMenuItem
            // 
            this.consultesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galeriaToolStripMenuItem,
            this.reseñasToolStripMenuItem});
            this.consultesToolStripMenuItem.Enabled = false;
            this.consultesToolStripMenuItem.Name = "consultesToolStripMenuItem";
            this.consultesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultesToolStripMenuItem.Text = "Consultes";
            // 
            // galeriaToolStripMenuItem
            // 
            this.galeriaToolStripMenuItem.Name = "galeriaToolStripMenuItem";
            this.galeriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.galeriaToolStripMenuItem.Text = "Galeria";
            this.galeriaToolStripMenuItem.Click += new System.EventHandler(this.galeriaToolStripMenuItem_Click);
            // 
            // reseñasToolStripMenuItem
            // 
            this.reseñasToolStripMenuItem.Name = "reseñasToolStripMenuItem";
            this.reseñasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reseñasToolStripMenuItem.Text = "Reseñas";
            this.reseñasToolStripMenuItem.Click += new System.EventHandler(this.reseñasToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Clubs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConnexioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñasToolStripMenuItem;
    }
}

