using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class AccesoDatosProducto : AccesoDatosBase
    {
        /// <summary>
        /// Retorna la lista de Productos de la Base de Datos
        /// </summary>
        /// <returns></returns>
        public List<Producto> ObtenerListaDato()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM dbo.Productos p INNER JOIN dbo.Stock_Productos s ON p.CODIGO_PRODUCTO = s.CODIGO_PRODUCTO";

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string codigoProducto = lector["Codigo_Producto"].ToString();
                    string nombre = lector["Nombre"].ToString();
                    int tipoProducto = (int)lector["Tipo"];
                    double valorPorKilo = (double)lector["Valor_Por_Kilo"];
                    eTipoProducto tipo = (eTipoProducto)tipoProducto;
                    double stock = (double)lector["Stock"];
                    string pathImagen = lector["Imagen_Producto"].ToString();
                    Producto producto = new Producto(codigoProducto, nombre, tipo, valorPorKilo);
                    producto.ImagenProducto = pathImagen;
                    producto.Stock = stock;
                    lista.Add(producto);
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
        public bool AgregarDato(Producto producto)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@TipoProducto", (int)producto.Tipo);
                comando.Parameters.AddWithValue("@ValorPorKilo", producto.ValorPorKilo);


                comando.CommandText = "INSERT INTO dbo.Productos (Codigo_Producto, Nombre, Tipo, Valor_Por_Kilo) VALUES (@CodigoProducto, @Nombre, @TipoProducto, @ValorPorKilo)";


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
                Console.WriteLine("Error al agregar el producto: " + ex.Message);
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
        public bool ModificarDato(Producto producto, string nuevoNombre)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@Nombre", nuevoNombre);

                string sql = "UPDATE dbo.Productos ";
                sql += " SET Nombre = @Nombre ";
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

        public bool ModificarDato(string codigoProducto, string pathImagen)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                comando.Parameters.AddWithValue("@ImagenProducto", pathImagen);

                string sql = "UPDATE dbo.Productos ";
                sql += "SET Imagen_Producto = @ImagenProducto ";
                sql += "WHERE Codigo_Producto = @CodigoProducto";

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

                string sql = "DELETE FROM dbo.Productos ";
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
