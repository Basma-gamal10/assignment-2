using System;
class Book
{
    public string title;
    public int pages;
}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book();

        object obj = b1;

        Console.WriteLine(obj);
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.Equals(obj));
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj.GetHashCode());

        //try , catch , finally
        try
        {
            int x = 0;
            int result = 10 / x;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("cannot divide by zero");
        }
        finally { Console.WriteLine("done"); }

        // imlicit casting
        int pages = 300;
        double newPages = pages;
        Console.WriteLine(newPages);
        //explicit casting
        double price = 49.99;
        int newPrice = (int)price;
        Console.WriteLine(newPrice);

        //convert
        string pagesText = "464";

        int pagesInt = Convert.ToInt32(pagesText);

        Console.WriteLine(pagesInt);
        //parse
        string yearText = "2023";

        int year = int.Parse(yearText);

        Console.WriteLine(year);

        //try parse
        string badText = "abc";

        bool success = int.TryParse(badText, out int number);

        if (success)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Invalid number");

        }
        //tostring
        int pages1 = 464;

        string pagesText1 = pages1.ToString();

        Console.WriteLine(pagesText1);
        Console.WriteLine(pagesText1.GetType());
        int copies = 100;

        // Boxing
        object obj1 = copies;

        // Unboxing
        int newCopies = (int)obj1;

        Console.WriteLine(obj1);
        Console.WriteLine(newCopies);
    }
}
