using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Walec w = new Walec(3,2);
        Console.WriteLine("Objętość walca = " + w.Objetosc());
        Console.WriteLine("Pole całkowite walca = " + w.PoleCalkowite());
    }
}