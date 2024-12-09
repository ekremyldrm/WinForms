namespace FirstApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Ödev : Kullanıcı en fazla 3 kez şifreyi hatalı girebilir. 4 kez girildiğinde formu kapatın.. Form kapatma komutu this.Close();
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "123")
            {
                frmAna frm = new frmAna();
                frm.ShowDialog(); // formu göster
            }
            else
            {
                MessageBox.Show("Hatalı Yada Eksik Bilgi!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}