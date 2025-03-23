
namespace IntervalNamespace
{

    struct Interval
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Get { get; private set; }

        public Interval(int minValue, int maxValue)
        {
            Random rand = new Random();

            minValue = rand.Next(0, 100);
            maxValue = rand.Next(0, 100);

            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
                Console.WriteLine("[struct Interval] Warning: maxValue was less than mimValue");
            }
            else if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("[struct Interval] Warning: minValue was less than 0");
            }
            else if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("[struct Interval] Warning: maxValue was less than 0");
            }
            else if (minValue == maxValue)
            {
                if (minValue > maxValue)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        minValue++;
                    }
                    Console.WriteLine("[struct Interval] Warning: minValue was equal to maxValue");
                }
                else if (maxValue == minValue)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        maxValue++;
                    }
                    Console.WriteLine("[struct Interval] Warning: maxValue was equal to minValue");
                }
            }

            Min = minValue;
            Max = maxValue;
            Get = rand.Next(Min, Max);
        }
    }
}