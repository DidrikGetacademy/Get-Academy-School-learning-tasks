class VirtualPet
{
    public string name;
    public int age;
    public bool hungry;

    public VirtualPet(
        string name,
        int age = 1,
        bool hungry = true
        )
    {
        this.name = name;
        this.age = age;
        this.hungry = hungry;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{name} (Age: {age}) - " +
                          $"{(hungry ? "Hungry" : "Full")}");
    }

    public void Feed()
    {
        Console.WriteLine($"{name} is now full and satisfied.");
        hungry = false;
    }
}