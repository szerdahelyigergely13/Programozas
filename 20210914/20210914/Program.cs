using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210914
{
    class Program
    {

        static void Main(string[] args)
        {

            //feladat1();
            //feladat2();
            //feladat3();
            feladat4();


            Console.WriteLine("ENTER");
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.WriteLine("Hello world!");



        }
        static void feladat2()
        {
            Console.WriteLine("Írd be a neved!");
            Console.ReadLine();
            Console.WriteLine("Hello!");
        }
        static void feladat3()
        {
            Console.WriteLine("Írd be a neved!");
            Console.ReadLine();

            Console.WriteLine("Hello!");
        }
        static void feladat4()
        {
            Console.WriteLine("Írj be egy számot!");
            int a = int.Parse(Console.ReadLine());
            {

            }
            int b = 2;
            {

            }
            int d = a * b;
            {
                Console.WriteLine("Szorzott szám={0}", d);
            }
        }
    }
}
