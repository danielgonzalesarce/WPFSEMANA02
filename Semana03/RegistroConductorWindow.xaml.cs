using System.Windows;

namespace Semana03
{
    public partial class RegistroConductorWindow : Window
    {
        public RegistroConductorWindow()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtLicencia.Text) ||
                string.IsNullOrWhiteSpace(txtTransporte.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Crear y guardar en la lista compartida
            Conductor nuevo = new Conductor
            {
                NombreConductor = txtNombre.Text.Trim(),
                Licencia = txtLicencia.Text.Trim(),
                Transporte = txtTransporte.Text.Trim()
            };

            DatosGlobales.ListaConductores.Add(nuevo);

            MessageBox.Show("¡Conductor registrado con éxito!", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

            // Limpiar campos y cerrar
            txtNombre.Clear();
            txtLicencia.Clear();
            txtTransporte.Clear();
            this.Close();
        }
    }
}