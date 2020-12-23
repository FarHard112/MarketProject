 
// burda salam deyazi var



using System;
using System.IO; 
using System.Collections.Generic;

namespace MarketProject
{
    class Program 
    {
        static void Main(string[] args)
        {

            // Database.mehsuls.Add("Winston", 3.50f, 2, 1212, MehsulKateqoriya.Siqaret);
            Database.addData();



            Console.WriteLine("1:Mehsul uzerind emeliyyat");
                Console.WriteLine("2:Satish uzerinde emelliyyat");
                Console.WriteLine("3: Cixis");

                int mehsul1 =Convert.ToInt32(Console.ReadLine());
            //Mehsullar aid komandalar
                if (mehsul1 == 1)
                {
                #region Mehsullar uzerinde emeliyyatlar (Komandlar)
                Console.WriteLine("1.Yeni mehsul elave et  ");
                Console.WriteLine("2.Mehsul uzerinde duzelis et   ");
                Console.WriteLine("3.Mehsulu sil -   ");
                Console.WriteLine(" 4.Butun mehsullari goster   ");
                Console.WriteLine("5.Categoriyasina gore mehsullari goster  ");
                Console.WriteLine("6.Qiymet araligina gore mehsullari goster  ");
                Console.WriteLine("7.Mehsullar arasinda ada gore axtaris et  ");
              
                int mehsuldaxili = Convert.ToInt32(Console.ReadLine());
                if (mehsuldaxili == 1)
                {
                    Mehsul mehsul = new Mehsul();
                    mehsul.CreateMehsul();
                }
                else if (mehsuldaxili == 2)
                {
                    Console.Write(" Duzelis etmek istediyiniz mehsulun:|| Kodu daxil edin :");
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

                        }

                    }

                }
                else if (mehsuldaxili == 3)
                {
                    Console.Write("Silmek istediyiniz mehsulun kodunu yazin :");
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

                            Database.mehsuls.RemoveAt(i);
                            Console.WriteLine("Mehsul SILINDI...\n\n");
                        }
                    }
                }
                else if (mehsuldaxili == 4)
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
                }
                else if (mehsuldaxili == 5)
                {

                }
                else if (mehsuldaxili == 6)
                {

                }
                else if (mehsuldaxili == 7)
                {

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
                Console.WriteLine(" - 3 Satisin silinmesi - satisin nomresine esasen silinmesi");
                Console.WriteLine("4 Butun satislarin ekrana cixarilmasi (");
                Console.WriteLine("- 5 Verilen tarix araligina gore satislarin gosterilmesi ");
                Console.WriteLine("6 Verilen mebleg araligina gore satislarin gosterilmesi - userden qebul edilen iki mebleg araligindaki satislarin gosterilmesi ");
                Console.WriteLine("7 Verilmis bir tarixde olan satislarin gosterilmesi ");
                Console.WriteLine("8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi ");
               int satishdaxili = Convert.ToInt32(Console.ReadLine());

                if (satishdaxili==1)
                {
                    Console.WriteLine("Satish lari elave et ");

                }
                else if (satishdaxili==2)
                {
                    Console.WriteLine("Satisdaki");

                }
                else if (satishdaxili == 3)
                {

                }
                else if (satishdaxili == 4)
                {


                }
                else if (satishdaxili == 5)
                {


                }
                else if (satishdaxili == 6)
                {


                }
                else if (satishdaxili == 7)
                {


                }
                else if (satishdaxili == 8)
                {


                }
                


                #endregion 
            }


            else if (mehsul1 == 3)
                {
                //CIXIS 
                    Console.WriteLine("Sistemden cixildi ");
                    Console.Clear();
                }





            Console.ReadLine();
           
        }
    }
}
