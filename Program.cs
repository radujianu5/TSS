using System;
using PasswordManager;

class Program
{
    static void Main(string[] args)
    {
        var validator = new PasswordValidator();

        Console.WriteLine("Introdu o parolă:");
        string input = Console.ReadLine();

        string rezultat = validator.ValidatePassword(input);
        Console.WriteLine($"Rezultat validare: {rezultat}");

        Console.WriteLine("Apasă orice tastă pentru a închide...");
        Console.ReadKey();
    }
}
