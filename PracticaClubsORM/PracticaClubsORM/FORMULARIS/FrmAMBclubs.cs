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
        private ClubsEntities7 clubbd { get; set; } = new ClubsEntities7();
        Char op { get; set; } = '\0';
        string base64Image;
        //variable
        Boolean bFirst = true;
        public FrmAMBclubs(char opcio, ClubsEntities7 bd)
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst && cbPais.SelectedValue != null)
            {
                getDadesPaises();
            }
        }

        private void getDadesPaises()
        {
            
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
    }
}
