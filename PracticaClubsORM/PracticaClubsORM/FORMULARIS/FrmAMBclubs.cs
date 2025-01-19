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
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;
using EO.WebBrowser;

namespace PracticaClubsORM.FORMULARIS
{
    public partial class FrmAMBclubs : Form
    {
        
        private ClubsEntities4 clubbd { get; set; } = new ClubsEntities4();
        //private ClubsEntities4 clubbd { get; set; } = new ClubsEntities4();

        //variables
        WebBrowser webBrowser1 = new WebBrowser();
        Char op { get; set; } = '\0';
        string base64Image;
        string webImage;
        private WebView2 webview;

        public String IdClub { get; set; }
        public String NomClub { get; set; } = "";
        public String telefono { get; set; } = "";
        public String correo { get; set; } = "";
        public String anyFund { get; set; } = "";
        public String ciudadNom { get; set; } = "";
        public String direccion { get; set; } = "";
        public String codiPot { get; set; } = "";
        public String pais { get; set; } = "";
        public String paginaWeb { get; set; } = "";
        public int idPais { get; set; }
        public int contactoID {  get; set; }
        public int ubicacionID { get; set; }
        public String logo { get; set; } = "";

        public FrmAMBclubs(char opcio, ClubsEntities4 bd)
        {
            InitializeComponent();
            clubbd = bd;
            op = opcio;
            webview = new WebView2
            {
                Width = 1024,
                Height = 768,
                Visible = false // Oculto, solo para capturas
            };
            this.Controls.Add(webview);
        }

        private void FrmAMBclubs_Load(object sender, EventArgs e)
        {
            omplirComboPaises();

            switch (op)
            {
                case 'A': this.Text = "Alta de un club"; break;
                case 'B': this.Text = "borrar club"; break;
                case 'M': this.Text = "Modificar el club"; break;

            }

            tbNom.Text = NomClub;
            tbTelefono.Text = telefono;
            tbCorreo.Text = correo;
            tbFundacion.Text = anyFund;
            tbCiudad.Text = ciudadNom;
            tbDireccion.Text = direccion;
            tbCodigoPostal.Text = codiPot;

            if (op == 'A')
            {
                cbPais.SelectedIndex = 0;
            }
            else
            {
                cbPais.SelectedValue = idPais;
               
            }

            if (!string.IsNullOrEmpty(logo))
            {
                try
                {
                    pblogo.Image = Base64ToImage(logo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen del logo: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            tbNom.Enabled = (op != 'B');
            tbTelefono.Enabled = (op != 'B');
            tbCorreo.Enabled = (op != 'B');
            tbFundacion.Enabled = (op != 'B');
            tbCiudad.Enabled = (op != 'B');
            tbDireccion.Enabled = (op != 'B');
            tbCodigoPostal.Enabled = (op != 'B');
            cbPais.Enabled = (op != 'B');
            tbWeb.Enabled = (op != 'B');
            button1.Enabled = (op != 'B');

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

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
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
                    case 'B': xb = delClub(); break;
                    case 'M': xb = ModClub(); break;
                }
                if (xb)
                {
                    this.Close();
                }
            }
        }

        private bool delClub()
        {
            Boolean xb = false;
            Clubs cl = clubbd.Clubs.Find(int.Parse(IdClub));
            Contacto c = clubbd.Contacto.Find(contactoID);
            Ubicacion u = clubbd.Ubicacion.Find(ubicacionID);


            if (cl != null && c != null && u != null)
            {
                clubbd.Clubs.Remove(cl);
                clubbd.Contacto.Remove(c);
                clubbd.Ubicacion.Remove(u);
                xb = ferCanvis();
            }
      
            
            return xb;
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if ((tbNom.Text.Trim().Length == 0) || (tbTelefono.Text.Trim().Length == 0) || (tbCorreo.Text.Trim().Length == 0)
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
                

                if (!string.IsNullOrEmpty(tbWeb.Text))
                {
                    

                    CapturarImagen();
                    m.MiniaturaWeb = webImage;

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

        private async void CapturarImagen()
        {
            string url = tbWeb.Text.Trim();

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                MessageBox.Show("Introduce una URL válida.");
                return;
            }

            try
            {
                // Navegar a la URL
                
                webview.Source = new Uri(url);
                await webview.EnsureCoreWebView2Async();

                // Esperar a que cargue
                await Task.Delay(3000);

                // Capturar la pantalla
                using (Bitmap bitmap = new Bitmap(webview.Width, webview.Height))
                {
                    webview.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

                    // Convertir a Base64
                    webImage = ConvertToBase64(bitmap);

                    // Mostrar la imagen
                    //pictureBoxPreview.Image = Base64ToImage(base64Image);

                    // Opcional: Mostrar el Base64 en consola
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al capturar la página: {ex.Message}");
            }
        }
        private string ConvertToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        private bool ModClub()
        {
            Boolean xb = false;
            Clubs e = clubbd.Clubs.Find(int.Parse(IdClub));

            if (e != null) 
            {

                e.Nombre = tbNom.Text.Trim();
                e.Fundacion = int.Parse(tbFundacion.Text.Trim());


                int clubID = e.ClubID;
                Contacto c = clubbd.Contacto.Find(contactoID);
                if (c != null)
                {
                    c.Telefono = tbTelefono.Text.Trim();
                    c.Email = tbCorreo.Text.Trim();
                }

                Ubicacion u = clubbd.Ubicacion.Find(ubicacionID);
                if (u != null)
                {
                    u.Direccion = tbDireccion.Text.Trim();
                    u.Ciudad = tbCiudad.Text.Trim();
                    u.CodigoPostal = tbCodigoPostal.Text.Trim();
                    u.PaisID = (int)cbPais.SelectedValue;
                }

                MediaVisual m = clubbd.MediaVisual.Find(e.ClubID);
                if (m != null)
                {
                    m.Logo = base64Image;
                    if (!string.IsNullOrEmpty(tbWeb.Text))
                    {
                    }
                }

                if (xb = ferCanvis())
                {
                    IdClub = e.ClubID.ToString();
                    NomClub = e.Nombre;
                }
                else
                {
                    IdClub = "";
                    NomClub = "";
                    
                }
                
            }
            return xb;
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


  
    }
}
