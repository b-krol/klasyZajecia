using klasyiobiekty.przykladyklas;

internal class Program
{
    private static void Main(string[] args)
    {
        Osoba cz1 = new Osoba("Kacper", "Konstantynopolski", null, new DateTime(1989, 3, 29), 'm');
        Osoba cz2 = new Osoba("Tadeusz", "Praski", "Czech", new DateTime(1989, 3, 29), 'm');
        Osoba cz3 = new Osoba("Felicja", "Reykjavska", new DateTime(1999, 12, 31), 'k');
        
        Console.WriteLine(cz1.Wypisz());
        Console.WriteLine(cz2.Wypisz());
        Console.WriteLine(cz3.Wypisz());

        Book ks1 = new Book("Pan Tadeusz", "Adam Mickiewicz", new DateTime(1750, 1, 1), 678, new List<string> { "Polski", "Litewski" });

        Console.WriteLine($"Książka {ks1.title} napisana przez {ks1.author} powstała {ks1.lifeTime().ToString()} temu");
    }
}