using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class AccesoDatosPublicidad : AccesoDatosBase
    {
        /// <summary>
        /// Retorna la lista de publicidades de la Base de Datos
        /// </summary>
        /// <returns></returns>
        public List<Publicidad> ObtenerListaDato()
        {
            List<Publicidad> lista = new List<Publicidad>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM dbo.Publicidad";

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string codigoPublicidad = lector["Codigo_Publicidad"].ToString();
                    string pathPublicidad = lector["Direccion_Publicidad"].ToString();
                    Publicidad publicidad = new Publicidad();
                    publicidad.codigo = codigoPublicidad;
                    publicidad.path = pathPublicidad;
                    lista.Add(publicidad);
                }
                lector.Close();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }
    }
}
