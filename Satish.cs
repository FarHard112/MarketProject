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

        public int NomreyrEsasenSatishQaytarmaq()
        {
            throw new NotImplementedException();
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

                    Console.WriteLine("***Mehsul \n " +
                                     "AD : " + item.ad + "\n" +
                                     "Qiymet :" + item.qiymet + "\n" +
                                     "Say :" + item.say + "\n" +
                                     "Kod :" + item.kod + "\n" +
                                     "Kateqoriya :" + item.kateqoriya + "\n"
                                    );
                    Console.Write("Tarixi daxil edin\nSaat:");
                    int saat = int.Parse(Console.ReadLine());
                    Console.Write("Deqiqe:");
                    int deqiqe = int.Parse(Console.ReadLine());

                    item.saat = saat;
                    item.deqiqe = deqiqe;

                    Database.satishes.Add(item);
                    Database.mehsuls.Remove(item);
                    
                    Console.WriteLine("Satishlar elave edildi");



                    //geriye donmek ucun
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
    }
}
