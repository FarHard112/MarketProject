using System.Collections.Generic;


namespace MarketProject
{
    class Database
    {
        
        static public List<MehsulStructure> mehsuls = new List<MehsulStructure>();
        static public List<MehsulStructure> satishes = new List<MehsulStructure>();

       
        static public void addData()
        {
            MehsulStructure mehsul_1 = new MehsulStructure();

          
            mehsul_1.ad = "Winston";
            mehsul_1.qiymet = 3.50f;
            mehsul_1.say = 2;
            mehsul_1.kod = 1;
            mehsul_1.kateqoriya = MehsulKateqoriya.Siqaret;
            mehsuls.Add(mehsul_1);
        }

    }
    
}
