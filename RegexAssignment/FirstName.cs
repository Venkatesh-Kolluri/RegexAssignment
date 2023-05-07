using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class FirstName
    {
        static string NamePattern = @"^[A-Z]{1}[a-z]{3,}$";
        public void Name()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Name: ");
                string name =Convert.ToString(Console.ReadLine());
                flag=Regex.IsMatch(name, NamePattern);
                if (flag)
                {
                    Console.WriteLine("Valid Name Pattern");
                }
                else
                {
                    Console.WriteLine("Invalid Name Pattern");
                }

            }
            
        }
    }
}
