using SuperMаrketApp.Interfaces;
using System.Collections.Generic;
namespace SuperMаrketApp
{
    public class StaffService<T> : IStaffService<T>,IGetAll<T>
    {
        List<T> workers;

        public StaffService(int count)
        {
            if (count>3)
            {
                workers = new List<T>(count);
            }
        }

        public void Dismissal(T worker)
        {
            workers.Remove(worker);
        }

        public void Hiring(T worker)
        {
            workers.Add(worker);
        }

        public List<T> GetAll() 
        {
            return workers;
        }
    }
}
