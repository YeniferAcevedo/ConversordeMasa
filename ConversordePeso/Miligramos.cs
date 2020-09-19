using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordePeso
{
    public class Miligramos : Peso
    {
        public double convertirAMiligramos()
        {
            return getValorIngresado() * 1000000;
        }
    }
}
