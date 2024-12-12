namespace _1_Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonu_Click(object sender, EventArgs e)
        {

            // hatalar
            // derlenme veya syntax hataları (kodu düzelterek çözülür)
            // mantıksal (debug modda break point ile çalışarak çözülür)
            // runtime hataları (try-catch blokları ile yönetilebilir)

            // runtime hatlarında uygulama eğer tedbir alınmazsa durur.. uygulamın durması yerine hata yönetilerek uygulamanın çalışması sağlanmalıdır. hatalar try-catch blokları ile yönetilir...

            /*
                    try
                    {
                            
                    }
                    catch{
            
                    }
            
                    try bloğunda oluşan hata catch bloğunda yakalanır...

            // hata olabilecek satırları try bloğuna yazmamız gerekir...


             */

            MessageBox.Show("Test"); // buu kod hata vermez
            int z = 4; // bu kod hata vermez...
            int y = Convert.ToInt32("44");

            // aşağıdaki kod satırının hata verme ihtimalleri;
            // 1. kullanıcı sayı yerine text girebilir veya hiç bir veri girmeden işlem yapmaya çalışabilir...
            // 2. kullanıcı int'in alabileceği değerden büyük bir değer girebilir...


            // Exception sınıfı => runtime oluşan hatalar hakkında exception sınıfı veya exception sınıfından türeyen exception sınıfları kullanılabilir....Bazı exception sınıfları;

            // FormatException
            // OverflowException
            // IndexOutOfRangeException

            // c# dilinde oluşabilecek bütün hatalar için bir exception sınıfı vardır....

            // Exception sınıfın Message özelliği ile hata detayı alınabilir. 

            // catch bloğunda ilgili exception sınıfı kullanılırsa ilgili exception'i yakalar diğer exceptionları yakalamaz. bu yüzden birden fazla catch bloğu yazılabilir...

            try
            {
                int a = Convert.ToInt32(txtKonu.Text); // olası hata kodu
            }
            catch (FormatException ex) //sadece format exceptionları yakalar
            {
                // hatanın yakalandığı blok
                MessageBox.Show($"Sadece Sayısal değer girebilirsiniz {ex.Message}", "ERROR");
                // hata loglanır (dosya, veritabanı vb..)
            }
            catch (OverflowException ex) // sadece taşma hataları yakalar...
            {
                MessageBox.Show($"Sadece {int.MinValue} ile {int.MaxValue} arası değer girebilirsiniz", "UYARI");
            }

        }

        private void btnKonu2_Click(object sender, EventArgs e)
        {
            // catch bloğu hatayı yakaladıktan sonra hata satırının altındaki kodlar çalıştırılmaz çünkü catch bloğu devreye girer...

            try
            {
                int x = Convert.ToInt32(txtKonu.Text);
                MessageBox.Show("Veri dönüştürüldü...");
            }
            catch (Exception ex) // bütün exceptionları yakalar...
            {
                MessageBox.Show("HATASIZ KUL OLMAX");
            }
            finally
            {
                // hata olsun olmasın çalışacak kod bloğudur... try bloğıundan veya catch bloğundan sonra kod çalıştırılacağı için finally bloğu tercih edilmez....
            }


            try
            {
                if (4 > 1)
                    //throw new OverflowException("\"4 Büyükten 1 olamaz");
                    throw new CustomException("4 Büyükten 1 olamaz");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}