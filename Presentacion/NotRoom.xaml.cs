using System.Windows.Controls;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para NotRoom.xaml
    /// </summary>
    public partial class NotRoom : UserControl
    {
        public NotRoom(string label)
        {
            InitializeComponent();
            txtInfo.Content = label;

        }
        public NotRoom(){}
    }
}
