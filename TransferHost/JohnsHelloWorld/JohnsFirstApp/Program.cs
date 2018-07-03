using System;

namespace JohnsFirstApp
{
    class Program
    {
        private const string Value = "John says:\nHello RVworld!";

        static void Main(string[] args)
        {
            Console.WriteLine(Value+"\n");
           
            System.Console.WriteLine(  "whats your age? ");
             int age = Convert.ToInt32(Console.ReadLine());//so, you wont have to use quotes during input in terminal
            Console.WriteLine("You are {0} years old\n",age);
            //FizzBuzz();
            ClassWork();

            //REF AND OUT(?delegate utilities?)
            
            
            int initializeMethod;
            OutArgExample(out  initializeMethod);//now initialize method has value given by OutArgExample
            System.Console.WriteLine(initializeMethod);
            void OutArgExample(out int number)
            {
                number = 144;
            }

            int[] arggs = new int[10];
            arggs[0]=10;
        }

        public static void ClassWork()
        {
            
                //Encapsulation Examples!!!
                Customer cust1 = new Customer(4987.63,"Northwind",90108);

                cust1.TotalPurchases += 499.99;

                System.Console.WriteLine(cust1.TotalPurchases);
                System.Console.WriteLine(cust1.Name);
                System.Console.WriteLine(cust1.CustomerID);
                string info = cust1.GetContactInfo();
                System.Console.WriteLine($"Here's {cust1.Name}'s {info}");
                System.Console.WriteLine(cust1.FirstName);

                //USING GETTER AND SETTER METHODS FOR PRIVATE VARIS 
                Rectangle r = new Rectangle();
                r.AcceptDetails();
                r.Display();

                //IMPLEMENTING ABSTRACT CLASSES AND METHODS
                Test test1 = new Example1();//early upcast example
                System.Console.WriteLine("\nAbstract Classes and Methods;");
                test1.A();
                Test test2 = new Example2();
                test2.A();

                //IMPLEMENTING STRUCT TYPE
                CoOrds coord1 = new CoOrds();
                coord1.x=8;
                coord1.y=9;
                CoOrds coord2 = new CoOrds(10,10);
                
                Console.Write("CoOrds 1: ");
                Console.WriteLine("x={0}, y = {1}", coord1.x, coord1.y);
                Console.Write("CoOrds 2: ");
                Console.WriteLine("x={0}, y = {1}", coord2.x, coord2.y);
                
                    //REMEMBER THIS: Keeps the console window open in debug mode
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();

                //INTERFACE EXAMPLE
                Point p = new Point(2,3);
                //IPoint p = new Point(2,3);upcasting

                Console.Write("My Point: ");
                PointClass pclass = new PointClass();
                pclass.PrintPoint(p);
              
               

        }

        class Customer
        {
            //Auto-Implemented Properties for trivial get and set
            public double TotalPurchases {get; set; }
            public string Name {get; set; }
            public int CustomerID { get; set;}
        
            //Constructor
            public Customer(double purchases, string name, int ID)
            {
                TotalPurchases=purchases;
                Name = name;
                CustomerID = ID;
            }
        
            //Methods
            public string GetContactInfo() {return "ContactInfo";}
            public string GetTransactionHistory(){return "History";}

            //INITIALIZING PROPERTIES WITHIN THE SAME LINE 
            public string FirstName{get;set;} = "Jane";
        
        }

        //USING GETTER AND SETTER METHODS FOR PRIVATE VARIS 
        class Rectangle
        {
            private double length;
            private double width;
            
            public void AcceptDetails()
            {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
            }
            
            public double GetArea()
            {
            return length*width;
            }
            
            public void Display()
            {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {GetArea()}");
            
            }
        }

        //### ABSTRACT CLASSES AND METHODS ###
        abstract class Test
        {
            public int _a;//this is considered a field, apparently
            public abstract void A();
        }
        
        class Example1 : Test //THIS IS HOW YOU IMPLEMENT AN ABSTRACT CLASS
        {
            public override void A()//TAKE NOTE OF THE OVERRIDE KEYWORD//needed for abstract/virtual methods
            {
                Console.WriteLine("Example1.A");
                base._a++;//calling the base-class field[like using super
                System.Console.WriteLine(base._a);
            }
        }
        
        class Example2: Test
        {
            public override void A()
            {
                Console.WriteLine("Example2.A");
                base._a--;
                System.Console.WriteLine(base._a);
            }
        }
        //#### THIS IS A **STRUCT** EXAMPLE
        public struct Book
        {
            public decimal price;
            public string title;
            public string author;
         }
        public struct CoOrds
        {
            public int x,y;
            public CoOrds(int p1, int p2)
            {
                x=p1;
                y=p2;
            }
        }

        //EXAMPLE OF USING INTERFACE
        public interface IPoint
            {
              int x
              {
                get;
                set;
              }
              int y
              {
                get;
                set;
              }
            }
            
            public class Point : IPoint
            {
              //fields
              private int _x;
              private int _y;
              
              //Constructor:
              public Point(int x, int y)
              {
                _x =x;
                _y = y;
              }
              
              //Interface Implementation of Property
              public int x
              {
                get
                {
                  return _x;
                }
                set
                {
                  _x=value;
                }
              }
              
              public int y
              {
                get
                {
                  return _y;
                }
                set
                {
                  _y = value;
                }
              }
            }
           public class PointClass
            {
                public  void PrintPoint(Point p)//(IPoint p)//upcasting
                {
                    Console.WriteLine("x={0},y={1}",p.x,p.y);
                }
            }

        public static void FizzBuzz()
        {
            int Fizzes = 0;
            int Buzzes = 0;
            int FizzBuzzes = 0;
            for(int i=1;i<=1000;i++)
            {
                if((i%3==0)&&(i%5==0))
                {
                    System.Console.WriteLine("FIZZBUZZ");
                    FizzBuzzes++;
                }
                else if(i%3==0)
                {
                    System.Console.WriteLine("Fizz");
                    Fizzes++;
                }
                else if(i%5==0)
                {
                    System.Console.WriteLine("Buzz");
                    Buzzes++;
                }
                
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("\nThere are "+Fizzes+" Fizzes.\n");
            System.Console.WriteLine("There are "+Buzzes+" Buzzes.\n");
            System.Console.WriteLine("There are "+FizzBuzzes+" FizzBuzzes.\n");
        }
    }
}
