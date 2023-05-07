using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLastName
{
    internal class LastName
    {
        static string NamePattern = @"^[A-Z]{1}[a-z]{3,}(\s|_)[A-Z]{1}[a-z]{3,}$";
        public void Name()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter FullName: ");
                string fullName=Convert.ToString(Console.ReadLine());
                flag = Regex.IsMatch(fullName,NamePattern);
                if (flag)
                {
                    Console.WriteLine("Valid FullName");
                }
                else
                {
                    Console.WriteLine("Invalid FullName");
                }
            }
        }        
    }
}
