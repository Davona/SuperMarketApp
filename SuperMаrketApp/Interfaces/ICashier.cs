using System;
using System.Collections.Generic;

namespace SuperMаrketApp.Interfaces
{
    public interface ICashier
    {
        int ClosedShift(int dailyRevenue,int ClientsCount);
        void ControleProcessSales();
    }
    public interface IWorker
    {
        void GoingToWork();
        void GetSalary();
        void HaveBreak();
    }
    public interface IStaffService<T>
    {
        void Hiring(T worker);
        void Dismissal(T worker);
    }
    public interface ICleaner
    {
        void Cleaning();
    }
    public interface ISecurity
    {
        void CheckStaff();
        void CheckTerritory();
    }
    public interface ILogger 
    {
        void Log(string source);
        string CreateLogger(Exception ex);
    }
    public interface IGetAll <T>
    {
        List<T> GetAll();
    }
}
