using ClasesCarniceria.TipoUsuario;

namespace ClasesCarniceria
{
    public static class Sistema
    {
        static AccesoDatosUsuario accesoDatosUsuario = new AccesoDatosUsuario();
        static AccesoDatosProducto accesoDatosProducto = new AccesoDatosProducto();
        static AccesoDatosCliente accesoDatosCliente = new AccesoDatosCliente();
        static AccesoDatosVendedor accesoDatosVendedor = new AccesoDatosVendedor();
        static AccesoDatosStockProducto accesoDatosStockProducto = new AccesoDatosStockProducto();
        static AccesoDatosPublicidad accesoDatosPublicidad = new AccesoDatosPublicidad();

        private const double RECARGA_CREDITO = 0.05;
        static Sistema()
        {

        }
        #region Metodos Usuario

        public static Vendedor LoguearUsuario(string email, string password)
        {
            Vendedor usuarioLogueado = null;

            if (ValidarCamposLogin(email, password))
            {
                foreach (Vendedor auxUsuario in accesoDatosUsuario.ObtenerListaDato())
                {
                    if (auxUsuario.Email == email && auxUsuario.CheckearPassword(password))
                    {
                        usuarioLogueado = auxUsuario;
                        break;
                    }
                }
            }
            return usuarioLogueado;
        }
        private static bool ValidarCamposLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Metodos Cliente

        public static List<Cliente> ObtenerTodosLosClientesDeLaBaseDeDatos()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                foreach (Usuario item in accesoDatosUsuario.ObtenerListaDato())
                {
                    if (item is Cliente cliente)
                    {
                        accesoDatosCliente.ObtenerDato(cliente);
                        lista.Add(cliente);
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool CalcularACobrarCliente(Cliente unCliente, double totalCarrito, bool conRecarga)
        {
            try
            {
                if (conRecarga)
                {
                    double cantidadRecarga = totalCarrito * RECARGA_CREDITO;
                    totalCarrito += cantidadRecarga;
                }
                if (totalCarrito < unCliente.Dinero)
                {
                    unCliente.Dinero -= totalCarrito;
                    accesoDatosCliente.ModificarDato(unCliente.Id, unCliente.Dinero);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        #region Metodos Vendedor

        public static void SumarUnaVenta(Vendedor vendedor)
        {
            vendedor.Ventas += 1;
        }
        public static Vendedor ActualizarDatosDelVendedor(Vendedor vendedor)
        {
            foreach (var item in accesoDatosUsuario.ObtenerListaDato())
            {
                if (item is Vendedor && item.Id == vendedor.Id)
                {
                    accesoDatosVendedor.ObtenerDato(vendedor);
                    break;
                }
            }
            return vendedor;
        }
        public static void ModificarVentasDelVendedor(Vendedor vendedor)
        {
            foreach (var item in accesoDatosUsuario.ObtenerListaDato())
            {
                if (item is Vendedor && item.Id == vendedor.Id)
                {
                    accesoDatosVendedor.ModificarDato(vendedor.Id, vendedor.Ventas);
                    break;
                }
            }
        }
        #endregion

        #region Métodos Producto
        public static void AgregarProducto(Producto producto)
        {
            try
            {
                if (ProductoExisteEnBaseDeDatos(producto.CodigoProducto) == null)
                {
                    accesoDatosProducto.AgregarDato(producto);
                    accesoDatosStockProducto.AgregarDato(producto);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static Producto ProductoExisteEnBaseDeDatos(string codigoProducto)
        {
            try
            {
                Producto productoExistente = null;
                foreach (Producto auxProducto in accesoDatosProducto.ObtenerListaDato())
                {
                    if (codigoProducto == auxProducto.CodigoProducto)
                    {
                        productoExistente = auxProducto;
                        break;
                    }
                }
                return productoExistente;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool EliminarProductoDeLaBaseDeDatos(Producto producto)
        {
            try
            {
                foreach (Producto auxProducto in accesoDatosProducto.ObtenerListaDato())
                {
                    if (producto.CodigoProducto == auxProducto.CodigoProducto)
                    {
                        accesoDatosProducto.EliminarDato(producto.CodigoProducto);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string[] ObtenerOpcionesPorTipo(eTipoProducto tipo)
        {
            try
            {
                if (tipo == eTipoProducto.CarneRes)
                {
                    return accesoDatosProducto.ObtenerListaDato()
                    .Where(producto => producto.Tipo == eTipoProducto.CarneRes)
                    .Select(producto => producto.Nombre)
                    .ToArray();
                }
                else
                {
                    if (tipo == eTipoProducto.CarnePollo)
                    {
                        return accesoDatosProducto.ObtenerListaDato()
                        .Where(producto => producto.Tipo == eTipoProducto.CarnePollo)
                        .Select(producto => producto.Nombre)
                        .ToArray();
                    }
                    else
                    {
                        return accesoDatosProducto.ObtenerListaDato()
                           .Where(producto => producto.Tipo == eTipoProducto.Variedad)
                           .Select(producto => producto.Nombre)
                           .ToArray();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static Producto ObtenerUnProductoDeLaBaseDeDatos(string nombre)
        {
            return accesoDatosProducto.ObtenerListaDato().FirstOrDefault(producto => producto.Nombre == nombre);
        }
        public static List<Producto> ObtenerTodosLosProductosDeLaBaseDeDatos()
        {
            try
            {
                List<Producto> lista = new List<Producto>();
                foreach (var item in accesoDatosProducto.ObtenerListaDato())
                {
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ModificarProductoDeLaBaseDeDatos(string codigoProducto, string nuevoNombre)
        {
            try
            {
                foreach (Producto auxProducto in accesoDatosProducto.ObtenerListaDato())
                {
                    if (codigoProducto == auxProducto.CodigoProducto)
                    {
                        accesoDatosProducto.ModificarDato(auxProducto, nuevoNombre);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DetalleVenta productoExistenteEnElCarrito(Venta venta, Producto producto)
        {
            try
            {
                DetalleVenta detalleVenta = null;

                detalleVenta = venta.Detalles.FirstOrDefault(detalle => detalle.Producto.CodigoProducto == producto.CodigoProducto);

                return detalleVenta;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void DisminuyoStock(Venta venta)
        {
            try
            {
                List<Producto> productos = ObtenerTodosLosProductosDeLaBaseDeDatos();
                foreach (var item in venta.Detalles)
                {
                    Producto productoEncontrado = productos.Find(p => p.CodigoProducto == item.Producto.CodigoProducto);
                    if (productoEncontrado != null)
                    {
                        productoEncontrado.Stock -= item.Peso;
                        accesoDatosStockProducto.ModificarDato(productoEncontrado.CodigoProducto, productoEncontrado.Stock);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool DisminuyoStock(Producto producto, double peso)
        {
            try
            {
                Producto productoEncontrado = ObtenerTodosLosProductosDeLaBaseDeDatos().Find(p => p.CodigoProducto == producto.CodigoProducto);
                if (productoEncontrado != null)
                {
                    if (!producto.VerificoQueHayaStock(producto, 1))
                    {
                        throw new Exception();
                    }
                    if (SetearStock(productoEncontrado, peso))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SetearStock(Producto producto, double kilos)
        {
            try
            {
                accesoDatosStockProducto.ModificarDato(producto.CodigoProducto, kilos);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SetearImagen(Producto producto, string pathImagen)
        {
            try
            {
                accesoDatosProducto.ModificarDato(producto.CodigoProducto, pathImagen);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Métodos Publicidad
        public static List<Publicidad> ObtenerTodasLasPublicidadesDeLaBaseDeDatos()
        {
            try
            {
                List<Publicidad> lista = new List<Publicidad>();
                foreach (var item in accesoDatosPublicidad.ObtenerListaDato())
                {
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
