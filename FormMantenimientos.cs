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
    public partial class FormMantenimientos : Form
    {
        clsBeTablaEntidades enti = new clsBeTablaEntidades();
        clsLnTablaEntidades data = new clsLnTablaEntidades();
        public bool update = false;
        public FormMantenimientos()
        {
            InitializeComponent();

        }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var data = new clsLnTablaEntidades();
            var enti = new clsBeTablaEntidades();

            if (update==false)
            {
                if (textBoxDescripcion.Text == "" || textBoxDireccion.Text == "" || textBoxLocalidad.Text == "" || textBoxUrlFacebook.Text == "" || textBoxUserName.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
                {
                    MessageBox.Show("Todos los campos estan basidos, Complete todos los ampos.");
                }
                else if (textBox11.Text != textBox12.Text)
                {
                    MessageBox.Show("La contraseña no coinsiden");

                }
                else
                {
                    enti.Descripcion = textBoxDescripcion.Text;

                    enti.DIRECCION = textBoxDireccion.Text;
                    enti.Localidad = textBoxLocalidad.Text;
                    enti.TipoEntidad = comboBoxTipoEntidad.Text;
                    enti.TipoDocumento = comboBoxTipoDocumento.Text;
                    enti.URLFACEBOOK = textBoxUrlFacebook.Text;
                    enti.URLINSTAGRAM = textBoxUrlFacebook.Text;
                    enti.URLPAaginaWeb = textBoxUrlFacebook.Text;
                    enti.URLTIKTOK = textBoxUrlFacebook.Text;
                    enti.URLTWITTER = textBoxUrlFacebook.Text;
                    enti.UserNameEntidad = textBoxUserName.Text;
                    enti.RolUserEntidad = comboBoxRol.Text;
                    enti.Statues = comboBoxStatus.Text;
                    enti.NumeroDocumento = Convert.ToInt16(textBox9.Text);
                    enti.Telefonos = textBox10.Text;
                    enti.PassworEntidad = textBox11.Text;
                    data.Insertar(ref enti);
                    MessageBox.Show("Entidad Guardada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            else
            {

            }





            if (textBoxDescripcion.Text == "" || textBoxDireccion.Text == "" || textBoxLocalidad.Text == "" || textBoxUrlFacebook.Text == "" || textBoxUserName.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("Todos los campos estan basidos, Complete todos los ampos.");
            }
            else if (textBox11.Text != textBox12.Text)
            {
                MessageBox.Show("La contraseña no coinsiden");

            }
            else
            {

            }


            /*
            enti.LimiteCredito = 9;
            enti.NoEliminable = true;
            enti.IdGrupoEntidad = 1;
            enti.IdTipoEntidad = 1;
            */
           

        }

        private void comboBoxTipoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
