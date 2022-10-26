using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetwin
{
     class Program
    {
        
        public static int somme(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Bonjour");
            Console.WriteLine(somme(15, 20));
            Console.WriteLine(somme(15, 39));
            Console.ReadLine();
        } 

     }
}

