namespace PrimerParcialLaboratorio2023
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonIngresar = new Button();
            groupBoxTipoUsuario = new GroupBox();
            radioButtonVendedor = new RadioButton();
            radioButtonCliente = new RadioButton();
            labelMensajeError = new Label();
            labelEstrellas = new Label();
            groupBoxTipoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(323, 121);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 16);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(304, 180);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(88, 16);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Contraseña";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(264, 141);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "lala123@gmail.com";
            textBoxEmail.Size = new Size(175, 26);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(264, 200);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "***********************";
            textBoxPassword.Size = new Size(175, 26);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            buttonIngresar.Location = new Point(304, 234);
            buttonIngresar.Margin = new Padding(4);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(93, 34);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            buttonIngresar.MouseEnter += buttonIngresar_MouseEnter;
            buttonIngresar.MouseLeave += buttonIngresar_MouseLeave;
            // 
            // groupBoxTipoUsuario
            // 
            groupBoxTipoUsuario.BackColor = Color.Transparent;
            groupBoxTipoUsuario.Controls.Add(radioButtonVendedor);
            groupBoxTipoUsuario.Controls.Add(radioButtonCliente);
            groupBoxTipoUsuario.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxTipoUsuario.Location = new Point(102, 135);
            groupBoxTipoUsuario.Margin = new Padding(4);
            groupBoxTipoUsuario.Name = "groupBoxTipoUsuario";
            groupBoxTipoUsuario.Padding = new Padding(4);
            groupBoxTipoUsuario.Size = new Size(147, 83);
            groupBoxTipoUsuario.TabIndex = 5;
            groupBoxTipoUsuario.TabStop = false;
            groupBoxTipoUsuario.Text = "Tipo de usuario: ";
            // 
            // radioButtonVendedor
            // 
            radioButtonVendedor.AutoSize = true;
            radioButtonVendedor.Location = new Point(8, 55);
            radioButtonVendedor.Margin = new Padding(4);
            radioButtonVendedor.Name = "radioButtonVendedor";
            radioButtonVendedor.Size = new Size(96, 20);
            radioButtonVendedor.TabIndex = 1;
            radioButtonVendedor.TabStop = true;
            radioButtonVendedor.Text = "Vendedor";
            radioButtonVendedor.UseVisualStyleBackColor = true;
            radioButtonVendedor.CheckedChanged += radioButtonVendedor_CheckedChanged;
            // 
            // radioButtonCliente
            // 
            radioButtonCliente.AutoSize = true;
            radioButtonCliente.Location = new Point(8, 27);
            radioButtonCliente.Margin = new Padding(4);
            radioButtonCliente.Name = "radioButtonCliente";
            radioButtonCliente.Size = new Size(77, 20);
            radioButtonCliente.TabIndex = 0;
            radioButtonCliente.TabStop = true;
            radioButtonCliente.Text = "Cliente";
            radioButtonCliente.UseVisualStyleBackColor = true;
            radioButtonCliente.CheckedChanged += radioButtonCliente_CheckedChanged;
            // 
            // labelMensajeError
            // 
            labelMensajeError.AutoSize = true;
            labelMensajeError.BackColor = Color.Yellow;
            labelMensajeError.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMensajeError.ForeColor = Color.Black;
            labelMensajeError.Location = new Point(102, 225);
            labelMensajeError.Margin = new Padding(4, 0, 4, 0);
            labelMensajeError.Name = "labelMensajeError";
            labelMensajeError.Size = new Size(68, 16);
            labelMensajeError.TabIndex = 6;
            labelMensajeError.Text = "Mensaje: ";
            labelMensajeError.Visible = false;
            // 
            // labelEstrellas
            // 
            labelEstrellas.AutoSize = true;
            labelEstrellas.BackColor = Color.Transparent;
            labelEstrellas.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstrellas.ForeColor = Color.Yellow;
            labelEstrellas.Location = new Point(78, 107);
            labelEstrellas.Name = "labelEstrellas";
            labelEstrellas.Size = new Size(26, 44);
            labelEstrellas.TabIndex = 9;
            labelEstrellas.Text = " ";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = SegundoParcialLaboratorio.Properties.Resources.Imagen_MUUUCHACHOS;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 445);
            Controls.Add(labelEstrellas);
            Controls.Add(labelMensajeError);
            Controls.Add(groupBoxTipoUsuario);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INGRESO A \"MUUUCHACHOS\"";
            Load += FormLogin_Load;
            groupBoxTipoUsuario.ResumeLayout(false);
            groupBoxTipoUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonIngresar;
        private GroupBox groupBoxTipoUsuario;
        private RadioButton radioButtonVendedor;
        private RadioButton radioButtonCliente;
        private Label labelMensajeError;
        private Button buttonCrearCuenta;
        private Label labelEstrellas;
    }
}