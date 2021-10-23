namespace SuperMаrketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security(25, "Ashot");
            StaffService<Security> securitystaff = new StaffService<Security>();
            securitystaff.Hiring(security);
            security.GoingToWork();
            security.CheckStaff();
            security.CheckTerritory();
            Cleaner cleaner = new Cleaner(45, "Armine");
            StaffService<Cleaner> cleanerstaff = new StaffService<Cleaner>();
            cleanerstaff.Hiring(cleaner);
            cleaner.GoingToWork();
            cleaner.Cleaning();
            Cashier cashier = new Cashier(21, "Anna");
            StaffService<Cashier> cashierstaff = new StaffService<Cashier>();
            cashierstaff.Hiring(cashier);
            cashier.GoingToWork();
            cashier.ControleProcessSales();
            cashier.ClosedShift(2500000);
        }
    }
}
