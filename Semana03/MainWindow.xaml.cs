using System.Windows;

namespace Semana03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuIngresos_Click(object sender, RoutedEventArgs e)
        {
            RegistroIngresoWindow win = new RegistroIngresoWindow();
            win.ShowDialog();
        }

        private void MenuConductores_Click(object sender, RoutedEventArgs e)
        {
            RegistroConductorWindow win = new RegistroConductorWindow();
            win.ShowDialog();
        }

        private void MenuListaConductores_Click(object sender, RoutedEventArgs e)
        {
            ListaConductoresWindow win = new ListaConductoresWindow();
            win.ShowDialog();
        }

        private void MenuReporteIngresos_Click(object sender, RoutedEventArgs e)
        {
            ReporteIngresosWindow win = new ReporteIngresosWindow();
            win.ShowDialog();
        }

        private void MenuDummy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Módulo en desarrollo.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}