using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lssn._1st;
using Lssn._2nd;
using Lssn._3rd;
using Lssn._4th;
using Lssn._5th;
using Lssn._6th;
using Lssn._7th;

namespace Lssn
{
    internal class MainMenu
    {
        _logtxt logtxt = new _logtxt();
        ExistFile existFile = new ExistFile();
        Plaintext plaintext = new Plaintext();
        Chart chart = new Chart();
        Booktxt booktxt = new Booktxt();
        UserInfo userInfo = new UserInfo();
        LetterCounter letterCounter = new LetterCounter();

        public void Menuuu()
        {
            Console.WriteLine("1 - 1st");
            Console.WriteLine("2 - 2nd");
            Console.WriteLine("3 - 3rd");
            Console.WriteLine("4 - 4th");
            Console.WriteLine("5 - 5th");
            Console.WriteLine("6 - 6th");
            Console.WriteLine("7 - 7th");
            Console.Write("Enter your choice (1-7): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 7)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                return;
            }
            if (choice == 1)
            {
                logtxt.MenuOfFirst();
            }
            else if (choice == 2)
            {
                existFile.MenuOfSecond();

            }
            else if (choice == 3)
            {
                plaintext.MenuOfPlainText();
            }
            else if (choice == 4)
            {
                chart.MenuOfFourth();
            }
            else if (choice == 5)
            {
                booktxt.MenuOfFifth();
            }
            else if (choice == 6)
            {
                userInfo.MenuOfSixth();
            }
            else if (choice == 7)
            {
                letterCounter.MenuOfSeventh();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
            }
        }
    }
}
