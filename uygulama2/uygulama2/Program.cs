using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 13;
            int z = 42;
            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
                
            }
            if (x > y && z == y && z < x)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }
            if(z>x && y < x)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");
            }
            if(x!=z || y <= z)
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Ynalış");
            }
            Console.ReadLine();
        }
    }
}
