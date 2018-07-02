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
            //SerializeToFile("data.xml", list);
            var desList = DeserializeFromFile("data.xml");
        }

        private static void SerializeToFile(string fileName, IEnumerable<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            //If exists, overwrite, else create
            var fileStream = new FileStream(fileName, FileMode.Create);

            serializer.Serialize(fileStream, people);
        }

        private static List<Person> DeserializeFromFile(string fileName)
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
                ID = 1,
                Name = new Name
                {
                    First = "Fred",
                    Last = "Belotte"
                },
                Nicknames = new List<string> { "Freddie", "Freddo"},
                Address = new Address
                {
                    Line1 = "123 Drury Ln",
                    Line2 = "",
                    City = "Yes",
                    State = "MN",
                    ZipCode = "94843"
                },
                Age = 27
            });
            list.Add(new Person
            {
                ID = 2,
                Name = new Name
                {
                    First = "George",
                    Last = "Belotte"
                },
                Address = new Address
                {
                    Line1 = "125 Drury Ln",
                    Line2 = "",
                    City = "Yes",
                    State = "MN",
                    ZipCode = "94843"
                },
                Age = 27
            });
        }
    }
}
