namespace SegundoParcialLaboratorio
{
    partial class FormInformacionDeProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacionDeProducto));
            lblInfoProducto = new Label();
            pictureBoxProducto = new PictureBox();
            openFileDialogImagenes = new OpenFileDialog();
            buttonCargarImagen = new Button();
            saveFileDialogImagenes = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            SuspendLayout();
            // 
            // lblInfoProducto
            // 
            lblInfoProducto.AutoSize = true;
            lblInfoProducto.BackColor = Color.Gold;
            lblInfoProducto.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoProducto.Location = new Point(118, 9);
            lblInfoProducto.Name = "lblInfoProducto";
            lblInfoProducto.Size = new Size(257, 24);
            lblInfoProducto.TabIndex = 0;
            lblInfoProducto.Text = "Información del Producto:";
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.Image = (Image)resources.GetObject("pictureBoxProducto.Image");
            pictureBoxProducto.Location = new Point(102, 155);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(273, 177);
            pictureBoxProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProducto.TabIndex = 1;
            pictureBoxProducto.TabStop = false;
            // 
            // openFileDialogImagenes
            // 
            openFileDialogImagenes.FileName = "openFileDialog1";
            // 
            // buttonCargarImagen
            // 
            buttonCargarImagen.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCargarImagen.Location = new Point(422, 131);
            buttonCargarImagen.Name = "buttonCargarImagen";
            buttonCargarImagen.Size = new Size(99, 44);
            buttonCargarImagen.TabIndex = 2;
            buttonCargarImagen.Text = "Cargar Imagen";
            buttonCargarImagen.UseVisualStyleBackColor = true;
            buttonCargarImagen.Click += buttonCargarImagen_Click;
            // 
            // FormInformacionDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(599, 380);
            Controls.Add(buttonCargarImagen);
            Controls.Add(pictureBoxProducto);
            Controls.Add(lblInfoProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInformacionDeProducto";
            Text = "INFORMACIÓN";
            FormClosed += FormInformacionDeProducto_FormClosed;
            Load += FormInformacionDeProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoProducto;
        private PictureBox pictureBoxProducto;
        private OpenFileDialog openFileDialogImagenes;
        private Button buttonCargarImagen;
        private SaveFileDialog saveFileDialogImagenes;
    }
}