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
        public bool ObtenerDato(Cliente cliente)
        {
            bool retorno = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@Id", cliente.Id);

                this.comando.CommandText = "SELECT * FROM dbo.Usuarios u LEFT JOIN dbo.DineroClientes d ON u.ID = d.ID_CLIENTE WHERE ID = @Id;";

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }
        public bool ModificarDato(int id, double dinero)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", id);
                this.comando.Parameters.AddWithValue("@dinero", dinero);

                string sql = "UPDATE dbo.DineroClientes ";
                sql += "SET Dinero = @dinero ";
                sql += "WHERE Id_Cliente = @Id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }
    }
}
