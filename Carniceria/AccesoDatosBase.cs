using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public abstract class AccesoDatosBase
    {
        protected static string cadena_conexion;
        protected SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;

        static AccesoDatosBase()
        {
            AccesoDatosBase.cadena_conexion = @"Data Source=.;
                                                Database=CARNICERIA_DB;
                                                Trusted_Connection=True;
                                                Encrypt=false;";
        }
        public AccesoDatosBase()
        {
            this.conexion = new SqlConnection(AccesoDatosBase.cadena_conexion);
        }
        public bool ProbarConexion()
        {
            bool retorno = true;
            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                retorno = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
    }
}
