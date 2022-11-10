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
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        int m, mx, my;
        private void controlVentana_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X; my = e.Y;
        }

        private void controlVentana_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void controlVentana_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
