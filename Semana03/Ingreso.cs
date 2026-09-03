using System;

namespace Semana03
{
    // Modelo para Registro y Listado de Ingresos
    public class Ingreso
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Placa { get; set; }
        public string Turno { get; set; }
        public string NombreConductor { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaHora { get; set; }
        public double PesoIngreso { get; set; }
        public string Producto { get; set; }
        public string Transporte { get; set; }
    }
}