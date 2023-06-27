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
    public class AccesoDatosUsuario : AccesoDatosBase
    {
        public List<Vendedor> ObtenerListaDato()
        {
            List<Vendedor> lista = new List<Vendedor>();
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT * FROM dbo.Usuarios";

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if ((int)lector["Id_Rol"] == 2)
                    {
                        lista.Add(new Cliente((int)lector["Id"],
                                              lector["Nombre"].ToString(),
                                              lector["Apellido"].ToString(),
                                              (int)lector["Dni"],
                                              lector["Nombre_Usuario"].ToString(),
                                              lector["Email"].ToString(),
                                              lector["Password_"].ToString()));
                    }
                    else
                    {



                        Vendedor vendedor = new Vendedor((int)lector["Id"],
                                                        lector["Nombre"].ToString(),
                                                        lector["Apellido"].ToString(),
                                                        (int)lector["Dni"],
                                                        lector["Nombre_Usuario"].ToString(),
                                                        lector["Email"].ToString(),
                                                        lector["Password_"].ToString());
                        lista.Add(vendedor);


                    }

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
        public bool AgregarDato(Vendedor usuario)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO dbo.Usuarios (Nombre, Apellido) VALUES (@Nombre, @Apellido)";

                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);

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
                Console.WriteLine("Error al agregar la persona: " + ex.Message);
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
        public bool ModificarDato(Vendedor usuario)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Id", usuario.Id);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);

                string sql = "UPDATE dbo.Personas_Ejemplo_1 ";
                sql += "SET Nombre = @Nombre, Apellido = @Apellido ";
                sql += "WHERE Id = @Id";

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
        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.Personas_Ejemplo_1 ";
                sql += "WHERE ID = @id";

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
