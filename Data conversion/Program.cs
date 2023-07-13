

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = Console.ReadLine();
        Console.WriteLine($"Your name is {name} and your age is {age}");
        Console.Write("Enter your birthdate: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine($"Your birthdate is {birthdate}");
        Console.ReadKey();
    }
}

/*enum Week : byte
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7

}*/