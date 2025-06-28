using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._6th
{
    internal class UserInfo
    {
        public void MenuOfSixth() 
        {
            Console.Write("Enter Path");
            string path = Console.ReadLine();
            User(path);
        }
        private void User(string path)
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            
            foreach (string line in lines)
            {
                var l = line.Split(',');
                var id = l[0];
                var name = l[1];
                var lastname = l[2];
                Console.WriteLine($"{name} {lastname} (ID: {id})");
            }
        }
    }
}
