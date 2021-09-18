namespace WpfMouseOperationPractice
{
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Input;
    using System.Windows.Media;

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
            // Trace.WriteLine($"Window_MouseMove x={e.GetPosition((IInputElement)sender).X:0.0f}");

            var coord = ((Visual)sender).PointToScreen(e.GetPosition((IInputElement)sender));
            Trace.WriteLine($"Window_MouseMove scx={coord.X:0.0f} scy={coord.Y:0.0f}");
        }

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            // Trace.WriteLine($"Ellipse_MouseMove x={e.GetPosition((IInputElement)sender).X:0.0f}");

            var coord = ((Visual)sender).PointToScreen(e.GetPosition((IInputElement)sender));
            Trace.WriteLine($"Ellipse_MouseMove scx={coord.X:0.0f} scy={coord.Y:0.0f}");
        }
    }
}
