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
    public partial class CSGayrimenkul : Form
    {
        public CSGayrimenkul()
        {
            InitializeComponent();
        }

        List<Daire> tumApartman = new List<Daire>();
        private void CSGayrimenkul_Load(object sender, EventArgs e)
        {
            // ilk 10 kat:
            int daireNo = 1;
            for (int kat = 1; kat <= 10; kat++)
            {
                Daire herbirDaireA = new Daire();
                herbirDaireA.Kat = kat;
                herbirDaireA.No = daireNo;
                herbirDaireA.Metrekare = 70;
                herbirDaireA.OdaSayisi = 3;
                tumApartman.Add(herbirDaireA);
                daireNo++;

                Daire herbirDaireB = new Daire();
                herbirDaireB.Kat = kat;
                herbirDaireB.No = daireNo;
                herbirDaireB.Metrekare = 70;
                herbirDaireB.OdaSayisi = 3;
                tumApartman.Add(herbirDaireB);
                daireNo++;
            }

            // 11-20 katlar
            for (int kat = 11; kat <= 20; kat++)
            {
                Daire herbirDaireA = new Daire()
                {
                    Kat = kat,
                    No = daireNo,
                    Metrekare = 70,
                    OdaSayisi = 2
                };
                tumApartman.Add(herbirDaireA);
                daireNo++;

                Daire herbirDaireB = new Daire()
                {
                    Kat = kat,
                    No = daireNo,
                    Metrekare = 70,
                    OdaSayisi = 2
                };
                tumApartman.Add(herbirDaireB);
                daireNo++;
            }

            // 21 - 30 katlar
            for (int kat = 21; kat <= 30; kat++)
            {
                for (int katDaire = 1; katDaire <= 2; katDaire++)
                {
                    Daire herbirDaire = new Daire()
                    {
                        Kat = kat,
                        No = daireNo,
                        Metrekare = 50,
                        OdaSayisi = 1
                    };
                    tumApartman.Add(herbirDaire);
                    daireNo++;
                }
            }

            // 31-40 katlar
            for (int kat = 31; kat <= 40; kat++)
            {
                Daire daire = new Daire()
                {
                    Kat = kat,
                    No = daireNo,
                    Metrekare = 100,
                    OdaSayisi = 2
                };
                daireNo++;
                tumApartman.Add(daire);
            }

            // 41-50 katlar
            for (int kat = 41; kat <= 50; kat++)
            {
                Daire daire = new Daire()
                {
                    Kat = kat,
                    No = daireNo,
                    Metrekare = 80,
                    OdaSayisi = 2
                };
                daireNo++;
                tumApartman.Add(daire);
            }

            // 51-60 katlar
            for (int kat = 51; kat <= 60; kat++)
            {
                Daire daire = new Daire()
                {
                    Kat = kat,
                    No = daireNo,
                    Metrekare = 80,
                    OdaSayisi = 1
                };
                daireNo++;
                tumApartman.Add(daire);
            }

            // fiyat hesaplamasi
            for (int DaireIndex = 0; DaireIndex < tumApartman.Count; DaireIndex++)
            {
                int fiyat = 200000;
                fiyat += tumApartman[DaireIndex].Kat * 1000;
                fiyat += tumApartman[DaireIndex].Metrekare * 100;
                fiyat += tumApartman[DaireIndex].OdaSayisi * 5000;
                tumApartman[DaireIndex].Fiyat = fiyat;
            }

            DaireleriListele(tumApartman);
        }

        void DaireleriListele(List<Daire> liste)
        {
            listBoxDaireler.Items.Clear();
            foreach (Daire herBirDaire in liste)
            {
                listBoxDaireler.Items.Add($"Kat:{herBirDaire.Kat} No:{herBirDaire.No} {herBirDaire.Metrekare}m² {herBirDaire.OdaSayisi}+1 {herBirDaire.Fiyat:c}");
            }
        }

        private void comboBoxSiralama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSiralama.SelectedIndex != -1)
            {
                int seciliIndex = comboBoxSiralama.SelectedIndex; // 0: kata, 1:fiyat, 2:oda, 3:metrekare
                List<Daire> siraliListe = new List<Daire>(new Daire[tumApartman.Count]);

                switch (seciliIndex)
                {
                    case 0: // kata
                        foreach (Daire incelenen in tumApartman)
                        {
                            int hedefIndex = 0;
                            foreach (Daire karsilastirilan in tumApartman)
                            {
                                if (incelenen.Kat > karsilastirilan.Kat)
                                {
                                    hedefIndex++;
                                }
                            }
                            while (siraliListe[hedefIndex] != null)
                            {
                                hedefIndex++;
                            }
                            siraliListe[hedefIndex] = incelenen;
                        }
                        break;
                    case 1: // fiyat
                        foreach (Daire incelenen in tumApartman)
                        {
                            int hedefIndex = 0;
                            foreach (Daire karsilastirilan in tumApartman)
                            {
                                if (incelenen.Fiyat > karsilastirilan.Fiyat)
                                {
                                    hedefIndex++;
                                }
                            }
                            while (siraliListe[hedefIndex] != null)
                            {
                                hedefIndex++;
                            }
                            siraliListe[hedefIndex] = incelenen;
                        }
                        break;
                    case 2: // oda
                        foreach (Daire incelenen in tumApartman)
                        {
                            int hedefIndex = 0;
                            foreach (Daire karsilastirilan in tumApartman)
                            {
                                if (incelenen.OdaSayisi > karsilastirilan.OdaSayisi)
                                {
                                    hedefIndex++;
                                }
                            }
                            while (siraliListe[hedefIndex] != null)
                            {
                                hedefIndex++;
                            }
                            siraliListe[hedefIndex] = incelenen;
                        }
                        break;
                    case 3: // metrekare
                        foreach (Daire incelenen in tumApartman)
                        {
                            int hedefIndex = 0;
                            foreach (Daire karsilastirilan in tumApartman)
                            {
                                if (incelenen.Metrekare > karsilastirilan.Metrekare)
                                {
                                    hedefIndex++;
                                }
                            }
                            while (siraliListe[hedefIndex] != null)
                            {
                                hedefIndex++;
                            }
                            siraliListe[hedefIndex] = incelenen;
                        }
                        break;
                }
                DaireleriListele(siraliListe);
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            int altLimit = Convert.ToInt32(textBoxAlt.Text);
            int ustLimit = Convert.ToInt32(textBoxUst.Text);
            if (altLimit > ustLimit)
            {
                MessageBox.Show("Alt limitiniz ust limitten kucuk olmalidir.");
                return;
            }

            List<Daire> arananlar = new List<Daire>();
            foreach (Daire incelenen in tumApartman)
            {
                if (incelenen.Fiyat >= altLimit && incelenen.Fiyat <= ustLimit)
                {
                    arananlar.Add(incelenen);
                }
            }
            DaireleriListele(arananlar);
        }

    }
}
