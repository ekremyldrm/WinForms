namespace FirstApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        bool flag;
        private void btnSayac_Click(object sender, EventArgs e)
        {
            if (sayac == 10)
                flag = false;

            if (sayac == 0)
                flag = true;

            if (flag)
                sayac++;
            else
                sayac--;

            btnSayac.Text = Convert.ToString(sayac);
        }
    }
}
