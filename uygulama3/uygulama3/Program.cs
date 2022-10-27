using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
        bas:
            Console.WriteLine("Bir Sayı Giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bir Sayı Giriniz: ");

            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (sayi2 == 0)
            {
                Console.WriteLine("Bölen Değer 0 Olamaz");
                goto bas;
            }
            else
            {
                double bolum = sayi1 / sayi2;
                Console.WriteLine(bolum);

            }
            Console.ReadKey();



        }


        }
    }

