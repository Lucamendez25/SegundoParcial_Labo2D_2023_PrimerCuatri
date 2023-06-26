using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class Venta
    {
        public List<DetalleVenta> Detalles { get; set; }
        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }
        public void EliminarDetalleVenta(DetalleVenta detalleVenta)
        {
            Detalles.Remove(detalleVenta);
        }
        public double ObtenerTotalVenta()
        {
            double totalVenta = 0;

            foreach (DetalleVenta detalleVenta in Detalles)
            {
                totalVenta += detalleVenta.Total;
            }
            return totalVenta;
        }

    }
}
