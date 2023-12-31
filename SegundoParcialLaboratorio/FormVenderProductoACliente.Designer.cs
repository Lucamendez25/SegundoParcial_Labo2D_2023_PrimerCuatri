﻿namespace PrimerParcialLaboratorio2023
{
    partial class FormVenderProductoACliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenderProductoACliente));
            dataGridViewListaProductos = new DataGridView();
            labelUsuario = new Label();
            buttonVender = new Button();
            pictureBox1 = new PictureBox();
            numericUpDownKilos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListaProductos
            // 
            dataGridViewListaProductos.BackgroundColor = Color.LightSkyBlue;
            dataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewListaProductos.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListaProductos.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewListaProductos.Location = new Point(60, 17);
            dataGridViewListaProductos.Margin = new Padding(5, 4, 5, 4);
            dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            dataGridViewListaProductos.RowTemplate.Height = 25;
            dataGridViewListaProductos.Size = new Size(528, 526);
            dataGridViewListaProductos.TabIndex = 0;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(597, 17);
            labelUsuario.Margin = new Padding(5, 0, 5, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(80, 42);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario: \r\nDinero: \r\n";
            // 
            // buttonVender
            // 
            buttonVender.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVender.Location = new Point(598, 236);
            buttonVender.Margin = new Padding(5, 4, 5, 4);
            buttonVender.Name = "buttonVender";
            buttonVender.Size = new Size(118, 40);
            buttonVender.TabIndex = 2;
            buttonVender.Text = "Vender";
            buttonVender.UseVisualStyleBackColor = true;
            buttonVender.Click += buttonVender_Click;
            buttonVender.MouseEnter += buttonVender_MouseEnter;
            buttonVender.MouseLeave += buttonVender_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(597, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // numericUpDownKilos
            // 
            numericUpDownKilos.BackColor = Color.Gold;
            numericUpDownKilos.DecimalPlaces = 1;
            numericUpDownKilos.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownKilos.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownKilos.Location = new Point(597, 201);
            numericUpDownKilos.Name = "numericUpDownKilos";
            numericUpDownKilos.Size = new Size(120, 28);
            numericUpDownKilos.TabIndex = 7;
            // 
            // FormVenderProductoACliente
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(850, 630);
            Controls.Add(numericUpDownKilos);
            Controls.Add(pictureBox1);
            Controls.Add(buttonVender);
            Controls.Add(labelUsuario);
            Controls.Add(dataGridViewListaProductos);
            Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormVenderProductoACliente";
            Text = "Vender Productos a Clientes";
            FormClosed += FormVenderProductoACliente_FormClosed;
            Load += FormVenderProductoACliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaProductos;
        private Label labelUsuario;
        private Button buttonVender;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownKilos;
    }
}