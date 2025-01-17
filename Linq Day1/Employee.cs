using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Day1
{
    public class Employee
    {
        public Employee(long id, string name,decimal Salary)
        {
            Id=id;
            Name=name;
            this.Salary=Salary;
        }

        public long Id { get;private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }
    }
}
