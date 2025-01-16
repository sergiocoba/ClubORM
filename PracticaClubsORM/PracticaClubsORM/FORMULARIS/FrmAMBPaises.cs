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
    public partial class FrmAMBPaises : Form
    {
        private ClubsEntities1 clubsd { get; set; } = new ClubsEntities1();

        //variables
        Char op { get; set; } = '\0';
        public string nomPais { get; set; } = "";
        public int idContinente { get; set; }
        public int idPais { get; set; }
        public FrmAMBPaises(char opcio, ClubsEntities1 bd)
        {
            InitializeComponent();
            clubsd = bd;
            op = opcio;
        }

        private void FrmAMBPaises_Load(object sender, EventArgs e)
        {
            omplirComboContinentes();

            switch (op)
            {
                case 'A': this.Text = "Alta de un pais"; break;
                case 'M': this.Text = "Modificar pais"; break;
                case 'B': this.Text = "Borrar pais"; break;
            }
            tbNomPais.Text = nomPais;

            if (op == 'A')
            {
                cbContinente.SelectedIndex = 0;
            }
            else
            {
                cbContinente.SelectedValue = idContinente;
            }

            tbNomPais.Enabled = (op != 'B');
            cbContinente.Enabled = (op != 'B');
        }

        private void omplirComboContinentes()
        {
            var qryContinentes = from c in clubsd.Continentes
                                 orderby c.Nombre
                                 select new
                                 {
                                     id = c.ContinenteID,
                                     nom = c.Nombre,
                                 };
            cbContinente.DataSource = qryContinentes.ToList();
            cbContinente.DisplayMember = "nom";
            cbContinente.ValueMember = "id";
            if (cbContinente.Items.Count > 0)
            {
                cbContinente.SelectedIndex = 0;
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            nomPais = "";
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addPais(); break;
                    case 'M': xb = modPais(); break;
                    case 'B': xb = delPais(); break;
                }
                if (xb)
                {
                    this.Close();
                }
            }
        }

        private bool delPais()
        {
            Boolean xb = false;
            Pais p = clubsd.Pais.Find(idPais);


            Ubicacion u = clubsd.Ubicacion.Find(idPais);                  

            if (p != null && u == null)
            {
                clubsd.Pais.Remove(p);
                xb = ferCanvis();
            }
            else
            {
                MessageBox.Show("No pots eliminar paisos vinculats a clubs", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
            return xb;
        }

        private bool modPais()
        {
            Boolean xb = false;
            Pais p = clubsd.Pais.Find(idPais);
           
            if (p != null)
            {
                p.Nombre = tbNomPais.Text.Trim();
                p.ContinenteID = (int)cbContinente.SelectedValue;
                if (xb = ferCanvis()) // lo mismo que xb= true;
                {
                   
                    nomPais = tbNomPais.Text;

                }
                else
                {
                    
                    nomPais = "";
                }
            }
            return xb;
        }

        private bool addPais()
        {
            Boolean xb = false;
            Pais p = new Pais();

            if (vDades())
            {
                p.Nombre = tbNomPais.Text.Trim();
                p.ContinenteID = (int)cbContinente.SelectedValue;
                clubsd.Pais.Add(p);
                if (xb = ferCanvis()) // lo mismo que xb= true;
                {
                    // guardem l'id introduït a la propietat pública id per a que després de refrescar el DataGridView puguem seleccionar la fila en qüestió
                    nomPais = tbNomPais.Text;

                    xb = true;
                }
                else
                {
                    // si hi ha error deixem en blanc l'id
                    nomPais = "";
                   
                }
            }


            return xb;
        }

        private bool ferCanvis()
        {
            Boolean xb = false;
            try
            {
                clubsd.SaveChanges();
                xb = true;
            }
            catch (Exception excp)
            {
                // Hauríem de posar un missatge que sigui més entenedor per a l'usuari ja que el missatge de l'excepció és molt tècnic
                // Aquí ho fem així perquè estem fent exemples de desenvolupament i, per a tu, és més interessant veure l'error des d'aquest punt de vista tècnic
                MessageBox.Show(excp.InnerException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Eliminem l'acció que volíem realitzar perquè, si no ho fem, en el pròxim SaveChanges() es tornarà a provar de fer
                // Això passa perquè les accions es van posant en una cua i no s'eliminen de la cua si no es fa efectiu el canvi.
                // Es pot comprovar que passa això comentant aquestes línies del for, fent una alta d'un ID ja existent i després posar un ID correcte.
                foreach (var accio in clubsd.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }

            }
            return xb;
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if ((tbNomPais.Text.Trim().Length == 0) || (cbContinente.SelectedItem == null))
            {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }
    }
}