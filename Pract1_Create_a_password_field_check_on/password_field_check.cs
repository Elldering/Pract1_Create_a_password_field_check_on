using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pract1_Create_a_password_field_check_on
{
    public class password_field_check
    {
        public int Passed_Checks(string password)
        {
            int passedChecks = 0;
            //Длина пароля > 7 символов
            if (password.Length > 7)
            {
                passedChecks++;
            }
            //Наличие цифр
            if (password.Any(char.IsDigit))
            {
                passedChecks++;
            }
            //Наличие строчных букв
            if (password.Any(char.IsLower))
            {
                passedChecks++;
            }
            //Наличие заглавных букв
            if (password.Any(char.IsUpper))
            {
                passedChecks++;
            }
            //Наличие специальных символов
            if (Regex.IsMatch(password, @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]"))
            {
                passedChecks++;
            }

            return passedChecks;
        }
    }
}
