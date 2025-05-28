using ObjectEx.Models;

namespace ObjectEx;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person { Name = "Yury", Age = 41 };
        var p2 = new Person { Name = "Alex", Age = 33 };
        var p3 = new Person { Name = "Yury", Age = 41 };


        Console.WriteLine(p1);

        Console.WriteLine(p1.Equals(p2));

        Console.WriteLine(p3.Equals(p1));

        Console.WriteLine(p3 == p1);


    }
}
