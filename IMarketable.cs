using System;
using System.Collections.Generic;
using System.Text;

namespace MarketProject
{
    interface IMarketable
    {
        public void  SatishELave(int n);
        public void SatishReturn();
        public void UmumiSatish();
        public void TarixeGoreAraligSatish();
        public void TarixeGoreDateSatish();
        public void MeblegAraliginaGoreMehsulQaytarilmasi();
        public int NomreyrEsasenSatishQaytarmaq();
        public void CreateMehsul();
        public void UpdateMeshul();
        public void KateqoriyaGoreQaytarish();
        public int QiymetAraligaGoreMehsulQaytarishi();
        public void AdaEsasenSearch();
        public void DeleteMehsul();
        public void showMehsuls();
        public void SatishDelete();

        
    }
}
