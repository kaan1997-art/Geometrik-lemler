using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrikİşlemler.Class.Base
{
    class DaireSekil
    {
        public double YariCap { get; set; }

        public double AlanSonuc()
        {
            return Math.PI * YariCap * YariCap;
        }
        public double CevreSonuc()
        {
            return Math.PI * YariCap * 2;
        }
    }
}
