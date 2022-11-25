using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MessageBox.xaml
    /// </summary>
    public partial class MessageBox : Window
    {
        public MessageBox(string label)
        {
            var window = GetWindow(this) as MainWindow;
            Owner = window;
            InitializeComponent();
            message.Content = label;
        }
        public MessageBox() { }
        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }
    }
}
