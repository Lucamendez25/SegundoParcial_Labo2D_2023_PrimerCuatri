namespace SegundoParcialLaboratorio
{
    partial class FormConfirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmar));
            buttonNo = new Button();
            buttonSi = new Button();
            labelPregunta = new Label();
            SuspendLayout();
            // 
            // buttonNo
            // 
            buttonNo.BackColor = Color.Red;
            buttonNo.Location = new Point(231, 113);
            buttonNo.Margin = new Padding(5, 4, 5, 4);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(129, 32);
            buttonNo.TabIndex = 5;
            buttonNo.Text = "NO";
            buttonNo.UseVisualStyleBackColor = false;
            buttonNo.Click += buttonNo_Click;
            // 
            // buttonSi
            // 
            buttonSi.BackColor = Color.Lime;
            buttonSi.Location = new Point(60, 113);
            buttonSi.Margin = new Padding(5, 4, 5, 4);
            buttonSi.Name = "buttonSi";
            buttonSi.Size = new Size(129, 32);
            buttonSi.TabIndex = 4;
            buttonSi.Text = "SI";
            buttonSi.UseVisualStyleBackColor = false;
            buttonSi.Click += buttonSi_Click;
            // 
            // labelPregunta
            // 
            labelPregunta.AutoSize = true;
            labelPregunta.BackColor = SystemColors.WindowText;
            labelPregunta.ForeColor = SystemColors.ButtonHighlight;
            labelPregunta.Location = new Point(60, 54);
            labelPregunta.Margin = new Padding(5, 0, 5, 0);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(300, 42);
            labelPregunta.TabIndex = 3;
            labelPregunta.Text = "ESTA SEGURO DE REALIZAR \r\nESTOS CAMBIOS?";
            // 
            // FormConfirmar
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Anotación_2023_06_15_113407;
            ClientSize = new Size(429, 206);
            Controls.Add(buttonNo);
            Controls.Add(buttonSi);
            Controls.Add(labelPregunta);
            Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormConfirmar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfirmar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNo;
        private Button buttonSi;
        private Label labelPregunta;
    }
}