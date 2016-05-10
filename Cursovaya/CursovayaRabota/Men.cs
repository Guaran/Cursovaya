using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursovayaRabota
{
     struct Men
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string birthday { get; set; }
        public string someinformation { get; set; }

        public Men(string Name, string Surname, string Birthday, string SomeInformation)
        {
            name = Name;
            surname = Surname;
            birthday = Birthday;
            someinformation = SomeInformation;
        }
        public static Men[] mens = new Men[0];
    }
}
