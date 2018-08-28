using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus02d
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsdato;

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsdato;
        }
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string efternavn, int fødselsdato)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsdato = fødselsdato;
        }

    }
}
