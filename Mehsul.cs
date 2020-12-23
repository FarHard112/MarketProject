using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    class Mehsul:IMarketable
    {
      

        public int AdaEsasenSearch()
        {
            throw new NotImplementedException();
        }

        public void CreateMehsul()
        {
            MehsulStructure yeniMehsul = new MehsulStructure();
            Console.WriteLine("Mehsulun adin daxil et");
            string MehsulunAd = Console.ReadLine();
            yeniMehsul.ad = MehsulunAd;

            Console.WriteLine("Qiymeti daxil edin");
            int MehsulQiymet = Convert.ToInt32(Console.ReadLine());
            yeniMehsul.qiymet = MehsulQiymet;

            Console.WriteLine("Mehsulun sayini daxil edin");
            int MehsulSayi = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Barkodu Elave Et");
            int MehsulBarkod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mehsul Melumatlari daxil edilidi");
        }

        public int KateqoriyaGoreQaytarish()
        {
            throw new NotImplementedException();
        }

        public void MeblegAraliginaGoreMehsulQaytarilmasi()
        {
            int qiymet = 30;
            Console.WriteLine("Qiymetin araligi birinci(Neceden ) qiymet ");
            int i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymetin araligi ikinci(Neceye) qiymet ");
            int j= Convert.ToInt32(Console.ReadLine());
            while (i<j)
            {
                if (i<qiymet||qiymet<j)
                {
                    Console.WriteLine(qiymet);
                }
                else
                {
                    Console.WriteLine("Bu qiymet araliginda mehsul tapilmadi ");
                    break;
                }
            }

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
