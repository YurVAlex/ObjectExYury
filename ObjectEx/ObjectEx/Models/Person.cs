namespace ObjectEx.Models;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            Name = name;
        }
        else
        {
            Name = "Unknown";
        }

        if (age >= 0)
        {
            Age = age;
        }
        else
        {
            Age = -1;
        }
    }

    public static bool operator ==(Person? a, Person? b)
    {
        if (ReferenceEquals(a, b)) // also check null == null is true
        {
            return true;
        }
        if ((a is null) || (b is null)) // null == obj is false
        {
            return false;
        }
        return a.Name == b.Name && a.Age == b.Age;
    }

    public static bool operator !=(Person? a, Person? b)
    {
        return !(a == b);
    }

    public static bool operator >(Person? a, Person? b)
    {
        if (ReferenceEquals(a, b))
        {
            return false;
        }
        if (a is null || b is null)
        {
            return false;
        }
        return a.Age > b.Age;
    }

    public static bool operator <(Person? a, Person? b)
    {
        return b > a;
    }

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
        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }
        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Math.Abs(Name.GetHashCode() / 7);

            return ((Age % 2) == 0) ? (int.MinValue + hashCode) : (int.MaxValue - hashCode);
        }
    } // Or: public override int GetHashCode() => HashCode.Combine(Name, Age);
}