
using System.Text;

namespace Methods
{
    class Methods
    {
        public void ConcatenateStrings()
        {
            string input1 = "";
            string input2 = "";

            Console.WriteLine("Enter text1: ");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter text2: ");
            input2 = Console.ReadLine();

            Console.WriteLine($"{input1} {input2}");
            //Console.WriteLine(input1 + "" + input2);
        }

        public void GreetUser()
        {
            string name = "";
            int age = 0;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}!\nYou are is {age} years old.");
        }

        public void SizeText()
        {
            string text = "";
            Console.WriteLine("Enter text: ");
            text = Console.ReadLine();
            Console.WriteLine($"Your text has: {text.Length} symbols (with spaces)");
            Console.WriteLine($"Your text where every letter is capital: {text.ToUpper()}");
            Console.WriteLine($"Your text where every letter is low: {text.ToLower()}");
        }

        public void FirstLetters()
        {
            string text = "";
            Console.WriteLine("Enter text: ");
            text = Console.ReadLine();
            Console.WriteLine($"First 5 symbols: {text.Substring(0, 5)} (with spaces)");
        }

        public void JoinWords()
        {
            Console.Write("How many words do you want to be in sentense?");
            int count = int.Parse(Console.ReadLine());

            string[] words = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter word: {i + 1}: ");
                words[i] = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word);
                sb.Append(" ");
            }

            Console.WriteLine($"\nYour sentense: {sb.ToString()}");
        }

        public string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
        public void PrintResult()
        {
            Console.WriteLine(ReplaceWords("Hello world", "world", "universe"));
        }
    }
}


