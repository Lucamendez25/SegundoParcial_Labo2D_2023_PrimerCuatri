namespace PrimerParcialLaboratorio2023
{
    partial class FormHeladera
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeladera));
            dataGridViewListaProductos = new DataGridView();
            buttonInformacionProducto = new Button();
            buttonVenderACliente = new Button();
            dataGridViewListaClientes = new DataGridView();
            pictureBox1 = new PictureBox();
            lblInformacionVendedor = new Label();
            buttonReponerStock = new Button();
            numericUpDownKilos = new NumericUpDown();
            buttonAgregarProducto = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaProductos
            // 
            dataGridViewListaProductos.AllowUserToAddRows = false;
            dataGridViewListaProductos.AllowUserToDeleteRows = false;
            dataGridViewListaProductos.AllowUserToResizeColumns = false;
            dataGridViewListaProductos.AllowUserToResizeRows = false;
            dataGridViewListaProductos.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Blue;
            dataGridViewCellStyle6.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewListaProductos.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewListaProductos.Location = new Point(127, 14);
            dataGridViewListaProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaProductos.MultiSelect = false;
            dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Blue;
            dataGridViewCellStyle8.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewListaProductos.RowTemplate.Height = 25;
            dataGridViewListaProductos.Size = new Size(192, 373);
            dataGridViewListaProductos.TabIndex = 0;
            dataGridViewListaProductos.TabStop = false;
            // 
            // buttonInformacionProducto
            // 
            buttonInformacionProducto.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInformacionProducto.Location = new Point(13, 37);
            buttonInformacionProducto.Margin = new Padding(4, 3, 4, 3);
            buttonInformacionProducto.Name = "buttonInformacionProducto";
            buttonInformacionProducto.Size = new Size(106, 53);
            buttonInformacionProducto.TabIndex = 1;
            buttonInformacionProducto.Text = "Informacion\r\nProducto\r\n";
            buttonInformacionProducto.UseVisualStyleBackColor = true;
            buttonInformacionProducto.Click += buttonInformacionProducto_Click;
            // 
            // buttonVenderACliente
            // 
            buttonVenderACliente.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVenderACliente.Location = new Point(372, 167);
            buttonVenderACliente.Margin = new Padding(4, 3, 4, 3);
            buttonVenderACliente.Name = "buttonVenderACliente";
            buttonVenderACliente.Size = new Size(112, 44);
            buttonVenderACliente.TabIndex = 2;
            buttonVenderACliente.Text = "VENDER A \r\nUSUARIO\r\n\r\n";
            buttonVenderACliente.UseVisualStyleBackColor = true;
            buttonVenderACliente.Click += buttonVenderACliente_Click;
            // 
            // dataGridViewListaClientes
            // 
            dataGridViewListaClientes.BackgroundColor = Color.Khaki;
            dataGridViewListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Yellow;
            dataGridViewCellStyle10.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewListaClientes.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewListaClientes.GridColor = Color.Black;
            dataGridViewListaClientes.Location = new Point(492, 14);
            dataGridViewListaClientes.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            dataGridViewListaClientes.RowTemplate.Height = 25;
            dataGridViewListaClientes.Size = new Size(694, 373);
            dataGridViewListaClientes.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(354, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblInformacionVendedor
            // 
            lblInformacionVendedor.AutoSize = true;
            lblInformacionVendedor.Location = new Point(12, 441);
            lblInformacionVendedor.Name = "lblInformacionVendedor";
            lblInformacionVendedor.Size = new Size(72, 17);
            lblInformacionVendedor.TabIndex = 5;
            lblInformacionVendedor.Text = "Vendedor: ";
            // 
            // buttonReponerStock
            // 
            buttonReponerStock.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReponerStock.Location = new Point(13, 311);
            buttonReponerStock.Margin = new Padding(4, 3, 4, 3);
            buttonReponerStock.Name = "buttonReponerStock";
            buttonReponerStock.Size = new Size(106, 42);
            buttonReponerStock.TabIndex = 6;
            buttonReponerStock.Text = "Reponer\r\nStock\r\n\r\n";
            buttonReponerStock.UseVisualStyleBackColor = true;
            buttonReponerStock.Click += buttonReponerStock_Click;
            // 
            // numericUpDownKilos
            // 
            numericUpDownKilos.BackColor = Color.FloralWhite;
            numericUpDownKilos.DecimalPlaces = 1;
            numericUpDownKilos.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownKilos.Location = new Point(14, 359);
            numericUpDownKilos.Name = "numericUpDownKilos";
            numericUpDownKilos.Size = new Size(106, 28);
            numericUpDownKilos.TabIndex = 7;
            // 
            // buttonAgregarProducto
            // 
            buttonAgregarProducto.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarProducto.Location = new Point(14, 96);
            buttonAgregarProducto.Name = "buttonAgregarProducto";
            buttonAgregarProducto.Size = new Size(105, 51);
            buttonAgregarProducto.TabIndex = 8;
            buttonAgregarProducto.Text = "Agregar\r\nProducto\r\n";
            buttonAgregarProducto.UseVisualStyleBackColor = true;
            buttonAgregarProducto.Click += buttonAgregarProducto_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(14, 153);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(106, 46);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificar.Location = new Point(14, 205);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(106, 41);
            buttonModificar.TabIndex = 10;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1199, 467);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregarProducto);
            Controls.Add(numericUpDownKilos);
            Controls.Add(buttonReponerStock);
            Controls.Add(lblInformacionVendedor);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewListaClientes);
            Controls.Add(buttonVenderACliente);
            Controls.Add(buttonInformacionProducto);
            Controls.Add(dataGridViewListaProductos);
            Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHeladera";
            Text = "Heladera";
            Activated += FormHeladera_Activated;
            FormClosed += FormHeladera_FormClosed;
            Load += FormHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaProductos;
        private Button buttonInformacionProducto;
        private Button buttonVenderACliente;
        private DataGridView dataGridViewListaClientes;
        private PictureBox pictureBox1;
        private Label lblInformacionVendedor;
        private Button buttonReponerStock;
        private NumericUpDown numericUpDownKilos;
        private Button buttonAgregarProducto;
        private Button buttonEliminar;
        private Button buttonModificar;
    }
}