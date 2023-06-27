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
        /// <summary>
        /// Elimina todos los detales de la venta
        /// </summary>
        /// <param name="detalleVenta"></param>
        public void EliminarDetalleVenta(DetalleVenta detalleVenta)
        {
            Detalles.Remove(detalleVenta);
        }
        /// <summary>
        /// Retorna el total de la Venta
        /// </summary>
        /// <returns></returns>
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
