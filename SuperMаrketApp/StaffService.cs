using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMаrketApp
{
    interface IWorkerService 
    {
        void GoingToWork();
        void GetSalary();
        void HaveBreak();
    
    }
    interface IStaffService<T> 
    {

        void Hiring(T worker);
        void Dismissal(T worker);
    }
    class StaffService<T> : IStaffService<T>
    {
        List<T> workers;
        public StaffService()
        {
            workers = new List<T>();
        }

        public void Dismissal(T worker)
        {
            workers.Remove(worker);
        }

        public void Hiring(T worker)
        {
            workers.Add(worker);
        }

       
    }
}
