using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            FillList(list);
            // @-string for disabling escape sequences like \t or \\.
            SerializeToFile("data.xml", list);
            
        }

        private static void SerializeToFile(string fileName, IEnumerable<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>)); //typeof is another operator
                                                                // that returns the System.Type class and gives us the type of a given class
                                                                // Note: "Reflection" will be covered in the future.
            var fileStream = new FileStream(fileName, FileMode.Create);
            serializer.Serialize(fileStream, people);
        }

        // NOTE: could be returning a List<Person>, but that's a concrete class.
        // IEnumerable<Person> is a more abstract class, and therefore better.
        private static List<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            var fileStream = new FileStream(fileName, FileMode.Open);

            var result = (List<Person>)serializer.Deserialize(fileStream);
            return result;
        }

        public static void FillList(List<Person> list)
        {
            list.Add(new Person
            {
                Id = 1,
                Name = new Name
                {
                    First = "Fred",
                    Last = "Belotte"
                },
                Address = new Address
                {
                    Line1 = "123 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "12345"
                },
                Age = 30,
                Nicknames = new List<string> { "Freddie", "Freddo" }
            });
            list.Add(new Person
            {
                Id = 2,
                Name = new Name
                {
                    First = "Nick",
                    Last = "Escalona"
                },
                Address = new Address
                {
                    Line1 = "124 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "12345"
                },
                Age = 27,
                Nicknames = new List<string> { "Nickolous", "Nearly Headless" }
            });
        }
    }
}
