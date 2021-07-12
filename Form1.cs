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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calisma();
            FonksiyonCalismalariParams();
            int toplam = SayilariTopla(12, 23);
            KosulVeDonguIfadeleri();
        }


        void KosulVeDonguIfadeleri()
        {
            // kosul operatorleri
            // ==   : esit ise
            // >=   : buyuk esit ise
            // <=   : kucuk esit ise
            // <        : kucuk ise
            // >        : buyuk ise
            // !=       : esit DEGIL ise
            // !        : DEGIL ise
            // mantik operatorleri
            // &        : AND
            // |        : OR

            int cocugunYasi = 19;
            if (cocugunYasi < 7)
            {
                // ana okulu
            }
            else if (cocugunYasi >= 7 & cocugunYasi < 14)
            {
                // ilkogretim
            }
            else if (cocugunYasi >= 14 & cocugunYasi < 18)
            {
                // lise
            }
            else if (cocugunYasi >= 18 & cocugunYasi < 24)
            {
                // universite
            }
            else
            {
                // artik kendine is bulsun
            }

            string soyad = "Tekinsoy";
            if (soyad == "Tekinsoy")
            {
                MessageBox.Show("Bu egitmen");
            }
            else if (soyad == "Nalbani" | soyad == "Gültekin")
            {
                MessageBox.Show("Bu katilimci");
            }
            else
            {
                MessageBox.Show("Tanimiyorum bu vatandasi");
            }

            bool dolmusGeldimi = false;
            bool paramVarmi = true;
            bool yerVarmi = true;
            // && operatoru cift kullanildiginda: AND mantiksal islemlerinde tek bir false bile tum sonucu false yapacagindan: ilk false a rastlanildiginda ayni cumledeki diger ihtimallere bakilmaz 
            if (dolmusGeldimi && paramVarmi && yerVarmi)
            {
                // gidebilirim
            }

            bool otobusVarmi = true;
            bool dolmusVarmi = false;
            // || operatoru cift kullanildiginda: OR mantiksal islemlerinde tek bir true bile tum sonucu true yapacagindan: ilk true a rastlanildiginda ayni cumledeki diger ihtimallere bakilmaz 
            if (otobusVarmi || dolmusVarmi)
            {
                // gidebilirim
            }

            // senaryo: banakada bir islem ancak bu islem tamamlanmasa bile belli asamalarda yapilmasi gereken islemlerim var:
            if (HesaptaYeterliBakiyeVarmi(123m) & EFTIslemKayitlariUygunmu(123m))
            {

            }

            // alternatif if syntex leri
            // eger if veya else if veya else scopelarim sadece tek satir ise: scope parantezlerini kullanmayabiliriz:
            string sonuc = "";
            if (cocugunYasi < 7)
                sonuc = "okula gitmeyecek";
            else
                sonuc = "okula gidecek";

            // tek satirda atamalarda kullandigimiz sadece if ve else den olusan kisa if kullanimi:
            sonuc = cocugunYasi < 7 ? "okula gitmeyecek" : "okula gidecek";



            string yapilacakIslem = "swift";

            if (yapilacakIslem == "virman" || yapilacakIslem == "havale")
            {
                // banka ici islem
            }
            else if (yapilacakIslem == "eft")
            {
                // banbkalar arasi islem
            }
            else if (yapilacakIslem == "swift")
            {
                // uluslararasi islem
            }
            else if (yapilacakIslem == "arbitraj")
            {
                // ulurlararasi farkli kur islemi
            }
            else
            {
                // baska bir islem
            }


            switch (yapilacakIslem)
            {
                case "virman":
                case "havale":
                    // banka ici islem
                    break;
                case "eft":
                    // bankalar arasi
                    break;
                case "swift":
                    // uluslararasi
                    break;
                case "arbitraj":
                    //uluslaraarsi kur farkli
                    break;
                default:
                    // baska bir islem
                    break;
            }


            BankaIslemi islem = BankaIslemi.arbitraj;
            int islemKodu = (int)islem;
            islem = (BankaIslemi)islemKodu;

            switch (islem)
            {
                case BankaIslemi.virman:
                case BankaIslemi.havale:
                    // banka ici
                    break;
                case BankaIslemi.eft:
                    // bankalar arasi
                    break;
                case BankaIslemi.swift:
                    // uluslararasi
                    break;
                case BankaIslemi.arbitraj:
                    // kur farkli
                    break;
                case BankaIslemi.diger:
                    // diger bir islem
                    break;
            }

            Cinsiyet musterimizinCinsiyeti = Cinsiyet.bay;

            switch (musterimizinCinsiyeti)
            {
                case Cinsiyet.bay:
                    // Ahmet bey
                    break;
                case Cinsiyet.bayan:
                    // Ayse hanim
                    break;
                default:
                    break;
            }


            // Döngü yapıları:

            // Veritabanindan aldigimiz bir isim listesi oldugunu hayal edelim:
            List<string> musteriListesi = new List<string>() { "Ahmet", "Mehmet", "Ayse", "Ali" };

            //listBoxArkadaslar.Items.Add(musteriListesi[0]);
            //listBoxArkadaslar.Items.Add(musteriListesi[1]);
            //listBoxArkadaslar.Items.Add(musteriListesi[2]);
            //listBoxArkadaslar.Items.Add(musteriListesi[3]);
            //listBoxArkadaslar.Items.Add(musteriListesi[4]);

            int index = 0;
            while (index < musteriListesi.Count)
            {
                listBoxArkadaslar.Items.Add(musteriListesi[index]);
                index = index + 1;
            }

            List<int> notListesi = new List<int>() { 23, 59, 12, 35, 88, 54, 100 };
            // 60dan buyuk olan ilk not kactir?
            int indexnot = 0;
            int ilkGecerliNot = 0; // en az 60
            while (indexnot < notListesi.Count)
            {
                if (notListesi[indexnot] > 60)
                {
                    // buldum!
                    ilkGecerliNot = notListesi[indexnot];
                    break;
                }
                indexnot = indexnot + 1;
            }

            //devam eden kodlarim

            // elimizde bulunan sayiya esit olmayan bir sayi uretelim
            int elimizdekiSayi = 12;
            Random rastgele = new Random();
            int sayi = -1;
            do
            {
                sayi = rastgele.Next(10, 15);
            } while (sayi == elimizdekiSayi);


            for (int indexNot = 0; indexNot < notListesi.Count; indexNot++)
            {
                if (notListesi[indexNot] >= ilkGecerliNot)
                {
                    ilkGecerliNot = notListesi[indexNot];
                    break;
                }
            }
            // for dongulerinde i (index) degiskenine mutlaka anlamli bir isim verelim!

            // isim listesinde Ayse nin index ini bulalim. Ayse nin ikinci adini da ekleyecegiz
            List<string> isimler = new List<string>()
            {
                "Ahmet",
                "Ali",
                "Ayse",
                "Zeynep",
                "Ozan"
            };
            int indexAyse = -1;
            for (int indexIsim = 0; indexIsim < isimler.Count; indexIsim++)
            {
                if (isimler[indexIsim] == "Ayse")
                {
                    // buldum
                    indexAyse = indexIsim;
                    break;
                }
            }
            if (indexAyse != -1) // bu buldugum anlamina gelecek
                isimler[indexAyse] = "Ayse Nur";

            // mod '%' operatoru: bir sayinin bolumdeki kalanini verir 
            int sayinin6yaBolumundenKalan = 32 % 6; // 2 verir
            sayinin6yaBolumundenKalan = 65 % 6; // 5 sayisini verir
            int incelenecekSayi = 40;
            bool sayi5inKatimi = false;
            if (incelenecekSayi % 5 == 0)
            {
                // 40 sayisi 5in kati 
            }
            else
            {
                // degil
            }

            // 7nin katlari olan toplam 12 adet sayiya ihtiyacimiz var
            // yontem 1:
            List<int> yedininKatlari = new List<int>();
            for (int denenecekSayi = 7; yedininKatlari.Count < 12; denenecekSayi++)
            {
                if (denenecekSayi % 7 == 0) // yedinin kati demek
                {
                    yedininKatlari.Add(denenecekSayi);
                }
            }

            // yontem 2:
            // listeyi bosaltiyoruz:
            yedininKatlari = new List<int>(); // yada:
            yedininKatlari.Clear();

            for (int denenecekSayi = 7; 12 > yedininKatlari.Count; denenecekSayi += 7)
            {
                yedininKatlari.Add(denenecekSayi);
            }

            // senaryo: 40 sayisi ve ardisik 12 sayiyi azalan dogrultuda listemize yazalim
            List<int> kirkVeAltiArdisiklar = new List<int>();
            for (int azalanSayi = 40; kirkVeAltiArdisiklar.Count < 12; azalanSayi--)
            {
                kirkVeAltiArdisiklar.Add(azalanSayi);
            }

            // senaryo: 50 ile 100 arasindaki 13un kati olan sayilari bir listeye yazalim
            List<int> elliIle100arasindaki13unKatlari = new List<int>();
            // Yontem 1:
            for (int denecekSayi = 50; denecekSayi < 100; denecekSayi++)
            {
                if (denecekSayi % 13 == 0)
                {
                    elliIle100arasindaki13unKatlari.Add(denecekSayi);
                }
            }

            // Yontem 2:
            for (int denecekSayi = 50; denecekSayi < 100; denecekSayi++)
            {
                if (denecekSayi % 13 == 0)
                {
                    elliIle100arasindaki13unKatlari.Add(denecekSayi);
                    denecekSayi += 12;
                }
            }

            // Yontem 3:
            int ellidenSonra13unIlkKati = 0;
            for (int denenecekSayi = 50; denenecekSayi < 100; denenecekSayi++)
            {
                if (denenecekSayi % 13 == 0)
                {
                    ellidenSonra13unIlkKati = denenecekSayi;
                    break;
                }
            }

            for (int kat = ellidenSonra13unIlkKati; kat < 100; kat+=13)
            {
                elliIle100arasindaki13unKatlari.Add(kat);
            }
        }


        int GecerliNotuBul(List<int> notListesi, int gecerliNot)
        {
            //int bulunanNot = 0;
            int indexNot = 0;
            while (notListesi.Count > indexNot)
            {
                if (notListesi[indexNot] >= gecerliNot)
                {
                    //bulunanNot = notListesi[index];
                    return notListesi[indexNot];
                }
                indexNot++;
            }
            return -1;
        }

        void ListBoxTemizle()
        {
            if (listBoxArkadaslar.Items.Count == 0)
                return;
            listBoxArkadaslar.Items.Clear();
        }

        void MatematikselIfadelerdeKisaltmalar()
        {
            int sayi = 12;
            sayi = sayi + 5;
            // yukaridaki satirin kisaltilmis hali:
            sayi += 5;

            sayi = sayi - 2;
            sayi -= 2;

            sayi *= 2; // sayinin 2 katini aldik: * = c#'da carpma islemi

            sayi /= 2; // sayinin kendisini ikiye bolduk, yarisina indirdik. / = c#'da bolme

            // asagidaki satirlarin 3'u de sayiyi 1 arttirir.
            sayi = sayi + 1;
            sayi += 1;
            sayi++;

            sayi = sayi - 1;
            sayi -= 1;
            sayi--;

            // Math class i bazi matematiksel fonksiyon ve sabit sayilari icerir:
            double besSayisininUseri6 = Math.Pow(5, 6);
        }


        bool HesaptaYeterliBakiyeVarmi(decimal miktar)
        {
            // loglama kayit
            // servis baslatilir
            // ekstre yada yapilan islemlere kayit dusulur
            // kontroller
            return false;
        }

        bool EFTIslemKayitlariUygunmu(decimal miktar)
        {
            // loglama kayit
            // servis baslatilir
            // ekstre yada yapilan islemlere kayit dusulur
            // kontroller
            return true;
        }


        // fonksiyonu asiri yukleme: function overload
        int SayilariTopla(int s1, int s2)
        {
            return s1 + s2;
        }

        int SayilariTopla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }

        int SayilariTopla(int s1, int s2, int s3, int s4)
        {
            return s1 + s2 + s3 + s4;
        }

        void FonksiyonCalismalariParams()
        {
            string cumle = string.Concat("Ben ", "bugun ", "c# ", "da ", "nesne,", "dizi,", "fonksiyon,", "konularini ", "anlatiyorum ");
            string[] kelimeler = cumle.Split(' ', ',');

            char[] ayiraclar = new char[] { ',', ' ' };
            kelimeler = cumle.Split(ayiraclar, StringSplitOptions.RemoveEmptyEntries);
        }

        void Calisma()
        {
            // temel veritiplerimiz:
            // intellisense: bize visual studio nun tavsiyelerde bulunmasi icin kullandigi ve kod yazimimi hizlandiran menu ve kod tamamlama yapisi
            // intellisense cagirmak icin: ctrl + space
            string EgitmenIsmi = "bu bizim ilk c# dersimiz... Eğitimimiz bu hafta beş gün";
            char tekKarakter = 'e';

            // degisken ve nesne isimlendirme kurallari:
            // 1- Asla rakam ile baslanamaz
            // 2- Ayni scope da (bolgede) ayni ismi tasiyan iki nesne olamaz, veya isimler c# daki nesnelerle ve kelimelerle cakisamaz
            // 3- _ underscore disinda herhangi bir ozel karakter iceremez
            // 4 (opsiyonel) - Ingilizce alfabe disinda harf kullanmayin

            // tamsayilar:
            byte enkucuk = 255; // 0 - 255 (1 byte)
            short kucuk = 31000; // -32000 - +32000 (2 byte)
            int temelTamSayi = -34556677; //-2milyar - +2milyar kusur arasi (4 byte) Varsayilan tam sayi;
            long buyukTamSayi = 4535435435434;//-9e18 - +9e18

            // pozitif tamsayi (unsigned)
            ushort pozitifKucuk = 64000; // 0 - 64000
            uint pozitifVarsayilanTamSayi = 4000000000; // 0 - 4milyar
            ulong pozitifBuyuk = 45353543543543; // 0 - 18e18

            // signed byte (eksi olabilen)
            sbyte negatifEnKucuk = -128; // -128 - 127


            // ondalik sayilar
            float kucukOndalik = 213431.99f; //1.5e-45 - 3.4e38 (ondalik anlamda 7 digit) (4 byte)
            double varsayilanOndalik = 543543.65465465; // 5e-324 - 3.4e308 (8 byte)
            varsayilanOndalik = 5435354.654654d; // buradaki 'd' suffix i varsayilan ondalik degisken oldugundan opsiyonel
            decimal enEnBuyukSayi = 453543543543.65465465465m; // -7.9e28 = 7.9e28 (16 byte)

            // yazilim dunyasinin temeli:
            bool varmiYokmu = true;

            // CLR tipleri: (Common Language Runtime)
            // Yukaridaki tiplerden altyapida hicbir farki yoktur sadece kaynagi farkli oldugundan yazimi farkli:
            String yazi = EgitmenIsmi;
            Boolean varmi = varmiYokmu;
            Int16 shortKarsiligi = kucuk;
            Int32 intKarsiligi = temelTamSayi;
            Int64 longKarsiligi = buyukTamSayi;



            // var kelimesi: C# in "sen deger ata, ben sonrasinda ne olacagina kendim karar veririm" demesi
            string isim;
            //object nesne;
            var deger = 12;
            temelTamSayi = deger;

            // temel veritipi olmasa da, cokca kullandigimiz ozel yapilar (struct)
            // tarih ve saat:
            DateTime zaman = DateTime.Now;
            DateTime dgunum = new DateTime(1976, 3, 18, 22, 30, 0);

            // uniqueidentifier :
            Guid uniqueidentifier = Guid.Empty;
            Guid ozelID = Guid.NewGuid();

            // yukaridaki tum anlatilan veritipleri (string haric) value-type veritipleridir.
            // null olamayanlardir:
            //int sayi = null;
            //string Isim = null;

            // OOP programlama dillerinin en temel nesnesi
            object rakamNesne = 32132; // arka planda bu nesne aslinda int
            object ondalikNesne = 43243.65464;// arka planda double
            object stringNesne = "ghfashdfahsgdf";
            object bosNesne = null;

            // referans type lar null olabilenlerdir
            string name = null;
            object deneme = null;

            // nullable value type
            int? nullableSayi = null;
            decimal? nullableDecimal = null;
            DateTime? nullableDateTime = null;
            Nullable<int> nullableSayi2 = nullableSayi;

            /////////////////////////////////////////
            // dizi ve liste (kolleksiyon) yapilari
            // dizi (Array) yapisi:
            int[] puanDizisi = new int[12];
            decimal[] notListesi = new decimal[] { 12.3m, 344.67m, 1024m }; // initializer
            puanDizisi[0] = 23;
            puanDizisi[11] = 34;
            //puanDizisi[23] = 6546; // ArgumentOutOfRangeException : index sinirlarin disinda hatasi
            int besinciEleman = puanDizisi[4]; // 4 indexli yada 5. eleman
            int puanListesiElemanSayisi = puanDizisi.Length;
            decimal notListesininSonElemani = notListesi[notListesi.Length - 1];

            // Liste yapilari:
            List<int> puanListesi = new List<int>();
            puanListesi.Add(12);
            puanListesi.Add(24);
            int listedekiIlkEleman = puanListesi[0];
            puanListesi[1] = 36;
            //puanListesi[5] = 456;
            List<int> ikinciListe = new List<int>() { 445, 55, 66 };
            puanListesi.AddRange(ikinciListe);
            int listeminUzunlugu = puanListesi.Count;
            int listeninSonElemani = puanListesi[puanListesi.Count - 1];
            ikinciListe.Clear();

            // .Net icerisinde bircok yerde rastlayabilecegimiz Collection yapilarina bir ornek:
            listBoxArkadaslar.Items.Add("Metin");
            int listBoximdaKacKisiVar = listBoxArkadaslar.Items.Count;
            string dorduncuSiradakiArkadas = listBoxArkadaslar.Items[2].ToString();
            listBoxArkadaslar.Items[3] = "Dilek";
            //listBoxArkadaslar.Items.Clear();

            ////////////
            // Dictionary yapisi :
            Dictionary<long, string> tcknSineGoreElemanlar = new Dictionary<long, string>();
            tcknSineGoreElemanlar.Add(12345678901, "Ahmet");
            tcknSineGoreElemanlar.Add(12345123455, "Zeynep");
            tcknSineGoreElemanlar.Add(87768768768, "Ozan");
            tcknSineGoreElemanlar[12345678901] = "Ahmet Ali";
            string ikinciEleman = tcknSineGoreElemanlar[12345123455];
            int elemanSayisi = tcknSineGoreElemanlar.Count;
            // tcknSineGoreElemanlar.Add(12345678901, "Mehmet"); Ayni key degerini iki kez kullanamam

            // trafik mudurlugu vergi kayitlarini tutuyor:
            Dictionary<string, bool> vergiDictionary = new Dictionary<string, bool>();
            vergiDictionary.Add("34 CS 123", true);
            vergiDictionary.Add("01 ET 545", false);
            vergiDictionary.Add("34 FF 546", true);
        }


        // fonksiyonlar
        void ListBoxiTemizle()
        {
            listBoxArkadaslar.Items.Clear();
            //MessageBox.Show(BanaBirSayiSoyle());
        }

        /// <summary>
        /// Bu fonksiyon, onyuzumde bulunan listbox a eleman ekler
        /// </summary>
        /// <param>Listeye eklenecek isim gonderilmeli</param>
        void ListeyeEkle(string eklenecekIsim)
        {
            listBoxArkadaslar.Items.Add(eklenecekIsim);
        }

        int BanaBirSayiSoyle()
        {
            //koldarim
            int sayi = 23;
            // islemlerim
            return sayi;
        }

        int BuIkiSayiyiTopla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        int BuUcSayiyiTopla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }

        int ButunBuSayilariTopla(int[] sayilar)
        {
            int gelenRakamlarinSayisi = sayilar.Length;
            // toplama islemlerim
            return 98; // toplamlarinin 98 oldugunu varsayalim
        }

        /// <summary>
        /// bu fonksiyon gonderdigim sayilari toplar
        /// </summary>
        /// <param name="sayilar">sayilar</param>
        /// <returns>toplami doner</returns>
        int BuSayilariTopla(params int[] sayilar)
        {
            int gelenRakamlarinSayisi = sayilar.Length;
            // toplama islemlerim
            return 654;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int[] toplanacaklar1 = new int[] { 12, 34, 56, 78 };
            int toplamlari1 = ButunBuSayilariTopla(toplanacaklar1);

            int toplanacaklar2 = BuSayilariTopla(12, 23, 34, 45, 56, 67, 78, 89);

            ListBoxiTemizle();
            int rakam = BanaBirSayiSoyle();
            int toplam = BuIkiSayiyiTopla(4, 56);
            MessageBox.Show(toplam.ToString());
            ListeyeEkle("Emre");
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string eklenecekOlan = textBox1.Text;
            ListeyeEkle(eklenecekOlan);
            textBox1.Clear();
        }

    }


    enum BankaIslemi
    {
        virman = 10,
        havale = 11,
        eft = 20,
        swift = 30,
        arbitraj = 33,
        diger = 99
    }
}
