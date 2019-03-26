using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialej1
{
    class piladocentes<docente>
    {
        public const int maximo = 15;
        private docente[] vector = new docente[maximo];

        private int tope = -1;

        public void insertarNombre(docente valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarEdad(docente valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public void insertarSexo(docente valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public void insertarCarrera(docente valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
            {
                Console.WriteLine("La pila esta llena");
            }
        }
        public docente eliminarEdad()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[tope];
            }
        }
        public docente eliminarNombre()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return vector[tope];
            }
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine("{0}", vector[i]);

            }


        }
        private Boolean vacia()
        {
            return tope == -1;
        }
        private Boolean llena()
        {
            return tope == maximo;

        }
    }
}

