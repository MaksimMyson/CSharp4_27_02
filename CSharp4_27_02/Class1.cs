namespace CSharp4_27_02
{
    public class City
    {
    private string name;
    private int population;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Population
    {
        get { return population; }
        set { population = value; }
    }

    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }

    
    public static City operator +(City city, int increase)
    {
        city.Population += increase;
        return city;
    }

    
    public static City operator -(City city, int decrease)
    {
        if (city.Population - decrease < 0)
            throw new InvalidOperationException("Неможливо відняти від кількості жителів, що вже є нульовою або від'ємною.");

        city.Population -= decrease;
        return city;
    }

    
    public static bool operator ==(City city1, City city2)
    {
        if (ReferenceEquals(city1, null))
            return ReferenceEquals(city2, null);
        if (ReferenceEquals(city2, null))
            return false;

        return city1.Population == city2.Population;
    }

    
    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }

    
    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    
    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    //
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is City))
            return false;

        City other = (City)obj;
        return this == other;
    }

    
    public override int GetHashCode()
    {
        return name.GetHashCode() ^ population.GetHashCode();
    }
}
}
