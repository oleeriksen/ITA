namespace Module4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person peter = new Person();

        peter.name = "Peter";
        peter.address = "byvej 123, 9876 Andeby";
        peter.birthday = new DateOnly(1999, 7, 17);

        if (peter.IsTeenager())
        { }

        Person kurt = new Person("kurt", "lærkevej 12, 8000 aarhus C", 172, 69);

        Person2 egon = new Person2
        {
            Name = "Egon",
            Address = "tremmely 1",
            Birthday = DateOnly.FromDateTime(DateTime.Now)
        };
    }
}

