class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("& = 1");
        Console.WriteLine("| = 2");
        Console.WriteLine("^ = 3");

        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
        Console.WriteLine("It isn't a number");
        return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
        Console.WriteLine("It isn't a number");
        return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out var c))
        {
            Console.WriteLine("It isn't a number");
            return;
        }

        if (c == 1)
        {
            int f = a & b;
            Console.WriteLine(Convert.ToString(f, 10));
            Console.WriteLine(Convert.ToString(f, 2));
            Console.WriteLine(Convert.ToString(f, 16));
            return;
        }
        if (c == 2)
        {
            int f = a | b;
            Console.WriteLine(Convert.ToString(f, 10));
            Console.WriteLine(Convert.ToString(f, 2));
            Console.WriteLine(Convert.ToString(f, 16));
            return;
        }
        if (c == 3)
        {
            int f = a ^ b;
            Console.WriteLine(Convert.ToString(f, 10));
            Console.WriteLine(Convert.ToString(f, 2));
            Console.WriteLine(Convert.ToString(f, 16));
            return;
        }
        else
        {
            Console.WriteLine("Last sign can be only 1,2 or 3");
            return ;
        }



    }
}