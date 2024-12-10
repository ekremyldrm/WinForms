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
            

            foreach(Ogrenci o in ogrencis)
            {
                lstOgrenciler.Items.Add(o);
            }

            // Seçilen öğrencinin bilgilerini ekranda gösteriniz. Adı için örnek tasarım yapıldı. BU gösterime işlemini listbox'in selectedIndexChanged eventinda gerçekleştiriniz...
            //
            //
           

        // bir sınıfın içerisinde tanımlamalar sınıf seviyesinde yapılır..
        // sınıf seviyesinde sadece tanımlama (değişken, property, metot) yapılabilir. kod bloğu (if, loop, vs. vs..) yazılamaz değişkene değer atanamaz...

        // sınıf seviyesine üye sadece tanımlanabilir fakat erişelemez...
    }
}

// Code Behind. Buraya designdan geçmenin kısa yolu f7 tuşudur. yada desing'a sağ click yapıp view code seçeneğinden geçebilirsiniz...


