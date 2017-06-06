using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 101;
            emp.Name = "Vikas";
            emp.Designation = "Manager";
            emp.Salary = 12345;

            Console.WriteLine(emp);

            AbstractPrototype clonedEmp = emp.Clone();
            Console.WriteLine(clonedEmp);

            Console.WriteLine(emp == clonedEmp);

            Console.ReadLine();
        }
    }
}
