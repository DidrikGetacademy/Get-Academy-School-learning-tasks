namespace Lagerstyringssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lager lager = new Lager();


            Klær klær1 = new Klær {Navn = "Polo", Pris = 250, Størrelse = "M"};
            Klær klær2 = new Klær { Navn = "H&M", Pris = 100, Størrelse = "S" };
            lager.AddProduct(klær1);
            lager.AddProduct(klær2);

            Elektronikk elektronikk1 = new Elektronikk { Navn = "Pc", Pris = 200, Garanti = 12 };
            Elektronikk elektronikk2 = new Elektronikk { Navn = "Telefon", Pris = 2000, Garanti = 24 };
            lager.AddProduct(elektronikk1);
            lager.AddProduct(elektronikk2);

            Matvare matvare1 = new Matvare { Navn = "Melk", Pris = 25, DateTime = DateTime.Now.AddDays(7) };
            Matvare matvare2 = new Matvare { Navn = "Brød", Pris = 34, DateTime = DateTime.Now.AddDays(10) };
            lager.AddProduct(matvare1);
            lager.AddProduct(matvare2);

            lager.RemoveProduct(matvare1);
            lager.ShowProducts();
        }
    }
}

