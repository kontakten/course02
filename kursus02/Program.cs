using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kursus02
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int resultat = LaegSammen(5, 6);

            double areal = BeregnAreal(5);

            string text = UdskrivTxt("test");

            Console.WriteLine($"resultatet: {resultat}");

            Console.WriteLine($"Arealet er følgende: {areal}");

            Console.WriteLine($"Udskriver følgende string: {text}");

            Console.WriteLine(Beregn(1,2));

            Console.WriteLine(Beregn(1, 2, 3));

            Console.WriteLine(Beregn(1, 2, 3, 4));

            RekursivMetode(1,100);

            var testT = TestTuple();

            Console.WriteLine($"tuple result: {testT.a}, {testT.b}");

            File.WriteAllText(@"c:\temp\test.txt", "Hej Mikkel. Jeg tilføjer tekst");

            string textData;

            if (File.Exists(@"c:\temp\test.txt"))
            {
                var filObj = new FileInfo(@"c:\temp\test.txt");

                textData = File.ReadAllText(@"c:\temp\test.txt");

                Console.WriteLine(filObj.LastAccessTime);

                Console.WriteLine(filObj.Extension);

                Console.WriteLine($"Der står følgende i filen: {textData}");


            }



            Console.ReadKey();

        }

        static (int a, int b) TestTuple()
        {
            return (10, 20);
        }

        static double BeregnAreal(int radius)
        {
            return (radius * radius) * 3.1415;
        }
        static int LaegSammen(int a, int b)
        {
            return a + b;
        }
        static string UdskrivTxt(string txt)
        {
            return txt;
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }
        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }
        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }

        static void RekursivMetode(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            RekursivMetode(start,stop);
        }


        
    }
}
