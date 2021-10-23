using SuperMаrketApp.Interfaces;
using System.Collections.Generic;
namespace SuperMаrketApp
{
    public class StaffService<T> : IStaffService<T>
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
