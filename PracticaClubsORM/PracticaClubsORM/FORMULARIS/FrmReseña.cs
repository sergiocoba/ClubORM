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
    public partial class FrmReseña : Form
    {
        private ClubsEntities4 clubbd { get; set; } = new ClubsEntities4();
        int calificacion = 0;
        FrmCreseñas creseña;
        public FrmReseña(ClubsEntities4 c)
        {
            InitializeComponent();
            clubbd = c;
            omplirComboClubs();
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
        private void Estrella5_Click(object sender, EventArgs e)
        {
            PictureBox estrellaSeleccionada = sender as PictureBox;

            if (estrellaSeleccionada != null)
            {
                
                int numeroEstrella = int.Parse(estrellaSeleccionada.Tag.ToString());
                calificacion = numeroEstrella;

                
                ActualizarEstrellas();
            }
        }
        private void ActualizarEstrellas()
        {
            for (int i = 1; i <= 5; i++)
            {
                PictureBox estrella = this.Controls.Find($"estrella{i}", true).FirstOrDefault() as PictureBox;
                if (estrella != null)
                {
                    estrella.Image = i <= calificacion
                        ? Properties.Resources.estrella_llena
                        : Properties.Resources.Estrella_vacia;
                }
            }
        }

        private void FrmReseña_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbReseña.Text == "Escribe una reseña sobre el club")
            {
                tbReseña.Text = "";
                tbReseña.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbReseña.Text))
            {
                tbReseña.Text = "Escribe una reseña sobre el club";
                tbReseña.ForeColor = Color.Gray; 
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Nombre y apellidos")
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.Text = "Nombre y apellidos";
                tbNombre.ForeColor = Color.Gray;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Reseña r = new Reseña();
            

            if (calificacion == 0)
            {
                MessageBox.Show("Por favor, selecciona una calificación.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbReseña.Text) || tbReseña.Text == "Por favor, selecciona una calificación.")
            {
                MessageBox.Show("Por favor, escribe una reseña.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || tbNombre.Text == "Nombre y apellidos")
            {
                MessageBox.Show("Por favor, escribe un nombre.");
                return;
            }

            r.Usuario = tbNombre.Text;
            r.Descripcion = tbReseña.Text;
            r.Valoracion = calificacion;
            r.ClubID = (int)cbClubs.SelectedValue;

            clubbd.Reseña.Add(r);
            MessageBox.Show("Reseña añadida");
            ferCanvis();

            reiniciarMenu();
            



        }

        private void reiniciarMenu()
        {
            calificacion = 0;
            for (int i = 1; i <= 5; i++)
            {
                PictureBox estrella = this.Controls.Find($"estrella{i}", true).FirstOrDefault() as PictureBox;
                if (estrella != null)
                {
                    estrella.Image = Properties.Resources.Estrella_vacia;
                }
            }

            tbNombre.Text = ""; 
            tbNombre.ForeColor = Color.Black;
            tbReseña.Text = "Escribe una reseña sobre el club"; 
            tbReseña.ForeColor = Color.Gray;

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

        private void button2_Click(object sender, EventArgs e)
        {
            creseña = new FrmCreseñas(clubbd);
            creseña.ShowDialog();

        }

        private void cbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            reiniciarMenu();
        }
    }
}
