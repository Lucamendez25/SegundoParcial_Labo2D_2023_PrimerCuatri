using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class AccesoDatosCliente : AccesoDatosBase
    {
        /// <summary>
        /// Retorna un cliente de la Base de Datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool ObtenerDato(Cliente cliente)
        {
            bool retorno = true;
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@Id", cliente.Id);

                comando.CommandText = "SELECT * FROM dbo.Usuarios u LEFT JOIN dbo.DineroClientes d ON u.ID = d.ID_CLIENTE WHERE ID = @Id;";

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    double dinero = (double)lector["Dinero"];
                    cliente.Dinero = dinero;
                }

                lector.Close();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Modifica el dinero de un cliente de la Base De Datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dinero"></param>
        /// <returns></returns>
        public bool ModificarDato(int id, double dinero)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@dinero", dinero);

                string sql = "UPDATE dbo.DineroClientes ";
                sql += "SET Dinero = @dinero ";
                sql += "WHERE Id_Cliente = @Id";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
    }
}
