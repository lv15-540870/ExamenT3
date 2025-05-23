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
    public partial class FormRegistrosInventarios : Form
    {
        public FormRegistrosInventarios()
        {
            InitializeComponent();
        }

        private void d_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Left)
            {
                dgvRegistrosInventarios.CurrentCell = dgvRegistrosInventarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltas formAlta = new FormAltas();
            formAlta.Show();
        }

        private void dgvRegistrosInventarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormActualizar actualizar = new FormActualizar(dgvRegistrosInventarios[0, e.RowIndex].Value.ToString(), dgvRegistrosInventarios[1, e.RowIndex].Value.ToString(), dgvRegistrosInventarios[2, e.RowIndex].Value.ToString(), dgvRegistrosInventarios[3, e.RowIndex].Value.ToString(), dgvRegistrosInventarios[4, e.RowIndex].Value.ToString(), dgvRegistrosInventarios[5, e.RowIndex].Value.ToString());
            actualizar.Show();
        }

        private void FormRegistrosInventarios_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            DataSet ds = datos.consulta("Select ProductoId as [Código del Artíoculo], Nombre as [Nombre del Artículo], Precio as [Precio del Artículo], Cantidad as [Cantidad], Categoria as [Categoria], Descripcion as [Descripcion] From Productos");

            if (ds != null)
            {
                dgvRegistrosInventarios.DataSource = ds.Tables[0];
            }
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select ProductoId as [Código del Artíoculo], Nombre as [Nombre del Artículo], Precio as [Precio del Artículo], Cantidad as [Cantidad], Categoria as [Categoria], Descripcion as [Descripcion] From Productos");

            if (ds != null)
            {
                dgvRegistrosInventarios.DataSource = ds.Tables[0];
            }
        }

        private void FormRegistrosInventarios_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formcr CR = new Formcr();
            CR.Show();
        }
    }
}
