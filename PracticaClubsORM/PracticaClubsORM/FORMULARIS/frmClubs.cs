﻿using System;
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
        FrmAMBclubs aMBclubs= null;
        //private ClubsEntities7 clubsBD {  get; set; } = new ClubsEntities7();
        private ClubsEntities8 clubsBD { get; set; } = new ClubsEntities8();
        public FrmClubs(ClubsEntities8 xclub)
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
            var qryClubs = from c in clubsBD.Contacto
                           join u in clubsBD.Ubicacion on c.ClubID equals u.ClubID
                           select new
                           {
                               Nombre = c.Clubs.Nombre,
                               Fundacion = c.Clubs.Fundacion,
                               Contacto = c.Telefono,
                               ciudad = u.Ciudad,
                               
                           };

            dgvClubs.DataSource = qryClubs.ToList();
                            
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            aMBclubs = new FrmAMBclubs('A',clubsBD);
            aMBclubs.ShowDialog();
            getDadesSenseFiltre();
            if (aMBclubs.NomClub != "")
            {
                //seleccionarFila(fABMestudiantes.nom1);
            }
        }
    }
}
