using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReservar : Form
    {
        public bool reservada = false;
        public FormReservar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Habitación reservada con exito");
            reservada = true;
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            reservada = false;
            this.Close();
        }
    }
}
