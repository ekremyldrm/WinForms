namespace FirstApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // control sürüklenip bırakıldığında control adının sonuna rrakam ekleyerek nesne adı oluşturulur... bu visual studio'nın varsayılan yaklaşımıdır... 
        // control'ün eventlarından herhangi biri tetiklendiğimde controladi_eventAdi ismiyle bir metot oluşturulur ve eventa atanır...Buda visual studionun default yaklaşımıdır. 
        // event metodu oluşturulduktan sonra control adının değişmesi default metot oluşturma yaklaşımındaki durumu değiştirmez...
        private void button1_Click(object sender, EventArgs e)
        {
            txtSayi.Text += btn1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSayi.Text += button2.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtSayi.Text += button11.Text;
        }

        // yukarıdaki gibi her bir controlün eventi için metot tanımlamaktansa ortak bir metot tanımlayıp controlleirn eventlarinda çağıralım...

        private void Yaz(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtSayi.Text += btn.Text;

        }
    }
}
