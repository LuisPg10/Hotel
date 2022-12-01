using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MessageBox.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox()
        {
            var window = GetWindow(this) as MainWindow;
            Owner = window;
            InitializeComponent();
        }
        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }
        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }
        public void Text (string label)
        {
            message.Content = label;
        }
    }
}
