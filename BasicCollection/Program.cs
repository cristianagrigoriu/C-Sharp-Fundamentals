using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = new List<string>()
            {
                "First",
                "Second",
                "Third",
                "Fourth"
            };

            Console.WriteLine();
            Console.WriteLine("------Input List------");
            Console.WriteLine();

            foreach (string s in Words)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("------Foreach Sorted List------");
            Console.WriteLine();

            Words.Sort();

            IEnumerator<string> Index = Words.GetEnumerator();
            while (Index.MoveNext())
            {
                Console.WriteLine(Index.Current);
            }

            Console.WriteLine();
            Console.WriteLine("------Linq Sorted List------");
            Console.WriteLine();

            Words.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
