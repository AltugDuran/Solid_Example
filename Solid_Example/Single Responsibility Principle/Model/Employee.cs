using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Solid_Example.Single_Responsibility_Principle.Model
{
    public class Employee
    {
        public int Id            { get; set; }
        public string FirstName  { get; set; }
        public string LastName   { get; set; }
        public DateTime HireDate { get; set; }
    }
}
