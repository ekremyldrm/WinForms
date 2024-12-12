namespace FirstApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Ogrenci o1 = new Ogrenci();
            o1.Adi = "Emine";
            o1.SoyAdi = "Demir";
            o1.Cinsiyet = "Kadın";
            o1.Memleket = "İzmir";
            o1.Yas = 18;

            Ogrenci o2 = new Ogrenci();
            o2.Adi = "Eren";
            o2.SoyAdi = "Mamurer";
            o2.Cinsiyet = "Erkek";
            o2.Memleket = "Çanakkale";
            o2.Yas = 25;
            ogrencis[0] = o1;
            ogrencis[1] = o2;
        }
        Ogrenci[] ogrencis = new Ogrenci[2];

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Ogrenci o in ogrencis)
            {
                lstOgrenciler.Items.Add(o); // boxing
            }

            string[] cinsiyet = { "Kadın", "Erkek" };
            
            foreach (string c in cinsiyet)
            {
                cmbCinsiyet.Items.Add(c);
            }
  
            // Seçilen öğrencinin bilgilerini ekranda gösteriniz. Adı için örnek tasarım yapıldı. BU gösterime işlemini listbox'in selectedIndexChanged eventinda gerçekleştiriniz...
            //
            //


            // bir sınıfın içerisinde tanımlamalar sınıf seviyesinde yapılır..
            // sınıf seviyesinde sadece tanımlama (değişken, property, metot) yapılabilir. kod bloğu (if, loop, vs. vs..) yazılamaz değişkene değer atanamaz...

            // sınıf seviyesine üye sadece tanımlanabilir fakat erişelemez...
        }

        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstOgrenciler.Items[0].ToString());

            // unboxing
            Ogrenci ogr = (Ogrenci)lstOgrenciler.SelectedItem;
            lblAdi.Text = ogr.Adi;
            lblSoyadi.Text = ogr.SoyAdi;

            cmbCinsiyet.Text = ogr.Cinsiyet;
        }

        private void btnBoxing_Click(object sender, EventArgs e)
        {
            int b = 5;
            byte a = 2;
            b = a;

            // type casting işlemi ortak tipler arasında büyük tipden küçük tipe dönüşüm işlemidir...
            a = (byte)b;

            // object sınıfı c# dilinde bütün tiplerin atasıdır. yani bütün türler objectten türemiştir..

            // aşağıdaki atama işlemine boxing(kutuluma) işlemi diyoruz...

            object o1 = "EKREM";
            object o2 = 5;
            object o3 = false;
            object o4 = new Ogrenci();

            // eğer objectten dönüşüm yapılıyorsa casting olarak bildiğimiz dönüşümün adı unboxing'tir.
            int l = (int)o2; // casting
            string k = (string)o1;
            bool j = (bool)o3;
            Ogrenci h = (Ogrenci)o4;
            object x = 3, y = 4;

            object z = (int)x + (int)y; // casting

        }
    }
}
// Code Behind. Buraya designdan geçmenin kısa yolu f7 tuşudur. yada desing'a sağ click yapıp view code seçeneğinden geçebilirsiniz...


