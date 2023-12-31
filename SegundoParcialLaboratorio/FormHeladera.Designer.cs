﻿namespace PrimerParcialLaboratorio2023
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            buttonInformeDelCliente = new Button();
            buttonSerializador = new Button();
            buttonDeserealizador = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewListaProductos.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewListaProductos.Location = new Point(127, 14);
            dataGridViewListaProductos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaProductos.MultiSelect = false;
            dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            dataGridViewListaProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Blue;
            dataGridViewCellStyle3.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewListaProductos.RowTemplate.Height = 25;
            dataGridViewListaProductos.Size = new Size(209, 373);
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
            buttonInformacionProducto.MouseEnter += buttonInformacionProducto_MouseEnter;
            buttonInformacionProducto.MouseLeave += buttonInformacionProducto_MouseLeave;
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
            buttonVenderACliente.MouseEnter += buttonVenderACliente_MouseEnter;
            buttonVenderACliente.MouseLeave += buttonVenderACliente_MouseLeave;
            // 
            // dataGridViewListaClientes
            // 
            dataGridViewListaClientes.BackgroundColor = Color.Khaki;
            dataGridViewListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Yellow;
            dataGridViewCellStyle5.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewListaClientes.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewListaClientes.GridColor = Color.Black;
            dataGridViewListaClientes.Location = new Point(492, 14);
            dataGridViewListaClientes.Margin = new Padding(4, 3, 4, 3);
            dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            dataGridViewListaClientes.ReadOnly = true;
            dataGridViewListaClientes.RowTemplate.Height = 25;
            dataGridViewListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            buttonReponerStock.Location = new Point(14, 311);
            buttonReponerStock.Margin = new Padding(4, 3, 4, 3);
            buttonReponerStock.Name = "buttonReponerStock";
            buttonReponerStock.Size = new Size(106, 42);
            buttonReponerStock.TabIndex = 6;
            buttonReponerStock.Text = "Reponer\r\nStock\r\n\r\n";
            buttonReponerStock.UseVisualStyleBackColor = true;
            buttonReponerStock.Click += buttonReponerStock_Click;
            buttonReponerStock.MouseEnter += buttonReponerStock_MouseEnter;
            buttonReponerStock.MouseLeave += buttonReponerStock_MouseLeave;
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
            buttonAgregarProducto.MouseEnter += buttonAgregarProducto_MouseEnter;
            buttonAgregarProducto.MouseLeave += buttonAgregarProducto_MouseLeave;
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
            buttonEliminar.MouseEnter += buttonEliminar_MouseEnter;
            buttonEliminar.MouseLeave += buttonEliminar_MouseLeave;
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
            buttonModificar.MouseEnter += buttonModificar_MouseEnter;
            buttonModificar.MouseLeave += buttonModificar_MouseLeave;
            // 
            // buttonInformeDelCliente
            // 
            buttonInformeDelCliente.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInformeDelCliente.Location = new Point(372, 223);
            buttonInformeDelCliente.Name = "buttonInformeDelCliente";
            buttonInformeDelCliente.Size = new Size(112, 45);
            buttonInformeDelCliente.TabIndex = 11;
            buttonInformeDelCliente.Text = "Informe Del Cliente";
            buttonInformeDelCliente.UseVisualStyleBackColor = true;
            buttonInformeDelCliente.Click += buttonInformeDelCliente_Click;
            buttonInformeDelCliente.MouseEnter += buttonInformeDelCliente_MouseEnter;
            buttonInformeDelCliente.MouseLeave += buttonInformeDelCliente_MouseLeave;
            // 
            // buttonSerializador
            // 
            buttonSerializador.Location = new Point(127, 393);
            buttonSerializador.Name = "buttonSerializador";
            buttonSerializador.Size = new Size(91, 29);
            buttonSerializador.TabIndex = 12;
            buttonSerializador.Text = "Serializador";
            buttonSerializador.UseVisualStyleBackColor = true;
            buttonSerializador.Click += buttonSerializador_Click;
            buttonSerializador.MouseEnter += buttonSerializador_MouseEnter;
            buttonSerializador.MouseLeave += buttonSerializador_MouseLeave;
            // 
            // buttonDeserealizador
            // 
            buttonDeserealizador.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeserealizador.Location = new Point(236, 393);
            buttonDeserealizador.Name = "buttonDeserealizador";
            buttonDeserealizador.Size = new Size(100, 29);
            buttonDeserealizador.TabIndex = 13;
            buttonDeserealizador.Text = "Deserealizador";
            buttonDeserealizador.UseVisualStyleBackColor = true;
            buttonDeserealizador.Click += buttonDeserealizador_Click;
            buttonDeserealizador.MouseEnter += buttonDeserealizador_MouseEnter;
            buttonDeserealizador.MouseLeave += buttonDeserealizador_MouseLeave;
            // 
            // FormHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1199, 467);
            Controls.Add(buttonDeserealizador);
            Controls.Add(buttonSerializador);
            Controls.Add(buttonInformeDelCliente);
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
        private Button buttonInformeDelCliente;
        private Button buttonSerializador;
        private Button buttonDeserealizador;
    }
}