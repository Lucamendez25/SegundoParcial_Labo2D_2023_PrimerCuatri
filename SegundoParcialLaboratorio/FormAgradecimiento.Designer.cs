namespace SegundoParcialLaboratorio
{
    partial class FormAgradecimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgradecimiento));
            pictureBoxAgradecimiento = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAgradecimiento).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAgradecimiento
            // 
            pictureBoxAgradecimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxAgradecimiento.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAgradecimiento.Image = (Image)resources.GetObject("pictureBoxAgradecimiento.Image");
            pictureBoxAgradecimiento.Location = new Point(0, 0);
            pictureBoxAgradecimiento.Name = "pictureBoxAgradecimiento";
            pictureBoxAgradecimiento.Size = new Size(793, 446);
            pictureBoxAgradecimiento.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAgradecimiento.TabIndex = 0;
            pictureBoxAgradecimiento.TabStop = false;
            // 
            // FormAgradecimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 444);
            Controls.Add(pictureBoxAgradecimiento);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAgradecimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡¡¡GRACIAS!!!";
            FormClosed += FormAgradecimiento_FormClosed;
            Load += FormAgradecimiento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAgradecimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAgradecimiento;
    }
}