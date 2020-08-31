using Solid_Example.Single_Responsibility_Principle.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.Single_Responsibility_Principle.BadExample
{
    public class BadEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                sb.AppendLine();
                File.WriteAllText(@"C:\EmployeeData.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("Kayıt ekleme tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newEmployee.Id);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Hata.!");
               
            }


        }
    }
}
