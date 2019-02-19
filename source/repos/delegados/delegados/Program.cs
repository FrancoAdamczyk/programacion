using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    delegate void Mdelegado();
    class Program
    {
        static void Main(string[] args)
        {
            Mdelegado del = new Mdelegado(metodo);
            del();
            Console.ReadKey();
        }
        static void metodo()
        {
            Console.WriteLine("ejecutando codigo");
        }
    }
}
