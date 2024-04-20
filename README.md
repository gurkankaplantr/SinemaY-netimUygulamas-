Sinema Bileti Rezervasyon Uygulaması
Proje Adı: Sinema Yönetim Rezervasyon Uygulaması
Amaç: Sinema bileti rezervasyon bilgilerini SQLite veritabanı dosyasına kaydetme projesi.
Teknolojiler ve Gereksinimler:
Visual Studio 2022:
Proje, Visual Studio 2022 IDE'si kullanılarak geliştirilmiştir.
.NET SDK 8:
Projeyi derlemek ve çalıştırmak için .NET SDK 8 gereklidir.
Microsoft.EntityFrameworkCore.Sqlite (8.0.4):
Entity Framework ile SQLite veritabanı entegrasyonu için kullanılan NuGet paketidir.
Proje Varlıkları:
DB:
DB.db veritabanını içeren klasördür.
Models:
Film.cs, Salon.cs ve Seans.cs adlı dosyaları içeren klasördür.
Veritabanı Yapısı:
Filmler:
Filmlerin bilgilerini tutar.
Salonlar:
Sinema salonlarının bilgilerini tutar.
Seanslar:
Film seanslarının bilgilerini tutar.
Proje Dosyaları:
Film.cs:
Film veritabanı modelini oluşturan sınıftır.
Salon.cs:
Sinema salonu veritabanı modelini oluşturan sınıftır.
Seanslar.cs:
Seans veritabanı modelini oluşturan sınıftır.
DBContext.cs:
DbContext sınıfını miras alan sınıftır. DbSet ve modelBuilder nesneleri için oluşturulmuştur.
Nasıl Çalışır:
Uygulamayı başlatın.
Ana sayfadaki sekme seçeneklerinden birine tıklayarak işlem yapın.
İlgili sayfada, gerekli bilgileri girin ve "Save" düğmesine tıklayarak verileri kaydedin.
Kaydedilen veriler ilgili tablolarda listelenecektir.
Önemli Notlar:
Eğer seçilen koltuk numarası rezerve edilmişse tekrardan boş koltuk listelenmesinde gözükmez.
Veritabanı dosyasının DB\DB.db olarak belirli bir konumda olması gerekmektedir.
Verilerin kaydedilmesi veya listelenmesi sırasında oluşabilecek hatalar kullanıcıya MessageBox nesnesi aracılığıyla bildirilecektir.

