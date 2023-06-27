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
        private Action mostrarFormularioProducto;
        private delegate void MostrarFormInformacionDelProcesoDelegate(bool resultado);




        private List<Cliente> clientes;
        public FormHeladera()
        {
            InitializeComponent();
            ActualizarListaDeProductos();
            ActualizarListaDeClientes();
            mostrarFormularioProducto = MostrarFormularioInformacionProducto;
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
            Sistema.ObtenerDatosDelVendedor(vendedor);
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

        private void MostrarFormularioInformacionProducto()
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
        private void buttonInformacionProducto_Click(object sender, EventArgs e)
        {
            try
            {
                mostrarFormularioProducto.Invoke();
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
                ActualizarListaDeProductos();
                ActualizarDGVHeladera();
            }
            catch (ArgumentOutOfRangeException) 
            {
                string mensajeFallo = null;
                MostrarInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
            }
            catch (Exception)
            {
                MostrarInformacionDelProceso(false);
            }
            finally
            {
                numericUpDownKilos.Value = 0;
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
                    MostrarInformacionDelProceso(true);
                    ActualizarListaDeProductos();
                    ActualizarDGVHeladera();
                }
                else
                {
                    if (formCrearProducto.DialogResult == DialogResult.Abort)
                    {
                        MostrarInformacionDelProceso("Se cancelo", false);
                    }
                    else
                    {
                        MostrarInformacionDelProceso(false);
                    }
                }
            }
            catch (NoLlenoTodosLosCamposException ex)
            {
                MostrarInformacionDelProceso(ex.Message, false);
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
                        MostrarInformacionDelProceso(true);
                        ActualizarListaDeProductos();
                        ActualizarDGVHeladera();
                    }
                    else
                    {
                        MostrarInformacionDelProceso(false);
                    }
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                string mensajeFallo = null;
                MostrarInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
            }
            catch (Exception)
            {
                MostrarInformacionDelProceso(false);
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
                    MostrarInformacionDelProceso(true);
                }
                ActualizarListaDeProductos();
                ActualizarDGVHeladera();
            }
            catch (ArgumentOutOfRangeException)
            {
                string mensajeFallo = null;
                MostrarInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
            }
            catch (NoLlenoTodosLosCamposException ex)
            {
                MostrarInformacionDelProceso(ex.Message, false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonInformeDelCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridViewListaClientes.SelectedRows[0].DataBoundItem;
                string info = Sistema.LeerInformeDeComprasDelCliente(cliente);
                FormInformacionDeComprasClientes formInformacionDeComprasClientes = new FormInformacionDeComprasClientes(info);
                formInformacionDeComprasClientes.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                string mensajeFallo = null;
                MostrarInformacionDelProceso(mensajeFallo.NoEligioNingunProductoDataGridView(), false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSerializador_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sistema.SerializarProductos())
                {
                    MostrarInformacionDelProceso(true);
                }
            }
            catch (Exception)
            {
                MostrarInformacionDelProceso("No se pudo serializar", false);
            }
        }

        private void buttonDeserealizador_Click(object sender, EventArgs e)
        {
            try
            {
                FormDeserealizador formDeserealizador = new FormDeserealizador();
                formDeserealizador.ShowDialog();

            }
            catch (Exception)
            {
                MostrarInformacionDelProceso("No se pudo Desearealizar", false);
            }
        }

        private void MostrarInformacionDelProceso(bool resultado)
        {
            FormInformacionDelProceso formInformacionDelProceso = new FormInformacionDelProceso(resultado);
            formInformacionDelProceso.ShowDialog();
        }
        private void MostrarInformacionDelProceso(string mensaje, bool resultado)
        {
            FormInformacionDelProceso formInformacionDelProceso = new FormInformacionDelProceso(mensaje, resultado);
            formInformacionDelProceso.ShowDialog();
        }


        private void buttonInformacionProducto_MouseEnter(object sender, EventArgs e)
        {
            buttonInformacionProducto.BackColor = Color.Gold;
        }

        private void buttonInformacionProducto_MouseLeave(object sender, EventArgs e)
        {
            buttonInformacionProducto.BackColor = Color.White;
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

        private void buttonModificar_MouseEnter(object sender, EventArgs e)
        {
            buttonModificar.BackColor = Color.Gold;
        }

        private void buttonModificar_MouseLeave(object sender, EventArgs e)
        {
            buttonModificar.BackColor = Color.White;
        }

        private void buttonReponerStock_MouseEnter(object sender, EventArgs e)
        {
            buttonReponerStock.BackColor = Color.Gold;
        }

        private void buttonReponerStock_MouseLeave(object sender, EventArgs e)
        {
            buttonReponerStock.BackColor = Color.White;
        }

        private void buttonVenderACliente_MouseEnter(object sender, EventArgs e)
        {
            buttonVenderACliente.BackColor = Color.Gold;
        }

        private void buttonVenderACliente_MouseLeave(object sender, EventArgs e)
        {
            buttonVenderACliente.BackColor = Color.White;
        }

        private void buttonInformeDelCliente_MouseEnter(object sender, EventArgs e)
        {
            buttonInformeDelCliente.BackColor = Color.Gold;
        }

        private void buttonInformeDelCliente_MouseLeave(object sender, EventArgs e)
        {
            buttonInformeDelCliente.BackColor = Color.White;
        }

        private void buttonSerializador_MouseEnter(object sender, EventArgs e)
        {
            buttonSerializador.BackColor = Color.Gold;
        }

        private void buttonSerializador_MouseLeave(object sender, EventArgs e)
        {
            buttonSerializador.BackColor = Color.White;
        }

        private void buttonDeserealizador_MouseEnter(object sender, EventArgs e)
        {
            buttonDeserealizador.BackColor = Color.Gold;
        }

        private void buttonDeserealizador_MouseLeave(object sender, EventArgs e)
        {
            buttonDeserealizador.BackColor = Color.White;
        }



    }
}
