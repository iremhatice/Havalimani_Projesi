# Havalimani Projesi

Bu proje, uçak bileti rezervasyon sistemi sağlayan basit bir konsol uygulamasıdır. Kullanıcılar **Business Class** veya **Economy Class** için koltuk seçebilir ve rezervasyonlarını tamamlayabilirler.

## 🚀 Özellikler
- Kullanıcıdan isim alarak koltuk rezervasyonu yapma
- Business ve Economy sınıflarını ayrı ayrı yönetme
- Seçilen koltuğun dolu olup olmadığını kontrol etme
- Tüm koltuklar dolduğunda programdan çıkma
- Yanlış girişlere karşı hata kontrolleri

## 🛠 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

### 1. Depoyu Klonlayın
```sh
git clone https://github.com/kullaniciadi/havalimani-projesi.git
cd havalimani-projesi
```

### 2. Projeyi Çalıştırın
- **Visual Studio** veya **.NET CLI** kullanarak projeyi çalıştırabilirsiniz.

#### **Visual Studio ile Çalıştırma**
1. `Havalimani_Projesi.sln` dosyasını açın.
2. `Program.cs` dosyasını çalıştırın.

#### **.NET CLI ile Çalıştırma**
```sh
dotnet run
```

## 📌 Kullanım
1. Program açıldığında **Business Class** veya **Economy Class** seçimi yapılır.
2. Kullanıcıdan adını girmesi istenir.
3. Kullanıcı boş koltuklardan birini seçerek rezervasyon yapar.
4. Eğer tüm koltuklar doluysa, program "Tüm uçuşlarımız dolmuştur" mesajını göstererek kapanır.
5. Hatalı giriş yapıldığında kullanıcıya tekrar giriş yapma şansı verilir.

## 🛠 Gereksinimler
- .NET Core veya .NET 6+ yüklü olmalıdır.
- Windows, macOS veya Linux üzerinde çalıştırılabilir.


