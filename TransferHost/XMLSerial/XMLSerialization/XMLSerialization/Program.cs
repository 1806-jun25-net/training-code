using System;
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
           
            //@-string for disabling escape sequence like \t
            
            Task<IEnumerable<Person>> desListTask = 
            DeserializationFromFileAsync("data.xml");/*Async in name lets
            compiler know it is an "await func"*/

            IEnumerable<Person> result = new List<Person>();
            try
            {
                result = desListTask.Result;// synchronously waits until "result" is ready
            }
            catch(AggregateException o)
            {
                Console.WriteLine($"File wasn't found: {o.Message}");
            }
            
           // list.AddRange(result);
            //DESERIALIZATION ENDS HERE

            //#####

            //SERIALIZATION STARTS HERE
            FillList(list);//so you can decide when to populate people constructors; and list

            SerializeToFile("data.xml", list);
            //if this is active, will rewrite xml file or
            //add to it. if AddRange(), will simply rewrite
            //if FillList as well, 
            //will add another, new-filled list

            List<int> largeNumbers = new List<int>();
            foreach (var item in largeNumbers)
            {
                ExpensiveCalculation(item);
            }

            ////Parallel foreach!
            // run as many calculations at the same time as we can, using threads
            // / multiple cpu cores

            Parallel.ForEach(largeNumbers, item => ExpensiveCalculation(item));
            //this specific lambda exp takes in each largeNumber item and performs
            //ExpensiveCalc func on it; but async lets this happen
            //simultaneously

            Console.ReadKey();
        }

        private static void ExpensiveCalculation(int item)
        {

        }

        private static void SerializeToFile(string fileName, IEnumerable<Person> people)
        {
            var serializer = new XmlSerializer(typeof(List<Person>));
           // var fileStream = new FileStream(fileName, FileMode.Create);
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializer.Serialize(fileStream, people);
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine($"path to long: {ex.Message}");
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Some other error with file I/O: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Some unexpected error: {ex.Message}");
                throw;//passes the exception on as if it never happened
                      //good for taking note of exception and passing it on so 
                       //that calling code notices as well
            }
            finally
            {
                if(fileStream != null)
                {
                    fileStream.Dispose();//safe way to ensure no 
                    //null in file and prevent exc raise
                }
            }
            
        }

        private async static Task<IEnumerable<Person>> DeserializationFromFileAsync(string fileName)
        {

            var serializer = new XmlSerializer(typeof(List<Person>));

            //try catch is good, but there is an easier way...BELOW!!

            //FileStream fileStream= null;
            //try
            //{
            //    fileStream = new FileStream(fileName, FileMode.Open);

            //    var result = (IEnumerable<Person>)serializer.Deserialize(fileStream);//deserializes back to C# bytecode
            //    return result;
            //}
            //finally
            //{
            //    if (fileStream != null)
            //    {
            //        fileStream.Dispose();
            //    }
            //}
            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream= new FileStream(fileName, FileMode.Open))
                {
                    //Task CopyToAsync(memoryStream);
                    await fileStream.CopyToAsync(memoryStream);
                   // await Task;
                }
                memoryStream.Position = 0;//reset cursor of stream to the beginning
                return (List<Person>)serializer.Deserialize(memoryStream);
            }//USE (USING) for DISPOSABLE METHOD

            //other "synchronous way to return deserialize"
                // return (List<Person>)serializer.Deserialize(fileStream);

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
                Address = new Address
                {
                    Line1 = "123 Drury Lane",
                    Line2 = "",
                    City = "Tampa",
                    State = "FL",
                    ZipCode = "12345"
                },
                Age = 30,
                Nicknames = new List<string> { "Freddie", "Freddo"}

            });

            list.Add(new Person
            {
                ID = 2,
                Name = new Name
                {
                    First = "Nick",
                    Last = "Escalona"
                },
                Address = new Address
                {
                    Line1 = "321 Drury Drive",
                    Line2 = "",
                    City = "Chicago",
                    State = "UT",
                    ZipCode = "43202"
                }

            });
        }

    }
}
