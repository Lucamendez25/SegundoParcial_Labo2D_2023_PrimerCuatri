using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesCarniceria.TipoUsuario;

namespace ClasesCarniceria
{
    public class AccesoDatosVendedor : AccesoDatosBase
    {
        public bool ObtenerDato(Vendedor vendedor)
        {
            bool retorno = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.Parameters.AddWithValue("@Id", vendedor.Id);

                this.comando.CommandText = "SELECT * FROM dbo.Usuarios u LEFT JOIN dbo.VentasVendedor v ON u.ID = v.ID WHERE u.ID = @Id";

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int ventas = (int)lector["Ventas"];
                    vendedor.Ventas = ventas;
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
        public bool ModificarDato(int id, int ventas)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", id);
                this.comando.Parameters.AddWithValue("@Ventas", ventas);

                string sql = "UPDATE dbo.VentasVendedor ";
                sql += "SET Ventas = @ventas ";
                sql += "WHERE Id = @Id";

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
