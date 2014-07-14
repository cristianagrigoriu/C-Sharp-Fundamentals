using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> CountryCodes = new Dictionary<int, string>()
            {
                
                {1, "Romania"},
                {2, "Germany"},
                {3, "USA"},
                //{"dfg", "fgh"}
            };

            Console.WriteLine("CountryCodes[1] = " + CountryCodes[1]);
            Console.WriteLine("Code of Country at Index 2 = " + CountryCodes.Keys.ElementAt(2));

            foreach (KeyValuePair<int, string> pair in CountryCodes)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            /* list of numbers */
            int Today = DateTime.Today.Day;

            List<int> Numbers = new List<int>()
            {
                17,
                13,
                101
            };
            Console.WriteLine("Today is " + Today);
            Console.WriteLine("------Added List Linq------");
            Numbers.ForEach(x => x = x + Today); //nu da eroare, dar nu se modifica

            Numbers.All(x => { x += Today; return true; });

            Numbers.ToList().ForEach(x => Console.WriteLine(x));

            /*foreach nu merge*/
            foreach (int i in Numbers)
            {
                //eroare, cannot modify readonly variable
                //i += Today;
            }

            Console.WriteLine("------Added List For------");
            for (int i=0; i< Numbers.Count; i++)
            {
                Numbers[i] += Today;
            }
            Numbers.ForEach(x => Console.WriteLine(x));
        }
    }
}
