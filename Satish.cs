using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    class Satish:IMarketable  
    {

 
        public int nomre;
        public int meblegi;
        public string Satishtime;
        List<MehsulStructure> SatishS = new List<MehsulStructure>();


        enum SatishItem
        {
            Satishnomresi,
            Satishsayi,
            SatishMehsulu
        }
        
 
        public void AdaEsasenSearch()
 
        {
            throw new NotImplementedException();
        }

        public void CreateMehsul()
        {

            throw new NotImplementedException();

        }

        public int KateqoriyaGoreQaytarish()
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

            Console.WriteLine(n);
            foreach (var item in Database.mehsuls)
            {
                if (n==item.kod)
                {
                    Console.WriteLine("AD : " + item.ad + "\n" +
                                     "Qiymet :" + item.qiymet + "\n" +
                                      "Say :" + item.say + "\n" +
                                      "Kod :" + item.kod + "\n" +
                                      "Kateqoriya :" + item.kateqoriya + "\n"
                                    );

                    Database.satishes.Add(item);
                    Database.mehsuls.Remove(item);
                    Console.WriteLine("Satishlar elave edildi");
                    Console.WriteLine("1:Mehsul uzerind emeliyyat");
                    Console.WriteLine("2:Satish uzerinde emelliyyat");
                    Console.WriteLine("3:Cixis");
                    int mehsul1 = Convert.ToInt32(Console.ReadLine());
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

      


        // enum SatishItem
        //  {
        //     Nomre,
        // /        Mehsul,
        ///           Say
        //  }


    }
}
