using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawnshop.Helpers
{
    public  class Authorization // Класс авторизации
    {
        public bool Login(string login, string password)
        {
            return SearchEmployee(login, password) != null ? true : false;
        }

        private Models.Employess SearchEmployee(string login, string password)
        {
            var db = Helpers.Singleton.GetContext();
            var resultSearch = db.Employess.Where(x => x.Login.Equals(login) && x.Password.Equals(password)).FirstOrDefault();
            if (resultSearch != null)
            {
                Helpers.Singleton.SetCurrentEmployee(resultSearch);
                return resultSearch;
            }
            return null;
        }
    }
}
