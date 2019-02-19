using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class inventario
    {
        private int stock;
        public inventario()
        {
           this.stock = 0;
        }
        public void incrementarstock(int n)
        {
            this.stock += n;
            if (this.stock < 5 && )
        }
       public void disminuirstock(int n)
        {
           if( this.stock < n)
            {
                Console.WriteLine("EL stock no esta dsiponible");
                Console.ReadKey();
            }
           else
            {
                this.stock -= n;
            }
        }
        public void mostrarstock()
        {
            Console.WriteLine("El stock actual en {0} " , this.stock);
        }
    }
    class program
    {
        static void Main (string[] arg)
        {
            inventario inv = new inventario();
            
            Boolean salir = false;
            while (salir == false)
            {


                Console.Clear();
                Console.WriteLine("1. Incrementar");
                Console.WriteLine("2. Disminuir");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("ELIJA UNA OPCION");
                int op = int.Parse(Console.ReadLine());
                int n;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese n");
                        n = int.Parse(Console.ReadLine());
                        inv.incrementarstock(n);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese n");
                        n = int.Parse(Console.ReadLine());
                        inv.disminuirstock(n);
                        break;
                    case 3:

                        inv.mostrarstock();
                        break;
                    case 4:

                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                Console.ReadKey();

            }
           
        }
        static void abc(int n)
        {
            Console.WriteLine("El stock esta en su minimo {0}", n);
            Console.ReadKey();
        }
    }
}
