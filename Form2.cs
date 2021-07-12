using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDers1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //TurDonusumleri();
            StringVeDateTimeIslemleri();
        }

        public void StringVeDateTimeIslemleri()
        {
            // string islemleri:
            // senaryo: bir alisveris sonunda musteriye gonderilen banka sms i nin olusturulmasi:
            string isim = "Ahmet Aydin";
            string magaza = "C# Bilgisayar";
            decimal tutar = 234.80m;
            int vade = 12;
            int bonus = 80;
            string sms = string.Empty;

            // 1- yorucu, agir ve kotu bir yontem:
            sms = "Sayin " + isim + ", " + magaza + " magazasindan yapmis oldugunuz " + tutar + "TL alisverisiniz " + vade + " takside bolundu. " + bonus + "tutarinda bonus kazandiniz.";

            // 2- Daha iyi ve hizli bir algoritmaya sahip ancak hala kullanimi zor
            sms = string.Concat("Sayin ", isim, ", ", magaza, " magazasindan yapmis oldugunuz ", tutar, "TL alisverisiniz ", vade, " takside bolundu. ", bonus, "tutarinda bonus kazandiniz.");

            // 3- Gayet hizli, semaya sahip oldugu icin nispeten kullanimi kolay, parametrelerin artmasi ciddi zorluklara sebep olabiliyor.
            sms = string.Format("Sayin {0}, {1} magazasindan yapmis oldugunuz {2}TL alisverisiniz {3} takside bolundu. {4} tutarinda bonus kazandiniz.", isim, magaza, tutar, vade, bonus);

            // 4- (Interpolation - C#6.0) Hizli, kolay ve net. BEST OF...
            sms = $"Sayin {isim}, {magaza} magazasindan yapmis oldugunuz {tutar}TL alisverisiniz {vade} takside bolundu. {bonus} tutarinda bonus kazandiniz.";

            // String cumlemi coklu satirlarda olusturuyor isem:
            StringBuilder smsBuilder = new StringBuilder();
            smsBuilder.Append($"Sayin {isim},");
            // kodlarim
            smsBuilder.Append(magaza);
            smsBuilder.Append($" magazasindan yapmis oldugunuz {tutar}TL alisverisiniz {vade} takside bolundu.");
            // bonus hesaplarim
            smsBuilder.Append($"{bonus} tutarinda bonus kazandiniz.");
            // herseyin sonunda:
            sms = smsBuilder.ToString();
            listBox1.Items.Add(sms);

            // Escape character: \
            sms = "Sayin musterimiz, \"HarcaBank\" kartiniz adresinize gonderilmistir...";
            listBox1.Items.Add(sms);

            // t: tab
            // r: return
            // n: new line (bazi yapilarda sadece alt satira gecmek yetmez, bir de yeni bir satir baslatmak gerekir)
            string dilekce = "\tSayin yetkili,\r\n\tDilekcemin isleme konmasini arz ve rica ederim.\r\r\nM.Emre Tekinsoy";
            //MessageBox.Show(dilekce);

            string dosyaAdresi = "C:\\Users\\FrozenDragon\\source\\repos\\WinDers1";
            dosyaAdresi = @"C:\Users\FrozenDragon\source\repos\WinDers1"; // burada @, C#'a ben bu cumlede hicbir komut kullanmayacagima soz veriyorum.

            string dosyaAdresiMesaji = "Proje dosyaniz asagidaki adrese kaydedilmistir: \r\r\n C:\\Users\\FrozenDragon\\source\\repos\\WinDers1";
            //MessageBox.Show(dosyaAdresiMesaji);

            // Cokca kullanilan String metodlari:

            string test = "Bu islem icin kodunuz: 1234";
            if (test.Contains("kodunuz")) // bir stringin icerisinde birseyin olup olmadigini soyler
                listBox1.Items.Add("Bu cumle kod icermektedir");

            test = "www.google.com";
            if (test.EndsWith(".com"))
                listBox1.Items.Add("Bu .com uzantili bir adrestir");

            test = "TR12 1234 1234 1234 1234 1234 44"; // IBAN
            if (test.StartsWith("TR"))
                listBox1.Items.Add("Bu turkiye banakalarina ait bir IBAN numarasidir");

            test = "Bu dersimiz bir Asp.Net egitimidir. Asp.Net bir web platformudur.";
            int aspNetIndex = test.IndexOf("Asp.Net"); // indexOf parametresinde verilen string i ilk buldugu lokasyonunu verir

            List<int> aspNetLokasyonlari = new List<int>();
            int indexKelime = 0;
            while (indexKelime < test.Length)
            {
                int buldugumLokasyon = test.IndexOf("Asp.Net", indexKelime);
                if (buldugumLokasyon == -1) break;
                aspNetLokasyonlari.Add(buldugumLokasyon);
                indexKelime = buldugumLokasyon + 1;
            }

            string Ad = "Abuzittin Tatlisukabaginipismisseveroglu";
            test = $"Sayın {Ad}, bu Işlem için kodunuz: 1234. Lütfen kodunuzu kimseyle paylaşmayınız.";
            int kodunuzKelimesininIndexi = test.IndexOf("kodunuz:");
            int kodKelimesininUzunlugu = "kodunuz: ".Length;
            int kodBaslangici = kodunuzKelimesininIndexi + kodKelimesininUzunlugu;
            string kod = test.Substring(kodBaslangici, 4);
            // kodu degistirmek istiyoruz:
            test = test.Replace(kod, "4567");

            // tum cumleyi buyuk harfa yapalim:
            string buyukHarfli = test.ToUpper();
            string kucukHarfli = test.ToLower();

            string username = "Emre"; // bhu veritabanindan geldi
            string girilenIsim = "emre"; // bu ekrandan geldi
            if (username.ToLower() == girilenIsim.ToLower())
            {
                MessageBox.Show("Dogru!");
            }

            string aramaKriteri = "       esmer    ekmek     ";
            string kriter = aramaKriteri.Trim();
            while (kriter.IndexOf("  ") != -1 )
            {
                kriter = kriter.Replace("  ", " ");
            }


            List<string> urunler = new List<string>() { "esmer ekmek", "cavdar ekmegi" };
            for (int indexUrun = 0; indexUrun < urunler.Count; indexUrun++)
            {
                if (urunler[indexUrun] == kriter)
                {
                    // siparis olustur
                }
            }

            string[] kelimeler = test.Split(' ');
            List<string> kelimeList = kelimeler.ToList();
            string cumle = string.Join("_", kelimeList);

            // Datetime islemleri
            DateTime simdikiZaman = DateTime.Now;
            DateTime sifirSaatDilimindeSimdikiZaman = DateTime.UtcNow;

            DateTime dgunum = new DateTime(1976, 3, 18);
            TimeSpan gecenSure =  simdikiZaman.Subtract(dgunum);
            int gecenGunler = gecenSure.Days;
            double gecenToplamGunler = gecenSure.TotalDays;

            DateTime peynirUretimTarihi = new DateTime(2021, 7, 7, 17, 30, 0);
            DateTime skt = peynirUretimTarihi.AddDays(90); // raf omru 90 gun

            string tamZaman = simdikiZaman.ToString();
            string uzunTarih = simdikiZaman.ToLongDateString();
            string kisaTarih = simdikiZaman.ToShortDateString();
            string uzunSaat = simdikiZaman.ToLongTimeString();
            string kisaSaat = simdikiZaman.ToShortTimeString();
            string customFormat = simdikiZaman.ToString("mm:ss (dd.MM.yyyy)");

            DateTime dokuzYuzGunOncesi = simdikiZaman.AddDays(-900);
        }

        public void TurDonusumleri()
        {
            int sayi1 = 432432;
            double doubleSayi = 543543.656;
            // asagidaki kodlar tur donusmu istiyorlar:
            //int sayi3 = sayi2 + sayi1;
            //int ekrandanGelenSayi = "12";


            // Explicit type conversion :
            // Acik tur donusumu

            // Parse eski dillerden gelen bir yontem:
            int rakam1 = int.Parse("5535");

            // C# in asli cevrim yapan class i : Convert
            int rakam2 = Convert.ToInt32(doubleSayi);
            int rakam3 = Convert.ToInt32("23");
            string rakamStr = Convert.ToString(545);
            // sadece string e ayricalikli bir Convert fonksiyonu: ToString()
            rakamStr = 545.ToString();
            rakamStr = sayi1.ToString();


            // Implicit type conversion:
            // Kapali tur donusumu: (sadece gerekli kosullar saglandiginda)
            // Gerekli kosul: donusturulen turun, hedef tur sinirlarini asmayacagi %100 garanti ise
            // o zaman c# bu donusumun sorumlulugunu alip otomatik olarak yapar.

            byte age = 24; // 0-255
            int yas = age; // -2milyar - 2 milyar

            int mesafe = 54353543;
            double distance = mesafe;

            // Casting
            // Cast bir tur donusumu degildir: bir kimlik bildirmedir.

            object rakamNesne = 54354354;
            int rakam5 = (int)rakamNesne;

            int cinsiyetKodu = (int)Cinsiyet.bay;

            char karakter = 'E';
            byte ascIIkod = (byte)karakter;
            karakter = (char)234;


            // Acaba convert edilmeye elverislimi?
            string Rakam = "23";
            int girilenRakam = -1;//Convert.ToInt32(Rakam);
            // tryParse: donusturup - donusturemedigine dair bool cevap verir,
            // donusturebilir ise, ikinci (out) parametresinde verilen degiskene, donusturdugu degeri yazar
            bool donusturebildik = int.TryParse(Rakam, out girilenRakam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenRakam = textBox1.Text;
            //int Rakam = Convert.ToInt32(girilenRakam);
            int Rakam = 0;
            if (int.TryParse(girilenRakam, out Rakam))
            {
                MessageBox.Show("Tesekkurler...");
            }
            else
            {
                MessageBox.Show("Lutfen sadece rakam giriniz!");
                textBox1.Clear();
            }
        }
    }
}
