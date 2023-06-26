using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
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
        FormHeladera formHeladera;
        List<Producto> listaProductos;
        bool vendedorVendio = false;
        public FormVenderProductoACliente()
        {
            InitializeComponent();
        }
        public FormVenderProductoACliente(Vendedor vendedor, Cliente cliente, FormHeladera formHeladera) : this()
        {
            this.vendedor = vendedor;
            this.cliente = cliente;
            this.formHeladera = formHeladera;
        }
        private void FormVenderProductoACliente_Load(object sender, EventArgs e)
        {
            ActualizarListaProductos();
            ActualizarDGVListaProductos();
            ActualizarCliente();
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
            if (dataGridViewListaProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                if (producto != null)
                {
                    if (Sistema.CalcularACobrarCliente(cliente, producto.ValorPorKilo, false))
                    {
                        //lo hago de a uno, porque vendo por unidad
                        Sistema.DisminuyoStock(producto, producto.Stock -= 1);
                        ActualizarListaProductos();
                        ActualizarDGVListaProductos();
                        ActualizarCliente();
                        vendedorVendio = true;
                    }
                }
            }
        }
        private void FormVenderProductoACliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vendedorVendio == true)
            {
                Sistema.SumarUnaVenta(vendedor);
                Sistema.ModificarVentasDelVendedor(vendedor);
            }
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
