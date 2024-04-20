using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SinemaRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan film adını al
            string filmAdi = textBox1.Text;

            // Eğer film adı boş değilse
            if (!string.IsNullOrEmpty(filmAdi))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Film adını veritabanına kaydetmek için yeni bir Film oluştur
                        Film film = new Film
                        {
                            FilmAdi = filmAdi
                        };

                        // Film nesnesini veritabanına ekleyin
                        context.Filmler.Add(film);
                        context.SaveChanges();

                        MessageBox.Show("Film adı başarıyla kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Film adı kaydedilirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Boş bir film adı girildiğinde kullanıcıyı uyar
                MessageBox.Show("Lütfen bir film adı girin.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen saati al
            string secilenSaatString = comboBoxFİLMSAATİ.SelectedItem?.ToString();

            // Eğer seçilen bir saat varsa
            if (!string.IsNullOrEmpty(secilenSaatString))
            {
                // Seçilen saati belirli bir tarih-saat formatına dönüştürmek için DateTime.TryParseExact kullanın
                DateTime secilenSaat;
                string[] saatFormatlari = { "HH:mm", "h:mm tt" }; // Saat formatlarını belirtin (24 saat ve 12 saat formatları)
                if (DateTime.TryParseExact(secilenSaatString, saatFormatlari, null, System.Globalization.DateTimeStyles.None, out secilenSaat))
                {
                    // Başarılı bir şekilde dönüştürüldü, secilenSaat artık bir DateTime nesnesi olarak tutuluyor
                    // İşlemlerinizi burada gerçekleştirin
                }
                else
                {
                    // Saat formatı uygun değilse, kullanıcıya uyarı verin veya hata işleyin
                    MessageBox.Show("Lütfen geçerli bir saat formatı seçin.");
                }
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen salon kapasitesini al
            string kapasiteText = comboBox3.SelectedItem?.ToString();

            // Seçilen kapasite boş değilse ve bir sayıya dönüştürülebiliyorsa
            if (!string.IsNullOrEmpty(kapasiteText) && int.TryParse(kapasiteText, out int kapasite))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // ComboBox'tan seçilen salonun adını al
                        string salonAdi = textBoxSALONADI.Text;

                        // Veritabanından seçilen salona ait kaydı bul
                        var salon = context.Salonlar.FirstOrDefault(s => s.SalonAdi == salonAdi);

                        // Eğer salon bulunduysa
                        if (salon != null)
                        {
                            // Salonun koltuk kapasitesini güncelle
                            salon.KoltukKapasitesi = kapasite;

                            // Değişiklikleri veritabanına kaydet
                            context.SaveChanges();

                            MessageBox.Show("Salon kapasitesi başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Seçilen salon bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Salon kapasitesi güncellenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Seçilen kapasite geçerli değilse veya boşsa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir kapasite seçin.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'tan film adını al
            string filmAdi = textBoxFİLMADI.Text;

            // ComboBox'tan seçilen saati al
            string secilenSaat = comboBoxFİLMSAATİ.SelectedItem?.ToString();

            // Eğer gerekli alanlar doluysa
            if (!string.IsNullOrEmpty(filmAdi) && !string.IsNullOrEmpty(secilenSaat))
            {
                // Burada film adı ve seçilen saat ile yapılacak işlemi gerçekleştirin
                // Örneğin, bir kayıt oluşturabilir veya başka bir işlem yapabilirsiniz

                // Ardından, kullanıcıya işlemin başarıyla tamamlandığını bildirin
                MessageBox.Show("Film başarıyla eklendi ve kaydedildi!");
            }
            else
            {
                // Kullanıcıya gerekli alanların doldurulması gerektiğini bildirin
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Salon adını ve kapasitesini al
            string salonAdi = textBoxSALONADI.Text;
            int kapasite = int.Parse(comboBoxSALONKAPASİTESİ.SelectedItem.ToString());

            // Veritabanı bağlantısını oluştur
            using (ApplicationContext context = new ApplicationContext())
            {
                // Yeni bir Salon nesnesi oluştur
                Salon yeniSalon = new Salon
                {
                    SalonAdi = salonAdi,
                    Kapasite = kapasite
                };

                // Salon nesnesini veritabanına ekleyerek kaydet
                context.Salonlar.Add(yeniSalon);
                context.SaveChanges();
            }

            // Kullanıcıya bilgi ver
            MessageBox.Show("Salon başarıyla eklendi.");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // TextBox'lardan kullanıcının girdiği bilgileri al
            string filmAdi = textBoxFİLMADI.Text;
            string salonAdi = textBoxSALONADI.Text;
            string seansSaat = comboBoxSEÇİLENSAAT.SelectedItem?.ToString();
            string kullaniciAdi = textBoxADI.Text;
            string kullaniciSoyadi = textBoxSOYADI.Text;
            string telefonNumarasi = textBoxTELNO.Text;
            string biletNo = textBoxBİLETNO.Text;
            string koltukNumarasi = textBoxSEÇİLENKOLTUKNO.Text;

            // Veritabanına erişim için bir ApplicationContext oluştur
            using (ApplicationContext context = new ApplicationContext())
            {
                try
                {
                    // Film, salon ve seans bilgilerini veritabanına eklemek için gerekli kodu buraya ekleyin

                    // Film eklemek
                    Film film = new Film { FilmAdi = filmAdi };
                    context.Filmler.Add(film);

                    // Salon eklemek
                    Salon salon = new Salon { SalonAdi = salonAdi, Kapasite = salonKapasitesi };
                    context.Salonlar.Add(salon);

                    // Seans eklemek
                    Seans seans = new Seans { SecilenSaat = seansSaat, FilmId = film.Id, SalonId = salon.Id };
                    context.Seanslar.Add(seans);

                    // Kullanıcı bilgilerini ve bilet bilgilerini de ekleyin

                    // Bilet eklemek
                    Bilet bilet = new Bilet { BiletNo = biletNo, KullaniciAdi = kullaniciAdi, KullaniciSoyadi = kullaniciSoyadi, TelefonNumarasi = telefonNumarasi, KoltukNumarasi = koltukNumarasi };
                    context.Biletler.Add(bilet);

                    // Değişiklikleri kaydet
                    context.SaveChanges();


                    // Kayıt başarılıysa kullanıcıya mesaj göster
                    MessageBox.Show("Bilgiler başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya mesaj göster
                    MessageBox.Show("Bilgiler kaydedilirken bir hata oluştu: " + ex.Message);
                }
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSALONADI_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan alınan salon adını ComboBox'a ekleyin
            string salonAdi = textBoxSALONADI.Text;
            if (!string.IsNullOrEmpty(salonAdi))
            {
                // Eğer salon adı daha önceden ComboBox'ta yoksa ekle
                if (!comboBoxhangiSALONDA.Items.Contains(salonAdi))
                {
                    comboBoxhangiSALONDA.Items.Add(salonAdi);
                }
            }
        }

        private void comboBoxhangiSALONDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen salon adını al
            string salonAdi = comboBoxhangiSALONDA.SelectedItem?.ToString();

            // Eğer seçilen salon adı boş değilse
            if (!string.IsNullOrEmpty(salonAdi))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Salon adını veritabanına kaydetmek için yeni bir Salon oluştur
                        Salon salon = new Salon
                        {
                            SalonAdi = salonAdi
                        };

                        // Salon nesnesini veritabanına ekleyin
                        context.Salonlar.Add(salon);
                        context.SaveChanges();

                        MessageBox.Show("Salon adı başarıyla kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Salon adı kaydedilirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Boş bir salon adı seçildiğinde kullanıcıyı uyar
                MessageBox.Show("Lütfen bir salon adı seçin.");
            }
        }



        private void textBoxADI_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan kullanıcının adını al
            string kullaniciAdi = textBoxADI.Text;
        }

        private void textBoxSOYADI_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan kullanıcının soyadını al
            string kullaniciSoyadi = textBoxSOYADI.Text;
        }

        private void textBoxTELNO_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan kullanıcının telefon numarasını al
            string telefonNumarasi = textBoxTELNO.Text;
        }

        private void textBoxBİLETNO_TextChanged(object sender, EventArgs e)
        {
            // Bilet numarası için rastgele bir değer oluştur
            string biletNo = GenerateRandomBiletNo();

            // TextBox'a rastgele bilet numarasını yaz
            textBoxBİLETNO.Text = biletNo;
        }

        private string GenerateRandomBiletNo()
        {
            // Rastgele bilet numarası oluşturmak için bir Random nesnesi oluştur
            Random random = new Random();

            // Bilet numarasını oluşturmak için rastgele bir tamsayı kullan
            int randomNumber = random.Next(100000, 999999);

            // Oluşturulan rastgele numarayı bir stringe dönüştür ve geri döndür
            return randomNumber.ToString();
        }


        private void textBoxSEÇİLENKOLTUKNO_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan koltuk numarasını al
            string koltukNumarasi = textBoxSEÇİLENKOLTUKNO.Text;

            // Koltuk numarasının dolu olup olmadığını kontrol etmek için bir işlev çağır
            bool koltukDolu = KoltukDoluMu(koltukNumarasi);

            // Koltuk dolu ise
            if (koltukDolu)
            {
                // TextBox'ın arka plan rengini kırmızı yap (veya başka bir görsel işaret kullanabilirsiniz)
                textBoxSEÇİLENKOLTUKNO.BackColor = Color.Red;
            }
            else
            {
                // Koltuk boş ise, TextBox'ın arka plan rengini varsayılan yap
                textBoxSEÇİLENKOLTUKNO.BackColor = SystemColors.Window;
            }
        }

        private bool KoltukDoluMu(string koltukNumarasi)
        {
           
          
            return false; 
        }


        private void comboBoxSEÇİLENFİLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen film adını al
            string secilenFilm = comboBoxSEÇİLENFİLM.SelectedItem?.ToString();

            // Eğer seçilen bir film varsa
            if (!string.IsNullOrEmpty(secilenFilm))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Veritabanından seçilen filmi adına göre bulun
                        Film film = context.Filmler.FirstOrDefault(f => f.FilmAdi == secilenFilm);

                        if (film != null)
                        {
                            // İlgili işlemi buraya ekleyebilirsiniz, örneğin, film adını bir metin kutusuna yazdırabilirsiniz
                            textBoxFİLMADI.Text = film.FilmAdi;
                        }
                        else
                        {
                            MessageBox.Show("Seçilen film bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Film bilgileri alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }


        private void comboBoxSEÇİLENSAAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen film adını al
            string secilenFilm = comboBoxSEÇİLENFİLM.SelectedItem?.ToString();

            // Eğer seçilen bir film varsa
            if (!string.IsNullOrEmpty(secilenFilm))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Seçilen filmin hangi saatlerde gösterildiğini kontrol et
                        var uygunSaatler = context.Seanslar
                                                  .Where(s => s.FilmAdi == secilenFilm)
                                                  .Select(s => s.Saat)
                                                  .Distinct() // Tekrar eden saatleri kaldır
                                                  .ToList();

                        // ComboBox'ı temizle
                        comboBoxSEÇİLENSAAT.Items.Clear();

                        // Uygun saatleri ComboBox'a ekle
                        foreach (var saat in uygunSaatler)
                        {
                            comboBoxSEÇİLENSAAT.Items.Add(saat);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Uygun saatler alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan Film ID'sini al
            string filmIdText = textBox2.Text;

            // Film ID'si boş değilse ve sayısal bir değer ise
            if (!string.IsNullOrEmpty(filmIdText) && int.TryParse(filmIdText, out int filmId))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Film ID'sini veritabanına kaydetmek için yeni bir Film oluştur
                        Film film = new Film
                        {
                            FilmId = filmId
                        };

                        // Film nesnesini veritabanına ekleyin
                        context.Filmler.Add(film);
                        context.SaveChanges();

                        MessageBox.Show("Film ID başarıyla kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Film ID kaydedilirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Geçersiz veya boş bir Film ID girildiğinde kullanıcıyı uyar
                MessageBox.Show("Lütfen geçerli bir Film ID girin.");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // TextBox'tan girilen salon ID'sini al
            string salonIDText = textBox1.Text;

            // Girilen salon ID'si boş değilse ve bir sayıya dönüştürülebiliyorsa
            if (!string.IsNullOrEmpty(salonIDText) && int.TryParse(salonIDText, out int salonID))
            {
                // Veritabanına erişim için bir ApplicationContext oluştur
                using (ApplicationContext context = new ApplicationContext())
                {
                    try
                    {
                        // Veritabanından girilen salon ID'sine sahip salonu bul
                        var salon = context.Salonlar.FirstOrDefault(s => s.SalonID == salonID);

                        // Eğer salon bulunduysa
                        if (salon != null)
                        {
                            // İlgili salonun adını textBoxSALONADI öğesine yükle
                            textBoxSALONADI.Text = salon.SalonAdi;
                        }
                        else
                        {
                            MessageBox.Show("Girilen salon ID'sine sahip salon bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Salon bilgileri alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                // Girilen salon ID'si geçerli değilse veya boşsa, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir salon ID'si girin.");
            }
        }

    }
}
