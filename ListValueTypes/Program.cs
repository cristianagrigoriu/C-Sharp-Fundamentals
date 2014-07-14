using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SByte, Byte, Int16, Int32, Int64, String Exception
            
            SByte _sbyte = new SByte();
            Byte _byte = new Byte();
            Int16 _int16 = new Int16();
            Int32 _int32 = new Int32();
            Int64 _int64 = new Int64();
            string _string = "ceva";
            Exception _exception = new Exception();

            Object[] objects = new object[] {_sbyte, _byte, _int16, _int32, _int64, _string, _exception};

            foreach (Object o in objects)
            {
                Console.WriteLine(o.GetType() + ((o.GetType().IsValueType == true) ? " Value Type" : " Reference Type"));
            }
            
        }
    }
}
