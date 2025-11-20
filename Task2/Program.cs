namespace Task2
{
    public class Program
    {
        private static Random random = new Random();
        public static void Main(string[] args) { }

        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(min, max + 1);
            return arr;
        }

        public static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int val in array)
                sum += val;
            return sum;
        }

        public static double GetAverage(int[] array)
        {
            return (double)GetSum(array) / array.Length;
        }

        public static int GetMin(int[] array)
        {
            return array.Min();
        }

        public static int GetMax(int[] array)
        {
            return array.Max();
        }
    }
}