using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordePeso
{
    public class Gramos : Peso
     {
        public double convertirAGramos()
        {
            return getValorIngresado() * 1000;
        }
    }
}
