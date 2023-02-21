namespace Module6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static void opgave6_1() {
        PermanentEmployee fullTime = new PermanentEmployee
        {
            Name = "peter",
            Address = "byvej 12",
            Email = "peter@peter.com",
            TaxDeduction = 3400,
            TaxPrecentage = 34,
            Salary = 23000
        };
        ParttimeEmployee partTime = new ParttimeEmployee
        {
            Name = "jens",
            Address = "byvej 14",
            Email = "jens@jens.com",
            TaxDeduction = 6700,
            TaxPrecentage = 54,
            HourlySalary = 123,
            Hours = 110
        };
    }
}

