using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Skill.xml";
            ClassContact contact1 = new ClassContact();
            CreateContact(contact1);

            XElement contact =
                new XElement("Person", contact1.name,
                    new XElement("Adress",
                        new XElement("Street", contact1.street),
                        new XElement("HouseNumber", contact1.house.ToString()),
                        new XElement("FlatNumber", contact1.flat.ToString())
                        ),
                    new XElement("Phones",
                        new XElement("MobilePhone", contact1.mobilePhone),
                        new XElement("FlatPhone", contact1.flatPhone)
                        )
                    );
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                contact.Save(sw);
                Console.WriteLine(contact);
            }

            Console.ReadKey();
        }

        static void CreateContact(ClassContact c)
        {
            Console.WriteLine("Name");
            c.name = Console.ReadLine();
            Console.WriteLine("Street");
            c.street = Console.ReadLine();
            Console.WriteLine("House Number");
            c.house = int.Parse(Console.ReadLine());
            Console.WriteLine("Flat Number");
            c.flat = int.Parse(Console.ReadLine());
            Console.WriteLine("Mobile Phone");
            c.mobilePhone = Console.ReadLine();
            Console.WriteLine("Flat Phone");
            c.flatPhone = Console.ReadLine();
        }
    }
}
