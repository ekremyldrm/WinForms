using System.Security.Cryptography;

namespace FirstApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click_1(object sender, EventArgs e)
        {
            frm = new Form1();
        }

        Form1 frm;
        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show(); // Göster...
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


        }


        void A()
        {

        }
        string myVariable;
        void B()
        {
            myVariable = "1";
        }
    }
}
