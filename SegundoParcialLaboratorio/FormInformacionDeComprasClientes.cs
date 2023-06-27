using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SegundoParcialLaboratorio
{
    public partial class FormInformacionDeComprasClientes : Form
    {
        string info;
        public FormInformacionDeComprasClientes()
        {
            InitializeComponent();
        }
        public FormInformacionDeComprasClientes(string info) : this()
        {
            this.info = info;
        }
        private void FormInformacionDeComprasClientes_Load(object sender, EventArgs e)
        {
            textBoxInfoCliente.AppendText("Compras Del Cliente: \r\n");
            textBoxInfoCliente.AppendText(info);
        }
    }
}
