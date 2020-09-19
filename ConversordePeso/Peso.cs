using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordePeso
{
    public class Peso
    {
        private double valorIngresado;

        public void setValorIngresado(double valor)
        {
            this.valorIngresado = valor;
        }

        public double getValorIngresado()
        {
            return this.valorIngresado;
        }
    }
}
