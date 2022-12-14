using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InfSec_Lab
{
    class PasswordCheck
    {
        public static bool isOK(String pass)
        {
            string pattern1 = @"[-.?!)(,:]";
            string pattern2 = @"[a-zA-Z]";

            if (Regex.IsMatch(pass, pattern1) && Regex.IsMatch(pass, pattern2)) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
