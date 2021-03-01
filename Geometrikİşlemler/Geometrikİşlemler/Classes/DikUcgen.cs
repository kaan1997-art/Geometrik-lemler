using Geometrikİşlemler.Class.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrikİşlemler.Classes
{
    class DikUcgen : KenarliSekiller, ISonuc
    {
        public double Hipotenus;
        public double AlanSonuc()
        {
            return Taban * Yukseklik / 2;
        }
      

        public double CevreSonuc()
        {
            Hipotenus = Math.Sqrt(Math.Pow(Taban, 2) + Math.Pow(Yukseklik, 2));
            return Taban + Yukseklik + Hipotenus;
        }
    }
}
