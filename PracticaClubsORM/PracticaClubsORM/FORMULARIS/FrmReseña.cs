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
    public partial class FrmReseña : Form
    {
        private ClubsEntities2 clubbd { get; set; } = new ClubsEntities2();
        int calificacion = 0;
        public FrmReseña(ClubsEntities2 c)
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
                tbReseña.Text = ""; // Limpia el texto del placeholder.
                tbReseña.ForeColor = Color.Black; // Cambia el color del texto al color predeterminado.
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbReseña.Text))
            {
                tbReseña.Text = "Escribe una reseña sobre el club"; // Reaparece el placeholder.
                tbReseña.ForeColor = Color.Gray; // Cambia el color a gris para que parezca un placeholder.
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Nombre y apellidos")
            {
                tbNombre.Text = ""; // Limpia el texto del placeholder.
                tbNombre.ForeColor = Color.Black; // Cambia el color del texto al color predeterminado.
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.Text = "Nombre y apellidos"; // Reaparece el placeholder.
                tbNombre.ForeColor = Color.Gray; // Cambia el color a gris para que parezca un placeholder.
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

            if (string.IsNullOrWhiteSpace(tbReseña.Text))
            {
                MessageBox.Show("Por favor, escribe una reseña.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("Por favor, escribe una reseña.");
                return;
            }

            r.Usuario = tbNombre.Text;
            r.Descripcion = tbReseña.Text;
            r.Valoracion = calificacion;

        }
    }
}
