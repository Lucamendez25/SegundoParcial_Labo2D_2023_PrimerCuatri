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
        static SerializadorJson<List<Producto>> serializadorJson = new SerializadorJson<List<Producto>>("Productos.json");
        static SerializadorXml<List<Producto>> serializadorXml = new SerializadorXml<List<Producto>>("Productos.xml");

        private const double RECARGA_CREDITO = 0.05;
        static Sistema()
        {

        }
        #region Metodos Usuario

        /// <summary>
        /// Corrobora si existe el usuario en la base de datos.
        /// Si existe retorna ese usuario, sino devuelve null.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Usuario</returns>
        public static Usuario LoguearUsuario(string email, string password)
        {
            Usuario usuarioLogueado = null;

            if (ValidarCamposLogin(email, password))
            {
                foreach (Usuario auxUsuario in accesoDatosUsuario.ObtenerListaDato())
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
        /// <summary>
        /// Valida que los campos email y password no sean null
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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



        /// <summary>
        ///  Llama a la base de datos, y le pide cada uno de los clientes
        /// Y los almacena en una lista, para luego retornarla
        /// </summary>
        /// <returns>list de Clientes</returns>
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
        /// <summary>
        /// Calcula cuanto le tiene que cobrar al cliente
        /// </summary>
        /// <param name="unCliente">un tipo cliente</param>
        /// <param name="totalCarrito">total de dinero en el carrito</param>
        /// <param name="conRecarga">para saber si necesita recarga</param>
        /// <returns>bool</returns>
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

        /// <summary>
        /// Suma una venta al vendedor
        /// </summary>
        /// <param name="vendedor"></param>
        public static void SumarUnaVenta(Vendedor vendedor)
        {
            vendedor.Ventas += 1;
        }
        /// <summary>
        /// Busca por Id al vendedor en la Base de Datos.
        /// Y me lo devuelve si lo encontro.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns>Vendedor</returns>
        public static Vendedor ObtenerDatosDelVendedor(Vendedor vendedor)
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
        /// <summary>
        /// Busca al vendedor en la Base de Datos, y modifica la columna ventas
        /// con el vendedor pasado como parametro
        /// </summary>
        /// <param name="vendedor"></param>
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
        /// <summary>
        /// Agrega en un archivo .txt las ventas de todos los clientes
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="cliente"></param>
        public static void GuardoVentaEnUnArchivo(Venta venta, Cliente cliente)
        {
            ArchivosDeTexto.AgregarAlArchivo(venta.Detalles, venta, cliente);
        }

        public static string LeerInformeDeComprasDelCliente(Cliente cliente)
        {
            string info = ArchivosDeTexto.LeerArchivoCliente(cliente);
            return info;
        }
        #endregion

        #region Métodos Producto

        /// <summary>
        /// Agrega un producto a la Base de Datos si no existe ya
        /// </summary>
        /// <param name="producto"></param>
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

        /// <summary>
        /// Verifica si ese producto ya existe en la Base de Datos
        /// </summary>
        /// <param name="codigoProducto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Elimina un producto de la Base de Datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool EliminarProductoDeLaBaseDeDatos(Producto producto)
        {
            try
            {
                foreach (Producto auxProducto in accesoDatosProducto.ObtenerListaDato())
                {
                    if (producto.CodigoProducto == auxProducto.CodigoProducto)
                    {
                        accesoDatosProducto.EliminarDato(producto.CodigoProducto);
                        accesoDatosStockProducto.EliminarDato(producto.CodigoProducto);
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

        /// <summary>
        /// Obtiene todas las opciones por tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>Un array de string, con cada una de las opciones encontradas</returns>
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
        /// <summary>
        /// Le paso el nombre del producto
        /// Me trae un producto, si encuentra por el nombre del producto en la Base de Datos
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Producto</returns>
        public static Producto ObtenerUnProductoDeLaBaseDeDatos(string nombre)
        {
            return accesoDatosProducto.ObtenerListaDato().FirstOrDefault(producto => producto.Nombre == nombre);
        }

        /// <summary>
        /// Me trae todos los productos de la Base de Datos
        /// </summary>
        /// <returns>Una lista con todos los Productos</returns>
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

        /// <summary>
        /// Modifica el nombre de un producto
        /// </summary>
        /// <param name="codigoProducto">Codigo del producto</param>
        /// <param name="nuevoNombre">Nombre al que le quiero cambiar</param>
        /// <returns>true = Si logro modificarlo en la Base de Datos
        /// False = Si no logro modificarlo en la Base de Datos</returns>
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
        /// <summary>
        /// Verifica que el producto exista en la venta
        /// que se esta llevando a cabo.
        /// En los detalles no exista.
        /// Si existe, le retorna el detalle, que seria el producto
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Resto el stock de los productos, con la venta que le pase
        /// </summary>
        /// <param name="venta"></param>
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
                        if (!SetearStock(productoEncontrado, productoEncontrado.Stock))
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Modifico stock con los kilos que le mando, en la Base de Datos 
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="kilos"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Modifico el path de la imagen
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="pathImagen"></param>
        /// <returns></returns>
        public static bool SetearImagen(Producto producto, string pathImagen)
        {
            try
            {
                if (string.IsNullOrEmpty(pathImagen))
                {
                    throw new Exception();
                }
                accesoDatosProducto.ModificarDato(producto.CodigoProducto, pathImagen);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SerializarProductos() 
        {
            try
            {
                List<Producto> productos = ObtenerTodosLosProductosDeLaBaseDeDatos();
                serializadorJson.Serializar(productos);
                serializadorXml.Serializar(productos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<Producto> DesearializarProductosXml()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                productos = serializadorXml.Deserializar();
                return productos;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public static List<Producto> DesearializarProductosJson()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                productos = serializadorJson.Deserializar();
                return productos;
            }
            catch (Exception)
            {
                throw new Exception();
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
