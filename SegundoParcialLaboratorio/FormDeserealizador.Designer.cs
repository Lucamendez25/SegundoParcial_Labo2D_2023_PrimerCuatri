namespace SegundoParcialLaboratorio
{
    partial class FormDeserealizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeserealizador));
            buttonJson = new Button();
            buttonXml = new Button();
            dataGridViewListaProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).BeginInit();
            SuspendLayout();
            // 
            // buttonJson
            // 
            buttonJson.Location = new Point(215, 12);
            buttonJson.Name = "buttonJson";
            buttonJson.Size = new Size(102, 37);
            buttonJson.TabIndex = 0;
            buttonJson.Text = "JSON";
            buttonJson.UseVisualStyleBackColor = true;
            buttonJson.Click += buttonJson_Click;
            buttonJson.MouseEnter += buttonJson_MouseEnter;
            buttonJson.MouseLeave += buttonJson_MouseLeave;
            // 
            // buttonXml
            // 
            buttonXml.Location = new Point(333, 12);
            buttonXml.Name = "buttonXml";
            buttonXml.Size = new Size(99, 37);
            buttonXml.TabIndex = 1;
            buttonXml.Text = "XML";
            buttonXml.UseVisualStyleBackColor = true;
            buttonXml.Click += buttonXml_Click;
            buttonXml.MouseEnter += buttonXml_MouseEnter;
            buttonXml.MouseLeave += buttonXml_MouseLeave;
            // 
            // dataGridViewListaProductos
            // 
            dataGridViewListaProductos.AllowUserToAddRows = false;
            dataGridViewListaProductos.AllowUserToDeleteRows = false;
            dataGridViewListaProductos.AllowUserToResizeColumns = false;
            dataGridViewListaProductos.AllowUserToResizeRows = false;
            dataGridViewListaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewListaProductos.Location = new Point(27, 55);
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
            dataGridViewListaProductos.Size = new Size(594, 393);
            dataGridViewListaProductos.TabIndex = 2;
            dataGridViewListaProductos.TabStop = false;
            // 
            // FormDeserealizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(667, 482);
            Controls.Add(dataGridViewListaProductos);
            Controls.Add(buttonXml);
            Controls.Add(buttonJson);
            Font = new Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDeserealizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDeserealizador";
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJson;
        private Button buttonXml;
        private DataGridView dataGridViewListaProductos;
    }
}