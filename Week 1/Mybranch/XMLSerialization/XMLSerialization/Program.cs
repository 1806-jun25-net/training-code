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
            Fillist(list);
            SerializetoFile("data.xml", list);

            
        }

        private static void SerializetoFile(string fileName, List<Person> people)
        {

            var serializer = new XmlSerializer(typeof(List<Person>));
            var filestream = new FileStream(fileName, FileMode.Create);
            serializer.Serialize(filestream, people);





        }

        private static List<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Person));
            var filestream = new FileStream(fileName, FileMode.Create);

            List <Person> result = (List<Person>)serializer.Deserialize(filestream);
            return result;

        }





        private static void Fillist(List<Person>list)
        {
            list.Add(new Person
            {

                ID = 1,
                Name = new Name
                {

                    First = "Fred",
                    Last = "Belotte"

                },
                Address = new Address
                {
                    Line1 = "",
                    Line2 = "",
                    City = "",
                    State = "",
                    ZipCode = "",

                }
            });

        }
            
    }
}
