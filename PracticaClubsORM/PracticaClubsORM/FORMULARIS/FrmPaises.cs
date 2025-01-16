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

        private ClubsEntities2 clubsBD { get; set; } = new ClubsEntities2();
        bool bfirst = true;

        public FrmPaises(ClubsEntities2 clubsBd)
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
            
            if (FrmAMBPaises.nomPais != "")
            {
                
                seleccionarFila(FrmAMBPaises.nomPais);
            }
        }

        private void seleccionarFila(string nomPais)
        {
            bool paisEncontrado = false;

            for (int i = 0; i < cbContinente.Items.Count; i++)
            {
                cbContinente.SelectedIndex = i;
                getDadesPais();

                for (int j = 0; j < dgvPais.Rows.Count; j++)
                {
                    if (dgvPais.Rows[j].Cells["nomPais"].Value != null &&
                        dgvPais.Rows[j].Cells["nomPais"].Value.ToString().Trim().Equals(nomPais.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        
                        dgvPais.Rows[j].Selected = true;
                        dgvPais.FirstDisplayedScrollingRowIndex = j;
                        
                        paisEncontrado = true;
                        break;
                    }
                }

                if (paisEncontrado)
                {
                    break;
                }
            }

            if (!paisEncontrado)
            {
                MessageBox.Show("No se encontró el país en ningún continente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (FrmAMBPaises.nomPais != "")
            {
                seleccionarFila(FrmAMBPaises.nomPais);
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (dgvPais.Rows.Count > 0)
            {
                FrmAMBPaises = new FrmAMBPaises('B', clubsBD);

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
