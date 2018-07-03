using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           //####### ALL PRIMITIVE TYPES BELOW ARE ACTUALLY Classes... ########
            int integer = 0;//integer data types
            //short sixteenbit = 0;
            //long sixtyfourbit = 0;
            //byte eightbit = 0;//default 0
            //float thirtytwobitfloat = 0;//floating-point(decimal) numbers
            //double sixtyfourbitfloat = 0;
            //decimal bit128 = 0;//suitable for currency

           // var number = 56;
           // var number = 4.5;//default type would be double

           // string name = "My name";//immutable/Unicode()
            //char character = 'a';

            bool trueorfalse = true;



           // "###### CAN CHANGE VALUE OF TYPES: #######"
            integer = 5;





           // "############## CONDITIONALS #############"
             
            if (integer == 5)
            {
                Console.WriteLine("this is from an if statement! - "+integer);
            }
            else
            {
                Console.WriteLine("Does not equal 5!");
            }
            

           // "##### SWITCH STATEMENTS #####"
            
            switch(integer)
            {
                case 0: 
                Console.WriteLine();
                break;
                case 1:
                Console.WriteLine();
                break;
                case 2:
                Console.WriteLine("This switch statement works");
                break;
                default:
                Console.WriteLine("none of the cases matched");
                break;
            }



        //"USE THIS COMMAND TO RUN PROGRAMS WITH ASSURANCE THEY-";
            //"-WILL RUN OR BUILD FROM THE RIGHT PLACE: ";
                       // "####";
        //dotnet bin/Debug/netcoreapp2.1/HelloWorld.dll
                       // "####"




        //############ IF STATEMENT SHORTHAND ###########
            if(integer > 0) System.Console.WriteLine("if statement shorthand");



        //############ TERNARY STATEMENTS #############
           var output = (integer < 6)? "less than 6" : "not less than 6";//more shorthand
           Console.WriteLine(output);
         


           //######## FOR LOOPS #############

           for(int i = 0;i<10;i++)
           {
               Console.WriteLine(i);
           }
          

          //###### MANIPULATING USER INPUT #############
           string userInput = Console.ReadLine();
           System.Console.WriteLine("\nHi, "+userInput+"!!!!\nHow've you been??!?\n");
          
          

          //########### USING INTEGER ARRAYS ##############
          int[] integerArray = new int[10];//size 10/BUT YOU CANNOT CALL [10]-BECAUSE 0-INDEX
           integerArray[2] = 6;
         
            
                //### USING FOREACH FOR INTERGERARRAY ###
           foreach(var item in integerArray)
           {
               System.Console.WriteLine(item);
           }
         



           //############### WHILES ###############
           
           while(trueorfalse)
           {
               trueorfalse=false;
           }
           System.Console.WriteLine("Because of while loop, trueorfalse now equals = "+trueorfalse);
           
           
           do
           {
               trueorfalse=true;
               System.Console.WriteLine("\nBecause of Do/While loop, trueorfalse now equals= "+trueorfalse);

           }while(!trueorfalse);



           //############ TRY/CATCH BLOCKS ###############
           
           try{
               integerArray[10] = 40;
               System.Console.WriteLine(integerArray[10]);

           }
           catch( System.Exception ex)
           {
               System.Console.WriteLine(ex.Message);
           }
           finally
           {
               //always runs after try and/or catch
               System.Console.WriteLine("\nThis msg shows as a result of finally block!\n");
           }

         
            Console.WriteLine("Hello Vworld! WE'RE DONE!");
         
            //##### USING CLASS FROM OUTSIDE SCRIPT BUT STILL IN HELLOwORLD FOLDER #####

            Employee newEmployee = new Employee();
            System.Console.WriteLine("\nEmployee Name: "+newEmployee.name);
            System.Console.WriteLine("Paycheck Amount: "+newEmployee.PaycheckAmount(1));
         
            //########## USING BUILT IN METHODS LIKE DATETIME ###############
            DateTime GetCurrentTime()
            {
                return DateTime.Now;

            }
            System.Console.WriteLine("\n"+GetCurrentTime());
        }

        
        
    }
}
