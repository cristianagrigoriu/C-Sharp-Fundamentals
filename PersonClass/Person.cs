using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public enum Genders
    {
        Male,
        Female
    };

    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }

        public Person()
        {
                
        }
        public Person(String _firstName, String _lastName, int _age, Genders _gender)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Age = _age;
            this.Gender = _gender;

            //this.Changed += new ManagerOnHolidayEventHandler(Nothing);
        }

        public void Nothing()
        {
            
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age + " " + this.Gender;
        }


        
    }
}
