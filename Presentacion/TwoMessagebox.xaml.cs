using System.Windows;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para TwoMessagebox.xaml
    /// </summary>
    public partial class TwoMessagebox : Window
    {
        public bool action = false;
        public TwoMessagebox()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            action = true;
        }
        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
            action = false;
        }

        public void setText(string label)
        {
            message.Content = label;
        }
    }
}
