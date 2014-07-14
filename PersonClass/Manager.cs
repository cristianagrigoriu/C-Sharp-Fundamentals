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
        public bool isOnHoliday { get; set; }

        public Manager(String _firstName, String _lastName, int _age, Genders _gender, Employee _manager, DateTime _hireDate, String _phoneNumber, String _officeLocation)
            : base (_firstName, _lastName, _age, _gender, _manager, _hireDate)
        {
            this.PhoneNumber = _phoneNumber;
            this.OfficeLocation = _officeLocation;
            this.isOnHoliday = false;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.PhoneNumber + " " + this.OfficeLocation;
        }
    }
}
