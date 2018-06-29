namespace HelloWorld
{
    public class Employer
    {
        //fields
        public string name;

        public decimal yearlySalary;

        //methods
        public decimal PaycheckAmount(int weeks)
        {
            return yearlySalary * (weeks / 52);
        }
    }
}