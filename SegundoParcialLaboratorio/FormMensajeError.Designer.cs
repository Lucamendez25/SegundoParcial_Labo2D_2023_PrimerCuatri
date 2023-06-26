namespace SegundoParcialLaboratorio
{
    partial class FormMensajeError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensajeError));
            pictureBoxError = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxError
            // 
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(-42, -1);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(499, 259);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 0;
            pictureBoxError.TabStop = false;
            // 
            // FormMensajeError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 256);
            Controls.Add(pictureBoxError);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMensajeError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERROR";
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxError;
    }
}