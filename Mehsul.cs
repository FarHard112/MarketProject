using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    class Mehsul:IMarketable
    {
      

        public void AdaEsasenSearch()
        {
            Console.WriteLine("Mehsulun adini daxil edin ");
            string axtarisAd = Console.ReadLine();
            

            foreach (var item in Database.mehsuls)
            {
                if (axtarisAd.ToUpper()==item.ad.ToUpper())
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
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Program.init(mehsul1);
        }

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

            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Program.init(mehsul1);


        }

        public int KateqoriyaGoreQaytarish()
        {
            throw new NotImplementedException();
        }

        public void MeblegAraliginaGoreMehsulQaytarilmasi()
        {
            
            Console.WriteLine("Qiymetin araligi birinci(Neceden ) qiymet ");
            int i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymetin araligi ikinci(Neceye) qiymet ");
            int j= Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("1:Mehsul uzerind emeliyyat");
            Console.WriteLine("2:Satish uzerinde emelliyyat");
            Console.WriteLine("3:Cixis");
            int mehsul1 = Convert.ToInt32(Console.ReadLine());
            Program.init(mehsul1);


        }

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

        public int UpdateMeshul()
        {
            throw new NotImplementedException();
        }

     
    }
}
