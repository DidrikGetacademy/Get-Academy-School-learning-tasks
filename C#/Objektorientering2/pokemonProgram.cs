namespace Objektorientering2
{
     class Program
    {
        static void Main(string[] args)
        {
           // javascript
           // let pikachu = { health: 50, level: 21}

           // C# anonyme typer 
         //  var pikachu = new pikachu(10,30);
          // var bulbasaur = new bulbasaur(20,3);
          //  Console.WriteLine($"pikachu har {pikachu.Health} hp og er level {pikachu.Level}");
           // Console.WriteLine($"bulbasaur har {bulbasaur.Health} hp og er level {bulbasaur.Level}");
           var pikachu = new Pokemons("pikachu", 30, 20);
           var balbasaur = new Pokemons("balbasaur", 30, 20);
           Console.WriteLine($"jeg har nå lagt til {pikachu.Name} og {balbasaur.Name}");
        }
    }
}
/*
 *Lag en generell Pokemon klasse,
 * gi den tilhørende properties og lag en constructor slik at vi kan generere nye pokemon
 */