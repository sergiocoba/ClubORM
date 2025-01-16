using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmCategoria : Form
    {
        private ClubsEntities1 clubbd { get; set; } = new ClubsEntities1();
        bool bfirst = true;

        public int id { get; set; }
        public String nom { get; set; } = "";
        public FrmCategoria(ClubsEntities1 bd)
        {
            InitializeComponent();
            clubbd = bd;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            omplirComboClubs();
            getDadesClubsInscrit();
            bfirst = false;

        }
        private void omplirComboClubs()
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

        private void cbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!bfirst && cbClubs.SelectedValue != null)
            {
                getDadesClubsInscrit();

            }
        }

        private void getDadesClubsInscrit()
        {
            var qryClubsIn = (from g in clubbd.ClubCategorias
                               where (g.ClubID == (Int32)cbClubs.SelectedValue)
                               select new
                               {
                                   nombre = g.Categorias.Nombre,
                               });

            var qryCursosDips = from c in clubbd.Categorias
                                where !(qryClubsIn.Select(q => q.nombre).Contains(c.Nombre))
                                orderby c.Nombre
                                select new
                                {
                                    nombre = c.Nombre,
                                    
                                };



            dgvInscrit.DataSource = qryClubsIn.ToList();
            dgvDisp.DataSource = qryCursosDips.ToList();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ClubCategorias c = new ClubCategorias();
            string nomclub = dgvDisp.SelectedRows[0].Cells["nombre"].Value.ToString().Trim();

            var categoriaId = (from g in clubbd.Categorias
                           where g.Nombre == nomclub
                           select g.CategoriaID).FirstOrDefault();

            c.ClubID = (Int32)cbClubs.SelectedValue;
            c.CategoriaID = categoriaId;
            clubbd.ClubCategorias.Add(c);

            ferCanvis();

            getDadesClubsInscrit();
        }
        
        private void pbDelete_Click(object sender, EventArgs e)
        {
            string nomclub = dgvInscrit.SelectedRows[0].Cells["nombre"].Value.ToString().Trim();

            var categoriaId = (from g in clubbd.Categorias
                               where g.Nombre == nomclub
                               select g.CategoriaID).FirstOrDefault();

            int clubId = (Int32)cbClubs.SelectedValue;

            var clubCategoria = (from cc in clubbd.ClubCategorias
                                 where cc.ClubID == clubId && cc.CategoriaID == categoriaId
                                 select cc).FirstOrDefault();

            if (clubCategoria != null)
            {

                clubbd.ClubCategorias.Remove(clubCategoria);

                ferCanvis();

                getDadesClubsInscrit();
            }
            else
            {
                MessageBox.Show("No se encontró la relación Club-Categoría para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ferCanvis()
        {
            try
            {
                clubbd.SaveChanges();
            }
            catch (Exception excp)
            {
                // Hauríem de posar un missatge que sigui més entenedor per a l'usuari ja que el missatge de l'excepció és molt tècnic
                // Aquí ho fem així perquè estem fent exemples de desenvolupament i, per a tu, és més interessant veure l'error des d'aquest punt de vista tècnic
                MessageBox.Show(excp.InnerException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Eliminem l'acció que volíem realitzar perquè, si no ho fem, en el pròxim SaveChanges() es tornarà a provar de fer
                // Això passa perquè les accions es van posant en una cua i no s'eliminen de la cua si no es fa efectiu el canvi.
                // Es pot comprovar que passa això comentant aquestes línies del for, fent una alta d'un ID ja existent i després posar un ID correcte.
                foreach (var accio in clubbd.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }

            }
        }

        private void cbClubs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!bfirst && cbClubs.SelectedValue != null)
            {
                getDadesClubsInscrit();
            }
        }
    }
}
