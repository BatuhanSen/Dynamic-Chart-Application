Dinamik Chart Uygulamasý

Bu proje, kullanýcýlarýn farklý veritabanlarýna baðlanarak seçtikleri veri setlerini dinamik olarak grafikler þeklinde görselleþtirebilecekleri bir uygulamadýr. Uygulama, .NET Core tabanlý bir web API ve Chart.js kütüphanesini kullanan bir frontend arayüzü içermektedir.

Özellikler
Veritabaný Baðlantýsý: Kullanýcýlar, dinamik olarak veritabaný bilgilerini girerek bir veritabanýna baðlanabilir.
Tablo ve Kolon Seçimi: Baðlantý saðlandýktan sonra, kullanýcýlar veritabanýndaki tablolarý ve kolonlarý seçebilir.
Grafik Oluþturma: Seçilen verilere göre farklý grafik türleri (çizgi grafiði, çubuk grafiði, radar grafiði vb.) oluþturulabilir.
Esnek Veri Seçimi: Kullanýcýlar, birden fazla kolonu seçerek iki boyutlu grafikler oluþturabilir.
Teknolojiler
Backend: ASP.NET Core, C#
Frontend: HTML, CSS, JavaScript, jQuery, Chart.js, Bootstrap
Veritabaný: PostgreSQL 

Gereksinimler
.NET Core SDK (3.1 veya üzeri)
Visual Studio 2019/2022 veya Visual Studio Code
Node.js (Frontend için gerekli olabilir)
PostgreSQL veritabaný sunucusu
Adýmlar
Projeyi klonladýktan sonra, appsettings.json dosyasýndaki veritabaný ayarlarýný kendi ortamýnýza göre yapýlandýrýn.
Terminal veya komut satýrý üzerinden backend için baðýmlýlýklarý yükleyin:
dotnet restore
Backend uygulamasýný baþlatýn:
dotnet run
Frontend dosyalarýný sunucunuzda çalýþtýrmak için wwwroot klasörüne kopyalayýn veya bir web sunucusu kullanarak açýn.
Kullaným
Uygulamayý çalýþtýrýn.
Veritabaný baðlantý bilgilerinizi giriþ formuna doldurun ve "Baðlan" butonuna týklayýn.
Baðlandýktan sonra tablo ve kolonlarý seçin.
Ýstediðiniz grafik türünü seçerek "Grafik Oluþtur" butonuna týklayýn.
Seçilen verilere göre grafikler sayfada görüntülenecektir.
