using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados1
{
    delegate int aritmetica(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoOperacion(new aritmetica(multiplicacion) , 10,2));
            Console.WriteLine(DoOperacion(new aritmetica(division), 10, 2));
            Console.ReadKey();

        }
        static int DoOperacion(aritmetica op , int x , int y)
        {
            return (op(x, y));
        }
        static int multiplicacion (int x, int y)
        {
            return (x * y);
        }
        static int division(int x, int y)
        {
            return (x / y);
        }

    }
}
