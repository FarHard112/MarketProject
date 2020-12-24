using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    class Satish : IMarketable
    {
        public void AdaEsasenSearch()

        {
            throw new NotImplementedException();
        }

        public void CreateMehsul()
        {

            throw new NotImplementedException();

        }

        public void KateqoriyaGoreQaytarish()
        {
            throw new NotImplementedException();
        }

        public void MeblegAraliginaGoreMehsulQaytarilmasi()
        {
            throw new NotImplementedException();
        }

        public void MeblegAraliginaGoreSatish()
        {
            throw new NotImplementedException();
        }

        public void  NomreyrEsasenSatishQaytarmaq()
        {

            Console.WriteLine("Satish Kodunu daxil edin ");
            int n = int.Parse(Console.ReadLine());
            foreach (var item in Database.satishes)
            {
                if (n==item.kod)

                {
                    Console.WriteLine("Elave olunan mehsul :" + "\n" +
                       "AD : " + item.ad + "\n" +
                                    "Qiymet :" + item.qiymet + "\n" +
                                     "Say :" + item.say + "\n" +
                                     "Kod :" + item.kod + "\n" +
                                     "Kateqoriya :" + item.kateqoriya + "\n"
                                  ); ;

                }
                else
                {
                    Console.WriteLine("Bele satish bazada yoxdur");
                }

            }
            
            
        }

        public int QiymetAraligaGoreMehsulQaytarishi()
        {
            throw new NotImplementedException();
        }

        public void SatishELave(int n)
        {

           
            foreach (var item in Database.mehsuls)
            {
                if (n == item.kod)
                {
                    Console.WriteLine("Elave olunan mehsul :" +"\n" +
                        "AD : " + item.ad + "\n" +
                                     "Qiymet :" + item.qiymet + "\n" +
                                      "Say :" + item.say + "\n" +
                                      "Kod :" + item.kod + "\n" +
                                      "Kateqoriya :" + item.kateqoriya + "\n"
                                   );;

                    Database.satishes.Add(item);
                    Database.mehsuls.Remove(item);
                    
                    Console.WriteLine("Satishlar elave edildi");


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
                else
                {
                    Console.WriteLine("Bu adda mehsul tapilmadi ");
                    break;
                }
            }




        }

        public void SatishReturn()
        {
            foreach (var item in Database.satishes)
            {
                Console.WriteLine(
                    "*** SATISHLAR" + "\n"+
                    "AD : " + item.ad + "\n" +
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

        void IMarketable.UpdateMeshul()
        {
            throw new NotImplementedException();
        }

        public void DeleteMehsul()
        {
            throw new NotImplementedException();
        }

        public void showMehsuls()
        {
            throw new NotImplementedException();
        }

        public void SatishDelete()
        {
            Console.Write("Silmek istediyiniz mehsulun kodunu yazin :");
            int code = int.Parse(Console.ReadLine());
            for (int i = 0; i < Database.satishes.Count; i++)
            {
                if (Database.satishes[i].kod == code)
                {
                    Console.WriteLine(Database.satishes[i].ad + " satish silindi...\n\n");
                    Database.satishes.RemoveAt(i);

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
                else
                {
                    Console.WriteLine("Satish tapilmadi");
                }
            }
        }

        public void MeblegeSatish()
        {

            Console.WriteLine("Qiymetin araligi birinci(Neceden (Kicik Qiymet) ) qiymet ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymetin araligi ikinci(Neceye (Boyuk Qiymet)) qiymet ");
            int j = Convert.ToInt32(Console.ReadLine());

            foreach (var item in Database.satishes)
            {

                if (i < item.qiymet && item.qiymet < j)
                {
                    Console.WriteLine("*** SATISHLAR : "+ "\n"+
                         item.ad + "\n" +
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
    }
}
