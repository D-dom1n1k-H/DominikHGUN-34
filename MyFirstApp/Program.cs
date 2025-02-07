class Program
{
    static void Main(string[] args)
    {
        int[] ex1 = new[] { 0, 1, 1, 2, 3, 5, 8, 13 };

        string[] ex2 = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        int[][] ex3 = { new[] { 2, 3, 4 }, new[] { 4, 9, 16 }, new[] { 8, 27, 64 } };


        double[][] ex4 = new double[3][];


        ex4[0] = new double[] { 1, 2, 3, 4, 5 };

        ex4[1] = new double[] { Math.E, Math.PI };

        ex4[2] = new double[]
        {
           Math.Log10 (1),
           Math.Log10 (10),
           Math.Log10 (100),
           Math.Log10 (1000)
        };



        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13, 0, 0, 0 }; //Я добавил в массив array2 три нолика в конце чтобы не удалять 11, 12 и 13. А массив на 10 элементов сделать не получилось.

        Array.Copy(array, 0, array2, 7, 3);

        Array.Resize(ref array, 10);
        Console.WriteLine(array[9]);
    }
}