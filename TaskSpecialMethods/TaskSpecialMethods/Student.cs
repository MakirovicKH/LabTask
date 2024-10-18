using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSpecialMethods
{
    public class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public int Limit { get; set; } // Dərsdən qalma limiti
        public string Group { get; set; }

        // Absent metodu
        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine($"{Name} did not comne to class today");
            }
            else
            {
                Console.WriteLine("to fail an exam");
            }
        }
    }

}
