using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexEmailSamples
{
    internal class EmailSamples
    {
        static string EmailPattern = @"^[a-z0-9.]{3,20}@[a-z]{3,10}.(com|co|in)$";

        public void Email()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Email:");
                string email = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(email, EmailPattern);

                if (flags)
                {
                    Console.WriteLine("Email is Valid");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Email is Invalid");

                }
            }
        }
    }
}
