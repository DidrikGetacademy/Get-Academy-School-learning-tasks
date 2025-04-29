public class elev
{
    public string name;
    public int age;

    public elev(string Name, int Age)
    {
        name = Name;
        age = Age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Hei mitt navn er {name} jeg er {age} år");
    }

    public void PerformHobbyDidrik()
    {
        Console.WriteLine($"Nå fisker jeg ");
    }

    public void PerformHobbyLisbeth()
    {
        Console.WriteLine($"nå gamer jeg ");
    }
}
