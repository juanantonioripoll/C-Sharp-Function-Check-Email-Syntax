using System;
using System.Text.RegularExpressions;

namespace VerifyEmailSyntax
{

    internal class Program
    {
        public static bool VerifyEmailSyntax(string email)
        {
            try
            {
                string pattern =
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

                if ((Regex.IsMatch(email, pattern)))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool debug = true;
            string text;

            Console.WriteLine("Enter Email:");
            text = Console.ReadLine();

            if (VerifyEmailSyntax(text))
                Console.WriteLine("Correct Email");
            else
                Console.WriteLine("Wrong Email");

            if (debug)
                Console.ReadLine();

        }

    }
}

