using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejeventos
{
    class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            operaciones o = new operaciones();
            o.cuandomultiplodetres += sumatoria;
            Console.WriteLine("El factorial de {0} es {1}", n, o.factorial(n));
            Console.ReadKey();
        }
          static void sumatoria(int x = 0)
          {
            int i;

            for (i = 1; i <= n; i++)
            {
                x = x + i;

            }
            Console.WriteLine("La sumatoria es:" + x);
            Console.ReadKey();
          }
    }
    class operaciones
    {
        public delegate void delegado (int n);
        public event delegado cuandomultiplodetres;

        public int factorial(int n)
        {
            int i, x=1 ;
           
            for (i=1; i<=n; i++)
            {
                x =x* i;
               
            }
            if (x % 3 == 0 && cuandomultiplodetres!=null)
            {
                cuandomultiplodetres(n);
            }
            return x;   
        }
    }
}
                