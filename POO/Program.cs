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
            Coche c = new Coche(1, "BMW", "4", 100, 12000);
            Console.WriteLine(c.id);
            Console.WriteLine(c.Marca);
            Console.WriteLine(c.Modelo);
            Console.WriteLine(c.Km);
            Console.WriteLine(c.Precio);
            //agregar nuevo valor 
            c.Precio = 15000;
            //return 
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
