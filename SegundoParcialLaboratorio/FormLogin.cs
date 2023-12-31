using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using System.Numerics;
using System.Text;
using WMPLib;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormLogin : Form
    {
        private float dineroCliente;
        public FormLogin()
        {
            InitializeComponent();

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = Sistema.LoguearUsuario(this.textBoxEmail.Text, this.textBoxPassword.Text);
            if (auxUsuario != null)
            {
                if (radioButtonCliente.Checked)
                {
                    Cliente cliente = (Cliente)auxUsuario;
                    FormDineroCliente formDineroCliente = new FormDineroCliente(this);
                    if (formDineroCliente.ShowDialog() == DialogResult.OK)
                    {
                        dineroCliente = formDineroCliente.DineroCliente;
                        cliente.Dinero = dineroCliente;
                        FormVenta formVenta = new FormVenta(cliente, this, dineroCliente);
                        formVenta.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (auxUsuario is Vendedor vendedor)
                    {
                        FormHeladera formHeladera = new FormHeladera(vendedor, this);
                        formHeladera.Show();
                        this.Hide();

                    }
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ERROR:");
                sb.AppendLine("Usuario o contraseņa");
                sb.AppendLine("Incorrectos");
                this.labelMensajeError.Text = sb.ToString();
                this.labelMensajeError.Visible = true;
            }
        }
        public void MostrarLogin()
        {
            this.Show();
        }
        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = "luca@gmail.com";
            this.textBoxPassword.Text = "1234";
        }

        private void radioButtonVendedor_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = "mauro@gmail.com";
            this.textBoxPassword.Text = "1234";
        }

        private void buttonIngresar_MouseLeave(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.White;
        }

        private void buttonIngresar_MouseEnter(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.Gold;

        }

        private void buttonCrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            buttonCrearCuenta.BackColor = Color.White;
        }

        private void buttonCrearCuenta_MouseEnter(object sender, EventArgs e)
        {
            buttonCrearCuenta.BackColor = Color.Gold;
        }
    }
}