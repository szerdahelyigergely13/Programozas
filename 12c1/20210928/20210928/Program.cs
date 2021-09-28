using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210928
{

    class Program
    {
        static void Main(string[] args)
        {
            // feladat11();
            // feladat12();
            // feladat13();
            // feladat14();
            // feladat15();
            // feladat16();
            feladat20();









            Console.WriteLine(" ENTER ");
            Console.ReadKey();
        }
        static void feladat11()
        {
            for (int i = -30; i < 31; i = i + 5)
            {
                Console.Write(i + " ");
            }

        }
        static void feladat12()
        {
            for (int i = 3; i < 52; i = i + 3)
            {
                Console.Write(i + " ");
            }

        }
        static void feladat13()
        {
            for (int i = 2; i < 65537; i = i * 2)
            {
                Console.Write(i + " ");
            }

        }
        static void feladat14()
        {
            for (int i = 1; i < 26; i++)
            {
                if (i * 7 % 4 == 0)
                {
                    Console.Write("{0} ", i * 7);
                }

            }
            Console.WriteLine();
        }
        static void feladat15()
        {
            for (int i = 1;i<145;i++)
            {
                if (144 % i == 0)
                {
                    Console.Write("{0} ", i);
                }

            }

        }
        static void feladat16()
        {
            Console.WriteLine("Írj be egy számot!");
            int i = int.Parse(Console.ReadLine());

            for (int b = 1; ; b++)
            {
                
            }
            
        }
        static void feladat20()
        {

            for (int i = 1; i < 26; i++)
            {
                if (i * 8)
                {
                    Console.Write("{0} ", i * 8);
                }

            }
            Console.WriteLine(); 
        }






























    }
}