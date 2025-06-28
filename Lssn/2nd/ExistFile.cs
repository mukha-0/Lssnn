using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._2nd
{
    internal class ExistFile
    {
        public void MenuOfSecond()
        {
            Console.Write("Enter PATH: ");
            var path = Console.ReadLine();
            CheckExistFile(path);
        }
        public void CheckExistFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists!");
            }
            else if (!File.Exists(path))
            {
                File.Create(path).Close();
                string[] magicwords = new string[1];
                magicwords[0] = "Hello World!";
                File.WriteAllLines(path, magicwords);
                Console.WriteLine("File didn`t existed before but now it does!");
            }
        }
    }
}
