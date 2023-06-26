using ClasesCarniceria;
using PrimerParcialLaboratorio2023;
using SegundoParcialLaboratorio.Properties;
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
    public partial class FormInformacionDeProducto : Form
    {
        Producto producto;
        FormHeladera formHeladera;
        public FormInformacionDeProducto()
        {
            InitializeComponent();
        }
        public FormInformacionDeProducto(FormHeladera formHeladera, Producto producto) : this()
        {
            this.producto = producto;
            this.formHeladera = formHeladera;
        }

        private void FormInformacionDeProducto_Load(object sender, EventArgs e)
        {
            lblInfoProducto.Text = producto.ObtenerInformacionCompleta();
            if (producto.ImagenProducto != null)
            {
                pictureBoxProducto.ImageLocation = producto.ImagenProducto;
            }
        }

        private void buttonCargarImagen_Click(object sender, EventArgs e)
        {
            // Filtro de archivos para mostrar solo imágenes
            saveFileDialogImagenes.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (this.saveFileDialogImagenes.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialogImagenes.FileName;
                if (rutaArchivo != null)
                {
                    producto.ImagenProducto = saveFileDialogImagenes.FileName;
                }

            }


            if (!string.IsNullOrEmpty(producto.ImagenProducto))
            {
                // Verificar si la ruta de archivo de imagen del producto no está vacía
                if (System.IO.File.Exists(producto.ImagenProducto))
                {
                    // Cargar la imagen en el PictureBox
                    pictureBoxProducto.ImageLocation = producto.ImagenProducto;
                }
                else
                {
                    // La imagen no existe en la ubicación guardada, puedes mostrar una imagen de error o dejar el PictureBox vacío
                    // pictureBox1.Image = Properties.Resources.imagen_error;
                }
            }
        }

        private void FormInformacionDeProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (producto.ImagenProducto != null)
            {
                Sistema.SetearImagen(producto, producto.ImagenProducto);
            }
        }
    }
}
