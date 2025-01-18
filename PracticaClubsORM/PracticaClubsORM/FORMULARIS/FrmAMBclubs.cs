using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuppeteerSharp;
namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmAMBclubs : Form
    {
        //private ClubsEntities7 clubbd { get; set; } = new ClubsEntities7();
        private ClubsEntities3 clubbd { get; set; } = new ClubsEntities3();

        //variables
        Boolean bFirst = true;
        Char op { get; set; } = '\0';
        string base64Image;

        public String IdClub { get; set; }
        public String NomClub { get; set; } = "";
        public String telefono { get; set; } = "";
        public String correo { get; set; } = "";
        public String ciudadNom { get; set; } = "";
        public String direccion { get; set; } = "";
        public String pais { get; set; } = "";
        public int idPais { get; set; }
        
        public FrmAMBclubs(char opcio, ClubsEntities3 bd)
        {
            InitializeComponent();
            clubbd = bd;
            op = opcio; 
        }

        private void FrmAMBclubs_Load(object sender, EventArgs e)
        {
            omplirComboPaises();

            switch (op)
            {
                case 'A': this.Text = "Alta d'un nou club"; break;

                case 'M': this.Text = "Modificar el clubs"; break;
                
            }

            tbNom.Text = NomClub;
            tbTelefono.Text = telefono;
            tbCorreo.Text = correo;
            tbCiudad.Text = ciudadNom;
            tbDireccion.Text = direccion;
            if (op == 'A')
            {
                cbPais.SelectedIndex = 0;
            }
            else
            {
                cbPais.SelectedValue = idPais;
            }

        }

        
        private void omplirComboPaises()
        {
            var qryPaises = from e in clubbd.Pais
                            orderby e.PaisID
                            select new
                            {
                                id = e.PaisID,
                                paisNom = e.Nombre,
                            };

            cbPais.DataSource = qryPaises.ToList();
            cbPais.DisplayMember = "paisNom";
            cbPais.ValueMember = "id";
            if (cbPais.Items.Count > 0)
            {
                cbPais.SelectedIndex = 0;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pblogo.Image = Image.FromFile(openFileDialog.FileName);

                    base64Image = ConvertImageToBase64(openFileDialog.FileName);
                }
            }
        }

        private string ConvertImageToBase64(string imagePath)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            return Convert.ToBase64String(imageBytes);
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            NomClub = "";
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addClub(); break;
                    case 'M': xb = modClub(); break;
                }
                if (xb)
                {
                    this.Close();
                }
            }
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if ((tbNom.Text.Trim().Length == 0) || (tbTelefono.Text.Trim().Length == 0) || (tbCorreo.Text.Trim().Length ==0)
                || (tbCiudad.Text.Trim().Length == 0) || (tbDireccion.Text.Trim().Length == 0) || (cbPais.SelectedItem == null))
            {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private bool addClub()
        {
            Boolean xb = false;
            Clubs e = new Clubs();
            Contacto c = new Contacto();
            Ubicacion u = new Ubicacion();
            MediaVisual m = new MediaVisual();

            if (vDades())
            {
                e.Nombre = tbNom.Text.Trim();
                e.Fundacion = int.Parse(tbFundacion.Text.Trim());

                clubbd.Clubs.Add(e);
                if (!ferCanvis()) return xb;

                
                c.ClubID = e.ClubID;
                c.Telefono = tbTelefono.Text.Trim();
                c.Email = tbCorreo.Text.Trim();

                u.ClubID = e.ClubID;
                u.Direccion = tbDireccion.Text.Trim();
                u.Ciudad = tbCiudad.Text.Trim();
                u.CodigoPostal = tbCodigoPostal.Text.Trim();
                u.PaisID = (int)cbPais.SelectedValue;

                m.ClubID = e.ClubID;
                m.Logo = base64Image;

                if(tbWeb != null) 
                {
                    m.MiniaturaWeb = obtenirMiniaturaWeb(tbWeb.Text).GetAwaiter().GetResult();
                }
            

                clubbd.Contacto.Add(c);
                clubbd.Ubicacion.Add(u);
                clubbd.MediaVisual.Add(m);


                if (ferCanvis())
                {
                    IdClub = e.ClubID.ToString();
                    NomClub = e.Nombre.ToString();
                    xb = true;
                }
                else
                {
                    IdClub = "";
                }
            }

            return xb;
        }

        static async Task<string> obtenirMiniaturaWeb(string url)
        {
            
            var browser = Puppeteer.LaunchAsync(new LaunchOptions { Headless = true }).GetAwaiter().GetResult();
            var page = browser.NewPageAsync().GetAwaiter().GetResult();

            page.GoToAsync(url).GetAwaiter().GetResult();

            var screenshotStream = page.ScreenshotStreamAsync(new ScreenshotOptions
            {
                FullPage = false,
                Type = ScreenshotType.Png
            }).GetAwaiter().GetResult();

            var memoryStream = new MemoryStream();
            screenshotStream.CopyTo(memoryStream);
            string base64Image = Convert.ToBase64String(memoryStream.ToArray());

            return base64Image;

        }

        private Boolean ferCanvis()
        {
            Boolean xb = false;
            try
            {
                clubbd.SaveChanges();
                xb = true;
            }
            catch (Exception excp)
            {
                string errorMessage = excp.InnerException != null
                    ? excp.InnerException.ToString()
                    : excp.Message;

                MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
                foreach (var accio in clubbd.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }
            }
            return xb;
        }


        private bool modClub()
        {
            throw new NotImplementedException();
        }

  
    }
}
