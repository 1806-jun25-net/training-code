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
            //SerializeToFile(@"C:\Revature\training-code\My Week 1\XMLSerialization\data.xml", list);
            var desList = DeserializeFromFile(@"C:\Revature\training-code\My Week 1\XMLSerialization\data.xml");

        }

        private static void SerializeToFile(string fileName, IEnumerable<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>)); //typeof is another operator
                                                                      // that returns the System.Type class and gives us the type of a given class
                                                                      // Note: "Reflection" will be covered in the future.
            FileStream fileStream = null;
            // try/catch/finally is how we error-check in C#
            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fileStream, people);
            }
            catch (PathTooLongException ex) // this exception is more specific than IOException,
                                            // so it's listed first.
            {
                System.Console.WriteLine($"Path {fileName} was too long! {ex.Message}");
            }
            catch (IOException ex)
            {
                System.Console.WriteLine($"Error with file I/O: {ex.Message}");
            }
            catch (Exception ex) // This is a general exception, and not a good practice.
            {
                System.Console.WriteLine($"Unexpected error: {ex.Message}");
                throw; // re-throws the same exception
            }            
            finally // this code runs whether or not try succeeds or fails
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
            
        }

        // NOTE: could be returning a List<Person>, but that's a concrete class.
        // IEnumerable<Person> is a more abstract class, and therefore better.
        private static List<Person> DeserializeFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
            //FileStream fileStream = null;
            //
            //try
            //{
            //    fileStream = new FileStream(fileName, FileMode.Open);
            //    var result = (List<Person>)serializer.Deserialize(fileStream);
            //    return result;
            //}
            //finally
            //{
            //    if(fileStream != null)
            //    {
            //        fileStream.Dispose();
            //    }
            //}          This all basically gets summarized down here.
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (List<Person>)serializer.Deserialize(fileStream);
            }
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
