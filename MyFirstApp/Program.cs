using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)

        //Первый вариант с swith/case (основной)

    {
        Console.WriteLine("1 = &");
        Console.WriteLine("2 = |");
        Console.WriteLine("3 = ^");

        var a02 = Console.ReadLine();
        if (!int.TryParse(a02, out var a))
        {
            Console.WriteLine("Is isn't a number");
            return;
        }
        var b02 = Console.ReadLine();
        if (!int.TryParse(b02, out var b))
        {
            Console.WriteLine("Is isn't a number");
            return;
        }
        var c02 = Console.ReadLine();
        if (!int.TryParse(c02, out var c))
        {
            Console.WriteLine("Is isn't a number");
            return;
        }



        switch (c)
        {
            case 1:
                int r01 = a & b;
                Console.WriteLine(Convert.ToString(r01, 10));
                Console.WriteLine(Convert.ToString(r01, 2));
                Console.WriteLine(Convert.ToString(r01, 16));
                break;


            case 2:
                int r02 = a | b;
                Console.WriteLine(Convert.ToString(r02, 10));
                Console.WriteLine(Convert.ToString(r02, 2));
                Console.WriteLine(Convert.ToString(r02, 16));
                break;

            case 3:
                int r03 = a ^ b;
                Console.WriteLine(Convert.ToString(r03, 10));
                Console.WriteLine(Convert.ToString(r03, 2));
                Console.WriteLine(Convert.ToString(r03, 16));
                break;

            default:
                Console.WriteLine("Third number can be only 1,2 or 3");
                break;



                //Второй вариант с if

                //Console.WriteLine("1 = &");
                //Console.WriteLine("2 = |");
                //Console.WriteLine("3 = ^");

                //var a02 = Console.ReadLine();
                //if (!int.TryParse(a02, out var a))
                //{
                //    Console.WriteLine("Is isn't a number");
                //    return;
                //}
                //var b02 = Console.ReadLine();
                //if (!int.TryParse(b02, out var b))
                //{
                //    Console.WriteLine("Is isn't a number");
                //    return;
                //}
                //var c02 = Console.ReadLine();
                //if (!int.TryParse(c02, out var c))
                //{
                //    Console.WriteLine("Is isn't a number");
                //    return;
                //}



                //switch (c)
                //{
                //    case 1:
                //        int r01 = a & b;
                //        Console.WriteLine(Convert.ToString(r01, 10));
                //        Console.WriteLine(Convert.ToString(r01, 2));
                //        Console.WriteLine(Convert.ToString(r01, 16));
                //        break;


                //    case 2:
                //        int r02 = a | b;
                //        Console.WriteLine(Convert.ToString(r02, 10));
                //        Console.WriteLine(Convert.ToString(r02, 2));
                //        Console.WriteLine(Convert.ToString(r02, 16));
                //        break;

                //    case 3:
                //        int r03 = a ^ b;
                //        Console.WriteLine(Convert.ToString(r03, 10));
                //        Console.WriteLine(Convert.ToString(r03, 2));
                //        Console.WriteLine(Convert.ToString(r03, 16));
                //        break;

                //    default:
                //        Console.WriteLine("Third number can be only 1,2 or 3");
                //        break;

                }

    }

}









