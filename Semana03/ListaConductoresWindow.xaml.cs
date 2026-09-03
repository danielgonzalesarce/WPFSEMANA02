using System.Windows;

namespace Semana03
{
    public partial class ListaConductoresWindow : Window
    {
        public ListaConductoresWindow()
        {
            InitializeComponent();
            CargarConductores();
        }

        public void CargarConductores()
        {
            dgConductores.ItemsSource = null;
            dgConductores.ItemsSource = DatosGlobales.ListaConductores;
        }
    }
}