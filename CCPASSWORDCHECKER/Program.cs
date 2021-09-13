using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCPASSWORDCHECKER
{
    class Program
    {
        private static object Tools;

        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*-+";

            Console.Write("Enter a password");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("4");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }
        }
    }
}
