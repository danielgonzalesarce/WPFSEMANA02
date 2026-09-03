using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Semana03
{
    public partial class ReporteIngresosWindow : Window
    {
        public ReporteIngresosWindow()
        {
            InitializeComponent();
            FiltrarEnTiempoReal();
        }

        // Se ejecuta cada vez que el usuario escribe una letra o cambia la fecha
        private void Filtro_Cambiado(object sender, RoutedEventArgs e)
        {
            FiltrarEnTiempoReal();
        }

        private void FiltrarEnTiempoReal()
        {
            if (DatosGlobales.ListaIngresos == null) return;

            var resultado = DatosGlobales.ListaIngresos.AsEnumerable();

            // Filtro Placa
            if (!string.IsNullOrWhiteSpace(txtFiltroPlaca.Text))
                resultado = resultado.Where(x => x.Placa != null && x.Placa.ToLower().Contains(txtFiltroPlaca.Text.ToLower()));

            // Filtro Conductor
            if (!string.IsNullOrWhiteSpace(txtFiltroConductor.Text))
                resultado = resultado.Where(x => x.NombreConductor != null && x.NombreConductor.ToLower().Contains(txtFiltroConductor.Text.ToLower()));

            // Filtro Producto
            if (!string.IsNullOrWhiteSpace(txtFiltroProducto.Text))
                resultado = resultado.Where(x => x.Producto != null && x.Producto.ToLower().Contains(txtFiltroProducto.Text.ToLower()));

            // Filtro Fechas
            if (dtpFechaInicio.SelectedDate.HasValue)
                resultado = resultado.Where(x => x.FechaHora.Date >= dtpFechaInicio.SelectedDate.Value.Date);

            if (dtpFechaFin.SelectedDate.HasValue)
                resultado = resultado.Where(x => x.FechaHora.Date <= dtpFechaFin.SelectedDate.Value.Date);

            dgReporteIngresos.ItemsSource = null;
            dgReporteIngresos.ItemsSource = resultado.ToList();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtFiltroPlaca.Clear();
            txtFiltroConductor.Clear();
            txtFiltroProducto.Clear();
            dtpFechaInicio.SelectedDate = null;
            dtpFechaFin.SelectedDate = null;
            FiltrarEnTiempoReal();
        }
    }
}