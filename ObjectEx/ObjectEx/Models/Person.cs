namespace ObjectEx.Models;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }

        return false;
    }

    public static bool operator ==(Person a, Person b)
    {
        if (a.Name == b.Name && a.Age == b.Age)
        {
            return true;
        }
        
        return false;
    }

    public static bool operator !=(Person a, Person b)
    {
        if (a.Name != b.Name || a.Age != b.Age)
        {
            return true;
        }

        return false;
    }

}
