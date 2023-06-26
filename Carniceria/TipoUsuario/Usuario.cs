using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string nombreUsuario;
        private string password;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public Usuario(int id, string nombre, string apellido, int dni, string nombreUsuario, string email, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.email = email;
            this.password = password;
        }
        public bool CheckearPassword(string password)
        {
            return Password == password;
        }
    }
}
