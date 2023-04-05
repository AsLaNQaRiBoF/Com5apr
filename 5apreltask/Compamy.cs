using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5apreltask
{
    internal class Compamy
    {
        private int _id;
        public int id { get; set; }
        private string _CompanyName;
        public string Companyname { get; set; }
        private Employee[] _Employee;

        public Compamy(int _id, int id, string _companyName, string companyname, Employee[] _employee, Employee[] employees)
        {
            this.id=_id;
            this.id=id;
            _CompanyName=_companyName;
            Companyname=companyname;
            _Employee=_employee;
            Employees=employees;
        }

        public Employee[] Employees { get; set; }=new Employee[0];  
        public void Add(Employee employee)
        {
            Array.Resize(ref Employee, Employees.Length+1);
            Employees[Employees.Length-1] = employee;
        }
        public Employee FindById(int id)
        {
         foreach(Employee emp in Employees) {
            if(emp.id==id) 
            return emp;  
            }
            return null;
        }
















    }
    
}
