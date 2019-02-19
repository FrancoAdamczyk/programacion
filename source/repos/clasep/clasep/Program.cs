﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasep
{
    class program
    {
        static void Main(string[] args)
        {
            persona[] personas = new persona[7];
            personas[0] = new persona("Diego" , "La torre",18,"masculino","12548798",1.75,75);
            personas[1] = new persona("Franco", "Adamczyk", 18, "masculino", "12609597", 1.73, 62);
            personas[2] = new persona("Carolina", "Lopez", 18, "femenino", "15879434", 1.68, 60);
            personas[3] = new persona("Gustavo", "Zarate", 19, "masculino", "8454458", 1.76, 65);
            personas[4] = new persona("Alejandro", "Castro", 19, "masculino", "45688798", 1.69, 70);
            personas[5] = new persona("Rossimar", "Guzman", 18, "femenino", "98632598", 1.58, 40);
            personas[6] = new persona("Dieter", "Quiñones", 19, "masculino", "16548798", 1.67, 57);



            var consulta1 = from alm in personas
                            select alm;

            var consulta2 = from alm in personas
                            where alm.edad > 18
                            select alm;

            var consulta3 = from alm in personas
                            orderby alm.apellidos
                            select new { alm.nombre, alm.apellidos };

            var consulta4 = from alm in personas
                            orderby alm.nombre, alm.apellidos descending
                            select alm;

            var consulta5 = from alm in personas
                            group alm by alm.edad into edad
                            select edad;

            foreach (var grupoedades in consulta5)
            {
                Console.WriteLine(grupoedades.Key);
                foreach (persona persona in grupoedades)
                {
                    Console.WriteLine("{0} {1}", persona.nombre, persona.apellidos);

                }
            }
            Console.WriteLine("-------------------------------------");

            var consulta6 = from alm in personas         
                            group alm by alm.edad into edad
                            select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var grupoedades in consulta6 )
            {
                Console.WriteLine("{0} {1}", grupoedades.Edad, grupoedades.Cantidad);
            }
            Console.WriteLine("-------------------------------------");

            var consulta7 = from alm in personas
                            orderby alm.apellidos descending
                            select alm;



            Console.ReadKey();
                            
        }
    }

        
    
}
