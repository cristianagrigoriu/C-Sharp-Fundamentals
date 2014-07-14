using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            String words = "Ana are mere";
            String[] arrayOfWords = words.Split();

            foreach (String w in arrayOfWords)
                Console.WriteLine(w);

            Array.Sort(arrayOfWords);
            Console.WriteLine(String.Join(" ", arrayOfWords, 0, arrayOfWords.Length));
        }
    }
}
