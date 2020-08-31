using Solid_Example.Single_Responsibility_Principle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Single_Responsibility_Principle.GoodExample
{
    public class GoodEmployeeProcess
    {
        GoodLoggerProcess logger;

        public GoodEmployeeProcess()
        {
            logger = new GoodLoggerProcess();
        }

        string log;


        public bool InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                log = logger.BuildLog("Employee instert succesfull: " + employee.Id);
                logger.LogFile(@"C:\Log.txt", log);
                return true;



            }
            catch (Exception ex)
            {
                log = logger.BuildLog("Hata mesajı: " + ex.Message);
                logger.LogFile(@"C:\Log.txt", log);

                return false;
                
            }

        }

    }
}
