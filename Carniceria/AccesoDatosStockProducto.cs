using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClasesCarniceria
{
    public class AccesoDatosStockProducto : AccesoDatosBase
    {
        public bool AgregarDato(Producto producto)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Stock", 0);


                comando.CommandText = "INSERT INTO dbo.Stock_Productos (Codigo_Producto, Stock) " +
                    "VALUES (@CodigoProducto,@Stock)";


                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception ex)
            {
                rta = false;
                Console.WriteLine("Error al agregar el producto a la lista Stock Producto: " + ex.Message);
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
        public bool ModificarDato(string codigoProducto, double stock)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                comando.Parameters.AddWithValue("@stock", stock);

                //SELECT* FROM dbo.Productos p INNER JOIN dbo.Stock_Productos s ON p.CODIGO_PRODUCTO = s.CODIGO_PRODUCTO;
                string sql = "UPDATE dbo.Stock_Productos ";
                sql += "SET Stock = @stock ";
                sql += "WHERE Codigo_Producto = @codigoProducto";

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

        public bool EliminarDato(string codigoProducto)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                string sql = "DELETE FROM dbo.Stock_Productos ";
                sql += " WHERE Codigo_Producto = @CodigoProducto";

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
