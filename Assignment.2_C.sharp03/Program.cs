using System;
internal class Program
{
    static void Main(string[] args)
    {
        //----------------Q1------------------------
        int pages = 464;
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }

        //----------------Q2------------------------
        string title = "Refactoring";
        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        //----------------Q3------------------------
        int Pages = 464;
        string sizeLabe = (Pages > 300) ? sizeLabe = "Long Book" : sizeLabe = "Short Book";
        Console.WriteLine(sizeLabe);

        //----------------Q4------------------------
        Console.WriteLine("----------------------------------------------");
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }

        //----------------Q5------------------------
        Console.WriteLine("----------------------------------------------");

        int j = 0;
        while (j < books.Length)
        {
            Console.WriteLine($"{j + 1}. {books[j]}");
            j++;
        }

    }
}

