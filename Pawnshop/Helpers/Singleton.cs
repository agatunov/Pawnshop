using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawnshop.Helpers
{
    public class Singleton 
    {
        private static Models.PawnshopEntities pawnshopEntities;
        private static Models.Employess currentEmployee;
        public static Models.PawnshopEntities GetContext()
        {
            if (pawnshopEntities == null) pawnshopEntities = new Models.PawnshopEntities();
            return pawnshopEntities;
        }

        public static Models.Employess GetCurrentEmployee()
        {
            return currentEmployee;
        }

        public static void SetCurrentEmployee(Models.Employess employee)
        {
            currentEmployee = employee;
        }
    }
}
