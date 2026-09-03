using System;
using System.Collections.Generic;

namespace Semana03
{
    public static class DatosGlobales
    {
        // Lista compartida de Conductores
        public static List<Conductor> ListaConductores { get; set; } = new List<Conductor>
        {
            new Conductor { NombreConductor = "Carlos Mendoza", Licencia = "Q-45892134", Transporte = "Transportes del Sur" },
            new Conductor { NombreConductor = "Juan Pérez", Licencia = "Q-12345678", Transporte = "Express Cargo" }
        };

        // Lista compartida de Ingresos
        public static List<Ingreso> ListaIngresos { get; set; } = new List<Ingreso>
        {
            new Ingreso { FechaHora = DateTime.Now.AddDays(-1), Placa = "ABC-123", Turno = "Mañana", NombreConductor = "Carlos Mendoza", Producto = "Minerales", PesoIngreso = 2500, Transporte = "Transportes del Sur" },
            new Ingreso { FechaHora = DateTime.Now, Placa = "XYZ-789", Turno = "Tarde", NombreConductor = "Juan Pérez", Producto = "Cemento", PesoIngreso = 4100, Transporte = "Express Cargo" }
        };
    }
}