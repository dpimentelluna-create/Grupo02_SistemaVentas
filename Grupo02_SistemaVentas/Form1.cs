using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo02_SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void javierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nuevo = new Form2();
            nuevo.Show();

        }

        private void felipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peña_Felipe nuevo = new Peña_Felipe();
            nuevo.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
