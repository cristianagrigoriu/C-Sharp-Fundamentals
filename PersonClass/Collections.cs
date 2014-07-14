using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Collections
    {
        public void CreateCollections()
        {
            List<Manager> collectionPeople = CreateAndInitializeEmployeeList();

            List<Manager> IasiPeople = GetPeopleFromIasi(collectionPeople);
            showList(IasiPeople, "Iasi People");

            List<Manager> LoyalPeople = GetLoyalPeople(collectionPeople);
            showList(LoyalPeople, "Loyal People");

            List<Manager> LoyalIasiPeople = IasiPeople.Intersect(LoyalPeople).ToList();
            showList(LoyalIasiPeople, "Iasi Loyal People");
        }

        public List<Manager> CreateAndInitializeEmployeeList()
        {
            Employee manager1 = new Employee("Anna", "Karenina", 20, Genders.Female, null, new DateTime(2014, 7, 8));
            Manager manager3 = new Manager("Alekansdra", "Karenina", 20, Genders.Female, null, new DateTime(2009, 7, 8), "0232", "Iasi");
            Manager manager4 = new Manager("Anna", "Karenina", 20, Genders.Female, null, new DateTime(2010, 7, 8), "0232", "there");
            Manager manager5 = new Manager("Freddie", "Mercury", 20, Genders.Male, manager1, new DateTime(2014, 7, 8), "0232", "there");

            List<Manager> MyPeople = new List<Manager>()
            {
                manager3,
                manager4,
                manager5,
            };

            return MyPeople;
        }

        public List<Manager> GetPeopleFromIasi(List<Manager> people)
        {
            return people.Where(manager => manager.OfficeLocation == "Iasi").ToList();
        }

        public List<Manager> GetLoyalPeople(List<Manager> people)
        {
            return people.Where(manager => ((DateTime.Today - manager.HireDate).TotalDays > 730)).ToList();
        }

        public List<Manager> GetLoyalPeople(List<Manager> people1, List<Manager> people2)
        {
            return people1.Intersect(people2).ToList();   
        }

        public void showList(List<Manager> people, string message)
        {
            Console.WriteLine();
            Console.WriteLine("------" + message + "------");
            people.ForEach(x => Console.WriteLine(x));
        }
    }
}
