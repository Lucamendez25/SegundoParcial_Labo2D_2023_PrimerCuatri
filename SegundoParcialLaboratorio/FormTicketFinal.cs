using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using SegundoParcialLaboratorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormTicketFinal : Form
    {
        private float totalCarrito;
        Venta venta;
        FormVenta formVenta;
        Cliente cliente;

        public FormTicketFinal()
        {
            InitializeComponent();
        }

        public FormTicketFinal(Venta venta, Cliente cliente, FormVenta formVenta) : this()
        {
            this.cliente = cliente;
            this.formVenta = formVenta;
            this.venta = venta;
        }

        private void FormTicketFinal_Load(object sender, EventArgs e)
        {
            this.labelDineroCliente.Text = $"Mi banco: {cliente.Dinero}";
            this.labelTotalCarrito.Text = $"Total a pagar: {venta.ObtenerTotalVenta()}";
            ActualizarDGVFinal();
        }

        private void ActualizarDGVFinal()
        {
            if (venta.Detalles.Count > 0)
            {
                dataGridViewCarritoFinal.DataSource = null;
                dataGridViewCarritoFinal.Visible = true;
                dataGridViewCarritoFinal.DataSource = venta.Detalles;
                dataGridViewCarritoFinal.Columns[1].Visible = false;
            }
            else
            {
                dataGridViewCarritoFinal.Visible = false;
            }
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                bool esCompraConCredito = radioButtonCredito.Checked;

                if (Sistema.CalcularACobrarCliente(cliente, venta.ObtenerTotalVenta(), esCompraConCredito))
                {

                    ArchivosDeTexto.AgregarAlArchivo(venta.Detalles, venta);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Se realizo la compra con exito");
                    sb.AppendLine($"Le restan: {cliente.Dinero} pesos.");
                    if (esCompraConCredito)
                    {
                        sb.AppendLine("Al haber sido con credito, se le cobro 5% recarga...");
                    }
                    Sistema.DisminuyoStock(venta);
                    venta.Detalles.Clear();
                    FormAgradecimiento formAgradecimiento = new FormAgradecimiento();
                    formAgradecimiento.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    formVenta.Show();

                }
                else
                {
                    throw new NoTieneDineroSuficienteException();
                }
            }
            catch (NoTieneDineroSuficienteException)
            {
                FormNoTieneDineroSuficiente noTieneDineroSuficiente = new FormNoTieneDineroSuficiente();
                noTieneDineroSuficiente.ShowDialog();
            }
            catch (Exception) 
            {
                throw;
            }
         
        }
        private void FormTicketFinal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formVenta.Show();
        }

        private void buttonFinalizarCompra_MouseEnter(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.Gold;
        }

        private void buttonFinalizarCompra_MouseLeave(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.White;
        }
    }
}
