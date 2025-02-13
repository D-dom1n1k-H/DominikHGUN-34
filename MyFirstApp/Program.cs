namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Зд 1

            int first = 0;
            int second = 1;

            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i = 2; i < 9; i++)
            {
                int next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
            }


            //Зд 2

            for (int i = 0; i < 21; i++, i++)
            {
                Console.WriteLine(i);
            }


            //Зд 3

            for (int i = 1; i < 6; i++, i++)
            {

                for (int j = 1; j < 6; j++, j++)
                {
                    Console.Write($"{i} * {j} = {i * j}    ");

                }
                Console.WriteLine();


                //Зд 4 

                string password = "qwerty";

                do
                {
                    Console.Write("Enter the password: ");
                    string input = Console.ReadLine();

                    if (input == password)
                    {
                        Console.WriteLine("You entered the correct password!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You entered the wrong password, please try again...");
                    }

                }while (true);
            }
        }
    }
}
