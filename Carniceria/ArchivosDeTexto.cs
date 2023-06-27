using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public static class ArchivosDeTexto
    {
        public static StreamWriter sw;
        public static StreamReader sr;
        public static string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos");



        /// <summary>
        /// Genera el directorio para guardar el archivo
        /// </summary>
        static ArchivosDeTexto()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        /// <summary>
        /// Guarda los productos de la lista que recibe en el archivo 
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool AgregarAlArchivo(List<DetalleVenta> lista, Venta venta, Cliente cliente)
        {
            bool agrego = false;
            try
            {
                string clientePath = Path.Combine(folderPath, cliente.Id + "_" + cliente.Nombre + ".txt");
                using (StreamWriter sw = new StreamWriter(clientePath, true))
                {
                    sw.WriteLine("");
                    sw.WriteLine($"Id: {cliente.Id} User {cliente.Nombre}");
                    foreach (DetalleVenta item in lista)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("TOTAL DE LA VENTA: " + venta.ObtenerTotalVenta().ToString());
                }
                agrego = true;
            }
            catch (Exception)
            {
                agrego = false;
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
            return agrego;
        }

        public static string LeerArchivoCliente(Cliente cliente)
        {
            string contenidoArchivo = string.Empty;
            string clientePath = Path.Combine(folderPath, cliente.Id + "_" + cliente.Nombre + ".txt");
            try
            {
                if (File.Exists(clientePath))
                {
                    contenidoArchivo = File.ReadAllText(clientePath);
                }
                else
                {
                    contenidoArchivo = "El cliente no tiene registros de compras.";
                }
            }
            catch (Exception)
            {
                contenidoArchivo = "Error al leer el archivo del cliente.";
            }

            return contenidoArchivo;
        }
    }
}
