using System;

namespace Uppgift2_1_
{

   class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("vilken satd kommer du ifrån");
            string stad = Console.ReadLine();
            Console.WriteLine("vilken är din drömresmål?");
            string resmål = Console.ReadLine();
            Console.WriteLine("Hej" + stad + "sbo. jag hoppas att du får resa till" + resmål + ".");
            Console.ReadKey();
        }
   }
}