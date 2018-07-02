using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            FillList(list);
            SerializeToFile("data.xml", list);
        }

        private static void SerializeToFile(string fileName, List<Person> people)
        {
            var serializer = new XmlSerializer(typeof(Person));
            var fileStream = new FileStream(fileName, FileMode.Create);
            serializer.Serialize(fileStream, people);
        }

        private static List<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Person));
            var fileStream = new FileStream(fileName, FileMode.Open);

            var result = serializer.Deserialize(fileStream);
            return (List<Person>)result;
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
                    Line1 = "l1",
                    Line2 = "l2",
                    City = "Reston",
                    State = "VA",
                    ZipCode = "10290"
                },
                Age = 030, 
                Nicknames = new List<string> { "a", "b" }
            });
        }
    }
}
