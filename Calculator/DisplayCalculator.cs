using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Calculator
{
    class DisplayCalculator
    {
        public string ReadExpression()
        {
            string input = Console.ReadLine();
            return input;
        }

        public void DisplayExpression(string expression)
        {
                Console.WriteLine(expression);
        }
    }
}
