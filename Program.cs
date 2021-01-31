using System;

namespace diffpair
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 5, 6, 7 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == k || arr[j] - arr[i] == k)
                    {
                        count++;
                    }

                }
            }


            Console.WriteLine(count);
        }
    }
}
