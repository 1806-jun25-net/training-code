using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            FillList(list);
            // @-string for disabling escape sequences like \t
            SerializeToFile(@"C:\Users\Revature\Desktop\data.xml", list);
        }

        private static void SerializeToFile(string fileName, List<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            var fileStream = new FileStream(fileName, FileMode.Create);

            serializer.Serialize(fileStream, people);
        }

        private static IEnumerable<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            var fileStream = new FileStream(fileName, FileMode.Open);

            var result = (List<Person>)serializer.Deserialize(fileStream);
            return result;
        }

        private static void FillList(List<Person> list)
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
                    Line1 = "123 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "VA",
                    ZipCode = "12345"
                }
            });
        }
    }
}
