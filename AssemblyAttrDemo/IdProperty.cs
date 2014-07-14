using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyAttrDemo
{
     [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]

    public class IdProperty : System.Attribute
     {
         private string IdPropertyName;

         public IdProperty(string name)
         {
             IdPropertyName = name;
         }
     }
}
