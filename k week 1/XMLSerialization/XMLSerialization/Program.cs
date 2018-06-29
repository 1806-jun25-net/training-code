using System;
using System.Collections.Generic;
using System.IO;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            FillList(list);
            SerializeToFile("data.xml", list);
        }

        private static void SerializeToFile(string fileName, IEnumerable<Person> people)
        {
            var serializer = new XMLSerializer(typeof(Person));
            var fileStream = new FileStream(fileName, FileMode.Create);

            serializer.Serialize(fileStream, people);
        }

        private static IEnumerable<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XMLSerializer(typeof(Person));
            var fileStream = new FileStream(fileName, FileMode.Open);

            var result = (IEnumerable<Person>) serializer.Deserialize(fileStream);
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
                Age = 21
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
                    Line1 = "456 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "12345"
                },
                Age = 21
            });
        }
    }
}
