using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {   // UYGULAMA 1
            Console.WriteLine(24 / 3 * 4);//işlem önceliği soldan sağadır
            Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);//önce parntez sonra çarpma sonra bölme
            Console.WriteLine((5 - 1) * 2 - 1 + 7 * 7 / 2);//önce parntez sonra çarpma sonra bölme
            //UYGULAMA 2
           // double x = 20, y = 13, z = 42;
           // Console.WriteLine(23 == 55 && 76>45 && 5<12);//false
           // Console.WriteLine(x>y && z== y && z<x);//false 
           
            //UYGULAMA 3
            Console.Write("Bir Tam Sayı Girin(1) :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bir Tam Sayı Girin(2) :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 % sayi2 == 0)
            {
                Console.WriteLine("{0} sayısı {1} sayısına tam bölünür.", sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("{0} sayısı {1} sayısına tam bölünmez.", sayi1, sayi2);




               // UYGULAMA 5
               // Console.Write("A Değerini Girin
               // int a = Convert.ToInt32(Console.ReadLine());
               // Console.Write("B Değerini Giriniz = ");
               // int b = Convert.ToInt32(Console.ReadLine());
               // Console.Write("C Değerini Giriniz = ");
               // int c = Convert.ToInt32(Console.ReadLine());
               // double d = (b * b) - (4 * a * c);
               // if (d > 0)
               //{
               //     double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
               //    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
               //    Console.WriteLine("Denklemin İki Kökü Vardır = ");
               //   Console.WriteLine("x1 =" + x1);
               //     Console.WriteLine("x2 =" + x2);
               // }
               // else if (d == 0)
               // {
               //     double x = -b / (2 * a);
                //    Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                //    Console.WriteLine("x =" + x);
                //}
                //else
                //{
                //    Console.Write("Sanal Kök Vardır");
                //}

              //UYGULAMA 6



Console.Write("Derece değerini giriniz : ");

                int D = Convert.ToInt32(Console.ReadLine());

                double R = D * Math.PI / 180;

                double G = D * 200 / 180;

                Console.WriteLine("derecenin radyan cinsinden değeri = {0} ", R);

                Console.Write("derecenin grad cinsinden değeri = {0}", G);
                Console.ReadLine();
            }



        }
    }
}
