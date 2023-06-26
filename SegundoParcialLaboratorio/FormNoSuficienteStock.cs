using ClasesCarniceria;
using PrimerParcialLaboratorio2023;
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
    public partial class FormNoSuficienteStock : Form
    {
        Producto producto;
        public FormNoSuficienteStock()
        {
            InitializeComponent();
        }

        public FormNoSuficienteStock(Producto producto) : this()
        {
            this.producto = producto;
        }

        private void FormNoSuficienteStock_Load(object sender, EventArgs e)
        {
            if (producto != null)
            {
                string infoProducto = producto.ObtenerNombreYKiloProducto();
                this.labelInfoProducto.Text = infoProducto;
            }
        }
    }
}
