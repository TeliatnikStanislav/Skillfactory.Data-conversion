

class MainClass
{
    public static void Main(string[] args)
    {
        Week favday;
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your name is {name} and age is {age}");
        Console.WriteLine("What is your favorute day?");
        Week MyFavDay = (Week) byte.Parse(Console.ReadLine());
        Console.WriteLine(MyFavDay);
        Console.ReadKey();
    }
}

enum Week : byte
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7

}