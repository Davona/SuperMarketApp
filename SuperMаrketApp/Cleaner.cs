using SuperMаrketApp.Interfaces;
using System;
namespace SuperMаrketApp
{
    public class Cleaner:ICleaner,IWorker
    {
        public Cleaner(int age, string name)
        {
            Age = age;
            Name = name;

        }

        public int Age { get; set; }
        public string Name { get; set; }

        public void Cleaning()
        {
            Console.WriteLine($"{Name} cleane territoy");
        }

        public void GetSalary()
        {
            Console.WriteLine($"{Name} have a 300$ salary");
        }

        public void GoingToWork()
        {
            Console.WriteLine($"{Name} go to work 08.30");
        }

        public void HaveBreak()
        {
            Console.WriteLine($"{Name} have a break at 15.00");
        }
    }
}
