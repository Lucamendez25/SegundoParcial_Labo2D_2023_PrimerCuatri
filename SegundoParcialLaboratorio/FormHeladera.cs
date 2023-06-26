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
    public partial class FormHeladera : Form
    {
        Vendedor vendedor;
        FormLogin formLogin;
        List<Producto> listaProductos;
        FormInformacionDelProceso formInformacionDelProceso;


        private List<Cliente> clientes;
        public FormHeladera()
        {
            InitializeComponent();
            ActualizarListaDeProductos();
            ActualizarListaDeClientes();

        }
        public FormHeladera(Vendedor vendedor, FormLogin formLogin) : this()
        {
            this.vendedor = vendedor;
            this.formLogin = formLogin;
        }
        private void FormHeladera_Load(object sender, EventArgs e)
        {
            ActualizarVendedor();
            ActualizarListaDeClientes();
            ActualizarDGVListaClientes();
            ActualizarListaDeProductos();
            ActualizarDGVHeladera();
        }
        private void ActualizarVendedor()
        {
            Sistema.ActualizarDatosDelVendedor(vendedor);
            lblInformacionVendedor.Text = vendedor.ObtenerNombreYVentasDelVendedor();
        }
        private void ActualizarListaDeProductos()
        {
            listaProductos = Sistema.ObtenerTodosLosProductosDeLaBaseDeDatos();
        }
        private void ActualizarListaDeClientes()
        {
            clientes = Sistema.ObtenerTodosLosClientesDeLaBaseDeDatos();
        }
        private void ActualizarDGVListaClientes()
        {
            try
            {
                if (clientes.Count > 0)
                {
                    dataGridViewListaClientes.DataSource = null;
                    dataGridViewListaClientes.Visible = true;
                    dataGridViewListaClientes.DataSource = clientes;
                    dataGridViewListaClientes.Columns[1].Visible = false;
                }
                else
                {
                    dataGridViewListaProductos.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ActualizarDGVHeladera()
        {
            try
            {
                if (listaProductos.Count > 0)
                {
                    dataGridViewListaProductos.DataSource = null;
                    dataGridViewListaProductos.Visible = true;
                    dataGridViewListaProductos.DataSource = listaProductos;
                    dataGridViewListaProductos.Columns[0].Visible = false;
                    dataGridViewListaProductos.Columns[1].HeaderCell.Value = "Producto";
                    dataGridViewListaProductos.Columns[2].Visible = false;
                    dataGridViewListaProductos.Columns[3].Visible = false;
                    dataGridViewListaProductos.Columns[4].Visible = false;
                }
                else
                {
                    dataGridViewListaProductos.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonInformacionProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListaProductos.SelectedRows.Count > 0)
                {
                    Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                    FormInformacionDeProducto formInformacionDeProducto = new FormInformacionDeProducto(this, producto);
                    formInformacionDeProducto.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonVenderACliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListaClientes.SelectedRows.Count > 0)
                {
                    Cliente cliente = (Cliente)dataGridViewListaClientes.SelectedRows[0].DataBoundItem;
                    if (cliente.Dinero > 0)
                    {
                        FormVenderProductoACliente formVenderProductoACliente = new FormVenderProductoACliente(vendedor, cliente, this);
                        this.Hide();
                        formVenderProductoACliente.Show();
                    }
                    else
                    {
                        MessageBox.Show("No tiene dinero");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormHeladera_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarListaDeClientes();
            ActualizarDGVListaClientes();
            formLogin.Show();
        }
        private void buttonReponerStock_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                double kilos = (double)numericUpDownKilos.Value;
                if (!Sistema.SetearStock(producto, kilos))
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualizarListaDeProductos();
                ActualizarDGVHeladera();
            }

        }

        private void FormHeladera_Activated(object sender, EventArgs e)
        {
            lblInformacionVendedor.Text = vendedor.ObtenerNombreYVentasDelVendedor();
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string? informa = null;
                FormCrearProducto formCrearProducto = new FormCrearProducto();

                if (formCrearProducto.ShowDialog() == DialogResult.OK)
                {
                    formInformacionDelProceso = new FormInformacionDelProceso(true);
                    formInformacionDelProceso.ShowDialog();
                    ActualizarListaDeProductos();
                    ActualizarDGVHeladera();
                }
                else
                {
                    if (formCrearProducto.DialogResult == DialogResult.Abort) 
                    {
                        formInformacionDelProceso = new FormInformacionDelProceso("Se cancelo",false);
                        formInformacionDelProceso.ShowDialog();
                    }
                    else 
                    { 
                        formInformacionDelProceso = new FormInformacionDelProceso(false);
                        formInformacionDelProceso.ShowDialog();                    
                    }
                }
            }
            catch (NoLlenoTodosLosCamposException ex)
            {
                FormInformacionDelProceso formInformacionDelProceso = new FormInformacionDelProceso(ex.Message, false);
                formInformacionDelProceso.ShowDialog();
            }

            catch (Exception)
            {
                throw;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                FormConfirmar formConfirmar = new FormConfirmar();
                if (formConfirmar.ShowDialog() == DialogResult.OK)
                {
                    if (Sistema.EliminarProductoDeLaBaseDeDatos(producto))
                    {
                        formInformacionDelProceso = new FormInformacionDelProceso(true);
                        ActualizarListaDeProductos();
                        ActualizarDGVHeladera();
                    }
                    else
                    {
                        formInformacionDelProceso = new FormInformacionDelProceso(false);
                    }
                    formInformacionDelProceso.ShowDialog();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                string mensajeFallo = null;
                formInformacionDelProceso = new FormInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
                formInformacionDelProceso.ShowDialog();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                FormModificarProducto formModificarProducto = new FormModificarProducto(producto);
                if (formModificarProducto.ShowDialog() == DialogResult.OK)
                {
                    formInformacionDelProceso = new FormInformacionDelProceso(true);
                }
                ActualizarListaDeProductos();
                ActualizarDGVHeladera();
            }
            catch (ArgumentOutOfRangeException)
            {
                string mensajeFallo = null;
                formInformacionDelProceso = new FormInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
                formInformacionDelProceso.ShowDialog();
            }
            catch (NoLlenoTodosLosCamposException ex) 
            {
                FormInformacionDelProceso formInformacionDelProceso = new FormInformacionDelProceso(ex.Message, false);
                formInformacionDelProceso.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }   
        }
    }
}
