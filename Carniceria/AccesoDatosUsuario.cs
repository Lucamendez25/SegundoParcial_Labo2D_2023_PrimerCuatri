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
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = "SELECT * FROM dbo.Usuarios";

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

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
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }
        public bool AgregarDato(Vendedor usuario)
        {
            bool rta = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.Connection = this.conexion;
                this.comando.CommandText = "INSERT INTO dbo.Usuarios (Nombre, Apellido) VALUES (@Nombre, @Apellido)";

                this.comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);

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
                Console.WriteLine("Error al agregar la persona: " + ex.Message);
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
        public bool ModificarDato(Vendedor usuario)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", usuario.Id);
                this.comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);

                string sql = "UPDATE dbo.Personas_Ejemplo_1 ";
                sql += "SET Nombre = @Nombre, Apellido = @Apellido ";
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
        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.Personas_Ejemplo_1 ";
                sql += "WHERE ID = @id";

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
