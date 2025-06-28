using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._5th
{
    internal class Booktxt
    {
        public void MenuOfFifth()
        {
            Console.WriteLine("Enter PATH: ");
            var path = Console.ReadLine();
            InfoFinding(path);
        }
        private void InfoFinding(string path)
        {
            using StreamReader streamReader = new StreamReader(path);

            var lines = streamReader.ReadToEnd();
            var parts = lines.Split('\n');
            var words = lines.Split(" ");
            var linecount = parts.Length;
            var maxline = 0;
            var count = 0;

            foreach (var line in parts)
            {
                if(line.Length > maxline)
                {
                    maxline = line.Length;
                }
            }

            foreach(var word in words)
            {
                if(word == "good")
                {
                    count++;
                }
            }
            Console.WriteLine($"Line of whole book: {linecount}");
            Console.WriteLine($"Max LineLength: {maxline}");
            Console.WriteLine($"Count of word (good): {count}");
            Console.WriteLine();
        }
    }
}
