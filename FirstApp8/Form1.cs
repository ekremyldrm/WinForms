namespace FirstApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Ay ay1 = new Ay();
            ay1.Text = "Ocak";
            ay1.Value = 1;

            Ay ay2 = new Ay();
            ay2.Text = "Şubat";
            ay2.Value = 2;

            Ay ay3 = new Ay();
            ay3.Text = "Mart";
            ay3.Value = 3;


            Ay ay4 = new Ay();
            ay4.Text = "Nisan";
            ay4.Value = 4;

            Ay ay5 = new Ay();
            ay5.Text = "Mayıs";
            ay5.Value = 5;

            Ay ay6 = new Ay();
            ay6.Text = "Haziran";
            ay6.Value = 6;

            Ay ay7 = new Ay();
            ay7.Text = "Temmuz";
            ay7.Value = 5;

            aylar[0] = ay1;
            aylar[1] = ay2;
            aylar[2] = ay3;
            aylar[3] = ay4;
            aylar[4] = ay5;
            aylar[5] = ay6;
            aylar[6] = ay7;

        }

        Ay[] aylar = new Ay[7];
        private void Form1_Load(object sender, EventArgs e)
        {






            cmbYil.Text = "Seçiniz";
            for (int i = 2024; i > 1970; i--)
            {
                cmbYil.Items.Add(i);
            }

            cmbAy.Text = "Seçiniz";
            foreach (Ay a in aylar)
            {
                cmbAy.Items.Add(a);
            }

            cmbGun.Text = "Seçiniz";
            for (int i = 1; i <= 31; i++)
            {
                cmbGun.Items.Add(i);
            }
        }

        // bu metodu manuel yazıp ilgili dropdownların SelectedIndexChanged eventine maneul yazıyoruz...
        private void SelectedDateChange(object sender, EventArgs e)
        {

            if (cmbYil.SelectedItem == null || cmbAy.SelectedItem == null || cmbGun.SelectedItem == null)
            {
                lblSonuc.Text = "-";
                return;
            }

            // cmbAy controlünün itemları ay nesneleridir. ay nesnelerine selectedItem üzreinden erişebiliriniz..

            Ay ay = (Ay)cmbAy.SelectedItem;


            lblSonuc.Text = $"{cmbYil.SelectedItem} - {ay.Value} -  {cmbGun.SelectedItem}";
        }

    }
}
