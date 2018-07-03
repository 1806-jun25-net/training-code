using BPJ.Library;
using BPJ.Library.Interface;
using BPJ.Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace BPJ.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING A LIST TO FILL WITH USER INFO
            var newuserorderinfolist = new Dictionary<string, object>();
            
            //USER-INFO FILLING METHOD
            FillUserInfoList(newuserorderinfolist);


            //Order Object  --CREATING AM OBJECT OF USER TO INTERACT WITH
            //WILL ADD USERINF TO THIS OBJECT'S DICT
            Order User1 = new Order();
            ///
            //User1.NewUserAdd(newuserorderlist);


            //PLUGGING IN UI RESPONSES TO NEW USER OBJECT DICT
            User1.NewUserAdd(newuserorderinfolist);


            //now, User1.NewUserInfo has list of new user's info

           // CREATING A DICT SIMILAR TO USER OBJECT'S(ADDS THE SAME THING ADDED TO OBJECT)
            DictToListClass DTLExampleobj = new DictToListClass(User1.NewUserInfo);

            //SEE WHAT YOU'VE DONE
            foreach (var data in DTLExampleobj.MyDictHost)
            {
                System.Console.WriteLine($"{data.Key}: {data.Value}");
            }
            ///////////

            //SerializeToFile A SEPARATE COPY
            SerializeToFile(DTLExampleobj);

            PizzaExe();
            System.Console.WriteLine("Thanks!");
            System.Console.ReadKey();
        }

        //HERE IS A UI IMPLEMENTATION OF THE PEPPERONIPIZZA CLASS
        public static void PizzaExe()
        {
            PepperoniPizza MedPep = new PepperoniPizza();

            System.Console.WriteLine(nameof(MedPep));

            foreach (var pair in MedPep.MediumPepperoniDict)
            {
                System.Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

        }

        public static void FillUserInfoList(Dictionary<string, object> lister)
        {

            User ex1 = new User();
            System.Console.WriteLine("What's Your First Name?");
            ex1.FirstName = Convert.ToString(System.Console.ReadLine());
            lister.Add("FirstName", ex1.FirstName);

            System.Console.WriteLine("What's your last name?");
            ex1.LastName = Convert.ToString(System.Console.ReadLine());
            lister.Add("LastName", ex1.LastName);

            System.Console.WriteLine("Whats User ID?");
            ex1.UserID = Convert.ToInt64(System.Console.ReadLine());
            lister.Add("User ID", ex1.UserID);

            System.Console.WriteLine("Whats phone number?");
            ex1.PhoneNumber = Convert.ToInt64(System.Console.ReadLine());
            lister.Add("Phone NUmber", ex1.PhoneNumber);

            System.Console.WriteLine("Whats User email?");
            ex1.Email = Convert.ToString(System.Console.ReadLine());
            lister.Add("Email", ex1.Email);

            System.Console.WriteLine("Whats credit card number?");
            ex1.CreditCardNum = Convert.ToInt64(System.Console.ReadLine());
            lister.Add("Credit Card#", ex1.CreditCardNum);

            System.Console.WriteLine("How many times have you ordered from us?");
            ex1.OrderCount = Convert.ToInt32(System.Console.ReadLine());
            lister.Add("Total Orders", ex1.OrderCount);

        }

             //////CONVERTING DICITONARY TO LIST//////

        [DataContract]
        public class DictToListClass
        {
            public DictToListClass(Dictionary<string, object> listey)
            {
                MyDictHost = new Dictionary<string, object>();
                foreach (var pair in listey)
                {
                    MyDictHost.Add(pair.Key, pair.Value);
                }

                
            }
            [DataMember]
            public Dictionary<string,object> MyDictHost { get; set; }
        }



        public static void SerializeToFile( DictToListClass User1_Info)
        {

            var serializer = new DataContractSerializer(typeof(DictToListClass));
            string xmlString;
            using (var sw = new StringWriter())
            {
                using (var writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;
                    //^this indents the the XML so that
                    //its human-readable
                    serializer.WriteObject(writer, User1_Info);
                    writer.Flush();
                    xmlString = sw.ToString();
                }
            }

            File.WriteAllText(@"C:/Revature/PROJECT1/BigPapaJohns/data.xml",xmlString);
              
            

        }

    }
}

