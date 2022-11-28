using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para TwoMessagebox.xaml
    /// </summary>
    public partial class TwoMessagebox : Window
    {
        public bool action = false;
        public TwoMessagebox(string label)
        {
            InitializeComponent();
            message.Content = label;
        }

        public TwoMessagebox() { }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            Close();
            action = true;
        }
        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
            action=false;
        }
    }
}
