using ClasesCarniceria;
using PrimerParcialLaboratorio2023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialLaboratorio
{
    public partial class FormModificarProducto : Form
    {
        string info;
        string nombreNuevo;
        Producto producto;
        FormConfirmar formConfirmar;
        FormInformacionDelProceso formInformacionDelProceso;
        public FormModificarProducto()
        {
            InitializeComponent();
            formConfirmar = new FormConfirmar();
        }
        public FormModificarProducto(Producto producto) : this()
        {
            this.producto = producto;
        }
        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            info = producto.ObtenerInformacionCompleta();
            labelNombreNuevo.Text += '\n';
            labelNombreNuevo.Text += producto.ObtenerInformacionCompleta();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                nombreNuevo = textBoxNuevoNombre.Text;
                if (string.IsNullOrEmpty(nombreNuevo))
                {
                    throw new NoLlenoTodosLosCamposException();
                }
                if (formConfirmar.ShowDialog() == DialogResult.OK)
                {
                    if (Sistema.ModificarProductoDeLaBaseDeDatos(producto.CodigoProducto, nombreNuevo))
                    {
                        formInformacionDelProceso = new FormInformacionDelProceso(true);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        formInformacionDelProceso = new FormInformacionDelProceso(false);
                        this.DialogResult = DialogResult.Cancel;
                    }
                    formInformacionDelProceso.ShowDialog();
                }
            }
            catch (NoLlenoTodosLosCamposException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
