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
    public partial class FrmConsultaClubs : Form
    {
        private ClubsEntities4 clubsd { get; set; } = new ClubsEntities4();

        //varibles
        Boolean bFirst = true;
        private String op { get; set; } = "";

        public FrmConsultaClubs(ClubsEntities4 c)
        {
            InitializeComponent();
            clubsd = c;
            bFirst = false;
            omplirComboContinente();
        }

        private void rbContinente_CheckedChanged(object sender, EventArgs e)
        {
            op = ((RadioButton)(sender)).Name;
            switch (op)
            {
                case "rbContinente":
                    omplirComboContinente();
                    break;
                case "rbPais":
                    omplirComboPais();
                    break;
                case "rbCategoria":
                    omplirComboCategoria();
                    break;
            }
        }

        private void omplirComboCategoria()
        {
           var qryCategoria = from c in clubsd.Categorias
                              orderby c.CategoriaID
                              select new
                              { 
                                 id = c.CategoriaID,
                                 nomCat = c.Nombre,
                              };
            cbFiltro.DataSource = qryCategoria.ToList();
            cbFiltro.DisplayMember = "nomCat";
            cbFiltro.ValueMember = "id";
            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }
        }

        private void omplirComboPais()
        {
            var qryPaises = from e in clubsd.Pais
                            orderby e.PaisID
                            select new
                            {
                                id = e.PaisID,
                                paisNom = e.Nombre,
                            };

            cbFiltro.DataSource = qryPaises.ToList();
            cbFiltro.DisplayMember = "paisNom";
            cbFiltro.ValueMember = "id";
            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }
        }

        private void omplirComboContinente()
        {
            var qryContinentes = from c in clubsd.Continentes
                                 orderby c.Nombre
                                 select new
                                 {
                                     id = c.ContinenteID,
                                     nom = c.Nombre,
                                 };
            cbFiltro.DataSource = qryContinentes.ToList();
            cbFiltro.DisplayMember = "nom";
            cbFiltro.ValueMember = "id";
            if (cbFiltro.Items.Count > 0)
            {
                cbFiltro.SelectedIndex = 0;
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst && cbFiltro.SelectedValue != null)
            {
                getDades((int)cbFiltro.SelectedValue);
            }
        }

        private void getDades(int selectedValue)
        {
            if (op == "rbContinente")
            {
                var qryClubPorContinente = from cl in clubsd.Clubs
                                           join c in clubsd.Contacto on cl.ClubID equals c.ClubID
                                           join u in clubsd.Ubicacion on cl.ClubID equals u.ClubID
                                           join p in clubsd.Pais on u.PaisID equals p.PaisID
                                           join co in clubsd.Continentes on p.ContinenteID equals co.ContinenteID
                                           orderby cl.Nombre
                                           where co.ContinenteID == selectedValue
                                           select new
                                           {
                                               nomClub = cl.Nombre,
                                               nomContinente = co.Nombre,

                                           };
                dgvClubs.DataSource = qryClubPorContinente.ToList();
            }
            else if (op == "rbPais")
            {
                
            }
            else
            {
                
            }

        }
    }
}
