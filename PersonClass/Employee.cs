using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public delegate void ManagerOnHolidayEvent(int NumberOfDays, Employee SubstituteManager);
    public delegate void ManagerComesBackFromHolidayEvent(Employee SubstituteManager);

    public class Employee : Person
    {
        public Employee Manager { get; set; }
        public DateTime HireDate;

        public bool isOnHoliday { get; set; }

        public event ManagerOnHolidayEvent ManagerGoes;
        public event ManagerComesBackFromHolidayEvent ManagerReturns;

        public Employee()
        {
                
        }
        public Employee(String _firstName, String _lastName, int _age, Genders _gender, Employee _manager, DateTime _hireDate)
            : base (_firstName, _lastName, _age, _gender)
        {
            this.Manager = _manager;
            this.HireDate = _hireDate;
            if (this.Manager != null)
                this.Manager.ManagerGoes += new ManagerOnHolidayEvent(ManagerLeavesOnHoliday);

            if (this.Manager != null)
                this.Manager.ManagerReturns += new ManagerComesBackFromHolidayEvent(ManagerComesBackFromHoliday);
        }

        protected virtual void OnManagerGoes(int NumberOfDays, Employee SubstituteManager)
        {
            if (ManagerGoes != null)
                ManagerGoes(NumberOfDays, SubstituteManager);
        }

        protected virtual void OnManagerReturns(Employee SubstituteManager)
        {
            if (ManagerReturns != null)
                ManagerReturns(SubstituteManager);
        }

        public void LeavesOnHoliday(int NumberOfDays)
        {
            this.isOnHoliday = true;
            OnManagerGoes(NumberOfDays, this.Manager);
        }

        public void ReturnsFromHoliday()
        {
            this.isOnHoliday = false;
            OnManagerReturns(this);
        }

        private void ManagerLeavesOnHoliday(int NumberOfDays, Employee SubstituteManager)
        {
            this.Manager = SubstituteManager;
        }

        private void ManagerComesBackFromHoliday(Employee SubstituteManager)
        {
            this.Manager = SubstituteManager;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.HireDate.ToString();
        }
    }
}
