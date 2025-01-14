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
    public partial class FrmAMBclubs : Form
    {
        //varibles de conexion 
        //private ClubsEntities7 clubbd { get; set; } = new ClubsEntities7();
        private ClubsEntities8 clubbd { get; set; } = new ClubsEntities8();

        //variables
        Boolean bFirst = true;
        Char op { get; set; } = '\0';
        string base64Image;

        //variables de modificacion 
        public String NomClub { get; set; } = "";
        public String telefono { get; set; } = "";
        public String correo { get; set; } = "";
        public String ciudadNom { get; set; } = "";
        public String direccion { get; set; } = "";
        public String pais { get; set; } = "";
        public int idPais { get; set; }
        
        public FrmAMBclubs(char opcio, ClubsEntities8 bd)
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
            var qryPaises = from e in clubbd.Clubs

                            select new
                            {
                                id = e.PaisID,
                                paisNom = e.Pais.Nombre,
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
            if (vDades())
            {
                e.Nombre = tbNom.Text.Trim();
                c.Telefono = tbTelefono.Text.Trim();
                c.Email = tbCorreo.Text.Trim();
                
            }
            return xb;
        }

        private bool modClub()
        {
            throw new NotImplementedException();
        }

    }
}
