using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windoappPractica
{
    internal class Class1
    {
        int baseI,alturaI;
        public Class1(int baser, int alturar)
        {
            this.baseI = baser;
            this.alturaI = alturar;

        }
        public double AreaTrian()
        {
            return baseI * alturaI / 2;
        }
   
    }
}
