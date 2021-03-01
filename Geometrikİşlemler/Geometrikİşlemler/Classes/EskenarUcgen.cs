using Geometrikİşlemler.Class.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrikİşlemler.Classes
{
    class EskenarUcgen : KenarliSekiller, ISonuc
    {
        public double AlanSonuc()
        {
            return Taban * Yukseklik;
        }

        public double CevreSonuc()
        {
            return (Taban + Yukseklik) * 3;
        }
    }
}
