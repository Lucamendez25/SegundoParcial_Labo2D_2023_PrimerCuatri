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
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /// <summary>
        /// Genera el directorio para guardar el archivo
        /// </summary>
        static ArchivosDeTexto()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos");
            }
            ArchivosDeTexto.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos\\Productos.txt";
        }

        /// <summary>
        /// Guarda los productos de la lista que recibe en el archivo 
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool AgregarAlArchivo(List<DetalleVenta> lista, Venta venta)
        {
            bool agrego = false;
            try
            {
                ArchivosDeTexto.sw = new StreamWriter(ArchivosDeTexto.path, true);
                foreach (DetalleVenta item in lista)
                {
                    ArchivosDeTexto.sw.WriteLine(item.ToString());
                }
                ArchivosDeTexto.sw.WriteLine("TOTAL DE LA VENTA: " + venta.ObtenerTotalVenta().ToString());
                agrego = true;
            }
            catch
            {
                agrego = false;
            }
            finally
            {
                if (ArchivosDeTexto.sw != null)
                    ArchivosDeTexto.sw.Close();
            }
            return agrego;
        }
    }
}
