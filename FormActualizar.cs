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
    public partial class FormActualizar : Form
    {
        public FormActualizar(string ID, string nombre, string precio, string cantidad, string categoria, string descripcion)
        {
            InitializeComponent();
            txtBID.Text = ID;
            txtBNombre.Text = nombre;
            txtBPrecio.Text = precio;
            txtBCantidad.Text = cantidad;   
            txtBCategoria.Text = categoria;  
            rTBDescripcion.Text = descripcion;
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            bool f = datos.comando("update Productos set Nombre='" + txtBNombre.Text + "', Precio='" + txtBPrecio.Text + "', Cantidad='" + txtBCantidad.Text + "', Categoria='" + txtBCategoria.Text + "', Descripcion='" + rTBDescripcion.Text + "' where ProductoId='" + txtBID.Text + "'");

            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from Productos where ProductoId='" + txtBID.Text + "'");
                if (f == true)
                {
                    MessageBox.Show("Datos ELiminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
