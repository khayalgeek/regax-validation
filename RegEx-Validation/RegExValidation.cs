using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx_Validation
{
    public static class RegExValidation
    {
        public static bool PasswordIsValid(string userPassword)
        {
            string pattern= @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex regex =new Regex(pattern);
            var regaxResult = regex.Match(userPassword);
            return regaxResult.Success is true ? true : false;
        }

        public static bool EmailIsValid(string userPassword)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";
            Regex regex = new Regex(pattern);
            var regaxResult = regex.Match(userPassword);
            return regaxResult.Success is true ? true : false;
        }
    }
}
