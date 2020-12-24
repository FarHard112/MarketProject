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
        public int saat;
        public int deqiqe;
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
