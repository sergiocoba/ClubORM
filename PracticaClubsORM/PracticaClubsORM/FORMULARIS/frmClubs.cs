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
    public partial class FrmClubs : Form
    {
        FrmAMBclubs aMBclubs= null;
        //private ClubsEntities7 clubsBD {  get; set; } = new ClubsEntities7();
        private ClubsEntities clubsBD { get; set; } = new ClubsEntities();
        public FrmClubs(ClubsEntities xclub)
        {
            InitializeComponent();
            clubsBD = xclub;
            ConfigurarColumnaLogo();
            getDadesSenseFiltre();
        }

        private void FrmClubs_Load(object sender, EventArgs e)
        {
            
            


        }

        private void ConfigurarColumnaLogo()
        {
            // Verifica si la columna Logo ya existe, si no la agrega
            if (!dgvClubs.Columns.Contains("Logo"))
            {
                DataGridViewImageColumn logoColumn = new DataGridViewImageColumn();
                logoColumn.Name = "Logo";
                logoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvClubs.Columns.Add(logoColumn);
                 
            }
        }


        private void getDadesSenseFiltre()
        {
            var qryClubs = from c in clubsBD.Contacto
                           join u in clubsBD.Ubicacion on c.ClubID equals u.ClubID
                           join m in clubsBD.MediaVisual on c.ClubID equals m.ClubID
                           select new
                           {
                               Nombre = c.Clubs.Nombre,
                               Fundacion = c.Clubs.Fundacion,
                               Contacto = c.Telefono,
                               Ciudad = u.Ciudad,
                               LogoBase64 = m.Logo // Asegúrate de que esto esté almacenado en la base de datos como Base64
                           };

            var clubsList = qryClubs.ToList();

            // Asigna los datos al DataGridView
            dgvClubs.DataSource = clubsList;

            // Convertir y asignar la imagen en la columna Logo para cada fila
            foreach (DataGridViewRow row in dgvClubs.Rows)
            {
                
                // Verifica si la celda LogoBase64 tiene un valor válido
                if (row.Cells["LogoBase64"] != null && row.Cells["LogoBase64"].Value != null)
                {
                    string base64String = row.Cells["LogoBase64"].Value.ToString();

                    // Si la cadena Base64 no está vacía, convierte a imagen
                    if (!string.IsNullOrEmpty(base64String))
                    {
                        try
                        {
                            // Convierte de Base64 a imagen
                            Image image = ConvertBase64ToImage(base64String);

                            // Asigna la imagen a la celda Logo
                     
                            row.Cells["Logo"].Value = image;
                        }
                        catch (Exception ex)
                        {
                            // Maneja cualquier error de conversión
                            MessageBox.Show($"Error al convertir la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.Cells["Logo"].Value = null; // Si falla, asigna null
                        }
                    }
                    else
                    {
                        row.Cells["Logo"].Value = null; // Si la cadena Base64 está vacía, asigna null
                    }
                }

            }
        }

        private void ConfigurarTamañoColumnaLogo()
        {
            // Configura el tamaño adecuado para la columna Logo
            dgvClubs.Columns["Logo"].Width = 100;  // Ajusta el tamaño de la columna según lo necesites
        }


        private Image ConvertBase64ToImage(string base64String)
        {
            byte[] byteArray = Convert.FromBase64String(base64String); // Decodificar base64
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms); // Convertir a imagen
            }
        }



        private void pbAdd_Click(object sender, EventArgs e)
        {
            aMBclubs = new FrmAMBclubs('A',clubsBD);
            aMBclubs.ShowDialog();
            getDadesSenseFiltre();
            if (aMBclubs.NomClub != "")
            {
                //seleccionarFila(fABMestudiantes.nom1);
            }
        }
    }
}
