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
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        if ((obj is null && this is not null) || (obj is not null && this is null))
        {
            return false;
        }
        if (obj is null && this is null) 
        {
            return true;
        }
        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }
        return false;
    }

    public override int GetHashCode()
    {
        var hashCode = int.MinValue;

        foreach (var symbol in Name)
        {
            hashCode += (int)symbol + (Age % 2);
        }
        return hashCode;
    }

    public static bool operator ==(Person? a, Person? b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }
        if ((a is null && b is not null) || (b is null && a is not null))
        {
            return false;
        }
        if (a is null && b is null)
        {
            return true;
        }
        return a.Name == b.Name && a.Age == b.Age;
    }

    public static bool operator !=(Person? a, Person? b)
    {
        if (ReferenceEquals(a, b))
        {
            return false;
        }
        if ((a is null && b is not null) || (b is null && a is not null))
        {
            return true;
        }
        if (a is null && b is null)
        {
            return false;
        }
        return a.Name != b.Name || a.Age != b.Age;
    }

    public static bool operator >(Person? a, Person? b)
    {
        if (a is null || b is null)
        {
           return false;
        }
        return a.Age > b.Age;
    }

    public static bool operator <(Person? a, Person? b)
    {
        if (a is null || b is null)
        {
            return false;
        }
        return a.Age < b.Age;
    }
}