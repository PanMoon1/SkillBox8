using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> spisok = new HashSet<int>();
            int i = 0;
            while (true)
            {
                i = int.Parse(Console.ReadLine());
                if (spisok.Contains(i))
                    Console.WriteLine("Такое число уже вводилось.");
                else
                {
                    spisok.Add(i);
                    Console.WriteLine("Число упешно сохранено.");
                }
            }
        }
    }
}
