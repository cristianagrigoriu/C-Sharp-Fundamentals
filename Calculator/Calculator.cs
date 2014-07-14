using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private double _operand1;
        private double _operand2;
        private string _operator;
        private string _formattedExpression;

        private List<String> operators = new List<string>() { "+", "-", "*", "/", "%" };

        public void ParseExpression(string expression)
        {
            expression = expression.Replace(" ", string.Empty);

            expression = expression.Replace(",", ".");

            if (setOperator(expression))
            {
                if (!expression.Contains("[a-zA-Z]+"))
                {
                    _operand1 = Convert.ToDouble(expression.Substring(0, expression.IndexOf(_operator)));
                    _operand2 = Convert.ToDouble(expression.Substring(expression.IndexOf(_operator) + 1));
                    _formattedExpression = expression;
                }
                else
                {
                    throw new InvalidDataException();
                }
            }
            else
            {
                throw new InvalidDataException();
            }
        }

        public double? Compute(string expression)
        {
            double? result = 0;


            ParseExpression(expression);

            switch (_operator)
            {
                case "+":
                    result = _operand1 + _operand2;
                    break;
                case "-":
                    result = _operand1 - _operand2;
                    break;
                case "*":
                    result = _operand1 * _operand2;
                    break;
                case "/":
                    if (_operand2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = _operand1 - _operand2;
                    break;
                case "%":
                    if (_operand2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = _operand1 % _operand2;
                    break;
            }

            return result;
        }

        public string GetFormattedExpression(string expression)
        {
            ParseExpression(expression);
            return _formattedExpression;
        }

        private Boolean setOperator(string expression)
        {
            foreach (string s in operators)
            {
                if (expression.Contains(s))
                {
                    _operator = s;
                    return true;
                }
            }
            return false;
        }
    }
}
