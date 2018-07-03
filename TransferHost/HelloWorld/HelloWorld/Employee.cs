namespace HelloWorld
{
    public class Employee
    {
        //constructor
        public Employee()
        {
            name = "Nick";
        }
        //fields
        public string name;
        
        public double salary;
        
        public decimal yearlySalary = 45000;
        
        //methods
        public decimal PaycheckAmount(decimal weeks)
        {
            return yearlySalary*(weeks/52);
        }
    }
}