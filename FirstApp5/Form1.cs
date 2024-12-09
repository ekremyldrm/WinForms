namespace FirstApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstIsimler.Items.Add("Yiğit");
            lstIsimler.Items.Add("Eren");
            lstIsimler.Items.Add("Veli");

            string[] kisiler = { "Gökberk", "Şimal" };
            for (int i = 0; i < kisiler.Length; i++)
            {
                lstIsimler.Items.Add(kisiler[i]);
            }

            string[] names = { "Emine", "Mahmut" };
            foreach (string name in names)
            {
                lstIsimler.Items.Add(name);
            }

            cmbIsimler.Text = "Yıl Seçiniz";

            for (int i = 2024; i > 1960; i--)
            {
                cmbIsimler.Items.Add(i);
            }

        }
        private void lstIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show($"seni seçtim {lstIsimler.SelectedItem.ToString()}");
        }
        private void cmbIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"yıllardan {cmbIsimler.SelectedItem}");
        }
    }
}
