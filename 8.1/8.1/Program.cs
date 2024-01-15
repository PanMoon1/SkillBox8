using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(GenerateList());

            GetListOnScreen(list);

            Console.WriteLine();
            Console.ReadKey();

            list = DeleteSome(list);

            GetListOnScreen(list);

            Console.WriteLine();
            Console.ReadKey();
        }

        static List<int> GenerateList()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(r.Next(100));
            }
            return list;
        }

        static void GetListOnScreen(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString() + " ");
            }
        }

        static List<int> DeleteSome(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 50 && list[i] > 25)
                    list.RemoveAt(i);
            }
            return list;
        }
    }
}
