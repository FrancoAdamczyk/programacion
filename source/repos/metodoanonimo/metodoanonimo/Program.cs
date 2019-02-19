using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoanonimo
{
    class Program
    {
        delegate int mdelegate(int a, int b);
        static void Main(string[] args)
        {
            mdelegate del = delegate (int a, int b)

            { return a + b; };

            Console.WriteLine(del(4, 5));

            Console.ReadKey();

        }
    }
}
