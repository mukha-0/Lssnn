using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._1st
{
    internal class _logtxt
    {
        public void MenuOfFirst()
        {
            Console.Write("Enter PATH: ");
            var pathh = Console.ReadLine();
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            AddLoginInfo(user, pathh);
        }
        public void AddLoginInfo(string username, string path)
        {
            // var path = "C:\\Projects\\Lssn\\log.txt";

            if (File.Exists(path))
            {
                List<string> list = File.ReadAllLines(path).ToList();

                var login = $"{username}|{DateTime.Now}";
                list.Add(login);

                File.WriteAllLines(path, list);
                Console.WriteLine("Login succesfull!");
            }
            else
            {
                File.Create(path).Close();

                List<string> list = File.ReadAllLines(path).ToList();

                var login = $"{username}|{DateTime.Now}";
                list.Add(login);

                File.WriteAllLines(path, list);
                Console.WriteLine("Login succesfull!");
            }
        }
    }
}
