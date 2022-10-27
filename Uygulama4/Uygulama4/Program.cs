using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            int gg, aa, yyyy;
            Console.WriteLine("gün giriniz");
            gg = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ay giriniz");
            aa = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("yıl giriniz");
            yyyy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(gg + "." + aa + "." + yyyy);
            switch (aa)
            {
                case 1:
                    Console.WriteLine("ocak");
                    break;
                case 2:
                    Console.WriteLine("şubat");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("nisan");
                    break;
                case 5:
                    Console.WriteLine("mayıs");
                    break;
                case 6:
                    Console.WriteLine("haziran");
                    break;
                case 7:
                    Console.WriteLine("temmuz");
                    break;
                case 8:
                    Console.WriteLine("ağustos");
                    break;
                case 9:
                    Console.WriteLine("eylül");
                    break;
                case 10:
                    Console.WriteLine("ekim");
                    break;
                case 11:
                    Console.WriteLine("kasım");
                    break;
                case 12:
                    Console.WriteLine("aralık");
                    break;
                default:
                    Console.WriteLine("ay bulunamadı tekrar deneyin");
                    break;
            }
            Console.ReadLine();
        }
    }
}
