using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMаrketApp
{
    interface ISecurityService 
    {
        void CheckStaff();
        void CheckTerritory();
    
    
    }
    class Security:ISecurityService, IWorkerService
    {
        public Security(int age, string name)
        {
            Age = age;
            Name = name;

        }
        public int Age { get; set; }
        public string Name { get; set; }

        public void CheckStaff()
        {
            Console.WriteLine($"{Name} check staff and your bags");
        }

        public void CheckTerritory()
        {
            Console.WriteLine($"{Name} check territoy and contole clients");
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Name} have a 400$ salary");
        }

        public void GoingToWork()
        {
            Console.WriteLine($"{Name} go to work at 08.00");
        }

        public void HaveBreak()
        {
            Console.WriteLine($"{Name} have a break at 13.00");
        }
    }
}
