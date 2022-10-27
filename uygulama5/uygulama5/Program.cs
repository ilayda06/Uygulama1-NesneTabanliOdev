using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Derece değerini giriniz : ");

            int D = Convert.ToInt32(Console.ReadLine());

            double R = D * Math.PI / 180;

            double G = D * 200 / 180;

            Console.WriteLine("derecenin radyan cinsinden değeri = {0} ", R);

            Console.Write("derecenin grad cinsinden değeri = {0}", G);

            Console.ReadKey();
        }
    }
}
