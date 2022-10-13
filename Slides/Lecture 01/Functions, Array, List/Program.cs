using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string localeFormat = "";
            string formatedName = "";
            string[] formatedNames = new string[2];
            List<string> lstFormatedNames = new List<string>();

            firstName = "Ali";
            lastName = "Ahmad";
            localeFormat = "FL";

            formatedName = FormatName(firstName, lastName, localeFormat);
            formatedNames[0] = formatedName;
            lstFormatedNames.Add(formatedName);
            //Console.WriteLine(formatedName);


            firstName = "Alishba";
            lastName = "Tahir";
            localeFormat = "LF";

            formatedName = FormatName(firstName, lastName, localeFormat);
            formatedNames[1] = formatedName;
            lstFormatedNames.Add(formatedName);
            //Console.WriteLine(formatedName);

            for (int i = 0; i < formatedNames.Length; i++)
            {
                Console.WriteLine(formatedNames[i]);
            }
            for (int i = 0; i < lstFormatedNames.Count; i++)
            {
                Console.WriteLine("Your Name is:  " + lstFormatedNames[i]);
            }

            Console.ReadLine();
        }

        private static string FormatName(string firstName, string lastName, string localeFormat)
        {
            string formatedName = "";
            if (localeFormat == "FL")
            {
                formatedName = firstName + " " + lastName;
            }
            else
            {
                formatedName = lastName + " " + firstName;
            }
            return formatedName;
        }
    }
}
