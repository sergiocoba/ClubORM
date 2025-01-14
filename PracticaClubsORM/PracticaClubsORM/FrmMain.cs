using PracticaClubsORM.FORMULARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClubsORM
{
    public partial class FrmMain : Form
    {
        FrmClubs FrmClubs;
        //private ClubsEntities7 clubsBd { get; set; } = new ClubsEntities7();
        FrmCategoria fmcategoria;
        private ClubsEntities clubsBd { get; set; } = new ClubsEntities();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            verificarConnexio();
            
        }

        #region TEST CONEXIÓ
        private void testConnexioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verificarConnexio();
        }

        private void verificarConnexio()
        {
            Boolean xb = testConnexio();

            gestioToolStripMenuItem.Enabled = xb;
            consultesToolStripMenuItem.Enabled = xb;
        }

        private Boolean testConnexio()
        {
            Boolean xb = false;

            Cursor = Cursors.WaitCursor;
            try
            {

                xb = (clubsBd.Database.Connection.State == ConnectionState.Open);
                if (!xb)
                {
                    clubsBd.Database.Connection.Open();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            return xb;
        }

        #endregion

        #region SORTIR
        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Clubs";

            if (!(ja_esta_obert(xnom)))
            {
                FrmClubs = new FrmClubs(clubsBd);
                FrmClubs.Name = xnom;
                FrmClubs.MdiParent = this;
                FrmClubs.Show();
            }
            FrmClubs.Activate();
        }

        private Boolean ja_esta_obert(String xnom)
        {
            Boolean xb = false;
            int x = 0;
            while ((x < this.MdiChildren.Length) && (this.MdiChildren[x].Name != xnom))
            {
                x++;
            }

            xb = (x < this.MdiChildren.Length);

            return xb;
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Categories";

            if (!(ja_esta_obert(xnom)))
            {
                fmcategoria = new FrmCategoria(clubsBd);
                fmcategoria.Name = xnom;
                fmcategoria.MdiParent = this;
                fmcategoria.Show();
            }
            fmcategoria.Activate();
        }
    }
}
