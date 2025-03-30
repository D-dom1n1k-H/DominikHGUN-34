namespace Task02
{
    class MyDictionary
    {
        private Dictionary<string, int> dictionary;
        private bool continuation;

        public void TaskLoop()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            dictionary = new Dictionary<string, int>();
            do
            {
                Console.WriteLine("Вы хотите посмотреть данные студентов или добавить их? see/add");
                Console.WriteLine(""); //разделитель между строками
                string answer = Console.ReadLine();
                if (answer == "see")
                {
                    if (!dictionary.ContainsKey("Алексей Кузнецов"))
                    {
                        dictionary.Add("Алексей Кузнецов", 4);
                    }
                    Console.WriteLine("Вы хотите посмотреть всю базу данных или информацию о конкретном студенте? 1/2 ");
                    Console.WriteLine(""); //разделитель между строками

                    string answer3 = Console.ReadLine();
                    if (answer3 == "1")
                    {
                        Console.WriteLine(""); //разделитель между строками
                        Console.WriteLine("Список всех студентов в базе данных:");
                        foreach (var item in dictionary)
                        {
                            Console.WriteLine($"Имя и фамилия: {item.Key}, Среднея оцнка: {item.Value}");
                        }
                    }
                    else if (answer3 == "2")
                    {
                        Console.WriteLine("Ведите имя и фамилию студента, пример: ");
                        Console.WriteLine(""); //разделитель между строками
                        Console.WriteLine("Алексей Кузнецов");
                        Console.WriteLine($"Среднея оценка студента: {dictionary["Алексей Кузнецов"]}");
                        Console.WriteLine(""); //разделитель между строками
                        Console.WriteLine(""); //разделитель между строками
                        Console.WriteLine("Ведите имя и фамилию студента");
                        Console.WriteLine(""); //разделитель между строками
                        string name = Console.ReadLine();
                        if (dictionary.ContainsKey(name))
                        {
                            Console.WriteLine($"Среднея оценка студента: {dictionary[name]}");
                        }
                        else
                        {
                            Console.WriteLine("Такого студента нет в базе данных");
                        }
                    }
                }
                else if (answer == "add")
                {
                    Console.WriteLine("Ведите имя и фамилию студента");
                    Console.WriteLine(""); //разделитель между строками
                    string name = Console.ReadLine();
                    Console.WriteLine("Ведите среднюю оценку студента, она может быть от 2 до 5");
                    Console.WriteLine(""); //разделитель между строками
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value < 2 || value > 5)
                    {
                        Console.WriteLine("[Warning] Вы ввели неверное значение, оценка может быть от 2 до 5");
                        return;
                    }
                    dictionary.Add(name, value);
                    Console.WriteLine("Студент добавлен в базу данных");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }

                Console.WriteLine(""); //разделитель между строками
                Console.WriteLine("Хотите продолжить? yes/no");
                string answer2 = Console.ReadLine();
                continuation = answer2 == "yes";
            } while (continuation);
        }
    }
}