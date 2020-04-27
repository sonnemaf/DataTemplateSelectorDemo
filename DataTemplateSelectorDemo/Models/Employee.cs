using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSelectorDemo.Models {

    internal class Employee {

        public Employee() {
        }

        public Employee(string name, double salary) {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name {
            get;
            set;
        }

        public double Salary {
            get;
            set;
        }

        public void RaiseSalary(double percentage) {
            this.Salary += Salary * (percentage / 100);
        }

        public override string ToString() {
            return string.Format("Employee Name = {0}, Salary = {1:C}", this.Name, this.Salary);
        }
    }

}
