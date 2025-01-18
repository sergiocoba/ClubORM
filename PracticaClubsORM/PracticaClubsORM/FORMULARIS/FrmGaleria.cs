using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmGaleria : Form
    {
        int indice = 0;
        private List<byte[]> imagesBase64;
        string newImage64;
        private ClubsEntities4 clubsBD { get; set; } = new ClubsEntities4();


        public FrmGaleria(ClubsEntities4 c)
        {
            InitializeComponent();
            clubsBD = c;
            omplirComboClubs();
            
        }

        private void omplirComboClubs()
        {
            var qryClubs = from c in clubsBD.Clubs
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

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            //CargarImagenes((int)cbClubs.SelectedValue);

            if (indice < imagesBase64.Count - 1)
            {
                indice++;
                CargarImagen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarImagenes((int)cbClubs.SelectedValue);
            if (imagesBase64.Count > 0 && imagesBase64 !=null )
                CargarImagen();
        }
        private void CargarImagen()
        {
            if (imagesBase64.Count > 0)
            {
                if (indice < 0) indice = 0;
                if (indice >= imagesBase64.Count) indice = imagesBase64.Count - 1;

                byte[] imageBytes = imagesBase64[indice];  
                pbFotos.Image = ConvertBytesToImage(imageBytes);
            }
        }
        private Image ConvertBytesToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms); 
            }
        }
        private void CargarImagenes(int clubID)
        { 
            {
                // Primero obtén las cadenas Base64 como están en la base de datos
                var base64Strings = clubsBD.Galeria
                    .Where(g => g.ClubID == clubID)
                    .Select(g => g.Foto) // Solo selecciona las cadenas Base64
                    .ToList(); // Materializa los datos en memoria

                // Luego convierte las cadenas Base64 a byte[] en memoria
                imagesBase64 = base64Strings
                    .Where(f => !string.IsNullOrEmpty(f)) // Filtra nulos o vacíos
                    .Select(f => Convert.FromBase64String(f)) // Convierte cada cadena a byte[]
                    .ToList();
            }
        }

        private void pbAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                CargarImagen();
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    

                    newImage64 = ConvertImageToBase64(openFileDialog.FileName);
                    agregarImagen();
                }

            }
        }

        private void agregarImagen()
        {
            Galeria g = new Galeria();
            
            g.ClubID = (int)cbClubs.SelectedValue;
            g.Foto = newImage64;
            clubsBD.Galeria.Add(g);

            ferCanvis();
        }
        private void ferCanvis()
        {
            
            try
            {
                clubsBD.SaveChanges();
                
            }
            catch (Exception excp)
            {
                // Hauríem de posar un missatge que sigui més entenedor per a l'usuari ja que el missatge de l'excepció és molt tècnic
                // Aquí ho fem així perquè estem fent exemples de desenvolupament i, per a tu, és més interessant veure l'error des d'aquest punt de vista tècnic
                MessageBox.Show(excp.InnerException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Eliminem l'acció que volíem realitzar perquè, si no ho fem, en el pròxim SaveChanges() es tornarà a provar de fer
                // Això passa perquè les accions es van posant en una cua i no s'eliminen de la cua si no es fa efectiu el canvi.
                // Es pot comprovar que passa això comentant aquestes línies del for, fent una alta d'un ID ja existent i després posar un ID correcte.
                foreach (var accio in clubsBD.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }

            }
            
        }

        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            return Convert.ToBase64String(imageBytes);
        }

        private void cbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
