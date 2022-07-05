using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pawnshop.Helpers
{
    public class Validator
    {
        public bool CharacterCheck(string line)
        {
            if (Regex.Match(line, "[А-Яа-яЁё]").Success)
            {
                return false;
            }
            return true;
        }
    }
}
