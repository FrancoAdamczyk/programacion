using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        delegate int serie(int n);
        static void Main(string[] args)
        {
            serie fibonacci = null;
            fibonacci = (n) =>
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else return fibonacci(n - 2) + fibonacci(n - 1);
            };
            Console.WriteLine(fibonacci(6));
            Console.ReadKey();
            
          

        }
    }
}
