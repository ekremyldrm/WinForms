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
            lblAdi.Location = new Point(215, 12);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(12, 15);
            lblAdi.TabIndex = 2;
            lblAdi.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 256);
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
    }
}
