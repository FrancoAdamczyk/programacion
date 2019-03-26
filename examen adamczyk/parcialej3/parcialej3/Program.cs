using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialej3
{
    public class multiplo
    {
        public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplotres; 
        public double multiplicacion(double x)
        {
            int imult = 0;

            if ((imult % 3 == 0) && (CuandoRecibaMultiplotres != null)) 
            { CuandoRecibaMultiplotres(imult); }
            return imult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z,mult,prod;
            multiplo m = new multiplo();
            Console.WriteLine("introduzca el primer numero");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el segundo numero");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca el tercer numero");
            z= int.Parse(Console.ReadLine());
            mult = x * y * z;
            prod = mult / 2;
            if (mult %3 ==0)
            {
                m.multiplicacion(mult);
            }
            Console.ReadKey();
        }
        
        
    }
    
}