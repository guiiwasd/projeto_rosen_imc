using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_rosen_imc
{
    public class CalculoIMC
    {
        public static double IMCTotal(double alturaIMC, double pesoIMC)
        {
            return pesoIMC / (alturaIMC * alturaIMC);
        }
    }
}

