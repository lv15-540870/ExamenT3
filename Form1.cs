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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltas formAltas = new FormAltas();
            formAltas.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrosInventarios formRegistrosInventarios = new FormRegistrosInventarios(); 
            formRegistrosInventarios.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
