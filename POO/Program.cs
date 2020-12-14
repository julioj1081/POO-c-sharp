using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //array de objetos y un limite
            //añadir coche (Coche c)
            //mostrar coches
            //vaciar coches
            //eliminar coches (Coche c)
            Concesionario conse = new Concesionario(10);
            Coche c1 = new Coche(1, "BMW", "4", 100, 12000);
            Coche c2 = new Coche(2, "Toyota", "auris", 200, 12000);
            Coche c3 = new Coche(3, "Sedan", "rosca", 500, 12000);
            Coche c4 = new Coche(4, "Ferrary", "204", 1200, 12000);

            Console.WriteLine("Todos los coches actual mente");
            conse.añadirCoche(c1);
            conse.añadirCoche(c2);
            conse.añadirCoche(c3);
            conse.añadirCoche(c4);

            conse.mostrarCoches();
            Console.WriteLine("Se elimino el coche Sedan");
            conse.eliminarCoches(c3);
            Console.WriteLine("Todos los coches despues");
            conse.mostrarCoches();
            Console.WriteLine("Vacio");
            conse.vaciarCoches();
            Console.WriteLine("Todos los coches despues del vacio");
            conse.mostrarCoches();
            Console.WriteLine("Llego un nuevo auto");
            Coche c5 = new Coche(5, "Bocho", "Bowx", 80, 10000);
            conse.añadirCoche(c5);
            Console.WriteLine("Todos los autos actualmente");
            conse.mostrarCoches();
            Console.ReadKey();
        }
    }
}
