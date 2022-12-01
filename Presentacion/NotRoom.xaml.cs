using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para NotRoom.xaml
    /// </summary>
    public partial class NotRoom : UserControl
    {
        public NotRoom()
        {
            InitializeComponent();
        }

        public void SetText(string label)
        {
            txtInfo.Content = label;
        }
    }
}
