Dinamik Chart Uygulamas�

Bu proje, kullan�c�lar�n farkl� veritabanlar�na ba�lanarak se�tikleri veri setlerini dinamik olarak grafikler �eklinde g�rselle�tirebilecekleri bir uygulamad�r. Uygulama, .NET Core tabanl� bir web API ve Chart.js k�t�phanesini kullanan bir frontend aray�z� i�ermektedir.

�zellikler
Veritaban� Ba�lant�s�: Kullan�c�lar, dinamik olarak veritaban� bilgilerini girerek bir veritaban�na ba�lanabilir.
Tablo ve Kolon Se�imi: Ba�lant� sa�land�ktan sonra, kullan�c�lar veritaban�ndaki tablolar� ve kolonlar� se�ebilir.
Grafik Olu�turma: Se�ilen verilere g�re farkl� grafik t�rleri (�izgi grafi�i, �ubuk grafi�i, radar grafi�i vb.) olu�turulabilir.
Esnek Veri Se�imi: Kullan�c�lar, birden fazla kolonu se�erek iki boyutlu grafikler olu�turabilir.
Teknolojiler
Backend: ASP.NET Core, C#
Frontend: HTML, CSS, JavaScript, jQuery, Chart.js, Bootstrap
Veritaban�: PostgreSQL 

Gereksinimler
.NET Core SDK (3.1 veya �zeri)
Visual Studio 2019/2022 veya Visual Studio Code
Node.js (Frontend i�in gerekli olabilir)
PostgreSQL veritaban� sunucusu
Ad�mlar
Projeyi klonlad�ktan sonra, appsettings.json dosyas�ndaki veritaban� ayarlar�n� kendi ortam�n�za g�re yap�land�r�n.
Terminal veya komut sat�r� �zerinden backend i�in ba��ml�l�klar� y�kleyin:
dotnet restore
Backend uygulamas�n� ba�lat�n:
dotnet run
Frontend dosyalar�n� sunucunuzda �al��t�rmak i�in wwwroot klas�r�ne kopyalay�n veya bir web sunucusu kullanarak a��n.
Kullan�m
Uygulamay� �al��t�r�n.
Veritaban� ba�lant� bilgilerinizi giri� formuna doldurun ve "Ba�lan" butonuna t�klay�n.
Ba�land�ktan sonra tablo ve kolonlar� se�in.
�stedi�iniz grafik t�r�n� se�erek "Grafik Olu�tur" butonuna t�klay�n.
Se�ilen verilere g�re grafikler sayfada g�r�nt�lenecektir.
