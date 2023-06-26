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
        public List<Producto> ObtenerListaDato()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = "SELECT * FROM dbo.Productos p INNER JOIN dbo.Stock_Productos s ON p.CODIGO_PRODUCTO = s.CODIGO_PRODUCTO";

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string codigoProducto = lector["Codigo_Producto"].ToString();
                    string nombre = lector["Nombre"].ToString();
                    int tipoProducto = (int)lector["Tipo"];
                    double valorPorKilo =((double)lector["Valor_Por_Kilo"]);
                    eTipoProducto tipo = (eTipoProducto)tipoProducto;
                    double stock = ((double)lector["Stock"]);
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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;

        }
        public bool AgregarDato(Producto producto)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                this.comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                this.comando.Parameters.AddWithValue("@TipoProducto", (int)producto.Tipo);
                this.comando.Parameters.AddWithValue("@ValorPorKilo", (double)producto.ValorPorKilo);


                this.comando.CommandText = "INSERT INTO dbo.Productos (Codigo_Producto, Nombre, Tipo, Valor_Por_Kilo) VALUES (@CodigoProducto, @Nombre, @TipoProducto, @ValorPorKilo)";


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
                Console.WriteLine("Error al agregar el producto: " + ex.Message);
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
        public bool ModificarDato(Producto producto, string nuevoNombre)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                this.comando.Parameters.AddWithValue("@Nombre", nuevoNombre);

                string sql = "UPDATE dbo.Productos ";
                sql += " SET Nombre = @Nombre ";
                sql += " WHERE Codigo_Producto = @CodigoProducto";

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

        public bool ModificarDato(string codigoProducto, string pathImagen)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                this.comando.Parameters.AddWithValue("@ImagenProducto", pathImagen);

                string sql = "UPDATE dbo.Productos ";
                sql += "SET Imagen_Producto = @ImagenProducto ";
                sql += "WHERE Codigo_Producto = @CodigoProducto";

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
        public bool EliminarDato(string codigoProducto)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                string sql = "DELETE FROM dbo.Productos ";
                sql += " WHERE Codigo_Producto = @CodigoProducto";

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
