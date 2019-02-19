using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareanro1
{
    class Program
    {
        static void Main (string[] args)
        {
           int [] array1 = new int[3];
            Console.WriteLine("Introduce los datos");
            for (int x = 0; x < 3; x++)
            {
                array1[x] = int.Parse( Console.ReadLine());
            }
            ordena1(array1);
            Console.ReadKey();
        }


         static void  ordena1 <T> (T[] array2)
          {
              Array.Sort(array2);

              Console.WriteLine("Ordenados:");
              for (int x = 0; x < 3; x++)
              {
                  Console.WriteLine(array2[x]);

              }
            
          }


       

       
       

    }
}
