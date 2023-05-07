using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEmailPattern
{
    public class Email
    {
        static string EmailPattern = @"^[a-z.]{3,20}@[a-z]{2}.co.(com|in)$";
        public void Mail()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Email: ");
                string email = Convert.ToString(Console.ReadLine());
                flag = Regex.IsMatch(email, EmailPattern);
                if (flag)
                {
                    Console.WriteLine("Valid Email ");
                }
                else
                {
                    Console.WriteLine("InValid Email");
                }


            }

        }
    }
}
