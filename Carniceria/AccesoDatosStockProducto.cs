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
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                this.comando.Parameters.AddWithValue("@Stock", 0);


                this.comando.CommandText = "INSERT INTO dbo.Stock_Productos (Codigo_Producto, Stock) " +
                    "VALUES (@CodigoProducto,@Stock)";


                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();
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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }
        public bool ModificarDato(string codigoProducto, double stock)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                this.comando.Parameters.AddWithValue("@stock", stock);

                //SELECT* FROM dbo.Productos p INNER JOIN dbo.Stock_Productos s ON p.CODIGO_PRODUCTO = s.CODIGO_PRODUCTO;
                string sql = "UPDATE dbo.Stock_Productos ";
                sql += "SET Stock = @stock ";
                sql += "WHERE Codigo_Producto = @codigoProducto";

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
