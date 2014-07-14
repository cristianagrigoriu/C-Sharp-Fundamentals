using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Hierarchy
    {
        private int count;

        public List<Employee> CreateHierarchy()
        {
            List<Employee> people = CreateAndInitializeEmployeeList();
            showHierarchy(people, "Print Hierarchy");
            return people;
        }

        public List<Employee> CreateAndInitializeEmployeeList()
        {
            var manager0 = new Employee("Alekansdra", "Karenina", 20, Genders.Female, null, new DateTime(2014, 7, 8));

            Employee manager1 = new Employee("Anna", "Karenina", 20, Genders.Female, null, new DateTime(2014, 7, 8));

            Employee manager2 = new Employee("Freddie", "Mercury", 20, Genders.Male, manager1, new DateTime(2014, 7, 8));

            Employee employee1 = new Employee("John", "Lennon", 20, Genders.Male, manager1, new DateTime(2014, 7, 8));

            Employee employee2 = new Employee("Kurt", "Cobain", 20, Genders.Male, manager2, new DateTime(2014, 7, 8));

            Employee employee3 = new Employee("Ringo", "Starr", 20, Genders.Male, manager2, new DateTime(2014, 7, 8));

            Employee employee4 = new Employee("Paul", "McCartney", 20, Genders.Male, employee2, new DateTime(2014, 7, 8));

            List<Employee> people = new List<Employee>
            {
                manager0,
                manager1,
                manager2,
                employee1,
                employee2,
                employee3,
                employee4
            };

            return people;
        }

        public void showHierarchy(List<Employee> people, string message)
        {
            Console.WriteLine();
            Console.WriteLine("------" + message + "------");
            Console.WriteLine();

            count = -1;

            parseList(null, people);
        }

        private void parseList(Employee lookFor, List<Employee> people)
        {
            List<Employee> peopleCopy = new List<Employee>(people);

            if (peopleCopy == null)
                return;
            else
            {
                List<Employee> pers = GetEmployeesOf(lookFor, peopleCopy);
                if (lookFor != null)
                    Console.WriteLine(String.Concat(Enumerable.Repeat("   ", count)) + lookFor.FirstName + " " + lookFor.LastName);
                count++;

                peopleCopy.Remove(lookFor);
                foreach (Employee e in pers)
                {
                    parseList(e, peopleCopy);
                    count--;
                }
            }
        }

        private List<Employee> GetEmployeesOf(Employee boss, List<Employee> people)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee p in people)
            {
                if (boss == p.Manager)
                    result.Add(p);
            }
            return result;
        } 
    }
}
