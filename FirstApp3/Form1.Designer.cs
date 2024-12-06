namespace FirstApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTikla = new Button();
            txtAdi = new TextBox();
            label1 = new Label();
            lblAdi = new Label();
            btnKaydir = new Button();
            btnSaydamlastir = new Button();
            SuspendLayout();
            // 
            // btnTikla
            // 
            btnTikla.Location = new Point(192, 33);
            btnTikla.Name = "btnTikla";
            btnTikla.Size = new Size(100, 23);
            btnTikla.TabIndex = 0;
            btnTikla.Text = "Tıkla";
            btnTikla.UseVisualStyleBackColor = true;
            btnTikla.Click += btnTikla_Click;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(58, 33);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(128, 23);
            txtAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Adınız";
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(97, 82);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(12, 15);
            lblAdi.TabIndex = 3;
            lblAdi.Text = "-";
            // 
            // btnKaydir
            // 
            btnKaydir.Location = new Point(16, 82);
            btnKaydir.Name = "btnKaydir";
            btnKaydir.Size = new Size(93, 33);
            btnKaydir.TabIndex = 4;
            btnKaydir.Text = "Kaydır";
            btnKaydir.UseVisualStyleBackColor = true;
            btnKaydir.Click += btnKaydir_Click;
            // 
            // btnSaydamlastir
            // 
            btnSaydamlastir.Location = new Point(131, 145);
            btnSaydamlastir.Name = "btnSaydamlastir";
            btnSaydamlastir.Size = new Size(135, 84);
            btnSaydamlastir.TabIndex = 5;
            btnSaydamlastir.Text = "Tıkla";
            btnSaydamlastir.UseVisualStyleBackColor = true;
            btnSaydamlastir.Click += btnSaydamlastir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 272);
            Controls.Add(btnSaydamlastir);
            Controls.Add(btnKaydir);
            Controls.Add(lblAdi);
            Controls.Add(label1);
            Controls.Add(txtAdi);
            Controls.Add(btnTikla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTikla;
        private TextBox txtAdi;
        private Label label1;
        private Label lblAdi;
        private Button btnKaydir;
        private Button btnSaydamlastir;
    }
}
