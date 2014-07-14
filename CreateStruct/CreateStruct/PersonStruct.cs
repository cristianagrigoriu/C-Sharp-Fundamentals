using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreateStruct
{
    public enum Genders
    {
        Male,
        Female
    };

    public struct Person
    {
        private String firstName;
        private String lastName;
        private int age;
        private Genders gender;
        

        public Person(String _firstName, String _lastName, int _age, Genders _gender)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.age = _age;
            this.gender = _gender;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.age + " " + this.gender + "\n";
        }
    }
}
