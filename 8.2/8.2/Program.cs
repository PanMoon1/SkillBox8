using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> kniga = new Dictionary<string, string>();
            string str = String.Empty;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 11)
                    kniga.Add(str.Substring(0, 11), str.Substring(11));
            } while (str != String.Empty);

            str = Console.ReadLine();
            string value = "";
            if (kniga.TryGetValue(str, out value))
            {
                Console.WriteLine("For key = {0}, value = {1}.", str, value);
            }
            else
            {
                Console.WriteLine("Key = {0} is not found.", str);
            }
            Console.ReadKey();
        }
    }
}
