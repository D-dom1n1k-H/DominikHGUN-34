namespace Task03
{
    class MyLinkedList<T>
    {
        private bool continuation;

        public MyLinkedList() { }

        public void TaskLoop()
        {
            do
            {
                LinkedList<int> linkedList = new LinkedList<int>();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Enter 3-6 numbers into the LinkedList");
                Console.WriteLine("How many numbers do you want to add to the LinkedList? 3/4/5/6");
                int count = Convert.ToInt32(Console.ReadLine());

                while (count < 3 || count > 6)
                {
                    Console.WriteLine("You entered a wrong number, please enter 3, 4, 5 or 6");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Enter number {i + 1}:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    linkedList.AddLast(number);
                }
                Console.WriteLine(""); //разделитель между строками
                Console.WriteLine("How would you like your LinkedList to be displayed?");
                Console.WriteLine("1. 1. Normal, as you entered");
                Console.WriteLine("2. In reverse order");
                Console.WriteLine("3. Sorted from smaller to bigger number");
                Console.WriteLine("Enter 1/2/3");
                Console.WriteLine(""); //разделитель между строками

                int display = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(""); //разделитель между строками

                while (display < 1 || display > 3)
                {
                    Console.WriteLine("You entered a wrong number, please enter 1, 2 or 3");
                    display = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(""); //разделитель между строками
                }
                if (display == 1)
                {
                    Console.WriteLine("The LinkedList without modifications:");
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (display == 2)
                {
                    Console.WriteLine("The LinkedList in reverse order:");
                    linkedList.Reverse();
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (display == 3)
                {
                    Console.WriteLine("The LinkedList sorted from smaller to bigger number:");
                    linkedList.OrderBy(x => x);
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("You entered a wrong number, please enter 1, 2 or 3");
                }

                Console.WriteLine(""); //разделитель между строками
                Console.WriteLine("Would you want to continue? yes/no");
                string answer = Console.ReadLine();
                continuation = answer.ToLower() == "yes";
            } while (continuation);
        }
    }
}