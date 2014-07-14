using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    interface IPerson
    {
        String FirstName { get; set; }
        String LastName { get; set; }
        int Age { get; set; }
        Genders Gender { get; set; }

        string ToString();
    }
}
