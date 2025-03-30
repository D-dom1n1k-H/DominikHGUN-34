
using System.Collections.Generic;
using Task01;
using Task02;
using Task03;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entered = false;

            Console.WriteLine("Hi user!");
            Console.WriteLine("This program contains 3 tasks: ");
            Console.WriteLine(""); //разделитель между строками
            Console.WriteLine("Choose the task you want to run: ");
            Console.WriteLine("1. Task01 (List)");
            Console.WriteLine("2. Task02 (Dictionary)");
            Console.WriteLine("3. Task03 (LinkedList)");
            Console.WriteLine("Enter 1/2/3");
            Console.WriteLine(""); //разделитель между строками
            int task = Convert.ToInt32(Console.ReadLine());

            while (entered == false)
            {
                switch (task)
                {
                    case 1:
                        MyList myList = new MyList();
                        myList.TaskLoop();
                        entered = true;
                        break;
                    case 2:
                        MyDictionary myDictionary = new MyDictionary();
                        myDictionary.TaskLoop();
                        entered = true;
                        break;
                    case 3:
                        MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
                        myLinkedList.TaskLoop();
                        entered = true;
                        break;
                    default:
                        Console.WriteLine("You entered a wrong number, please enter 1, 2 or 3");
                        task = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}


