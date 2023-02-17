namespace Module5;
class Program
{
    static void Main(string[] args)
    {
        Nicoline.Diceapp.Run();
    }

    static void ListTest1() {
        List<int> aList = new List<int>();
        aList.AddRange(new int[] { 1,2,3,4});

        foreach (int value in aList)
            Console.WriteLine(value);

        for (int value = 5; value < 11; value++)
        {
            aList.Add(value);
        }

        for (int i = 0; i < aList.Count; i++)
        {
            Console.WriteLine(aList[i]);
        }

        aList.ForEach( v => Console.WriteLine(v)) ;

        aList.ForEach(delegate (int v) { Console.WriteLine(v); }) ;

    }

    static void ListTest2() {
        List<Person> venner = new List<Person>();

        Person kurt = new Person("kurt", "byvej 17", 180, 72);
        venner.Add(kurt);

        Person egon = new Person("egon", "byvej 19", 187, 84);
        venner.Add(egon);

        Person palle = new Person("palle", "byvej 21", 162, 69);
        venner.Add(palle);

        venner.ForEach(ven => Console.WriteLine(ven.name));

        kurt = new Person("peter", "byvej 23", 150, 50);

        foreach (var ven in venner) {
            Console.WriteLine(ven.name);
        }
    }
}

