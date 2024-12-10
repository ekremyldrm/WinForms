namespace FirstApp6
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
            label1 = new Label();
            button1 = new Button();
            btnSelam = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(139, 15);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.MouseHover += button1_MouseHover;
            // 
            // btnSelam
            // 
            btnSelam.Location = new Point(335, 19);
            btnSelam.Name = "btnSelam";
            btnSelam.Size = new Size(91, 35);
            btnSelam.TabIndex = 2;
            btnSelam.Text = "button2";
            btnSelam.UseVisualStyleBackColor = true;
            btnSelam.Click += btnSelam_Click;
            btnSelam.MouseLeave += btnSelam_MouseLeave;
            btnSelam.MouseHover += btnSelam_MouseHover;
            // 
            // button2
            // 
            button2.Location = new Point(69, 92);
            button2.Name = "button2";
            button2.Size = new Size(124, 30);
            button2.TabIndex = 3;
            button2.Text = "Ekrem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AksamAksam;
            // 
            // button3
            // 
            button3.Location = new Point(200, 90);
            button3.Name = "button3";
            button3.Size = new Size(130, 32);
            button3.TabIndex = 4;
            button3.Text = "Mahmut";
            button3.UseVisualStyleBackColor = true;
            button3.MouseHover += AksamAksam;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSelam);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnSelam;
        private Button button2;
        private Button button3;
    }
}
