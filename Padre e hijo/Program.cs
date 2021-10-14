using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padre_e_hijo

{
    class Program
    {
        static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(98, 76);
            Console.WriteLine(a.ToString());

            Punto2D b;
            b = new Punto2D(30, 21);

            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine("Distancia " + d);

            Punto3D c;
            c = new Punto3D(98, 76, 102);
            Console.WriteLine(c.ToString());

            c = new Punto3D(95, 60, 201);
            Console.WriteLine(c.ToString());

            c = new Punto3D(84, 71, 11);
            Console.WriteLine(c.ToString());

            Console.WriteLine("Distancia " + d);


        

            Console.ReadKey();
        }
        
    }
}