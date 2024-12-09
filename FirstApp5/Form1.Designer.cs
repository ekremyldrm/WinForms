namespace FirstApp5
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
            lstIsimler = new ListBox();
            cmbIsimler = new ComboBox();
            SuspendLayout();
            // 
            // lstIsimler
            // 
            lstIsimler.FormattingEnabled = true;
            lstIsimler.ItemHeight = 15;
            lstIsimler.Location = new Point(20, 11);
            lstIsimler.Name = "lstIsimler";
            lstIsimler.Size = new Size(110, 154);
            lstIsimler.TabIndex = 0;
            lstIsimler.SelectedIndexChanged += lstIsimler_SelectedIndexChanged;
            // 
            // cmbIsimler
            // 
            cmbIsimler.FormattingEnabled = true;
            cmbIsimler.Location = new Point(186, 12);
            cmbIsimler.Name = "cmbIsimler";
            cmbIsimler.Size = new Size(107, 23);
            cmbIsimler.TabIndex = 1;
            cmbIsimler.SelectedIndexChanged += cmbIsimler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 301);
            Controls.Add(cmbIsimler);
            Controls.Add(lstIsimler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstIsimler;
        private ComboBox cmbIsimler;
    }
}
