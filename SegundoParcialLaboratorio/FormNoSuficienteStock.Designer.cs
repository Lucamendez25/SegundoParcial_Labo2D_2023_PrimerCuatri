namespace SegundoParcialLaboratorio
{
    partial class FormNoSuficienteStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoSuficienteStock));
            labelInfoProducto = new Label();
            SuspendLayout();
            // 
            // labelInfoProducto
            // 
            labelInfoProducto.AutoSize = true;
            labelInfoProducto.BackColor = Color.CornflowerBlue;
            labelInfoProducto.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfoProducto.Location = new Point(152, 338);
            labelInfoProducto.Name = "labelInfoProducto";
            labelInfoProducto.Size = new Size(52, 18);
            labelInfoProducto.TabIndex = 0;
            labelInfoProducto.Text = "label1";
            // 
            // FormNoSuficienteStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(588, 443);
            Controls.Add(labelInfoProducto);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormNoSuficienteStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNoSuficienteStock";
            Load += FormNoSuficienteStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfoProducto;
    }
}