using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class ProovedorPublicidad
    {
        public event Action<Publicidad> PublicidadCambio;

        public void GenerarPublicidad(Publicidad publicidad)
        {
            PublicidadCambio?.Invoke(publicidad);
        }
    }
}
