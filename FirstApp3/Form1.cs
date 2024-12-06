using System.Linq.Expressions;

namespace FirstApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {

            lblAdi.Text = txtAdi.Text;
        }

        private void btnKaydir_Click(object sender, EventArgs e)
        {
            btnKaydir.Left = btnKaydir.Left + 10;
        }


        double saydam = 1.0;
        bool flag = false;
        private void btnSaydamlastir_Click(object sender, EventArgs e)
        {

            if (saydam == 0.7)
                flag = true;
            if (saydam == 1)
                flag = false;

            if (flag)
                saydam = saydam + 0.1;
            else
                saydam = saydam - 0.1;

            this.Opacity = saydam;

        }
    }
}
