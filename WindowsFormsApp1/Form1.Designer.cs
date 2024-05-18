namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath; // Dosya yolu textbox'u eklendi
        private System.Windows.Forms.Label lblFilePathTitle; // Dosya yolu başlık etiketi eklendi

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePathTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBrowse.Location = new System.Drawing.Point(12, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(234, 353);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Dosya Seçin";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.White;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnConvert.Location = new System.Drawing.Point(760, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(231, 344);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Dönüştür ve Kaydet";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(276, 169);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(459, 22);
            this.txtFilePath.TabIndex = 2;
            // 
            // lblFilePathTitle
            // 
            this.lblFilePathTitle.AutoSize = true;
            this.lblFilePathTitle.BackColor = System.Drawing.Color.PowderBlue;
            this.lblFilePathTitle.Location = new System.Drawing.Point(273, 137);
            this.lblFilePathTitle.Name = "lblFilePathTitle";
            this.lblFilePathTitle.Size = new System.Drawing.Size(80, 16);
            this.lblFilePathTitle.TabIndex = 3;
            this.lblFilePathTitle.Text = "Dosya Yolu:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.A31cWJd0_400x400_fotor_bg_remover_2024051719920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1003, 368);
            this.Controls.Add(this.lblFilePathTitle);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowse);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Excel Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
