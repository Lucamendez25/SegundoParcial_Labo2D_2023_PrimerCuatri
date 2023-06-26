using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Cliente : Vendedor
    {
        private double dinero;
        public double Dinero { get => dinero; set => dinero = value; }

        public Cliente(int id, string nombre, string apellido, int dni, string nombreUsuario, string email, string password) : base(id, nombre, apellido, dni, nombreUsuario, email, password)
        {
        }
        public Cliente(int id, string nombre, string apellido, int dni, string nombreUsuario, string email, string password, double dinero) : this(id, nombre, apellido, dni, nombreUsuario, email, password)
        {
            this.dinero = dinero;
        }
    }
}
