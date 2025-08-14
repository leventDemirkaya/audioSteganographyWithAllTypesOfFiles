# 🎵 Audio Steganography - Ses Dosyalarına Gizli Mesaj Gömme

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![License: MIT](https://img.shields.io/badge/License-MIT-green)

> ✨ **Açıklama:**  
> Bu proje, **C# .NET** kullanarak **LSB (Least Significant Bit)** yöntemiyle **.wav** formatındaki ses dosyalarına gizli metin, resim ve video gibi çeşitli dosya türlerini gömme işlemini gerçekleştirir.  
> Ses dosyalarının orijinal kalitesi korunarak, mesajlar güvenli ve görünmez şekilde saklanır.

## 📑 İçindekiler  
- [📜 Proje Hakkında](#proje-hakkinda)  
- [⚡ Özellikler](#ozellikler)  
- [🧩 Algoritma Özeti](#algoritma-özeti)  
- [⚙️ Kurulum ve Kullanım](#kurulum-ve-kullanim)  
- [📊 Örnek Çıktı](#ornek-cikti)  
- [🛠 Teknolojiler](#teknolojiler)  
- [🤝 Katkıda Bulunma](#katkida-bulunma)  
- [📄 Lisans](#lisans)  
- [📬 İletişim](#iletisim)

<a id="proje-hakkinda"></a>
## 📜 Proje Hakkında  
Audio Steganography, ses dosyalarının en düşük anlamlı bitlerini kullanarak gizli mesajların saklanmasını sağlayan bir tekniktir.  

Bu proje:  
- 🎙️ .wav formatındaki ses dosyalarını işler  
- 🔍 Gizlenecek metin, resim ve video gibi farklı dosya türlerini binary formata dönüştürür  
- 🌿 Fibonacci dizisi kullanarak mesajı ses verisine gömer  
- 🔊 Orijinal ses kalitesini korur  
- 📂 Gizlenmiş mesajı içeren yeni ses dosyası oluşturur

<a id="ozellikler"></a>
## ⚡ Özellikler  
✅ LSB yöntemi ile güvenli mesaj gizleme  
✅ Metin, resim ve video dosyalarını gömme desteği  
✅ Fibonacci dizisi ile bitlerin yerleştirilmesi  
✅ Türkçe karakter kontrolü  
✅ Orijinal ve gizlenmiş ses dosyalarının yönetimi  
✅ Kullanıcı dostu Windows Forms arayüzü

<a id="algoritma-özeti"></a>
## 🧩 Algoritma Özeti  
1. Ses dosyası byte dizisine dönüştürülür ve binary formata çevrilir.  
2. Gizlenecek dosya türüne göre (metin, resim, video) içerik binary hale getirilir.  
3. Fibonacci dizisi kullanılarak, mesaj bitleri ses dosyasının belirli bitlerine gömülür.  
4. Değiştirilen binary veriler tekrar byte dizisine çevrilir.  
5. Yeni .wav dosyası oluşturulur ve gizlenmiş mesaj oynatıcıda dinlenebilir.  
6. Gizlenen mesaj, ses dosyasından okunarak doğrulanabilir.

<a id="kurulum-ve-kullanim"></a>
## ⚙️ Kurulum ve Kullanım  
1. 📥 Projeyi klonlayın:  
   ```bash
   git clone https://github.com/leventDemirkaya/audio-steganography.git
   cd audio-steganography
2. 💻 Projeyi Visual Studio veya dotnet CLI ile açın ve çalıştırın.
3. 🎵 Program arayüzünden .wav dosyası seçin, gizlenecek metin, resim veya video dosyasını seçin ve mesajı gömün.
4. 🔊 Oluşan yeni ses dosyasını dinleyerek veya mesajı çıkararak doğrulayabilirsiniz.

<a id="ornek-cikti"></a>
## 📊 Örnek Çıktı
### 🎙️ Seçilen Ses Dosyası
example.wav

### 📝 Gizlenecek Mesaj
Merhaba, bu gizli bir mesajdır.

### 🔢 Binary Mesaj Parçaları
01001101 01100101 01110010 01101000 01100001 01100010 01100001 ...

### 🎧 Oluşan Gizlenmiş Ses Dosyası
gizlenen1.wav

### 📬 Çıkarılan Mesaj
Merhaba, bu gizli bir mesajdır.

<a id="teknolojiler"></a>
## 🛠 Teknolojiler
- 💻 C#
- 🖥 .NET Framework / .NET 6.0
- 🎨 Windows Forms
- 🎵 NAudio kütüphanesi

<a id="katkida-bulunma"></a>
## 🤝 Katkıda Bulunma
💡 Katkılarınız çok değerlidir!
- 🐛 Hata bildirmek için Issues sekmesini kullanabilirsiniz.
- 🚀 Geliştirme önerileri için Pull Request açabilirsiniz.

<a id="lisans"></a>  
## 📄 Lisans
📝 Bu proje MIT Lisansı ile korunmaktadır. Detaylar için LICENSE dosyasına bakabilirsiniz.

<a id="iletisim"></a>  
## 📬 İletişim
📧 leventdemirkaya@outlook.com
