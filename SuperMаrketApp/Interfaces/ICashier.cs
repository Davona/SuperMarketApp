namespace SuperMаrketApp.Interfaces
{
    public interface ICashier
    {
        int ClosedShift(int dailyRevenue);
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
}
