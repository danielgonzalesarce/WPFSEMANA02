using System;
using System.Windows;
using System.Windows.Controls;

namespace Semana03
{
    public partial class RegistroIngresoWindow : Window
    {
        public RegistroIngresoWindow()
        {
            InitializeComponent();
            dtpFechaHora.SelectedDate = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text) || string.IsNullOrWhiteSpace(txtNombreConductor.Text))
            {
                MessageBox.Show("Por favor complete al menos la Placa y el Conductor.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            double.TryParse(txtPesoIngreso.Text, out double peso);

            Ingreso nuevo = new Ingreso
            {
                TipoDocumento = (cmbTipoDoc.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "DNI",
                NumeroDocumento = txtNumDoc.Text.Trim(),
                Placa = txtPlaca.Text.Trim(),
                Turno = (cmbTurno.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Mañana",
                NombreConductor = txtNombreConductor.Text.Trim(),
                NombreCliente = txtNombreCliente.Text.Trim(),
                FechaHora = dtpFechaHora.SelectedDate ?? DateTime.Now,
                PesoIngreso = peso,
                Producto = "General",
                Transporte = "Propio"
            };

            DatosGlobales.ListaIngresos.Add(nuevo);

            MessageBox.Show("¡Ingreso guardado exitosamente!", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}