namespace WpfMouseOperationPractice
{
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Trace.WriteLine($"Window_MouseMove x={e.GetPosition((IInputElement)sender).X}");
        }

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Trace.WriteLine($"Ellipse_MouseMove x={e.GetPosition((IInputElement)sender).X}");
        }
    }
}
