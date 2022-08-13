using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace pruebas_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //@string palabra = new @string();
            //palabra.crear();
            //foreach(string s in palabra.Vecpalabra11)
            //{
            //    Console.WriteLine(s);
            //}
            //palabra.quick();
            //Console.WriteLine("///////////////////////////////////////////////////");
            //foreach (string a in palabra.Vecpalabra51)
            //{
            //    Console.WriteLine(a);
            //}
            @decimal vecdecimal = new @decimal();
            vecdecimal.crear(5000);
            vecdecimal.MergeSort();
            foreach (var item in vecdecimal.Vecdecimal3)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
   


