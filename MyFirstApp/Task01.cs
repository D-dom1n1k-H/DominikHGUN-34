namespace Task01
{
    class MyList
    {
        private List<string> list;
        private bool continuation;

        public void TaskLoop()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            list = new List<string> { "Python", "JavaScript", "Java", "C#", "C++", "PHP", "TypeScript", "Go", "Swift", "Kotlin" };

            do
            {
                Console.WriteLine("List of the most popular programming languages: ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(""); //разделитель между строками
                Console.WriteLine("Do you want to add some languages to the list? yes/no");
                string answer = Console.ReadLine();
                Console.WriteLine(""); //разделитель между строками

                if (answer == "yes")
                {
                    Console.WriteLine($"You can enter an index from 0 to {list.Count}, the index is the place where you will write the new text. Enter the index: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    while (index < 0 || index > list.Count)
                    {
                        Console.WriteLine(""); //разделитель между строками
                        Console.WriteLine($"You entered a wrong index, please enter an index from 0 to {list.Count}");
                        index = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter the new language: ");
                    string newLanguage = Console.ReadLine();
                    list.Insert(index, newLanguage);

                    Console.WriteLine(""); //разделитель между строками

                    Console.WriteLine("The new list of the most popular programming languages: ");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine(""); //разделитель между строками
                    Console.WriteLine("Would you want to continue? yes/no");
                    string answer2 = Console.ReadLine();
                    continuation = answer2 == "yes";
                }
                else if (answer == "no")
                {
                    Console.WriteLine("You don't want to add new languages to the list.");
                    Console.WriteLine("Goodbye!");
                    continuation = false;
                }
                else
                {
                    Console.WriteLine("You entered a wrong input!");
                    Console.WriteLine("Please enter again");
                    continuation = true;
                }
            } while (continuation);
        }
    }
}