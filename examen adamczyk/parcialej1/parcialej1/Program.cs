using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            piladocentes<string> p = new piladocentes<string>();
            piladocentes<int> pi = new piladocentes<int>();
            int opcion = 0;
            int edad = 0;
            string nombre, sexo, carrera;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por delante");
                Console.WriteLine("2. Insertar por detras");
                Console.WriteLine("3. Eliminar por delante");
                Console.WriteLine("4. Eliminar por detras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Insertar Nombre");
                        nombre = Console.ReadLine();
                        p.insertarNombre(nombre);
                        Console.WriteLine("Insertar Edad");
                        edad = int.Parse(Console.ReadLine());
                        pi.insertarEdad(edad);
                        Console.WriteLine("Insertar Sexo");
                        sexo = Console.ReadLine();
                        p.insertarSexo(sexo);
                        Console.WriteLine("Insertar Carrera");
                        carrera = Console.ReadLine();
                        p.insertarCarrera(carrera);
                        break;



                    case 3:
                        edad = pi.eliminarEdad();
                        nombre = p.eliminarNombre();
                        sexo = p.eliminarNombre();
                        carrera = p.eliminarNombre();
                        Console.WriteLine("Eliminado Nombre " + nombre);
                        Console.WriteLine("Eliminado edad " + edad);
                        Console.WriteLine("Eliminado sexo " + sexo);
                        Console.WriteLine("Eliminado carrera " + carrera);
                        Console.ReadKey();
                        break;





                    case 5:

                        p.mostrar();
                        pi.mostrar();
                        Console.ReadKey();
                        break;
                    case 6:

                        break;
                }
            }
        }
    }
}
