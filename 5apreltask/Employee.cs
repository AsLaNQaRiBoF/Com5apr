using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5apreltask
{
    internal class Employee
    {
        private int _id;
        public int id { get; set; }
    
     
        private int _surname;
        public int Surname { get; set; }

        private int _name;
        public int name { get; set; }


        public Employee(int _id, int id, int _surname, int surname, int _name, int name)
        {
            this.id=_id;
            this.id=id;
            Surname=_surname;
            Surname=surname;
            Name=_name;
            Name=name;
        }
        public int Name { get; set; }
    }
}


