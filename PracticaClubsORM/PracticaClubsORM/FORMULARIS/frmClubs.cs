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
    public partial class FrmClubs : Form
    {
        FrmAMBclubs aMBclubs;
        private ClubsBaseD clubsBD {  get; set; } = new ClubsBaseD();
        public FrmClubs(ClubsBaseD xclub)
        {
            InitializeComponent();
            clubsBD = xclub;
        }

        private void FrmClubs_Load(object sender, EventArgs e)
        {
            getDadesSenseFiltre();
        }

        private void getDadesSenseFiltre()
        {
            var qryClyubs = from c in clubsBD.Clubs
                            orderby c.Nombre ascending
                            select new
                            {
                                nombre = c.Nombre,
                                pais = c.Pais.Nombre,
                                fundacion = c.fundacion
                            };
            dgvClubs.DataSource = qryClyubs.ToList();
                            
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            aMBclubs = new FrmAMBclubs('A',clubsBD);
            aMBclubs.ShowDialog();
        }
    }
}
