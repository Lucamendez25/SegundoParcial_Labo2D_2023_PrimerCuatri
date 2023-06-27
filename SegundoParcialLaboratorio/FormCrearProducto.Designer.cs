namespace SegundoParcialLaboratorio
{
    partial class FormCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearProducto));
            textBoxCodigoProducto = new TextBox();
            labelCodigoProducto = new Label();
            comboBoxTipo = new ComboBox();
            label1 = new Label();
            textBoxNombreProducto = new TextBox();
            labelNombreProducto = new Label();
            textBoxValorPorKilo = new TextBox();
            labelValorPorKilo = new Label();
            buttonAgregar = new Button();
            SuspendLayout();
            // 
            // textBoxCodigoProducto
            // 
            textBoxCodigoProducto.Location = new Point(84, 194);
            textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            textBoxCodigoProducto.Size = new Size(114, 24);
            textBoxCodigoProducto.TabIndex = 0;
            // 
            // labelCodigoProducto
            // 
            labelCodigoProducto.AutoSize = true;
            labelCodigoProducto.Location = new Point(84, 174);
            labelCodigoProducto.Name = "labelCodigoProducto";
            labelCodigoProducto.Size = new Size(109, 17);
            labelCodigoProducto.TabIndex = 1;
            labelCodigoProducto.Text = "Codigo Producto";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.Gold;
            comboBoxTipo.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(84, 54);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(114, 29);
            comboBoxTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 4;
            label1.Text = "Tipo Producto";
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(84, 127);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(114, 24);
            textBoxNombreProducto.TabIndex = 5;
            // 
            // labelNombreProducto
            // 
            labelNombreProducto.AutoSize = true;
            labelNombreProducto.Location = new Point(84, 107);
            labelNombreProducto.Name = "labelNombreProducto";
            labelNombreProducto.Size = new Size(115, 17);
            labelNombreProducto.TabIndex = 6;
            labelNombreProducto.Text = "Nombre Producto";
            // 
            // textBoxValorPorKilo
            // 
            textBoxValorPorKilo.Location = new Point(84, 263);
            textBoxValorPorKilo.Name = "textBoxValorPorKilo";
            textBoxValorPorKilo.Size = new Size(115, 24);
            textBoxValorPorKilo.TabIndex = 7;
            // 
            // labelValorPorKilo
            // 
            labelValorPorKilo.AutoSize = true;
            labelValorPorKilo.Location = new Point(84, 234);
            labelValorPorKilo.Name = "labelValorPorKilo";
            labelValorPorKilo.Size = new Size(102, 17);
            labelValorPorKilo.TabIndex = 8;
            labelValorPorKilo.Text = "Valor Por Kilo";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(98, 303);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 33);
            buttonAgregar.TabIndex = 9;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // FormCrearProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(280, 392);
            Controls.Add(buttonAgregar);
            Controls.Add(labelValorPorKilo);
            Controls.Add(textBoxValorPorKilo);
            Controls.Add(labelNombreProducto);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(label1);
            Controls.Add(comboBoxTipo);
            Controls.Add(labelCodigoProducto);
            Controls.Add(textBoxCodigoProducto);
            Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrearProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCodigoProducto;
        private Label labelCodigoProducto;
        private ComboBox comboBoxTipo;
        private Label label1;
        private TextBox textBoxNombreProducto;
        private Label labelNombreProducto;
        private TextBox textBoxValorPorKilo;
        private Label labelValorPorKilo;
        private Button buttonAgregar;
    }
}