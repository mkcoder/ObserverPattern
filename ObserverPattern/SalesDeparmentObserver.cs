using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SalesDeparmentObserver : AbstractObserver
    {
        public SalesDeparmentObserver(EmployeeSubject subj)
        {
            this.DataSource = subj;
            subj.Subscribe(this);
        }

        public EmployeeSubject DataSource { get; set; }

        public override void Update()
        {
            if (DataSource.Employee.Deptarment == Department.Sales)
            {
                Console.WriteLine($"{DataSource.Employee.Name} ({DataSource.Employee.Id}) sold {DataSource.Employee.ItemsSold}");
            }
        }
    }
}
