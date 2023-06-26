using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class DetalleVenta
    {
        public double Peso { get; set; }
        public Producto Producto { get; set; }
        public double Total { get => Peso * Producto.ValorPorKilo; }
        public string NombreProducto { get => Producto.Nombre; }
        public void AgregarKilos(DetalleVenta detalleVenta, double kilos)
        {
            detalleVenta.Peso += kilos;
        }
        public override string ToString()
        {
            return $"Producto: {NombreProducto} - Peso: {Peso} - Valor Por Producto: {Total}";
        }
    }
}
