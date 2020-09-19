using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordePeso
{
    public class Decagramos : Peso
    {
        public double convertirADecagramos()
        {
            return getValorIngresado() * 100;
        }
    }
}
