using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinDers1.Nesnelerim;

namespace WinDers1
{
    public partial class Work2 : Form
    {
        public Work2()
        {
            InitializeComponent();
        }

        //List<string> isimler = new List<string>();
        //List<string> tecrubeler = new List<string>();

        List<Personel> perList = new List<Personel>();

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //isimler.Add(textBoxIsim.Text);

            //string tecrube = string.Empty;
            //if (radioButtonJunior.Checked)
            //{
            //    tecrube = "Junior";
            //}
            //else if (radioButtonSenior.Checked)
            //{
            //    tecrube = "Senior";
            //}
            //tecrubeler.Add(tecrube);

            //listBoxIsimler.Items.Add($"{textBoxIsim.Text} ({tecrube})");

            Personel yeniPersonel = new Personel() // instance aldik
            {
                Isim = textBoxIsim.Text,
                Tecrube = radioButtonJunior.Checked ? "Junior" : "Senior"
            };

            // bu personelin ismini okumak istersek:
            string perIsim = yeniPersonel.Isim;

            listBoxIsimler.Items.Add($"{yeniPersonel.Isim} ({yeniPersonel.Tecrube})");
            perList.Add(yeniPersonel);

            textBoxIsim.Clear();
            textBoxIsim.Focus();
        }

        private void Work2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ben ne yapsamda: elimdeki Personel class larindan olusan listeyi 
            // bir butun yaziya dokerek (string olarak ifade ederek)
            // tekrar geri okuyabilecegim bir sekilde
            // NASIL YAZARIM?

            // Her bir elemani (Personel), her bir satira yazar, ve sahip oldugu ozellikleri ',' ile ayirirsak bunlari bir text dosyasina donusturmus oluruz.
            // Yontem 1:
            StringBuilder backupBuilder = new StringBuilder();
            //for (int indexPer = 0; indexPer < perList.Count; indexPer++)
            //{
            //    backupBuilder.Append($"{perList[indexPer].Isim},{perList[indexPer].Tecrube};");
            //}

            // for dongusune alternatif:
            // foreach
            // 1- Eger for dongumu belli bir collection yapisinda calismak uzere tasarladi isem,
            // 2- For dongusunde geriye gitmek, yada index e 0 degerinden farkli bir deger vermek gibi bir ozellestirme yapmadi isem
            // 3- For dongumun sahip oldugu index i, index den farkli bir amac icin kullanmadi isem
            // o zaman alternatif Foreach kullanilabilir:
            foreach (Personel herbirPersonel in perList)
            {
                backupBuilder.Append($"{herbirPersonel.Isim},{herbirPersonel.Tecrube}");
            }

            string data = backupBuilder.ToString();


            // Yontem 2:
            List<string> degerler = new List<string>();
            //for (int indexPer = 0; indexPer < perList.Count; indexPer++)
            //{
            //    degerler.Add($"{perList[indexPer].Isim},{perList[indexPer].Tecrube}");
            //}

            foreach (Personel item in perList)
            {
                degerler.Add($"{item.Isim},{item.Tecrube}");
            }

            string veriler = string.Join(";", degerler);

            File.WriteAllText("backup.txt", veriler);


            // Karmasik datalarimizi string formata donusturme isleminin yazilim dunyasindaki adi:
            // Serialization
            // Ornek serialization formatlari: XML (eXtended Markup Language), JSON (JavaScript Object Notation)
            // .Net icerisinde aktif kullanmakta oldugumuz 3 cesit serialization yontemi var:
            // Binary, XML, (Newtonsoft) JSON

            string jsonVeriler = Newtonsoft.Json.JsonConvert.SerializeObject(perList);
            File.WriteAllText("backup.json", jsonVeriler);
        }

        private void Work2_Load(object sender, EventArgs e)
        {
            string veriler = File.ReadAllText("backup.txt");

            List<string> degerler = veriler.Split(';').ToList();

            foreach (string herbirKayit in degerler)
            {
                string[] ozellikler = herbirKayit.Split(',');
                Personel personel = new Personel();
                personel.Isim = ozellikler[0];
                personel.Tecrube = ozellikler[1];
                perList.Add(personel);
                listBoxIsimler.Items.Add($"{personel.Isim} ({personel.Tecrube})");
            }


            //JSON kullanarak:
            string jsonVeriler = File.ReadAllText("backup.json");
            perList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(jsonVeriler);
        }

        // yazilim ekipleri olusturuyoruz:
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            // Random kullanim ornegi:
            int sayi = rastgele.Next(0, 10); // 0 dahil 10 haric; 0 ile 10 arasinda rastgele sayi belirler

            // Yontem1:
            // kac takimim var?
            int juniorSayisi = 0;
            int seniorSayisi = 0;
            foreach (Personel herbirPer in perList)
            {
                if (herbirPer.Tecrube == "Senior")
                    seniorSayisi++;
                else
                    juniorSayisi++;
            }
            int takimSayisi = 0;
            if (seniorSayisi < juniorSayisi)
                takimSayisi = seniorSayisi;
            else
                takimSayisi = juniorSayisi;
            // once kendime bir junior bulayim:
            for (int indexTakim = 0; indexTakim < takimSayisi; indexTakim++)
            {
                int juniorIndex = rastgele.Next(0, perList.Count);
                // bu sayi junior mi?
                // degil ise bir daha cekicem
                // buldugum da bunu takima yazicam
                //
            }

            // uzamasindan farkettim ki bu ideal degil: baska bisey lazim...

            // Yontem 2: Beynimin gercek hayatta bu isi nasil yaptigini gozlemledim:
            // junior ve senior lari ayirt ediyor
            List<Personel> juniorList = new List<Personel>();
            List<Personel> seniorList = new List<Personel>();
            foreach (Personel per in perList)
            {
                if (per.Tecrube == "Senior")
                    seniorList.Add(per);
                else
                    juniorList.Add(per);
            }

            while (0 < juniorList.Count && 0 < seniorList.Count)
            {
                int juniorSansli = rastgele.Next(0, juniorList.Count);
                int seniorSansli = rastgele.Next(0, seniorList.Count);

                listBoxEkipler.Items.Add($"{juniorList[juniorSansli].Isim} - {seniorList[seniorSansli].Isim}");

                //juniorList.Remove(juniorList[juniorSansli]);
                juniorList.RemoveAt(juniorSansli);
                seniorList.RemoveAt(seniorSansli);
            }
        }
    }
}
