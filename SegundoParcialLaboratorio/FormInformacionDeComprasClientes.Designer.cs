namespace SegundoParcialLaboratorio
{
    partial class FormInformacionDeComprasClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacionDeComprasClientes));
            textBoxInfoCliente = new TextBox();
            SuspendLayout();
            // 
            // textBoxInfoCliente
            // 
            textBoxInfoCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInfoCliente.BackColor = Color.LightSkyBlue;
            textBoxInfoCliente.BorderStyle = BorderStyle.None;
            textBoxInfoCliente.Location = new Point(421, 27);
            textBoxInfoCliente.Multiline = true;
            textBoxInfoCliente.Name = "textBoxInfoCliente";
            textBoxInfoCliente.ReadOnly = true;
            textBoxInfoCliente.ScrollBars = ScrollBars.Vertical;
            textBoxInfoCliente.Size = new Size(351, 473);
            textBoxInfoCliente.TabIndex = 1;
            // 
            // FormInformacionDeComprasClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 538);
            Controls.Add(textBoxInfoCliente);
            Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInformacionDeComprasClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInfoDeVentasClientes";
            Load += FormInformacionDeComprasClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfoCliente;
    }
}