﻿using System;
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
        /// <summary>
        /// Obtiene un Vendedor de la Base De Datos
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public bool ObtenerDato(Vendedor vendedor)
        {
            bool retorno = true;
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                comando.Parameters.AddWithValue("@Id", vendedor.Id);

                comando.CommandText = "SELECT * FROM dbo.Usuarios u LEFT JOIN dbo.VentasVendedor v ON u.ID = v.ID WHERE u.ID = @Id";

                conexion.Open();

                lector = comando.ExecuteReader();

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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Modifica un vendedor de la Base De Datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ventas"></param>
        /// <returns></returns>
        public bool ModificarDato(int id, int ventas)
        {
            bool rta = true;
            try
            {
                comando = new SqlCommand();
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Ventas", ventas);

                string sql = "UPDATE dbo.VentasVendedor ";
                sql += "SET Ventas = @ventas ";
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
    }
}
