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
        public List<Publicidad> ObtenerListaDato()
        {
            List<Publicidad> lista = new List<Publicidad>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = "SELECT * FROM dbo.Publicidad";

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
    }
}
