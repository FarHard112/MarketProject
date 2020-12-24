using System;
using System.IO; 
using System.Collections.Generic;

namespace MarketProject
{
    class Program 
    {
        static public Mehsul mehsul = new Mehsul();
        static public  Satish satish1 = new Satish();
        static void Main(string[] args)
        {
     
            //hazir datani elave elemek
             Database.addData();

             Console.WriteLine("1:Mehsul uzerind emeliyyat");
             Console.WriteLine("2:Satish uzerinde emelliyyat");
             Console.WriteLine("3:Cixis");

                int mehsul1 =Convert.ToInt32(Console.ReadLine());
                init(mehsul1);

            Console.ReadLine();
           
        }
        static public void init(int mehsul1)
        {
            if (mehsul1 == 1)
            {
                #region Mehsullar uzerinde emeliyyatlar (Komandlar)
                Console.WriteLine("1.Yeni mehsul elave et  ");
                Console.WriteLine("2.Mehsul uzerinde duzelis et   ");
                Console.WriteLine("3.Mehsulu sil -   ");
                Console.WriteLine("4.Butun mehsullari goster   ");
                Console.WriteLine("5.Categoriyasina gore mehsullari goster  ");
                Console.WriteLine("6.Qiymet araligina gore mehsullari goster  ");
                Console.WriteLine("7.Mehsullar arasinda ada gore axtaris et  ");
                Console.WriteLine("0.Geri");

                //secim
                int mehsuldaxili = Convert.ToInt32(Console.ReadLine());

                if (mehsuldaxili == 1)
                {
                    mehsul.CreateMehsul();
                }
                else if (mehsuldaxili == 2)
                {
                    mehsul.UpdateMeshul();
                }
                else if (mehsuldaxili == 3)
                {
                    mehsul.DeleteMehsul();
                }
                else if (mehsuldaxili == 4)
                {
                    mehsul.showMehsuls();
                }
                else if (mehsuldaxili == 5)
                {
                    mehsul.KateqoriyaGoreQaytarish();
                }
                else if (mehsuldaxili == 6)
                {
                    mehsul.MeblegAraliginaGoreMehsulQaytarilmasi();
                }
                else if (mehsuldaxili == 7)
                {
                    mehsul.AdaEsasenSearch();
                }
                else if(mehsuldaxili == 0)
                {
                    Console.Clear();
                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");

                    int mehsul2 = Convert.ToInt32(Console.ReadLine());
                    init(mehsul2);
                }
                else
                {
                    Console.WriteLine("Hec bir kod uygun gelmedi");
                }

                #endregion
            }
            else if (mehsul1 == 2)
            {
                #region  SATISH KOMANDALAR
                Console.WriteLine("1 Yeni satis elave etmek ");
                Console.WriteLine("2 Satisdaki hansisa mehsulun geri qaytarilmasi( satisdan cixarilmasi");
                Console.WriteLine(" 3 Satisin silinmesi - satisin nomresine esasen silinmesi");
                Console.WriteLine("4 Butun satislarin ekrana cixarilmasi (");
                Console.WriteLine("- 5 Verilen tarix araligina gore satislarin gosterilmesi ");
                Console.WriteLine("6 Verilen mebleg araligina gore satislarin gosterilmesi - userden qebul edilen iki mebleg araligindaki satislarin gosterilmesi ");
                Console.WriteLine("7 Verilmis bir tarixde olan satislarin gosterilmesi ");
                Console.WriteLine("8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi ");
                int satishdaxili = Convert.ToInt32(Console.ReadLine());

                if (satishdaxili == 1)
                {
                    Console.WriteLine("Kodu daxil edin");
                    int i =int.Parse(Console.ReadLine());
                    satish1.SatishELave(i);

                }
                else if (satishdaxili == 2)
                {
                    //Console.WriteLine("Mehsul Kodu daxil ele");
                    //int i = int.Parse(Console.ReadLine());
                    //satish1.SatishELave(i);

                }
                else if (satishdaxili == 3)
                {
                    satish1.SatishDelete();

                }
                else if (satishdaxili == 4)
                {
                    satish1.SatishReturn();

                }
                else if (satishdaxili == 5)
                {

                    satish1.TarixeGoreAraligSatish();
                }
                else if (satishdaxili == 6)
                {
                    satish1.MeblegeSatish();
                }
                else if (satishdaxili == 7)
                {
                    satish1.TarixeGoreDateSatish();

                }
                else if (satishdaxili == 8)
                {
                    satish1.MeblegeSatish();

                }



                #endregion
            }
            else if (mehsul1 == 3)
            {
                //CIXIS 
                Console.WriteLine("Sistemden cixildi ");
                Console.Clear();
            }



        }
    }
    
}
