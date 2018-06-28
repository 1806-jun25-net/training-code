﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            FillList(list);
            //SerializeToFile(@"D:\Revature\training-code\Week 1\coronado\XMLSerialization\XMLSerialization\data.xml", list);
            Task<IEnumerable<Person>> desListTask = DeserializeFromFileAsync(@"D:\Revature\training-code\Week 1\coronado\XMLSerialization\XMLSerialization\data.xml");
            IEnumerable<Person> result = desListTask.Result; // synchronously sits around until th result is ready

            /*
            List<int> largeNumbers = new List<int>();
            foreach (var item in largeNumbers)
            {
                ExpensiveCalculation(item);
            }
            // run as many calculations at the same time as we can using threads
            // / multiple cpu cores
            Parallel.ForEach(largeNumbers, item => ExpensiveCalculatiion(item));
            */

        }

        private static void SerializeToFile(string fileName, List<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
                        
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fileStream, people);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Path {fileName} was too long! {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Some other error with file I/O {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw; // re-throws the same exception
            }
            finally
            {
                fileStream.Dispose();
            }



        }

        private async static Task<IEnumerable<Person>> DeserializeFromFileAsync(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));

            /*
            // we can do it like this, but using statement is easier

            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Open);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }

            var result = (List<Person>)serializer.Deserialize(fileStream);
            return result;
            */

            /*
            // using statement compresses the try-finally block for disposables
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (List<Person>)serializer.Deserialize(fileStream);
            }
            */

            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    await fileStream.CopyToAsync(memoryStream);                    
                }
                memoryStream.Position = 0; // reset "cursor" of stream to beginning
                return(List<Person>)serializer.Deserialize(memoryStream);
            }

                        
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
                    Line1 = "321 Drury Ln",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "54321"
                }

            });

        }
    }
}
