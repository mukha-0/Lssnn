using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._7th
{
    internal class LetterCounter
    {
        public void MenuOfSeventh()
        {
            Console.Write("Enter PATH: ");
            var path = Console.ReadLine();
            Count(path);
        }
        public void Count(string path)
        {
            using StreamReader sr = new StreamReader(path);

            string lines = File.ReadAllText(path, Encoding.UTF8);

            int countA = 0; int countE = 0; int countI = 0;

            foreach (char line in lines)
            {
                char lowerChar = char.ToLower(line);

                if(lowerChar == 'a') countA++;
                else if(lowerChar == 'e') countE++;
                else if(lowerChar == 'i') countI++;
            }
            Console.WriteLine($"A -> {countA}");
            Console.WriteLine($"E -> {countE}");
            Console.WriteLine($"I -> {countI}");
        }
    }
}
