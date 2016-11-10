using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfileio
{
    class employee
    {
        private string name;
        private float salary;
        public employee(string name,float salary)
        {
            this.name = name;
            this.salary = salary;
        }
        
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
