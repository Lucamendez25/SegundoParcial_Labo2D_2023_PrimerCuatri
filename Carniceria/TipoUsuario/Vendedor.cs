using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Vendedor : Usuario
    {
        int ventas;
        public int Ventas { get => ventas; set => ventas = value; }
        public Vendedor(int id, string nombre, string apellido, int dni, string nombreUsuario, string password, string email) : base(id, nombre, apellido, dni, nombreUsuario, password, email)
        {

        }
    }
}
