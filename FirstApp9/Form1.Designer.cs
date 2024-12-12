namespace FirstApp9
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
            lstOgrenciler = new ListBox();
            label1 = new Label();
            lblAdi = new Label();
            label2 = new Label();
            lblSoyadi = new Label();
            btnBoxing = new Button();
            label3 = new Label();
            cmbCinsiyet = new ComboBox();
            SuspendLayout();
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.ItemHeight = 15;
            lstOgrenciler.Location = new Point(37, 12);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(120, 154);
            lstOgrenciler.TabIndex = 0;
            lstOgrenciler.SelectedIndexChanged += lstOgrenciler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 13);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(246, 13);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(12, 15);
            lblAdi.TabIndex = 2;
            lblAdi.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 38);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "SoyAdı";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Location = new Point(246, 38);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(12, 15);
            lblSoyadi.TabIndex = 4;
            lblSoyadi.Text = "-";
            // 
            // btnBoxing
            // 
            btnBoxing.Location = new Point(208, 199);
            btnBoxing.Name = "btnBoxing";
            btnBoxing.Size = new Size(163, 45);
            btnBoxing.TabIndex = 5;
            btnBoxing.Text = "Boxing - Unboxing";
            btnBoxing.UseVisualStyleBackColor = true;
            btnBoxing.Click += btnBoxing_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 64);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Enabled = false;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(246, 61);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(121, 23);
            cmbCinsiyet.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 256);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label3);
            Controls.Add(btnBoxing);
            Controls.Add(lblSoyadi);
            Controls.Add(label2);
            Controls.Add(lblAdi);
            Controls.Add(label1);
            Controls.Add(lstOgrenciler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOgrenciler;
        private Label label1;
        private Label lblAdi;
        private Label label2;
        private Label lblSoyadi;
        private Button btnBoxing;
        private Label label3;
        private ComboBox cmbCinsiyet;
    }
}
