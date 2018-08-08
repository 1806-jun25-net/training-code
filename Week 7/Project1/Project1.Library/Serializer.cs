using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project1.Library
{
    public static class Serializer
    {
        public static void SerializeOrderToFile(string fileName, List<SerializeOrder> order)
        {
            var serializeOrder = new XmlSerializer(typeof(List<SerializeOrder>));
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializeOrder.Serialize(fileStream, order);
            }

            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Path {fileName} was too long! {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error with file I/O {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public async static Task<IEnumerable<SerializeOrder>> DeserializeOrderFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<SerializeOrder>));
            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    await fileStream.CopyToAsync(memoryStream);
                }
                memoryStream.Position = 0;
                return (List<SerializeOrder>)serializer.Deserialize(memoryStream);
            }
        }

        public static void SerializeInventoryToFile(string fileName, List<SerializeInventory> inventory)
        {
            var serializeInventory = new XmlSerializer(typeof(List<SerializeInventory>));
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Create);
                serializeInventory.Serialize(fileStream, inventory);
            }

            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Path {fileName} was too long! {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error with file I/O {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }

            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public async static Task<IEnumerable<SerializeInventory>> DeserializeInventoryFromFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<SerializeInventory>));
            using (var memoryStream = new MemoryStream())
            {
                using (var fileStream = new FileStream(fileName, FileMode.Open))
                {
                    await fileStream.CopyToAsync(memoryStream);
                }
                memoryStream.Position = 0;
                return (List<SerializeInventory>)serializer.Deserialize(memoryStream);
            }
        }
    }
}
