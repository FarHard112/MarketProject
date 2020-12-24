using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    class Mehsul:IMarketable
    {
        // 1 ci variantadi funksiyalar
        public void CreateMehsul()
        {
            MehsulStructure yeniMehsul = new MehsulStructure();
            Console.WriteLine("Mehsulun adin daxil et");
            string MehsulunAd = Console.ReadLine();
            yeniMehsul.ad = MehsulunAd;

            Console.WriteLine("Qiymeti daxil edin");
            float MehsulQiymet = float.Parse(Console.ReadLine());
            yeniMehsul.qiymet = MehsulQiymet;

            Console.WriteLine("Mehsulun sayini daxil edin");
            int MehsulSayi = int.Parse(Console.ReadLine());
            yeniMehsul.say = MehsulSayi;

            Console.WriteLine("Barkodu elave edin");
            int MehsulBarkod = int.Parse(Console.ReadLine());
            yeniMehsul.kod = MehsulBarkod;

            Console.WriteLine("Kateqoriya daxil edin");
            Console.WriteLine("Yuyucuvasite = 1 \nIckiler = 2\nSiqaret = 3\nSudMehsullari=4\nEtMehsullari=5");
            int kateqoriya = int.Parse(Console.ReadLine());

            switch (kateqoriya)
            {
                case 1:
                    {
                        yeniMehsul.kateqoriya = MehsulKateqoriya.Yuyucuvasite;

                        break;
                    }
                case 2:
                    {
                        yeniMehsul.kateqoriya = MehsulKateqoriya.Ickiler;

                        break;
                    }
                case 3:
                    {
                        yeniMehsul.kateqoriya = MehsulKateqoriya.Siqaret;

                        break;
                    }
                case 4:
                    {
                        yeniMehsul.kateqoriya = MehsulKateqoriya.SudMehsullari;

                        break;
                    }
                case 5:
                    {
                        yeniMehsul.kateqoriya = MehsulKateqoriya.EtMehsullari;

                        break;
                    }
            }

             yeniMehsul.saat = 0;
             yeniMehsul.deqiqe = 0;


            Console.WriteLine("Mehsul Melumatlari daxil edilidi");
            Database.mehsuls.Add(yeniMehsul);

            Console.WriteLine("****Mehsul****");

            Console.WriteLine("AD : " + yeniMehsul.ad + "\n" +
                 "Qiymet :" + yeniMehsul.qiymet + "\n" +
                  "Say :" + yeniMehsul.say + "\n" +
                  "Kod :" + yeniMehsul.kod + "\n" +
                  "Kateqoriya :" + yeniMehsul.kateqoriya + "\n"
                );

            Console.WriteLine("************************");


            //geriye qayitmaq ucun
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

            Program.init(mehsul1);



        }
        public void UpdateMeshul()
        {
            Console.Write(" Duzelis etmek istediyiniz mehsulun Kodunu daxil edin :");
            int code = int.Parse(Console.ReadLine());
            for (int i = 0; i < Database.mehsuls.Count; i++)
            {
                if (Database.mehsuls[i].kod == code)
                {
                    foreach (var item in Database.mehsuls)
                    {
                        Console.WriteLine("AD : " + item.ad + "\n" +
                             "Qiymet :" + item.qiymet + "\n" +
                              "Say :" + item.say + "\n" +
                              "Kod :" + item.kod + "\n" +
                              "Kateqoriya :" + item.kateqoriya + "\n"
                            );
                    }

                    Console.WriteLine("Duzelis edin:");

                    Console.Write("AD : ");
                    string ad = Console.ReadLine();
                    Database.mehsuls[i].ad = ad;

                    Console.Write("QİYMƏT : ");
                    float qiymet = float.Parse(Console.ReadLine());
                    Database.mehsuls[i].qiymet = qiymet;

                    Console.Write("SAY : ");
                    int say = int.Parse(Console.ReadLine());
                    Database.mehsuls[i].say = say;

                    Console.Write("KOD : ");
                    int kod = int.Parse(Console.ReadLine());
                    Database.mehsuls[i].kod = kod;

                    Console.Write("KATEQORİYALAR \n\n");
                    Console.WriteLine("Yuyucuvasite = 1 \nIckiler = 2\nSiqaret = 3\nSudMehsullari=4\nEtMehsullari=5");
                    int kateqoriya = int.Parse(Console.ReadLine());

                    switch (kateqoriya)
                    {
                        case 1:
                            {
                                Database.mehsuls[i].kateqoriya = MehsulKateqoriya.Yuyucuvasite;

                                break;
                            }
                        case 2:
                            {
                                Database.mehsuls[i].kateqoriya = MehsulKateqoriya.Ickiler;

                                break;
                            }
                        case 3:
                            {
                                Database.mehsuls[i].kateqoriya = MehsulKateqoriya.Siqaret;

                                break;
                            }
                        case 4:
                            {
                                Database.mehsuls[i].kateqoriya = MehsulKateqoriya.SudMehsullari;

                                break;
                            }
                        case 5:
                            {
                                Database.mehsuls[i].kateqoriya = MehsulKateqoriya.EtMehsullari;

                                break;
                            }
                    }

                    Console.WriteLine("DEYİŞİKLİKLƏR YADDAŞDA SAXLANILDI...\n\n");
                    Console.WriteLine("MEHSUL\n");

                    foreach (var item in Database.mehsuls)
                    {
                        Console.WriteLine("AD : " + item.ad + "\n" +
                             "Qiymet :" + item.qiymet + "\n" +
                              "Say :" + item.say + "\n" +
                              "Kod :" + item.kod + "\n" +
                              "Kateqoriya :" + item.kateqoriya + "\n"
                            );
                    }


                    //geriye qayitmaq ucun
                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");
                    int mehsul1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Program.init(mehsul1);



                }

            }
        }
        public void DeleteMehsul()
        {
            Console.Write("Silmek istediyiniz mehsulun kodunu yazin :");
            int code = int.Parse(Console.ReadLine());
            for (int i = 0; i < Database.mehsuls.Count; i++)
            {
                if (Database.mehsuls[i].kod == code)
                {
                    Console.WriteLine(Database.mehsuls[i].ad + " mehsulu silindi...\n\n");
                    Database.mehsuls.RemoveAt(i);

                    //geriye qayitmaq ucun
                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");
                    int mehsul1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

                    Program.init(mehsul1);
                }
            }
        }
        public void showMehsuls()
        {
            foreach (var item in Database.mehsuls)
            {
                Console.WriteLine("AD : " + item.ad + "\n" +
                     "Qiymet :" + item.qiymet + "\n" +
                      "Say :" + item.say + "\n" +
                      "Kod :" + item.kod + "\n" +
                      "Kateqoriya :" + item.kateqoriya + "\n"
                    );

            }
            //geriye qayitmaq ucun
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");
            Program.init(mehsul1);

        }
        public void KateqoriyaGoreQaytarish()
        {
            Console.WriteLine("Secmek istediyiniz kateqoriyanin kodunu yazin :\n");
            Console.WriteLine("Yuyucuvasite = 0 \nIckiler = 1\nSiqaret = 2\nSudMehsullari=3\nEtMehsullari=4");
            int code = int.Parse(Console.ReadLine());
            for (int i = 0; i < Database.mehsuls.Count; i++)
            {
                if (Database.mehsuls[i].kateqoriya == (MehsulKateqoriya)code)
                {

                    Console.WriteLine(
                            "AD : " + Database.mehsuls[i].ad + "\n" +
                            "Qiymet :" + Database.mehsuls[i].qiymet + "\n" +
                            "Say :" + Database.mehsuls[i].say + "\n" +
                            "Kod :" + Database.mehsuls[i].kod + "\n" +
                            "Kateqoriya :" + Database.mehsuls[i].kateqoriya + "\n");
                }


            }
            //geriye qayitmaq ucun
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

            Program.init(mehsul1);
        }
        public void MeblegAraliginaGoreMehsulQaytarilmasi()
        {

            Console.WriteLine("Qiymetin araligi birinci(Neceden ) qiymet ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymetin araligi ikinci(Neceye) qiymet ");
            int j = Convert.ToInt32(Console.ReadLine());

            foreach (var item in Database.mehsuls)
            {
               
                if (i < item.qiymet && item.qiymet < j)
                {
                    Console.WriteLine("AD : " + item.ad + "\n" +
                                     "Qiymet :" + item.qiymet + "\n" +
                                      "Say :" + item.say + "\n" +
                                      "Kod :" + item.kod + "\n" +
                                      "Kateqoriya :" + item.kateqoriya + "\n"
                                    );
                }
                else
                {
                    Console.WriteLine("Bu qiymet araliginda mehsul tapilmadi ");
                    break;
                }
            }

            //geriye qayitmaq ucun
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");
            Program.init(mehsul1);


        }
        public void AdaEsasenSearch()
        {
            Console.WriteLine("Mehsulun adini daxil edin ");
            string axtarisAd = Console.ReadLine();


            foreach (var item in Database.mehsuls)
            {
                if (axtarisAd.ToUpper() == item.ad.ToUpper())
                {
                    Console.WriteLine("AD : " + item.ad + "\n" +
                                     "Qiymet :" + item.qiymet + "\n" +
                                      "Say :" + item.say + "\n" +
                                      "Kod :" + item.kod + "\n" +
                                      "Kateqoriya :" + item.kateqoriya + "\n"
                                    );
                }
                else
                {
                    Console.WriteLine("Bu adda mehsul tapilmadi ");
                    break;
                }
            }


            //geriye qayitmaq ucun
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

            Program.init(mehsul1);
        }

        //********************************************************************

        public int NomreyrEsasenSatishQaytarmaq()
        {
            throw new NotImplementedException();
        }

        public int QiymetAraligaGoreMehsulQaytarishi()
        {
            throw new NotImplementedException();
        }

        public int SatishELave()
        {
            throw new NotImplementedException();
        }

        public void SatishELave(int n)
        {
            
        }

        public void SatishReturn()
        {
            throw new NotImplementedException();
        }


        public void TarixeGoreAraligSatish()
        {
            throw new NotImplementedException();
        }

        public void TarixeGoreDateSatish()
        {
            throw new NotImplementedException();
        }

        public void UmumiSatish()
        {
            throw new NotImplementedException();
        }

        public void SatishDelete()
        {
            throw new NotImplementedException();
        }
    }
}
