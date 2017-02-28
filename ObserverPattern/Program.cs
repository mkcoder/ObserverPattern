using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSubject employee = new EmployeeSubject();

            SalesDeparmentObserver salesDeparmentObserver = new SalesDeparmentObserver(employee);

            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Deptarment =  Department.Sales, ItemsSold = 1000, Name = "Name 1"},
                new Employee() { Deptarment =  Department.Technology, Name = "Name 2"},
                new Employee() { Deptarment =  Department.Sales, ItemsSold = 1, Name = "Name 6"},
                new Employee() { Deptarment =  Department.Sales, ItemsSold = 100, Name = "Name 7"},
                new Employee() { Deptarment =  Department.Sales, ItemsSold = 0, Name = "Name 8"}
            };

            foreach (var emp in employees)
            {
                employee.Employee = emp;
            }
        }
    }
}
