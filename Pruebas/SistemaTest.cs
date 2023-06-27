using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
namespace Pruebas
{
    [TestClass]
    public class SistemaTest
    {
        [TestMethod]
        public void RetornaTrue_EnCasoQueSePuedaConectar_ALaBaseDeDatos()
        {
            //Arrange - Preparar el caso de Prueba
            //Hardcodeo un Cliente Activo
            bool seConecto = false;
            AccesoDatosBase accesoDatosBase = new AccesoDatosProducto();

            //Act - Invocar al método a probar
            seConecto = accesoDatosBase.ProbarConexion();
            //Assert - verifico que el resultado sea el esperado
            Assert.IsTrue(seConecto);
        }

        [TestMethod]
        public void RetornaUsuarioDelTipoCliente_SiEncuentraEnLaBaseDeDatos_CoincideElMailYPassword()
        {
            //Arrange - Preparar el caso de Prueba
            //Hardcodeo un Cliente Activo
            string email = "luca@gmail.com";
            string pass = "1234";

            //Act - Invocar al método a probar
            Usuario usuario = Sistema.LoguearUsuario(email, pass);
            Cliente cliente = (Cliente)usuario;
            //Assert - verifico que el resultado sea el esperado
            Assert.IsNotNull(usuario);
            Assert.IsNotNull(cliente);
        }

        [TestMethod]
        public void RetornaUsuarioDelTipoVendedor_SiEncuentraEnLaBaseDeDatos_CoincideElMailYPassword()
        {
            //Arrange - Preparar el caso de Prueba
            //Hardcodeo un Vendedor Activo
            string email = "mauro@gmail.com";
            string pass = "1234";

            //Act - Invocar al método a probar
            Usuario usuario = Sistema.LoguearUsuario(email, pass);
            Vendedor vendedor = (Vendedor)usuario;
            //Assert - verifico que el resultado sea el esperado
            Assert.IsNotNull(usuario);
            Assert.IsNotNull(vendedor);
        }

        [TestMethod]
        public void RetornaUsuarioNull_SiNoEncuentraEnLaBaseDeDatos_NoCoincideElMailYPassword()
        {
            //Arrange - Preparar el caso de Prueba
            //Hardcodeo un email y pass falsos, no existentes en la BD
            string email = "hola@gmail.com";
            string pass = "1234";

            //Act - Invocar al método a probar
            Usuario usuario = Sistema.LoguearUsuario(email, pass);
            //Assert - verifico que el resultado sea el esperado
            Assert.IsNull(usuario);
        }

        [TestMethod]
        public void RetornarFalso_CuandoElTotalDelCarrito_EsMayorADineroDelCliente()
        {
           //Arrange - Preparar el caso de Prueba
           //Preparo un cliente falso, y que sea creado, en el parametro dinero = 0;
           Cliente cliente = new Cliente(1, "Pepe", "Pupu", 1234,"pepeXd", "Pepe@gmail.com", "1234", 0);
            double totalCarrito = 1;
            bool recarga = false;
            
            //Act - Invocar al método a probar
            bool resultado = Sistema.CalcularACobrarCliente(cliente, totalCarrito, recarga);

            //Assert - verifico que el resultado sea el esperado
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void RetornarFalso_SiElPathDeLaImagen_EsNull()
        {
            //Arrange - Preparar el caso de Prueba
            Producto producto = new Producto("Lala", eTipoProducto.Variedad);
            string pathImagenVacio = null;

            //Act - Invocar al método a probar
            bool resultado = Sistema.SetearImagen(producto, pathImagenVacio);

            //Assert - verifico que el resultado sea el esperado
            Assert.IsFalse(resultado);
        }
    }
}