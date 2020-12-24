using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{

    [System.Serializable]
    class MehsulStructure 
    {
        public string ad;
        public float qiymet;
        public int say;
        public int kod;
        public MehsulKateqoriya kateqoriya;

    }
    enum MehsulKateqoriya
    {
        Yuyucuvasite,
        Ickiler,
        Siqaret,
        SudMehsullari,
        EtMehsullari

    }
}
