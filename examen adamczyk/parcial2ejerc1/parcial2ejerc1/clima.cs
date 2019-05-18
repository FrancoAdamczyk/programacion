using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2ejerc1
{
    class clima
    {
        private double temperatura = 0;
        private static clima instance;
        private clima()
        {

        }
        public void colocartemperatura(double temp)
        {

            temperatura = temp;
        }
       
       
        public static clima getInstance()
        {
            if (instance == null)
                instance = new clima();

            return instance;
        }
        public string obtenertemp()
        {
            return temperatura.ToString();
        }
    }
}
