using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Docentes[] Docente = new Docentes[4];
            Docente[0] = new Docentes("Juan", "Perez", 35, "Ing Industrial", "Diniosio,Pedro,juan", "M");
            Docente[1] = new Docentes("Maria", "Gomez", 33, "Ing Civil", "Marcela,Ricardo,Maria", "F");
            Docente[2] = new Docentes("Pedro", "Vaca", 35, "Ing civil", "Marcela", "M");
            Docente[3] = new Docentes("Marta", "Aramayo", 40, "Ing Industrial", "Diniosio,Pedro,juan", "F");



            Console.WriteLine("4.- lista de docentes ordenadas descendentemente por carrera y luego por apellido");
            //
            var consulta1 = from alm in Docente
                            orderby alm.Carrera descending, alm.Apellido
                            select alm;
            foreach (var p in consulta1)
            {
                Console.WriteLine("{0}, {1}", p.Carrera, p.Apellido);
            }

            Console.WriteLine("********************************");
            Console.WriteLine("2.-lista de doscentes mayores de 35");

            var consulta2 = from alm in Docente
                            where alm.Edad > 35
                            select alm;
            foreach (var p in consulta2)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellido);
            }

            Console.WriteLine("************************");
            Console.WriteLine("3.-Cantidad de docentes por sexo");
            var consulta3 = from almu in Docente
                            group almu by almu.Sexo into sexo
                            select new { Sexo = sexo.Key, Cantidad = sexo.Count() };
            foreach (var grupoedad in consulta3)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Cantidad);

            }


            Console.WriteLine("************************");
            Console.WriteLine("3.-Cantidad de docentes por sexo masculino y edad=35");

            var consulta4 = from almu in Docente
                            where almu.Sexo.Contains("M") && almu.Edad == 35
                            group almu by almu.Sexo into sexo
                            
                            select new { Sexo = sexo.Key, Cantidad=sexo.Count() };
            foreach (var gruposexo in consulta4)
            {
                Console.WriteLine("{0} {1}", gruposexo.Sexo,gruposexo.Cantidad);

            }
            Console.ReadKey();

        }
    }

}

        
    

