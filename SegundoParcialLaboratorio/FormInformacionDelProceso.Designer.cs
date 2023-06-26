namespace SegundoParcialLaboratorio
{
    partial class FormInformacionDelProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacionDelProceso));
            labelInformacion = new Label();
            SuspendLayout();
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelInformacion.Location = new Point(95, 21);
            labelInformacion.Margin = new Padding(5, 0, 5, 0);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(63, 21);
            labelInformacion.TabIndex = 0;
            labelInformacion.Text = "label1";
            labelInformacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormInformacionDelProceso
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(350, 222);
            Controls.Add(labelInformacion);
            Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormInformacionDelProceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMO SALIO?";
            Load += FormInformacionDelProceso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInformacion;
    }
}