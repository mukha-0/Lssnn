using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lssn._4th
{
    internal class Chart
    {
        public void MenuOfFourth()
        {
            Console.Write("Enter PATH");
            var path = Console.ReadLine();
            AddAndSeeChart(path);
        }
        public void AddAndSeeChart(string path)
        {
            using StreamWriter streamWriter = new StreamWriter(path, false);
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string line = $"{i} * {j} = {i * j}";
                    streamWriter.WriteLine(line);
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
        }
    }
}
