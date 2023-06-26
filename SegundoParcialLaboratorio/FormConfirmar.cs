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
    public partial class FormConfirmar : Form
    {
        public FormConfirmar()
        {
            InitializeComponent();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
