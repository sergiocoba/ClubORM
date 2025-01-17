using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmCreseñas : Form
    {
        private ClubsEntities3 clubbd { get; set; } = new ClubsEntities3();

        public FrmCreseñas(ClubsEntities3 c)
        {
            InitializeComponent();
            clubbd = c;
            omplirComboBox();
        }

        private void getDadesDGV()
        {
            var qryReseñas = from r in clubbd.Reseña
                            //where r.ClubID == (int)cbClubs.SelectedValue
                           select new
                           {
                                Club = r.Clubs.Nombre,
                                Usuario = r.Usuario,
                                Estrellas = r.Valoracion,
                                Descripción = r.Descripcion,
                           };

            var reseñaList = qryReseñas.ToList();

            // Asigna los datos al DataGridView
            dgvReseñas.DataSource = reseñaList;
        }

        private void omplirComboBox()
        {
            var qryClubs = from c in clubbd.Clubs
                           orderby c.Nombre
                           select new
                           {
                               id = c.ClubID,
                               nom = c.Nombre,
                           };
            cbClubs.DataSource = qryClubs.ToList();
            cbClubs.DisplayMember = "nom";
            cbClubs.ValueMember = "id";
            if (cbClubs.Items.Count > 0)
            {
                cbClubs.SelectedIndex = 0;
            }
        }

        private void FrmCreseñas_Load(object sender, EventArgs e)
        {

        }

        private void cbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDadesDGV();

        }
    }
}
