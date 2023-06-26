using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Numerics;

namespace SegundoParcialLaboratorio
{
    public partial class FormAgradecimiento : Form
    {
        private SoundPlayer sonido;
        public FormAgradecimiento()
        {
            InitializeComponent();

        }
        private void FormAgradecimiento_Load(object sender, EventArgs e)
        {
            try
            {
                sonido = new SoundPlayer("C:\\Users\\Luca\\Desktop\\Muchachos.wav");
                sonido.Play();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void FormAgradecimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            sonido.Stop();
        }
    }
}
