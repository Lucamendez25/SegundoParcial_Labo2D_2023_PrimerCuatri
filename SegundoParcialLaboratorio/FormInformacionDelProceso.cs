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
    public partial class FormInformacionDelProceso : Form
    {
        string informacion;
        bool salioBien;
        public FormInformacionDelProceso()
        {
            InitializeComponent();
        }
        public FormInformacionDelProceso(bool salioBien) : this()
        {
            this.salioBien = salioBien;
        }

        public FormInformacionDelProceso(string informacion, bool salioBien) : this(salioBien)
        {
            this.informacion = informacion;
        }

        private void FormInformacionDelProceso_Load(object sender, EventArgs e)
        {
            this.labelInformacion.Text = informacion.informacionDelProceso(salioBien);
            if (salioBien)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
