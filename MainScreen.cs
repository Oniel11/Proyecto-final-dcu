using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
           

        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelFecha.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel1Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntidadesForm entidad = new EntidadesForm();
            entidad.MdiParent = this;
            entidad.Show();
        }

        private void gruposDeEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos grupos = new Grupos();
            grupos.MdiParent = this;
            grupos.Show();
        }

        private void tiposDeEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoEntidad tipoEntidad = new TipoEntidad();
            tipoEntidad.MdiParent = this;
            tipoEntidad.Show();
        }
    }
}
