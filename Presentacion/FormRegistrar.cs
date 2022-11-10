using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
            
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            Cambiar.AbrirFormulario<FormInicioSesion>();
            
        }

    }
}
