using ClasesCarniceria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialLaboratorio
{
    public partial class FormDeserealizador : Form
    {
        List<Producto> productos;
        public FormDeserealizador()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }
        private void buttonJson_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarListaProductos();
                productos = Sistema.DesearializarProductosJson();
                ActualizarDGVVenta();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarListaProductos();
                productos = Sistema.DesearializarProductosXml();
                ActualizarDGVVenta();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LimpiarListaProductos()
        {
            if (productos is not null)
            {
                productos.Clear();
            }
        }

        private void ActualizarDGVVenta()
        {
            try
            {
                if (productos.Count > 0)
                {
                    dataGridViewListaProductos.DataSource = null;
                    dataGridViewListaProductos.Visible = true;
                    dataGridViewListaProductos.DataSource = productos;
                }
                else
                {
                    dataGridViewListaProductos.Visible = false;
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void buttonJson_MouseEnter(object sender, EventArgs e)
        {
            buttonJson.BackColor = Color.LimeGreen;
        }

        private void buttonJson_MouseLeave(object sender, EventArgs e)
        {
            buttonJson.BackColor = Color.White;
        }

        private void buttonXml_MouseEnter(object sender, EventArgs e)
        {
            buttonXml.BackColor = Color.OrangeRed;
        }

        private void buttonXml_MouseLeave(object sender, EventArgs e)
        {
            buttonXml.BackColor = Color.White;
        }
    }
}
