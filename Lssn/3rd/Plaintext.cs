using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._3rd
{
    internal class Plaintext
    {
        public void MenuOfPlainText()
        {
            Console.Write("Enter path: ");
            var path = Console.ReadLine();
            Console.WriteLine("You need to enter 5 plans");
            Console.Write("1- ");
            string one = Console.ReadLine();
            Console.Write("2- ");
            string two = Console.ReadLine();    
            Console.Write("3- ");
            string three = Console.ReadLine();
            Console.Write("4- ");
            string four = Console.ReadLine();
            Console.Write("5- ");
            string five = Console.ReadLine();
            Add(one, two, three, four, five, path);

        }
        public void Add(string one,  string two, string three, string four, string five, string path)
        {
            string[] lines =
            {
                one,
                two,
                three,
                four,
                five
            };
            if (File.Exists(path))
            {
                using StreamWriter streamWriter = new StreamWriter(path, append: true, encoding: Encoding.UTF8);
                foreach(string line in lines)
                {
                    streamWriter.WriteLine(line);
                }
                streamWriter.Close();
            }
            Console.WriteLine("Mission accomplished!");
        }
    }
}
