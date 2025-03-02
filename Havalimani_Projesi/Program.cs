namespace Havalimani_Projesi
{
    internal class Program
    {

        // Business ve Economy class için koltuk dizileri
        static string[] business = { "", "", "", "", "", "", "", "" };
        static string[] economy = { "", "", "", "", "", "", "", "", "", "", "", "" };

        // Kullanıcı seçimleri ve sayaç değişkenleri
        static int koltuksecim, businesssayac = 0, economysayac = 0;
        static string isim, tus;

        static void Main(string[] args)
        {
            AnaMenu(); // Ana menüyü göster
            IsimAl(); // Kullanıcıdan isim al
            KoltukKontrol(); // Mevcut koltuk durumlarını kontrol et
            Rezervasyon(); // Kullanıcıya koltuk seçimi yaptır
            Main(null); // Programı döngüye sokarak tekrar başlat
        }

        private static void Rezervasyon()
        {
            try
            {
                Console.WriteLine("Istediğiniz koltuğu seçin:");
                koltuksecim = Convert.ToInt32(Console.ReadLine()) - 1; // Kullanıcının girdiği değeri diziye uyarlamak için 1 azaltıyoruz.

                if (tus == "1") // Business class seçildiyse
                {
                    if (business[koltuksecim] == "") // Koltuk boşsa
                    {
                        business[koltuksecim] = isim; // Kullanıcının ismini koltuğa atıyoruz
                        businesssayac++; // Dolu koltuk sayısını artırıyoruz
                    }
                    else // Koltuk doluysa
                    {
                        Console.WriteLine($"{koltuksecim + 1}. koltuk daha önce {business[koltuksecim]} tarafından rezerve edilmiştir.");
                        Rezervasyon(); // Kullanıcıya tekrar seçim yaptır
                    }
                    Console.WriteLine($"{koltuksecim + 1}. koltuk {business[koltuksecim]} tarafından rezerve edilmiştir");
                }
                else // Economy class seçildiyse
                {
                    if (economy[koltuksecim] == "")
                    {
                        economy[koltuksecim] = isim;
                        economysayac++;
                    }
                    else
                    {
                        Console.WriteLine($"{koltuksecim + 1}. koltuk daha önce {economy[koltuksecim]} tarafından rezerve edilmiştir.");
                        Rezervasyon();
                    }
                    Console.WriteLine($"{koltuksecim + 1}. koltuk {economy[koltuksecim]} tarafından rezerve edilmiştir");
                }
                KoltukKontrol(); // Koltukların güncel durumunu ekrana yazdır
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Olmayan koltuk seçimi yaptınız.");
                Rezervasyon();
            }
            catch (Exception)
            {
                Console.WriteLine("Koltuk numarasını doğru formatta girmediniz.");
                Rezervasyon();
            }
        }

        private static void KoltukKontrol()
        {
            if (tus == "1") BusinessKoltukKontrol(); // Business koltuklarını kontrol et
            else EconomyKoltukKontrol(); // Economy koltuklarını kontrol et
        }

        private static void BusinessKoltukKontrol()
        {
            for (int i = 0; i < business.Length; i++)
            {
                Console.WriteLine(business[i] == "" ? $"{i + 1}. koltuk boş" : $"{i + 1}. koltuk {business[i]} tarafından dolu");
            }
            Console.WriteLine(businesssayac == business.Length ? "Business Uçuşumuz dolmuştur" : "Yerimiz vardır.");
        }

        private static void EconomyKoltukKontrol()
        {
            for (int i = 0; i < economy.Length; i++)
            {
                Console.WriteLine(economy[i] == "" ? $"{i + 1}. koltuk boş" : $"{i + 1}. koltuk {economy[i]} tarafından dolu");
            }
            Console.WriteLine(economysayac == economy.Length ? "Economy Uçuşumuz dolmuştur" : "Yerimiz vardır.");
        }

        private static void AnaMenu()
        {
            Console.WriteLine("*****************Ataturk HavaYollarına Hoş Geldiniz**************");
            if (economy.Length != economysayac && business.Length != businesssayac)
            {
                Console.WriteLine("1. Business Class için 1 tuşuna basınız.");
                Console.WriteLine("2. Economy Class için 2 tuşuna basınız.");
            }
            else if (economy.Length == economysayac && business.Length != businesssayac)
            {
                Console.WriteLine("1. Business Class için 1 tuşuna basınız.");
            }
            else if (economy.Length != economysayac && business.Length == businesssayac)
            {
                Console.WriteLine("2. Economy Class için 2 tuşuna basınız.");
            }
            else
            {
                Console.WriteLine("Tüm uçuşlarımız dolmuştur. İlginiz için teşekkürler..");
                Cikis();
            }

            tus = Console.ReadLine();
            switch (tus)
            {
                case "1": break;
                case "2": break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçim giriniz.");
                    AnaMenu();
                    break;
            }
        }

        static void IsimAl()
        {
            Console.WriteLine("Adınızı giriniz: ");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                if (char.IsDigit(isim[i]))
                {
                    Console.WriteLine("Isim sayısal karakter içermemelidir.");
                    IsimAl();
                }
            }
        }

        private static void Cikis()
        {
            Console.WriteLine("Seçilecek koltuk kalmamıştır. Programdan çıkmak için 'exit' yazınız.");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "exit") Environment.Exit(0);
        }
    }
}

