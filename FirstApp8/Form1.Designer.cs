namespace FirstApp8
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
            lblSonuc = new Label();
            label2 = new Label();
            cmbAy = new ComboBox();
            cmbYil = new ComboBox();
            cmbGun = new ComboBox();
            SuspendLayout();
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(140, 59);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(12, 15);
            lblSonuc.TabIndex = 14;
            lblSonuc.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 13;
            label2.Text = "Seçilen Tarih";
            // 
            // cmbAy
            // 
            cmbAy.FormattingEnabled = true;
            cmbAy.Location = new Point(161, 12);
            cmbAy.Name = "cmbAy";
            cmbAy.Size = new Size(121, 23);
            cmbAy.TabIndex = 12;
            cmbAy.SelectedIndexChanged += SelectedDateChange;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Location = new Point(34, 12);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(121, 23);
            cmbYil.TabIndex = 11;
            cmbYil.SelectedIndexChanged += SelectedDateChange;
            // 
            // cmbGun
            // 
            cmbGun.FormattingEnabled = true;
            cmbGun.Location = new Point(288, 12);
            cmbGun.Name = "cmbGun";
            cmbGun.Size = new Size(121, 23);
            cmbGun.TabIndex = 10;
            cmbGun.SelectedIndexChanged += SelectedDateChange;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 182);
            Controls.Add(lblSonuc);
            Controls.Add(label2);
            Controls.Add(cmbAy);
            Controls.Add(cmbYil);
            Controls.Add(cmbGun);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSonuc;
        private Label label2;
        private ComboBox cmbAy;
        private ComboBox cmbYil;
        private ComboBox cmbGun;
    }
}
