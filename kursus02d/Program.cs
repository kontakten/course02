using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus02d
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();

            P1.Fornavn = "Mikkel";
            P1.Efternavn = "Stensgaard";
            P1.Fødselsdato = 1988;

            Console.WriteLine(P1.FuldtNavn());
            Console.WriteLine(P1.Alder());


            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            var sum = Beregninger.LægSammen(1, 5);

            var subtract = Beregninger.TrækFra(10, 6);

            Console.WriteLine($"summen: {sum}");

            Console.WriteLine($"subtract {subtract}");

            Console.ReadLine();
        }
    }
}
