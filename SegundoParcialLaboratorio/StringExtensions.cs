using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLaboratorio2023
{
    public static class StringExtensions
    {
        public static string ObtenerNombreYKiloProducto(this Producto producto)
        {
            double cantidadKilos = ObtenerCantidad(producto);
            return $"Producto: {producto.Nombre}, Cantidad disponible: {cantidadKilos}";
        }
        private static double ObtenerCantidad(Producto producto)
        {
            return producto.Stock;
        }
        public static string ObtenerInformacionCompleta(this Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {producto.Nombre}");
            sb.AppendLine($"Código de Producto: {producto.CodigoProducto}");
            sb.AppendLine($"Tipo: {producto.Tipo.ToString()}");
            sb.AppendLine($"Valor por Kilo: {producto.ValorPorKilo.ToString()}");
            sb.AppendLine($"Stock: {producto.Stock.ToString()}");
            return sb.ToString();
        }

        public static string ObtenerNombreYVentasDelVendedor(this Vendedor vendedor) 
        {
            return $"Vendedor: {vendedor.NombreUsuario} Ventas: {vendedor.Ventas}";
        }

        public static string ObtenerNombreDeUsuarioYDineroCliente(this Cliente cliente)
        {
            return $"User: {cliente.NombreUsuario} Dinero: {cliente.Dinero}";
        }

        public static string informacionDelProceso(this string info, bool salioBien) 
        {
            StringBuilder sb = new StringBuilder();
            if (salioBien)
            {
                sb.AppendLine("El proceso se");
                sb.AppendLine("pudo ejectuar");
                sb.AppendLine("correctamente");
            }
            else 
            { 
                sb.AppendLine("Hubo un problema");
                sb.AppendLine("al ejecutar");
                sb.AppendLine("este proceso...");
                if (info != null) 
                { 
                    sb.AppendLine($"{info}");
                }
            }
            return sb.ToString();
        }

        public static string NoEligioNingunProductoDataGridView(this string info)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("No eligió");
            sb.AppendLine("ningun producto");
            sb.AppendLine("del DataGridView");
            return sb.ToString();
           
        }
    }
}
