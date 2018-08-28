using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus02b
{
    class Program
    {

        
        static void Main(string[] args)
        {

            string path = "c:\\temp\\tal.txt";

            if (!System.IO.File.Exists(path))
                throw new ApplicationException("Filen c:\\temp\\tal.txt findes ikke!");

            ValidateData(path);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void ValidateData(string path)
        {
            try
            {

                var fileContent = System.IO.File.ReadAllText(path);

                int number = Convert.ToInt32(fileContent);

                int addedNumber = 1337;

                int sum = addedNumber + number;

                System.IO.File.WriteAllText(path, sum.ToString());

                Console.WriteLine($"Der er nu tilføjet {addedNumber}, til {number}. Hvilket giver {sum} !");

            }
            catch (FormatException fex)
            {
                throw new ApplicationException($"Indhold kan ikke konverteres til et heltal - msg: {fex}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
