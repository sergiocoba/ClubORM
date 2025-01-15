using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmPaises : Form
    {

        //variables frmAMBç
        FrmAMBPaises FrmAMBPaises=null;

        private ClubsEntities10 clubsBD { get; set; } = new ClubsEntities10();
        bool bfirst = true;

        public FrmPaises(ClubsEntities10 clubsBd)
        {
            InitializeComponent();
            clubsBD = clubsBd;
            
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {
            omplirComboContinentes();
            getDadesPais();
            bfirst = false;
        }

        private void omplirComboContinentes()
        {
            var qryContinentes = from c in clubsBD.Continentes
                           orderby c.Nombre
                           select new
                           {
                               id = c.ContinenteID,
                               nom = c.Nombre,
                           };
            cbContinente.DataSource = qryContinentes.ToList();
            cbContinente.DisplayMember = "nom";
            cbContinente.ValueMember = "id";
            if (cbContinente.Items.Count > 0)
            {
                cbContinente.SelectedIndex = 0;
            }
        }

        private void cbContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bfirst && cbContinente.SelectedValue != null)
            {
                getDadesPais();

            }
        }

        private void getDadesPais()
        {
            var qryPaise = from p in clubsBD.Pais
                           where  p.ContinenteID == (Int32)cbContinente.SelectedValue 
                           orderby p.Nombre                        
                           select new
                           {
                               id = p.ContinenteID,
                               paisID = p.PaisID,
                               nomPais = p.Nombre,
                           };

            dgvPais.DataSource = qryPaise.ToList();
            dgvPais.Columns["id"].Visible = false;
            dgvPais.Columns["paisID"].Visible = false;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            FrmAMBPaises = new FrmAMBPaises('A', clubsBD);
            FrmAMBPaises.ShowDialog();
            getDadesPais();
            if(FrmAMBPaises.nomPais != "")
            {
                seleccionarFila(FrmAMBPaises.nomPais);
            }
        }

        private void seleccionarFila(string nomPais)
        {
            int i = -1;
            Boolean xbTrobat = false;

            while (!xbTrobat && i < dgvPais.Rows.Count)
            {
                i++;
                xbTrobat = (dgvPais.Rows[i].Cells["nomPais"].Value.ToString() == nomPais);
            }
            if (dgvPais.Rows.Count > 0)
            {
                dgvPais.Rows[i].Selected = true;
                dgvPais.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void dgvPais_DoubleClick(object sender, EventArgs e)
        {
            FrmAMBPaises = new FrmAMBPaises('M', clubsBD);
            FrmAMBPaises.idPais = (Int32)dgvPais.SelectedRows[0].Cells["paisID"].Value;
            FrmAMBPaises.nomPais = dgvPais.SelectedRows[0].Cells["nomPais"].Value.ToString().Trim();
            FrmAMBPaises.idContinente = (Int32)dgvPais.SelectedRows[0].Cells["id"].Value;

            FrmAMBPaises.ShowDialog();
            getDadesPais();
            
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (dgvPais.Rows.Count > 0)
            {
                FrmAMBPaises = new FrmAMBPaises('b', clubsBD);

                // posem les dades de la fila a les propietats de fABMTerritoris
                // ****ALERTA!!! ARA ELS NOMS DE LES COLUMNES DEL DATAGRIDVIEW NO SÓN ELS DELS CAMPS DE LA TAULA EN LA BD
                //     SINÓ QUE SÓN ELS QUE HEM UTILITZAT EN LA QUERY DINS DE getDades() o getDadesSenseFiltre()
                FrmAMBPaises.idPais = (Int32)dgvPais.SelectedRows[0].Cells["paisID"].Value;
                FrmAMBPaises.nomPais = dgvPais.SelectedRows[0].Cells["nomPais"].Value.ToString().Trim();
                FrmAMBPaises.idContinente = (Int32)dgvPais.SelectedRows[0].Cells["id"].Value;
                
                FrmAMBPaises.ShowDialog();

                getDadesPais();              
                
                FrmAMBPaises = null;
            }
            else
            {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
