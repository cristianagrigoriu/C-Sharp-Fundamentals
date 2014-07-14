using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            DisplayCalculator dc = new DisplayCalculator();

            while (true)
            {
                string input = dc.ReadExpression();
                if (input != null || input != string.Empty)
                {
                    try
                    {
                        dc.DisplayExpression(c.GetFormattedExpression(input));
                        dc.DisplayExpression(c.Compute(input).ToString());
                    }
                    catch (System.DivideByZeroException e)
                    {
                        Console.WriteLine("Division by 0 is not permitted", e);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("The arguments are incorrectly written", e);
                    }
                    catch (InvalidDataException e)
                    {
                        Console.WriteLine("No operator found", e);
                    }
                }
            }
        }
    }
}
