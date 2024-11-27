using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ditt förnamn och efternamn på samma rad (t.ex. Anna Andersson):");
        string input = Console.ReadLine();

        string[] names = input.Split(' ');

        if (names.Length == 2)
        {
            string firstName = names[0];
            string lastName = names[1];

            if (string.Compare(firstName, lastName, StringComparison.OrdinalIgnoreCase) < 0)
            {
                Console.WriteLine($"Förnamnet \"{firstName}\" kommer före efternamnet \"{lastName}\" i bokstavsordning.");
            }
            else if (string.Compare(firstName, lastName, StringComparison.OrdinalIgnoreCase) > 0)
            {
                Console.WriteLine($"Efternamnet \"{lastName}\" kommer före förnamnet \"{firstName}\" i bokstavsordning.");
            }
            else
            {
                Console.WriteLine("Förnamnet och efternamnet är samma i bokstavsordning.");
            }
        }
        else
        {
            Console.WriteLine("Var vänlig skriv in exakt ett förnamn och ett efternamn.");
        }
    }
}
