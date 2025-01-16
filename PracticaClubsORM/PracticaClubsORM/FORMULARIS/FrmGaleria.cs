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

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmGaleria : Form
    {
        int indice = 0;
        private List<byte[]> imagesBase64;
        private ClubsEntities1 clubsBD { get; set; } = new ClubsEntities1();


        public FrmGaleria(ClubsEntities1 c)
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
            CargarImagenes((int)cbClubs.SelectedValue);

            if (indice < imagesBase64.Count - 1)
            {
                indice++;
                CargarImagen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imagesBase64.Count > 0)
                CargarImagen();
        }
        private void CargarImagen()
        {
            if (imagesBase64.Count > 0)
            {
                if (indice < 0) indice = 0;
                if (indice >= imagesBase64.Count) indice = imagesBase64.Count - 1;

                byte[] imageBytes = imagesBase64[indice];  
                pbAnterior.Image = ConvertBytesToImage(imageBytes);
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
                var query = from g in clubsBD.Galeria
                            where g.ClubID == clubID
                            select g.Foto;

                
                imagesBase64 = query
                .Where(f => !string.IsNullOrEmpty(f)) 
                .Select(f => Convert.FromBase64String(f))  
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
    }
}
