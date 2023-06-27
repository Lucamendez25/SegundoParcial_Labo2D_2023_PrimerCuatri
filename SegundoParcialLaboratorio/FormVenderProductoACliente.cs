using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using SegundoParcialLaboratorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormVenderProductoACliente : Form
    {
        Cliente cliente;
        Vendedor vendedor;
        Venta venta;
        FormHeladera formHeladera;
        List<Producto> listaProductos;
        bool vendedorVendio = false;
        private Action mostrarFormNoHayStock;
        private Action mostrarFormNoTieneDineroSuficiente;
        private Action actualizarTodo;
        private delegate Producto ObtenerProductoDelegate();
        public FormVenderProductoACliente()
        {
            InitializeComponent();
            mostrarFormNoHayStock = MostrarFormNoHayStock;
            mostrarFormNoTieneDineroSuficiente = MostrarFormNoTieneDineroSuficiente;
            actualizarTodo = ActualizarTodo;
            venta = new Venta();
        }
        public FormVenderProductoACliente(Vendedor vendedor, Cliente cliente, FormHeladera formHeladera) : this()
        {
            this.vendedor = vendedor;
            this.cliente = cliente;
            this.formHeladera = formHeladera;
        }
        private void ActualizarDGVListaProductos()
        {
            if (listaProductos.Count > 0)
            {
                dataGridViewListaProductos.DataSource = null;
                dataGridViewListaProductos.Visible = true;
                dataGridViewListaProductos.DataSource = listaProductos;
                dataGridViewListaProductos.Columns[4].Visible = false;

            }
            else
            {
                dataGridViewListaProductos.Visible = false;
            }
        }

        private void ActualizarListaProductos()
        {
            listaProductos = Sistema.ObtenerTodosLosProductosDeLaBaseDeDatos();
        }
        private void ActualizarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {cliente.Nombre}");
            sb.AppendLine($"Usuario: {cliente.NombreUsuario}");
            sb.AppendLine($"Dinero: {cliente.Dinero}");
            labelUsuario.Text = sb.ToString();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListaProductos.SelectedRows.Count > 0)
                {
                    Producto producto = ObtenerProductoSeleccionado();
                    double kilos = (double)numericUpDownKilos.Value;
                    DetalleVenta detalleVenta = new DetalleVenta();
                    if (kilos <= 0)
                    {
                        throw new NullReferenceException();
                    }
                    if (producto != null)
                    {
                        detalleVenta.Producto = producto;
                        detalleVenta.Peso = kilos;
                        if (!detalleVenta.Producto.VerificoQueHayaStock(detalleVenta.Producto, detalleVenta.Peso))
                        {
                            throw new NoHayStockException();
                        }
                        venta.Detalles.Add(detalleVenta);

                        if (!Sistema.CalcularACobrarCliente(cliente, detalleVenta.Total, false))
                        {
                            throw new NoTieneDineroSuficienteException();
                        }
                        Sistema.DisminuyoStock(venta);
                        actualizarTodo.Invoke();
                        venta.Detalles.Clear();
                    }
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch(NoTieneDineroSuficienteException) 
            {
                mostrarFormNoTieneDineroSuficiente.Invoke();
            }
            catch (NoHayStockException)
            {
                mostrarFormNoHayStock.Invoke();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void FormVenderProductoACliente_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            ActualizarDGVListaProductos();
            ActualizarCliente();
        }

        private void ActualizarTodo()
        {
            ActualizarListaProductos();
            ActualizarDGVListaProductos();
            ActualizarCliente();
            numericUpDownKilos.Value = 0;
            Sistema.SumarUnaVenta(vendedor);
            Sistema.ModificarVentasDelVendedor(vendedor);
        }
        private void MostrarFormNoTieneDineroSuficiente()
        {
            FormNoTieneDineroSuficiente formNoTieneDineroSuficiente = new FormNoTieneDineroSuficiente();
            formNoTieneDineroSuficiente.ShowDialog();
        }
        private void MostrarFormNoHayStock()
        {
            Producto producto = ObtenerProductoSeleccionado();
            FormNoSuficienteStock formNoSuficienteStock = new FormNoSuficienteStock(producto);
            formNoSuficienteStock.ShowDialog();
        }


        private Producto ObtenerProductoSeleccionado()
        {
            if (dataGridViewListaProductos.InvokeRequired)
            {
                // Si es necesario invocar el método en el hilo correcto
                return (Producto)dataGridViewListaProductos.Invoke(new ObtenerProductoDelegate(ObtenerProductoSeleccionado));
            }
            else
            {
                return (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
            }
        }
        private void FormVenderProductoACliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            formHeladera.Show();
        }

        private void buttonVender_MouseEnter(object sender, EventArgs e)
        {
            buttonVender.BackColor = Color.Gold;
        }

        private void buttonVender_MouseLeave(object sender, EventArgs e)
        {
            buttonVender.BackColor = Color.White;
        }
    }
}
