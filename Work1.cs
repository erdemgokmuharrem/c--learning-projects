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
    public partial class Work1 : Form
    {
        public Work1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kullanicinin verdigi katsayinin, verilen alt ve ust limitler arasindaki katlarinin hesaplanmasi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKat_Click(object sender, EventArgs e)
        {
            // Degil operatoru ile ilgili olarak:
            // cevirebilmis ise
            // if(tryParse...)
            // if(true == false)
            // if(!true) => if(false)
            // ceviremedi ise
            // if(!tryParse...)
            // if(!false) : ceviremedi ise
            // if(true)

            // Hazirliklar:
            string katSayiStr = textBoxKatSayi.Text;
            string altLimitStr = textBoxAltLimit.Text;
            string ustLimitStr = textBoxUstLimit.Text;
            int katSayi = 0;
            int altLimit = 0;
            int ustLimit = 0;
            //if (int.TryParse(katSayiStr, out katSayi) == false)
            if (!int.TryParse(katSayiStr, out katSayi))
            {
                MessageBox.Show("Lutfen kat sayiya rakam giriniz.");
                textBoxKatSayi.Clear();
                textBoxKatSayi.Focus();
                return;
            }
            if (!int.TryParse(altLimitStr, out altLimit))
            {
                MessageBox.Show("Lutfen alt limite rakam giriniz.");
                textBoxAltLimit.Clear();
                textBoxAltLimit.Focus();
                return;
            }
            if (!int.TryParse(ustLimitStr, out ustLimit))
            {
                MessageBox.Show("Lutfen ust limite rakam giriniz.");
                textBoxUstLimit.Clear();
                textBoxUstLimit.Focus();
                return;
            }
            listBoxKatlar.Items.Clear();

            // Yontem1:
            //for (int kat = altLimit; kat <= ustLimit; kat++)
            //{
            //    if (kat % katSayi == 0)
            //    {
            //        listBoxKatlar.Items.Add(kat);
            //    }
            //}

            // Yontem2:
            //for (int kat = altLimit; kat <= ustLimit; kat++)
            //{
            //    if (kat % katSayi == 0)
            //    {
            //        listBoxKatlar.Items.Add(kat);
            //        kat += katSayi -1 ;
            //    }
            //}

            // Yontem3:
            if (radioButtonArtanKat.Checked)
            {
                int ilkKat = 0;
                for (int kat = altLimit; kat <= ustLimit; kat++)
                {
                    if (kat % katSayi == 0)
                    {
                        ilkKat = kat;
                        break;
                    }
                }

                for (int kat = ilkKat; kat <= ustLimit; kat += katSayi)
                {
                    listBoxKatlar.Items.Add(kat);
                }
            }
            else if (radioButtonAzalanKat.Checked)
            {
                int sonKat = 0;
                for (int kat = ustLimit; kat >= altLimit; kat--)
                {
                    if (kat % katSayi == 0)
                    {
                        sonKat = kat;
                        break;
                    }
                }

                for (int kat = sonKat; kat >= altLimit; kat -= katSayi)
                {
                    listBoxKatlar.Items.Add(kat);
                }
            }

        }

        private void buttonFaktoriyel_Click(object sender, EventArgs e)
        {
            // Faktoriyel: bir sayinin kendi ve alt ardisik sayilarinin carpimidir
            // 6! = 6*5*4*3*2 = 720
            // 3! = 3*2 = 6

            decimal sayi = 0;
            if (!decimal.TryParse(textBoxFaktoriyel.Text, out sayi))
            {
                MessageBox.Show("Lutfen rakam giriniz.");
                textBoxFaktoriyel.Clear();
                textBoxFaktoriyel.Focus();
                return;
            }

            decimal sonuc = 1;
            // Yontem1:
            for (decimal rakam = sayi; rakam > 1; rakam--)
            {
                sonuc *= rakam;
            }

            // Yontem2:
            sonuc = 1;
            for (decimal rakam = 2; rakam <= sayi; rakam++)
            {
                sonuc *= rakam;
            }
            labelFaktoriyel.Text = sonuc.ToString();
        }

        private void buttonObeb_Click(object sender, EventArgs e)
        {
            // bir for dongusu icinde kucuk olan sayidan baslayarak, geriye dogru kuculterek, her iki sayiyi da boldugumuzde kalani iki islemde de 0 veren OBEB dur.

            string s1str = textBoxS1.Text;
            string s2str = textBoxS2.Text;
            int s1 = 0;
            int s2 = 0;
            if (!int.TryParse(s1str, out s1) || !int.TryParse(s2str, out s2))
            {
                MessageBox.Show("Rakamlar hatali");
                return;
            }

            int kucuk = 0;
            int buyuk = 0;
            if (s1 > s2)
            {
                kucuk = s2;
                buyuk = s1;
            }
            else
            {
                kucuk = s1;
                buyuk = s2;
            }

            for (int rakam = kucuk; rakam >= 1; rakam--)
            {
                if (kucuk % rakam == 0 && buyuk % rakam == 0)
                {
                    labelOrtakKat.Text = rakam.ToString();
                    break;
                }
            }
        }

        private void buttonOkek_Click(object sender, EventArgs e)
        {
            // buyuk sayiyi sirayla kucukten (1)den baslayarak katlarini sirayla alarak, herbirini kucuk olana boldugumde ilk buldugum kalan 0 sonucu, ilk ortak kat demektir. En son ihtimal, OKEK iki sayinin carpimi olacagindan; buyuk ile carpacagim son rakam kucuk olandir.

            string s1str = textBoxS1.Text;
            string s2str = textBoxS2.Text;
            int s1 = 0;
            int s2 = 0;
            if (!int.TryParse(s1str, out s1) || !int.TryParse(s2str, out s2))
            {
                MessageBox.Show("Rakamlar hatali");
                return;
            }

            int kucuk = 0;
            int buyuk = 0;
            if (s1 > s2)
            {
                kucuk = s2;
                buyuk = s1;
            }
            else
            {
                kucuk = s1;
                buyuk = s2;
            }

            for (int carpan = 1; carpan <= kucuk; carpan++)
            {
                int kat = buyuk * carpan;
                if (kat % kucuk == 0)
                {
                    labelOrtakKat.Text = kat.ToString();
                    break;
                }
            }
        }

        List<int> sayilarim = new List<int>();
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            int girilenSayi = Convert.ToInt32(textBoxGirilenSayi.Text);
            sayilarim.Add(girilenSayi);
            listBoxSayilar.Items.Add(girilenSayi.ToString());
        }

        // siralama algoritmasi ornegi
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> siraliSayilarim = new List<int>(new int[sayilarim.Count]);

            for (int incelenecekOlanSayi = 0; incelenecekOlanSayi < sayilarim.Count; incelenecekOlanSayi++)
            {
                int hedefIndex = 0;
                for (int karsilastirilacakSayi = 0; karsilastirilacakSayi < sayilarim.Count; karsilastirilacakSayi++)
                {
                    if (sayilarim[incelenecekOlanSayi] > sayilarim[karsilastirilacakSayi])
                    {
                        hedefIndex++;
                    }
                }
                siraliSayilarim[hedefIndex] = sayilarim[incelenecekOlanSayi];
            }

            // listBox a ait Items listesine tek tek eklemek yerine; listbox a "kendi listen yerine bunu kullan" anlaminda DataSource tanimlayabiliriz:
            listBoxSirali.DataSource = siraliSayilarim;
        }
    }
}
