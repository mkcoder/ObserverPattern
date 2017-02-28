using System;

namespace ObserverPattern
{
    public class Employee
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public Department Deptarment { get; set; }
        public Decimal MoneyEarned { get; set; }
        public int ItemsSold { get; set; }
    }
}