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
        private ClubsEntities4 clubsBD { get; set; } = new ClubsEntities4();
        public FrmClubs(ClubsEntities4 xclub)
        {
            InitializeComponent();
            clubsBD = xclub;
            ConfigurarColumnaLogo();
            getDadesSenseFiltre();
        }

        private void FrmClubs_Load(object sender, EventArgs e)
        {
            getDadesSenseFiltre();
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
                               ClubID = c.ClubID,
                               Nombre = c.Clubs.Nombre,
                               correo = c.Email,
                               telefono = c.Telefono,
                               Fundacion = c.Clubs.Fundacion,
                               Ciudad = u.Ciudad,
                               direccion = u.Direccion,
                               codiP = u.CodigoPostal,
                               paisid= u.PaisID,
                               paisNom = u.Pais,
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
                iniDgrid();
                
            }
        }

        private void iniDgrid()
        {
            dgvClubs.Columns["ClubID"].Visible = false;
            dgvClubs.Columns["correo"].Visible = false;
            dgvClubs.Columns["telefono"].Visible = false;
            dgvClubs.Columns["LogoBase64"].Visible = false;
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
                seleccionarFila(aMBclubs.NomClub);
            }
        }

        private void seleccionarFila(string name)
        {
            int i = -1;
            Boolean xbTrobat = false;

            while (!xbTrobat && i < dgvClubs.Rows.Count)
            {
                i++;
                xbTrobat = (dgvClubs.Rows[i].Cells["Nombre"].Value.ToString() == name);
            }
            if (dgvClubs.Rows.Count > 0)
            {
                dgvClubs.Rows[i].Selected = true;
                dgvClubs.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void dgvClubs_DoubleClick(object sender, EventArgs e)
        {
            aMBclubs = new FrmAMBclubs('M', clubsBD);
            aMBclubs.IdClub = dgvClubs.SelectedRows[0].Cells["ClubID"].Value.ToString().Trim();
            aMBclubs.NomClub = dgvClubs.SelectedRows[0].Cells["Nombre"].Value.ToString().Trim();
            aMBclubs.telefono = dgvClubs.SelectedRows[0].Cells["telefono"].Value.ToString().Trim();
            aMBclubs.correo = dgvClubs.SelectedRows[0].Cells["correo"].Value.ToString().Trim();
            aMBclubs.anyFund = dgvClubs.SelectedRows[0].Cells["Fundacion"].Value.ToString().Trim();
            aMBclubs.ciudadNom = dgvClubs.SelectedRows[0].Cells["Ciudad"].Value.ToString().Trim();
            aMBclubs.direccion = dgvClubs.SelectedRows[0].Cells["direccion"].Value.ToString().Trim();
            aMBclubs.codiPot= dgvClubs.SelectedRows[0].Cells["codiP"].Value.ToString().Trim();
            aMBclubs.idPais= (Int32)dgvClubs.SelectedRows[0].Cells["paisid"].Value;

            aMBclubs.ShowDialog();

            getDadesSenseFiltre();
        }
    }
}
