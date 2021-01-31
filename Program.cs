using System;

namespace diffpair
{
    class Program
    {
        static void Main(string[] args)
        {
            try
               {

                int[] arr = { 4, 1, 5, 6, 8 };// initializing array with variable name arr
                Console.WriteLine("Q4: Enter the absolute difference to check");// Printing display message for user.
                int k = Convert.ToInt32(Console.ReadLine());// Converting string to integer type
                int count = 0;// Starting a counter
                for (int i = 0; i < arr.Length; i++) // Initializing for loop to pick the first element from the array.
                {
                    for (int j = i + 1; j < arr.Length; j++)// Initializing for loop to pick the second element from the array.
                    {
                        if (arr[i] - arr[j] == k || arr[j] - arr[i] == k)//If the difference between first and second element is equal to k, counter is incremented by 1.
                        {
                            count++;
                        }

                    }
                }
                Console.WriteLine("There exists {0} pairs with the given difference", count);// Once both the loops are executed,final output is displayed.
            }

            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
    }
}
