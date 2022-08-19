using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layers.Framework.ADO.Net.Data;
using Layers.Framework.ADO.Net.Data.Modelos;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            clsLnTablaEntidades data = new clsLnTablaEntidades();
            clsBeTablaEntidades enti = new clsBeTablaEntidades();

            enti.UserNameEntidad = textBoxUsuario.Text;
            enti.PassworEntidad = textBoxContrasenia.Text;

            if (data.Obtenerusario(ref enti))
            {
                MessageBox.Show("conectado");
                this.Dispose();
            }
            else
            {
                MessageBox.Show(" no conectado");
            }
        }
    }
}
