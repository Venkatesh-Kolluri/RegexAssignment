﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPassword2
{
    internal class PasswordPattern
    {
        static string PasswordChar = @"^(?=.*[A-Z]).{8}$";

        public void Password()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter Password:");
                string pass = Convert.ToString(Console.ReadLine());
                var flags = Regex.IsMatch(pass, PasswordChar);

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