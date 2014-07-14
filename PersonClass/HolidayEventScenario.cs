using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class HolidayEventScenario
    {
        public void showScenario()
        {
            Hierarchy h = new Hierarchy();
            List<Employee> people = h.CreateHierarchy();

            people[4].LeavesOnHoliday(3);
            h.showHierarchy(people, "On Holiday");

            people[4].ReturnsFromHoliday();
            h.showHierarchy(people, "Holiday Over");
        }
    }
}
