using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat21();
            // feladat22();
            // feladat23();
            // feladat24();
            // feladat25();





            Console.WriteLine("ENTER");
            Console.ReadKey();
        }
        static void feladat21()
        {
            for (int i = 1; i < 6; i++)
            {


                for (int a = 1; a < 16; a++)
                {


                    int k = i * a;
                    Console.Write("{0} ", k);
                }
                Console.WriteLine();

                
            }

        }
        static void feladat22()
        {
            int a = 2;
            int b = 3;
            int c = 5;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("{0} ",a*b*c);
                a = a +1;
                b = b +2;
                c = c +3;
            }
            



        }
        static void feladat23()
        {
            int a = 5;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} ", 6*a*a);
                a = a + 2;
            }
        }
        static void feladat24()
        {
            int a;
            do
            {
                Console.WriteLine("Kérek egyszámot");
                 a = int.Parse(Console.ReadLine());

            } while (a!=0);
        }
        static void feladat25()
        {
            int a=-1;
            while (a < 0)
            {
              
                Console.WriteLine("Írj valamilyen számot -végtelen és +végtelen között!");
                a = int.Parse(Console.ReadLine());
            }
             
        }

        
    } 
}

