namespace FirstApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label Clicklendi");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Üzerine geldi");
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }

        private void btnSelam_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Üzerime Gelme");
        }

        private void btnSelam_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Gitme Dur!!!");
        }

        private void AksamAksam(object sender, EventArgs e)
        {
            MessageBox.Show("Gördüğünüz gibi ben bir metot...");
        }

       
    }
}
