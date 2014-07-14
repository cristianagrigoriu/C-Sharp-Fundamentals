using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Anna", "Karenina", 20, Genders.Female);
            Console.WriteLine(newPerson.ToString());
        }
    }
}
