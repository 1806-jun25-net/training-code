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
            SerializToFile("data.xml", list);
            //can use @ symbol to specify location
            //SerializeToFile(@"C:\Users\wknai\Desktop\data.xml"), list);

            //var desList = DeserializeFromFile("data.xml");
        }

        private static void SerializToFile(string fileName, List<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            var fileStream = new FileStream(fileName, FileMode.Create);

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fileStream, people);
            }
            //more specific Exceptions must be placed first
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Path {fileName} was too long! {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Eror with file I/O: {ex.Message}");
            }
            catch (Exception ex)
            {
                //catch Exception, record message, rethrow Exception
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
            //always runs whether the try code succeeds or the catch catches the code
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }

            serializer.Serialize(fileStream, people);
        }

        private static IEnumerable<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (List<Person>)serializer.Deserialize(fileStream);
            }

            //var fileStream = new FileStream(fileName, FileMode.Open);

            //var result = (List<Person>)serializer.Deserialize(fileStream); //upcasting
            //return result;
        }

        private static void FillList(List<Person> list)
        {
            list.Add(new Person
            {
                ID = 1,
                Name = new Name
                {
                    First = "Wayne",
                    Last = "Knain"
                },
                Address = new Address
                {
                    Line1 = "123 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "12345"
                },
                Age = 23,
                Nicknames = new List<string> { "Wayno", "Ralph" }
            });

            list.Add(new Person
            {
                ID = 2,
                Name = new Name
                {
                    First = "Bob",
                    Last = "Sagget"
                },
                Address = new Address
                {
                    Line1 = "999 Steele Rd",
                    Line2 = "",
                    City = "Blitz",
                    State = "HI",
                    ZipCode = "99999"
                }
            });
        }
    }
}
