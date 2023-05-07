using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPassword1
{
    public class PasswordCharacters
    {
        static string PasswordPattern = @"^[A-Za-z0-9!@#$%^&*()<>~?]{8}$";

        public void Password()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Password:");
                string pass = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(pass, PasswordPattern);

                if (flags)
                {
                    Console.WriteLine("Valid Password");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }

        }
    }
}
