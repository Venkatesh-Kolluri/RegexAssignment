using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhonePattern
{
    public class Mobile
    {
        static string PhonePattern = @"^[0-9]{2,3}\s[0-9]{10}$";

        public void Phone()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Phone Number:");
                string number = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(number, PhonePattern);

                if (flags)
                {
                    Console.WriteLine("Phone number is Valid");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Phone number is Invalid");

                }
            }
        }
    }
}
