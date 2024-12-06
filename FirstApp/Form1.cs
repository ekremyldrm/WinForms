namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Forma Tıkladınız");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yüklendi");
        }
    }
}
