using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus02d
{
    class Terning
    {
        public int Værdi;
        private bool Snyd;
        private static System.Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }
        public void Ryst()
        {
            if (!this.Snyd)
                this.Værdi = rnd.Next(1, 7);
            else
                this.Værdi = 6;

        }
        public Terning()
        {
            this.Værdi = 1;
            this.Snyd = false;
        }
        public Terning(bool snyd)
        {
            this.Snyd = snyd;
            Ryst();
        }
        
    }
}
