namespace MyApp
{
    class Program
    {


        static void Main()
        {
            int[] array = new int[] { 1, 2, 3 };
            int[] array2 = new int[3];
            int[] array3 = (int[])array2.Clone();
            array2[1] = 1;

            Array.ForEach(array3, n => Console.WriteLine(n));

            Array.Copy(array, array2, 3);
            array2[2] = 1;
            Array.ForEach(array, n => Console.WriteLine(n));
            Array.ForEach(array2, n => Console.WriteLine(n));
        }

    }
}