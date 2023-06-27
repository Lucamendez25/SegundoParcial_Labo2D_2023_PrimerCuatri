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
    public partial class FormCrearProducto : Form
    {
        public FormCrearProducto()
        {
            InitializeComponent();
            this.comboBoxTipo.Items.Add(eTipoProducto.CarneRes);
            this.comboBoxTipo.Items.Add(eTipoProducto.CarnePollo);
            this.comboBoxTipo.Items.Add(eTipoProducto.Variedad);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                eTipoProducto tipo = (eTipoProducto)comboBoxTipo.SelectedItem;
                string nombre = this.textBoxNombreProducto.Text;
                string codigoProducto = this.textBoxCodigoProducto.Text;
                bool seParseo = Double.TryParse(this.textBoxValorPorKilo.Text, out double precioPorKilo);
                if (seParseo == false) 
                {
                    throw new Exception();
                }

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigoProducto) || seParseo == false)
                {
                    throw new NoLlenoTodosLosCamposException();
                }
                Producto producto = new Producto(codigoProducto, nombre, tipo, precioPorKilo);
                Sistema.AgregarProducto(producto);
                DialogResult = DialogResult.OK;
            }
            catch (NullReferenceException)
            {
                throw new NoLlenoTodosLosCamposException();
            }
            catch (NoLlenoTodosLosCamposException)
            {
                throw;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Intento ingresar letras en el text ValorPorKilo");
            }
        }
    }
}
