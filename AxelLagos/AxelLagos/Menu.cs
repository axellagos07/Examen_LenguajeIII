using System;
using System.Windows.Forms;

namespace AxelLagos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void formularioDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Productos();
            formulario2.Show();
        }

        private void formularioDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario3 = new Multiplos();
            Formulario3.Show();
        }

        private void formularioDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Intereses();
            formulario1.Show();
        }
    }
}
