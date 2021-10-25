using SuperMаrketApp.Interfaces;
using System;
using System.Collections.Generic;

namespace SuperMаrketApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogger logger = new Logger();
            try
            {
                StaffService<Security> securitystaff = new StaffService<Security>(-1);
                StaffService<Cashier> cashierstaff = new StaffService<Cashier>(5);
                Cashier cashier = new Cashier(25, "Armen");
                cashierstaff.Hiring(cashier);
                cashier.ClosedShift(100000, 0);
                StaffService<Cleaner> cleanerstaff = new StaffService<Cleaner>(2);
                Cleaner cleaner = new Cleaner(25, "Anna");
                cleanerstaff.Hiring(cleaner);
                List<Cleaner> cleaners = cleanerstaff.GetAll();
                cleaners[0].Cleaning();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                string log = logger.CreateLogger(ex);
                logger.Log(log);
                Console.WriteLine("Some Error Occured");
            }
            catch (DivideByZeroException ex)
            {
                string log = logger.CreateLogger(ex);
                logger.Log(log);
                Console.WriteLine("Some Error Occured");
            }
            catch (ArgumentNullException ex)
            {
                string log = logger.CreateLogger(ex);
                logger.Log(log);
                Console.WriteLine("Some Error Occured");
            }
            catch (Exception ex)
            {
                string log = logger.CreateLogger(ex);
                logger.Log(log);
                Console.WriteLine("Some Error Occured");
            }
        }
    }
}
