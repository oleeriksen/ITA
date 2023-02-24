namespace Module6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        SalaryApp app = new SalaryApp();
        app.Init();
    }

    static void opgave6_1() {
        PermanentEmployee fullTime = new PermanentEmployee
        {
            Name = "Ander And",
            Address = "byvej 12",
            Email = "peter@peter.com",
            TaxDeduction = 5000,
            TaxPrecentage = 32,
            Salary = 23000,
            IsMemberOfLunch = true,
            IsMemberGiftbox = false
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

        fullTime.PrintSalaryNote();

        partTime.PrintSalaryNote();
    }
}

