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
    public partial class EntidadesForm : Form
    {
        clsBeTablaEntidades enti = new clsBeTablaEntidades();        
        clsLnTablaEntidades data = new clsLnTablaEntidades();

        public EntidadesForm()
        {
            InitializeComponent();
            ListarEntidades();
        }
        public void ListarEntidades()
        {
            var data = new clsLnTablaEntidades();
            dataGridViewEntidad.DataSource = data.Listar();

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormMantenimientos mantenimientos = new FormMantenimientos();
            mantenimientos.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var mants = new FormMantenimientos();

            if (dataGridViewEntidad.SelectedRows.Count > 0)
            {
                mants.textBoxDireccion.Text = dataGridViewEntidad.CurrentRow.Cells[0].Value.ToString;
                
            }
            
            



            mantenimientos.Show();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
