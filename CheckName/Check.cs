using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckName
{
    internal class Check
    {
        public bool chekN (string input)
        {
            string expresion = "^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$";
            if (Regex.IsMatch(input, expresion))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
