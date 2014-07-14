using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    partial class Manager : Employee
    {
        public String PhoneNumber { get; set; }
        public String OfficeLocation { get; set; }
    }
}
