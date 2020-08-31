using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Example.DIP.Bad
{
    public class BadStationery
    {
        BadPen FaberCastell = new BadPen();
        BadNoteBooks Cross = new BadNoteBooks();
            
        public string GenerateInstruction()
        {
            return FaberCastell.GetPenSellingInstructions() + " " + Cross.GetNotebooksSellingIntroductions();
        }

    }
}
