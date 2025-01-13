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
        private ClubsGestio clubbd { get; set; } = new ClubsGestio();
        Char op { get; set; } = '\0';
        public FrmAMBclubs(char opcio, ClubsGestio bd)
        {
            InitializeComponent();
            clubbd = bd;
            op = opcio; 
        }

        private void FrmAMBclubs_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'A': this.Text = "Alta d'un nou club"; break;

                case 'M': this.Text = "Modificar el clubs"; break;
            }
        }
    }
}
