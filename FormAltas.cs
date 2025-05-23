using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenT3
{
    public partial class FormAltas : Form
    {
        public FormAltas()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into Productos (Nombre, Precio, Cantidad, Categoria, Descripcion) values ('" + txtBNombre.Text + "', '" + txtBPrecio.Text + "', '" + txtBCantidad.Text + "', '" + txtBCategoria.Text + "', '" + rTBDescripcion.Text + "');");

            if (f)
            {
                MessageBox.Show("Datos Insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al Insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
