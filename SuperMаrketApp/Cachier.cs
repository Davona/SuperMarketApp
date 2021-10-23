using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMаrketApp
{
    interface ICashierService
    {
        int ClosedShift(int dailyRevenue);
        void ControleProcessSales();
    }
    class Casher:ICashierService,IWorkerService
    {
        public Casher(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }

        public int ClosedShift(int dailyRevenue)
        {
            return dailyRevenue;
        }

        public void ControleProcessSales()
        {
            Console.WriteLine($"{Name} controle Process Sales");
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Name} have a 500$ salary");
        }

        public void GoingToWork()
        {
            Console.WriteLine($"{Name} Go to work at 09.00");
        }

        public void HaveBreak()
        {
            Console.WriteLine($"{Name} have a break at 14.00");
        }
    }
}
