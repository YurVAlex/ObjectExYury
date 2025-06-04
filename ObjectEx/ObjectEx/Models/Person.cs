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
        if (ReferenceEquals(a, b))
        {
            return true;
        }
        if ((a is null && b is not null) || (b is null && a is not null)) // null == obj is false.
        {
            return false;
        }
        if (a is null && b is null) // null == null is true.
        {
            return true;
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
        var hashCode = Name != null ? Name.Length : 0;

        unchecked
        {
            if (hashCode != 0)
            {
                foreach (var symbol in Name)
                {
                    hashCode += (int)symbol * Name.Length;
                }
                hashCode += Age;
            }
            hashCode = ((Age % 2) == 0) ? hashCode * (-1) : hashCode;

            return hashCode;
        }
    } // Or proper: public override int GetHashCode() => HashCode.Combine(Name, Age);
}