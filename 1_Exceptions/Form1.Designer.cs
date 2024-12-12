namespace _1_Exceptions
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
            txtSayi1 = new TextBox();
            btnIslem = new Button();
            txtSayi2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnKonu = new Button();
            txtKonu = new TextBox();
            btnKonu2 = new Button();
            SuspendLayout();
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(64, 12);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(102, 23);
            txtSayi1.TabIndex = 0;
            // 
            // btnIslem
            // 
            btnIslem.Location = new Point(64, 91);
            btnIslem.Name = "btnIslem";
            btnIslem.Size = new Size(102, 23);
            btnIslem.TabIndex = 1;
            btnIslem.Text = "İşlem Yap";
            btnIslem.UseVisualStyleBackColor = true;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(64, 48);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "1. Sayı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "2. Sayı";
            // 
            // btnKonu
            // 
            btnKonu.Location = new Point(257, 219);
            btnKonu.Name = "btnKonu";
            btnKonu.Size = new Size(58, 23);
            btnKonu.TabIndex = 5;
            btnKonu.Text = "Konu";
            btnKonu.UseVisualStyleBackColor = true;
            btnKonu.Click += btnKonu_Click;
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(266, 190);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(100, 23);
            txtKonu.TabIndex = 6;
            // 
            // btnKonu2
            // 
            btnKonu2.Location = new Point(321, 219);
            btnKonu2.Name = "btnKonu2";
            btnKonu2.Size = new Size(64, 23);
            btnKonu2.TabIndex = 7;
            btnKonu2.Text = "kONU 2";
            btnKonu2.UseVisualStyleBackColor = true;
            btnKonu2.Click += btnKonu2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 253);
            Controls.Add(btnKonu2);
            Controls.Add(txtKonu);
            Controls.Add(btnKonu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSayi2);
            Controls.Add(btnIslem);
            Controls.Add(txtSayi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi1;
        private Button btnIslem;
        private TextBox txtSayi2;
        private Label label1;
        private Label label2;
        private Button btnKonu;
        private TextBox txtKonu;
        private Button btnKonu2;
    }
}
