using ObjectEx.Models;

namespace ObjectEx;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person { Name = "Yury", Age = 41 };
        var p2 = new Person { Name = "Alex", Age = 33 };
        var p3 = new Person { Name = "Yury", Age = 41 };
        var p4 = new Person { Name = "Alex", Age = 50 };

        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine($"p3: {p3}");
        Console.WriteLine($"p4: {p4}");
        Console.WriteLine();

        Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
        Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");
        Console.WriteLine($"p2.Equals(p4): {p2.Equals(p4)}");
        Console.WriteLine($"p2.Equals(p2): {p2.Equals(p2)}");
        Console.WriteLine();

        Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
        Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");
        Console.WriteLine($"p3.GetHashCode(): {p3.GetHashCode()}");
        Console.WriteLine($"p4.GetHashCode(): {p4.GetHashCode()}");
        Console.WriteLine();

        Console.WriteLine($"p1 == p2: {p1 == p2}");
        Console.WriteLine($"p1 == p3: {p1 == p3}");
        Console.WriteLine($"p1 != p2: {p1 != p2}");
        Console.WriteLine($"p2 != p4: {p2 != p4}");
        Console.WriteLine();

        Console.WriteLine($"p1 > p2: {p1 > p2}");
        Console.WriteLine($"p2 < p1: {p2 < p1}");
        Console.WriteLine($"p2 > p4: {p2 > p4}");
        Console.WriteLine($"p4 > p1: {p4 > p1}");
        Console.WriteLine();

        Person older = p1 > p2 ? p1 : p2;
        Console.WriteLine($"{older.Name} is older between p1 and p2.");

        Person youngest = p1 < p2 ? p1 : p2;
        Console.WriteLine($"{youngest.Name} is younger between p1 and p2.");
    }
}
