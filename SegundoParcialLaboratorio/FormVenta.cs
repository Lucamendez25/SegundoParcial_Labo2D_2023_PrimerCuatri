using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using SegundoParcialLaboratorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormVenta : Form
    {
        private Cliente cliente;
        private FormLogin formLogin;
        private ProovedorPublicidad proovedorPublicidad;
        private List<Publicidad> listaPublicidad;
        private double dineroCliente;
        private Publicidad publicidadActual;
        private Producto productoSinStock;

        Venta venta;

        public FormVenta()
        {
            try
            {
                InitializeComponent();
                this.formLogin = new FormLogin();
                this.venta = new Venta();
                proovedorPublicidad = new ProovedorPublicidad();
                this.listaPublicidad = Sistema.ObtenerTodasLasPublicidadesDeLaBaseDeDatos();
                this.comboBoxTipo.Items.Add(eTipoProducto.CarneRes);
                this.comboBoxTipo.Items.Add(eTipoProducto.CarnePollo);
                this.comboBoxTipo.Items.Add(eTipoProducto.Variedad);
                proovedorPublicidad.PublicidadCambio += ManejadorPublicidadCambio;
                Task.Run(CambiarPublicidadPeriodicamente);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public FormVenta(Cliente cliente, FormLogin formLogin, double dineroCliente) : this()
        {
            this.cliente = cliente;
            this.formLogin = formLogin;
            this.dineroCliente = dineroCliente;
        }
        private void FormVenta_Load(object sender, EventArgs e)
        {
            ActualizarDatosCliente();
            ActualizarDGVVenta();
        }

        private void ActualizarDatosCliente()
        {
            this.labelDineroIngresado.Text = cliente.ObtenerNombreDeUsuarioYDineroCliente();
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.MostrarLogin();
        }
        private void ActualizarDGVVenta()
        {
            if (venta.Detalles.Count > 0)
            {
                dataGridViewListaProductos.DataSource = null;
                dataGridViewListaProductos.Visible = true;
                dataGridViewListaProductos.DataSource = venta.Detalles;
                dataGridViewListaProductos.Columns[1].Visible = false;
                labelCarritoVacio.Visible = false;
            }
            else
            {
                labelCarritoVacio.Visible = true;
                dataGridViewListaProductos.Visible = false;
            }
            #region CodigoViejo
            //dataGridViewListaProductos.Rows.Clear();
            //foreach (Producto item in carrito)
            //{
            //    int n = dataGridViewListaProductos.Rows.Add();
            //    dataGridViewListaProductos.Rows[n].Cells[0].Value = item.Tipo;
            //    dataGridViewListaProductos.Rows[n].Cells[1].Value = item.DevolverTipoCorte();
            //    dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Precio;
            //    dataGridViewListaProductos.Rows[n].Cells[3].Value = item.Peso;
            //}
            #endregion
        }
        #region CodigoViejo
        /*
       private void ActualizarDGVVenta()
       {
           dataGridViewListaProductos.DataSource = null;

           foreach (var item in BaseDeDatos.TiposCortesRes)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Carne Res";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }

           foreach (var item in BaseDeDatos.TiposCortesPollo)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Carne Pollo";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }

           foreach (var item in BaseDeDatos.TiposVariedad)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Variedad ";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }
       }
       */
        #endregion
        private void comboBoxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                comboBoxTipoProducto.DataSource = null;
                eTipoProducto tipoSeleccionado = (eTipoProducto)comboBoxTipo.SelectedItem;
                comboBoxTipoProducto.DataSource = Sistema.ObtenerOpcionesPorTipo(tipoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                eTipoProducto tipo = (eTipoProducto)comboBoxTipo.SelectedItem;
                string tipoSeleccionado = comboBoxTipoProducto.Text;
                double kilos = (double)numericUpDownKilos.Value;
                double precio = 0;
                if (kilos <= 0)
                {
                    throw new NullReferenceException();
                }
                Producto producto = Sistema.ObtenerUnProductoDeLaBaseDeDatos(tipoSeleccionado);
                //Corroboro que no exista ya en la lista el mismo producto
                DetalleVenta detalleVenta = Sistema.productoExistenteEnElCarrito(venta, producto);
                if (producto == null)
                {
                    throw new Exception();
                }
               
                //si no existe lo creo
                if (detalleVenta == null)
                {
                    detalleVenta = new DetalleVenta();
                    detalleVenta.Producto = producto;
                    detalleVenta.Peso = kilos;
                    if (detalleVenta.Producto.VerificoQueHayaStock(detalleVenta.Producto, detalleVenta.Peso))
                    {
                        venta.Detalles.Add(detalleVenta);
                    }
                    else
                    {
                        productoSinStock = detalleVenta.Producto;
                        throw new NoHayStockException();
                    }
                }
                else
                {
                    if (!detalleVenta.Producto.VerificoQueHayaStock(detalleVenta.Producto, detalleVenta.Peso + kilos))
                    {
                        throw new NoHayStockException();
                    }
                    detalleVenta.AgregarKilos(detalleVenta, kilos);

                }
                ActualizarTotalDeMiCarrito();
            }
            catch (NullReferenceException)
            {
                FormNoIngresoLosDatosNecesarios formNoIngresoLosDatosNecesarios = new FormNoIngresoLosDatosNecesarios();
                formNoIngresoLosDatosNecesarios.ShowDialog();
            }
            catch (NoHayStockException)
            {
                FormNoSuficienteStock formNoSuficienteStock = new FormNoSuficienteStock(productoSinStock);
                formNoSuficienteStock.ShowDialog();
                productoSinStock = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarDGVVenta();
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListaProductos.SelectedRows.Count > 0)
                {
                    DetalleVenta detalleVenta = (DetalleVenta)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                    ActualizarTotalDeMiCarrito();
                    venta.EliminarDetalleVenta(detalleVenta);
                    ActualizarDGVVenta();
                }
            }
            catch (Exception)
            {
                FormMensajeError formMensajeError = new FormMensajeError();
                formMensajeError.ShowDialog();
            }

        }
        private void ActualizarTotalDeMiCarrito()
        {
            labelCarritoTotal.Text = "Dinero: " + venta.ObtenerTotalVenta().ToString();
        }
        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta.Detalles.Count <= 0)
                {
                    throw new NoHayNadaEnElCarritoException();
                }
                Form formTicketFinal = new FormTicketFinal(venta, cliente, this);
                this.Hide();
                if (formTicketFinal.ShowDialog() == DialogResult.OK)
                {
                    dineroCliente = cliente.Dinero;
                    ActualizarDatosCliente();
                    ActualizarDGVVenta();
                    ActualizarTotalDeMiCarrito();
                }
            }
            catch (NoHayNadaEnElCarritoException) 
            { 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FormVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
        }

        private void buttonAgregarProducto_MouseEnter(object sender, EventArgs e)
        {
            buttonAgregarProducto.BackColor = Color.Gold;
        }

        private void buttonAgregarProducto_MouseLeave(object sender, EventArgs e)
        {
            buttonAgregarProducto.BackColor = Color.White;
        }

        private void buttonEliminar_MouseEnter(object sender, EventArgs e)
        {
            buttonEliminar.BackColor = Color.Gold;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminar.BackColor = Color.White;
        }

        private void buttonFinalizarCompra_MouseLeave(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.White;
        }

        private void buttonFinalizarCompra_MouseEnter(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.Gold;
        }

        private async Task CambiarPublicidadPeriodicamente()
        {
            while (true)
            {
                await Task.Delay(5000);
                // Actualizar la publicidad actual con una nueva imagen
                if (listaPublicidad.Count > 0)
                {
                    int indice = new Random().Next(0, listaPublicidad.Count);
                    Publicidad nuevaPublicidad = listaPublicidad[indice];
                    publicidadActual = nuevaPublicidad;
                    Invoke((Action)(() => proovedorPublicidad.GenerarPublicidad(publicidadActual)));
                }
            }
        }

        private void ManejadorPublicidadCambio(Publicidad publicidad)
        {
            // Actualizar la imagen de la publicidad en el PictureBox
            PictureBoxPublicidad.ImageLocation = publicidad.path;
        }


    }
}
