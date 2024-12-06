using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class btakademi : Form
    {
        public btakademi()
        {
            BackColor = Color.White;
            this.Width = 320;
            this.Height = 200;
            this.Text = "Bu bizim ilk formumuz";
            this.StartPosition = FormStartPosition.CenterScreen;

            TextBox txt = new TextBox();
            txt.Width = 150;
            txt.Left = 60;

            Button btn = new Button();
            btn.Text = "Giriş Yap";

            btn.Left = 210;

            this.Controls.Add(txt);
            this.Controls.Add(btn);
        }
    }
}
