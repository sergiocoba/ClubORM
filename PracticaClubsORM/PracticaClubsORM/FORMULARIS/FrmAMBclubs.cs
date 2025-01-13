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
    public partial class FrmAMBclubs : Form
    {
        private ClubEntities clubbd { get; set; } = new ClubEntities();
        Char op { get; set; } = '\0';

        //variable
        Boolean bFirst = true;
        public FrmAMBclubs(char opcio, ClubEntities bd)
        {
            InitializeComponent();
            clubbd = bd;
            op = opcio; 
        }

        private void FrmAMBclubs_Load(object sender, EventArgs e)
        {
            omplirComboPaises()

            switch (op)
            {
                case 'A': this.Text = "Alta d'un nou club"; break;

                case 'M': this.Text = "Modificar el clubs"; break;
            }
        }

        private void omplirComboPaises()
        {
            throw new NotImplementedException();
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
    }
}
