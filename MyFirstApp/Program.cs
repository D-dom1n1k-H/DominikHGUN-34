using Methods;

namespace Strings
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var methods = new Methods.Methods();
            methods.ConcatenateStrings();
            Console.Write("\n");
            methods.GreetUser();
            Console.Write("\n");
            methods.SizeText();
            Console.Write("\n");
            methods.FirstLetters();
            Console.Write("\n");
            methods.JoinWords();
            Console.Write("\n");
            methods.ReplaceWords("Hello world", "world", "universe");
            methods.PrintResult(); //Результаты метода ReplaceWords
        }
    }
}
