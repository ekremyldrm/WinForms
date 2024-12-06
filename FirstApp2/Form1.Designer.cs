namespace FirstApp2
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
            btnSayac = new Button();
            SuspendLayout();
            // 
            // btnSayac
            // 
            btnSayac.Font = new Font("Segoe UI", 50F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSayac.Location = new Point(28, 27);
            btnSayac.Name = "btnSayac";
            btnSayac.Size = new Size(210, 200);
            btnSayac.TabIndex = 0;
            btnSayac.Text = "0";
            btnSayac.UseVisualStyleBackColor = true;
            btnSayac.Click += btnSayac_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 287);
            Controls.Add(btnSayac);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSayac;
    }
}
