namespace SegundoParcialLaboratorio
{
    partial class FormModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProducto));
            labelNombreNuevo = new Label();
            textBoxNuevoNombre = new TextBox();
            buttonModificar = new Button();
            SuspendLayout();
            // 
            // labelNombreNuevo
            // 
            labelNombreNuevo.AutoSize = true;
            labelNombreNuevo.Location = new Point(91, 9);
            labelNombreNuevo.Name = "labelNombreNuevo";
            labelNombreNuevo.Size = new Size(209, 21);
            labelNombreNuevo.TabIndex = 0;
            labelNombreNuevo.Text = "Ingrese nombre nuevo: ";
            // 
            // textBoxNuevoNombre
            // 
            textBoxNuevoNombre.Location = new Point(91, 118);
            textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            textBoxNuevoNombre.Size = new Size(209, 28);
            textBoxNuevoNombre.TabIndex = 1;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(114, 152);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(156, 38);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // FormModificarProducto
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(407, 214);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxNuevoNombre);
            Controls.Add(labelNombreNuevo);
            Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
            Load += FormModificarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombreNuevo;
        private TextBox textBoxNuevoNombre;
        private Button buttonModificar;
    }
}